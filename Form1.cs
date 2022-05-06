using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Timers;
using System.Text.RegularExpressions;

namespace Teleporter_GUI
{
    public partial class Form1 : Form
    {
        System.Threading.Thread t;
       // private static bool MAXIMIZED = false;

        double htemprature = 0;
        int stage = 0;
        int pausing = 0;
        int SubstratePosition = 0;
        int steps = 0;
        int stageProgression;
        int psi = 0; // For the suction cup psi level
        string sendArduino;
        bool UpdateData = false;
        bool recieved = false;
        int posA;
        int posB;

        string readArduino;
        string readVantage;
        string serialDataIn;

        SerialPort arduino = new SerialPort("COM5", 115200);
        SerialPort vantage = new SerialPort("COM4", 9600);

        public SerialPort myport;

        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            progressBar_statusBar.Value = 0;
            label_status.Text = "DISCONNECTED";
            label_status.ForeColor = Color.Red;

            comboBox_baudRate.Text = "115200";
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.AddRange(portLists);

            tmp_chart.Series["Temprature"].Points.AddXY(1,1);  // Temprature Tab
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function that initializes the timers within our application
        /// </summary>
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            Timer_temp.Interval = 100;
            Timer_temp.Tick += new EventHandler(Timer_temp_Tick);
            Timer_MainProg.Interval = 1000;
            Timer_MainProg.Tick += new EventHandler(Timer_MainProg_Tick);

            // Enable timer.  
            Timer_temp.Enabled = true;
            Timer_MainProg.Enabled = true;

        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataIn = serialPort.ReadTo("\n");
            DataParsing(dataIn);
            //arduino.DiscardOutBuffer();
            this.BeginInvoke(new EventHandler(Show_Data));
            
        }

        public void Show_Data(object sender, EventArgs e)
        {
            if(UpdateData == true)
            {
                currTmp_Heater_label.Text = string.Format("Current Temprature of Heater = {0} ºC", htemprature.ToString());
                tmp_chart.Series["Temperature"].Points.Add(htemprature);

                if(posA == 1)
                {
                    pos1_btn.BackColor = Color.LimeGreen;
                    pos2_btn.BackColor = Color.Red;
                    pos1_checkBox.Checked = true;
                    pos2_checkBox.Checked = false;
                    richTextBox_leadScrew.Text = "The Fixture is at position 1.";
                }

                if(psi == 30)
                {
                    Cups_btn.BackColor = Color.LimeGreen;
                    cups_psi_label.Text = "30 psi";
                    suctionCup_checkBox.Checked = true;
                    richTextBox_cupStatus.Text = "PSI at 30 and Suction Cups are active.";
                }
                else if(psi == 0)
                {
                    Cups_btn.BackColor = Color.Red;
                    cups_psi_label.Text = "0 psi";
                    suctionCup_checkBox.Checked = false;
                    richTextBox_cupStatus.Text = "PSI at 0 and Suction Cups are not active.";
                }
            }
        }


        public void DataParsing(string data)
        {
            sbyte indexOf_startDataCharacter = (sbyte)data.IndexOf("@");
            sbyte indexOfStg = (sbyte)data.IndexOf("S");
            sbyte indexOfPhot = (sbyte)data.IndexOf("P");
            sbyte indexOfLclmp = (sbyte)data.IndexOf("L");
            sbyte indexOfRclmp = (sbyte)data.IndexOf("R");
            sbyte indexOfCC = (sbyte)data.IndexOf("C");
            sbyte indexOfCheckSol = (sbyte)data.IndexOf("I");
            sbyte indexOfPsi = (sbyte)data.IndexOf("#");
            sbyte indexOfPosA = (sbyte)data.IndexOf("[");
            sbyte indexOfPosB = (sbyte)data.IndexOf("]");
            sbyte indexOfmidway = (sbyte)data.IndexOf("M");
            sbyte indexOfTemp = (sbyte)data.IndexOf("T");
            sbyte indexOfmaxTmp = (sbyte)data.IndexOf("X");


            // If any of the strings above exists in the parsing package
            if (indexOf_startDataCharacter != -1 && indexOfStg != -1 && indexOfPhot != -1 && indexOfLclmp != -1 && indexOfRclmp != -1
                && indexOfCC != -1 &&    indexOfCheckSol != -1 && indexOfPsi != -1 && indexOfPsi != -1 && indexOfPosA != -1 && 
                indexOfPosB != -1 && indexOfmidway != -1 && indexOfTemp != -1 && indexOfmaxTmp != -1)
            {
                try
                {
                    string str_STG = data.Substring(indexOf_startDataCharacter + 1, (indexOfStg - indexOf_startDataCharacter) - 1);
                    string str_PHOT = data.Substring(indexOf_startDataCharacter + 1, (indexOfPhot - indexOf_startDataCharacter) - 1);
                    string str_LCLMP = data.Substring(indexOf_startDataCharacter + 1, (indexOfLclmp - indexOf_startDataCharacter) - 1);
                    string str_RCLMP = data.Substring(indexOfLclmp + 1, (indexOfRclmp - indexOfLclmp) - 1);
                    string str_CC = data.Substring(indexOf_startDataCharacter + 1, (indexOfCC - indexOf_startDataCharacter) - 1);
                    string str_CHECKSOL = data.Substring(indexOf_startDataCharacter + 1, (indexOfCheckSol - indexOf_startDataCharacter) - 1);
                    string str_PSI= data.Substring(indexOfCheckSol + 1, (indexOfPsi - indexOfCheckSol) - 1);
                    string str_POSA = data.Substring(indexOf_startDataCharacter + 1, (indexOfPosA - indexOf_startDataCharacter) - 1);
                    string str_POSB = data.Substring(indexOfPosA + 1, (indexOfPosB - indexOfPosA) - 1);
                    string str_MIDWAY = data.Substring(indexOfPosB + 1, (indexOfmidway - indexOfPosB) - 1);
                    string str_TEMP = data.Substring(indexOf_startDataCharacter + 1, (indexOfTemp - indexOf_startDataCharacter) - 1);
                    string str_MaxTMP = data.Substring(indexOfTemp + 1, (indexOfmaxTmp - indexOfTemp) - 1);


                    
                    stage = Convert.ToInt32(str_STG);
                    htemprature = Convert.ToDouble(str_TEMP);
                    recieved = Convert.ToBoolean(str_PHOT);
                    psi = Convert.ToInt32(str_PSI);
                    posA = Convert.ToInt32(str_POSA);
                    posB = Convert.ToInt32(str_POSB);
                    

                   UpdateData = true;

                }
                catch(Exception)
                {
                    
                }
            }

            else
            {
                UpdateData = false;
            }

        }


/// <summary>
/// Button for opening the Serial Port connection
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = comboBox_comPort.Text;
                serialPort.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                serialPort.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                progressBar_statusBar.Value = 100;
                label_status.Text = "CONNECTED";
                label_status.ForeColor = Color.Green;
                tmp_chart.Series["Temprature"].Points.Clear();

                MessageBox.Show("Success!!! Connected to Arduino Board");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

/// <summary>
/// This button is used seperately to close the port
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();

                    button_open.Enabled = true;
                    button_close.Enabled = false;
                    progressBar_statusBar.Value = 0;
                    label_status.Text = "DISCONNECTED";
                    label_status.ForeColor = Color.Red;

                    MessageBox.Show("Disconnected from the board!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

/// <summary>
/// In case of closing the entire Form, The port will be closing the same time
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

/// <summary>
/// Everything that is Happening in the main progress Tab
/// Making sure the Timer Sync with the progress Bar and moving in between Stages
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Timer_MainProg_Tick(object sender, EventArgs e)
        {
            percentage_lable.Text = stageProgression.ToString() + "%";
            main_prog_progressBar.Increment(stageProgression);
            arduino.ReadTo(readArduino);
    //        checkParse(readArduino);
            switch (stage)
            {
                case 0:
                    stage_lable.Text = "Setup Stage";
                    mainProg_richTextBox.Text = "Raising the fixture and then waiting for a substrate before turning on the suction cups " +
                        "and heating up the plate to 110C";
                    percentage_lable.Text = "0%";
                    break;
                case 1:
                    stage_lable.Text = "Stage 1";
                    mainProg_richTextBox.Text = "Substrate is at the first postition, Vaccum has turned on, Fixture has been lowered. ";
                    percentage_lable.Text = "20%";
                    break;
                case 2:
                    stage_lable.Text = "Stage 2";
                    mainProg_richTextBox.Text = "The Clamps are holding the substrate, Temprature of the Substrate has reached 120.5C, " +
                        "Vantage Can starts it's process.";
                    percentage_lable.Text = "40%";
                    break;
                case 3: // The fixture reaching the second postion might need a delay in the richTextBox
                    stage_lable.Text = "Stage 3";
                    mainProg_richTextBox.Text = "Fixture moving to the second postition, Vantage starting the second part of it's process, " +
                        "Heater goes to 60C";
                    percentage_lable.Text = "60%";
                    break;
                case 4:
                    stage_lable.Text = "Stage 4";
                    mainProg_richTextBox.Text = "Fixture back at the first postition, The Temprature is at 60C";
                    percentage_lable.Text = "80%";
                    break;
                case 5:
                    stage_lable.Text = "Stage 5";
                    mainProg_richTextBox.Text = "Temprature is at 60C, The Clamps have been taken off, The fixture has been lifted, " +
                        "Vaccum is off, The Substrate is ready for pick up!";
                    percentage_lable.Text = "100%";
                    break;
            }
            main_prog_progressBar.Value = stageProgression;
            percentage_lable.Text = stageProgression + "%";
        }

/// <summary>
/// The Status Of clamp mainly if both Clamps are at work then the Clamping mechanism is applied
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void clmp_status_Click(object sender, EventArgs e)
        {
            // If both right Clamp and left Clamp are holding the substrate
            if ((clmpR_btn.BackColor == Color.LimeGreen) && (clmpL_btn.BackColor == Color.LimeGreen))
            {
                clmp_status.BackColor = Color.LimeGreen;
                mainProg_richTextBox.Text = "Both Clamps are holding the Substrate";
                clmp_checkBox.Checked = true;
                clmp_status.Text = "Active";
            }
        }

/// <summary>
/// Button to increase the temprature
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Incr_btn_Click(object sender, EventArgs e)
        {
            htemprature += 1;
        }

/// <summary>
/// Button To decrease the temprature
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Decr_btn_Click(object sender, EventArgs e)
        {
            htemprature -= 1;
        }

/// <summary>
/// Timer in regards to our heater
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Timer_temp_Tick(object sender, EventArgs e)
        {
            // Set the caption to the current time.  
            currTmp_Heater_label.Text = htemprature.ToString() + "ºC";
        }

        private void clmpDebug_btn_Click(object sender, EventArgs e)
        {
            sendArduino = "3";
            arduino.Write(sendArduino);
        }

        private void rst_btn_Click(object sender, EventArgs e)
        {
            sendArduino = "1";
            arduino.Write(sendArduino);
        }
    }




}
