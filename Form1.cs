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
        private static bool MAXIMIZED = false;

        double temprature = 0;
        int stage = 0;
        int SubstratePosition = 0;
        int steps = 0;
        int stageProgression;
        int psi = 0; // For the suction cup psi level

        bool clamps; // The clamps on the progress
        bool vaccum; // The cups in total
        bool vac_sol; // The Solenoid for suction cup
        bool UpdateData = false;

        string readArduino;
        string readVantage;
        string serialDataIn;

        SerialPort arduino = new SerialPort("COM7", 115200);
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
            this.BeginInvoke(new EventHandler(Show_Data));
        }

        public void Show_Data(object sender, EventArgs e)
        {
            if(UpdateData == true)
            {
                currTmp_Heater_label.Text = string.Format("Temprature = {0} ºC", temprature.ToString());
                tmp_chart.Series["Temperature"].Points.Add(temprature);

                if(vaccum == true)
                {
                    Cups_btn.BackColor = Color.LimeGreen;
                    cups_psi_label.Text = "30 psi";
                    suctionCup_checkBox.Checked = true;
                    richTextBox_cupStatus.Text = "PSI at 30 and Suction Cups are active.";
                }
            }
        }


        public void DataParsing(string data)
        {
            sbyte indexOf_startDataCharacter = (sbyte)data.IndexOf("@");
            sbyte indexOfT = (sbyte)data.IndexOf("T");

            // sbyte indexOfSTG = (sbyte)data.IndexOf("STG");
            sbyte indexOfVAC = (sbyte)data.IndexOf("VSL");
            // sbyte indexOfVSL = (sbyte)data.IndexOf("VAC");
            // sbyte indexOfPOS = (sbyte)data.IndexOf("POS");
            // sbyte indexOfCLL = (sbyte)data.IndexOf("CLL");
            // sbyte indexOfCLR = (sbyte)data.IndexOf("CLR");

            // If any of the strings above exists in the parsing package
            if (/*indexOfCLL != -1 && indexOfCLR != -1 && indexOfPOS!= -1 && indexOfSTG != -1 
                && indexOfVSL != -1 && */ indexOfVAC != -1 && indexOf_startDataCharacter != -1 && indexOfT != -1)
            {
                try
                {
                    string str_temperature = data.Substring(indexOf_startDataCharacter + 1, (indexOfT - indexOf_startDataCharacter) - 1);

                   // string str_STG = data.Substring(indexOf_startDataCharacter + 1, (indexOfSTG - indexOf_startDataCharacter) - 1);
                   string str_VAC = data.Substring(indexOf_startDataCharacter + 1, (indexOfVAC - indexOf_startDataCharacter) - 1);
                   // string str_VSL = data.Substring(indexOf_startDataCharacter + 1, (indexOfVSL - indexOf_startDataCharacter) - 1);
                   // string str_POS = data.Substring(indexOf_startDataCharacter + 1, (indexOfPOS - indexOf_startDataCharacter) - 1);
                   // string str_CLL = data.Substring(indexOf_startDataCharacter + 1, (indexOfCLL - indexOf_startDataCharacter) - 1);
                   // string str_CLR = data.Substring(indexOf_startDataCharacter + 1, (indexOfCLR - indexOf_startDataCharacter) - 1);

                    temprature = Convert.ToDouble(str_temperature);
                   // stage = Convert.ToInt32(str_STG);
                   vaccum = Convert.ToBoolean(str_VAC);

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



        public void checkParse(string data)
        {
            try
            {
                int val;
                val = Int32.Parse(data);
                Console.WriteLine("'{0}' parsed as {1}", data, val);
            }

            catch
            {
                Console.WriteLine("Can't Parsed '{0}'", data);
            }

            string protocol = data.Substring(0, 3);
            string protocolVal = Regex.Match(data, @"\d+").Value;
            int pval = Int32.Parse(protocolVal);
            switch (data)
            {
                case "STG0":
                    stage = 0;
                    stageProgression = 0;
                    break;
                case "STG1":
                    stage = 1;
                    stageProgression = 20;
                    break;
                case "STG2":
                    stage = 2;
                    stageProgression = 40;
                    break;
                case "STG3":
                    stage = 3;
                    stageProgression = 60;
                    break;
                case "STG4":
                    stage = 4;
                    stageProgression = 80;
                    break;
                case "STG5":
                    stage = 5;
                    stageProgression = 100;
                    break;
            }

            switch (protocol)
            {
                case "VAC":
                    if (pval == 1)
                    {
                        Cups_btn.BackColor = Color.LimeGreen;
                        cups_psi_label.Text = "30 psi";
                        suctionCup_checkBox.Checked = true;
                        richTextBox_cupStatus.Text = "PSI at 20 and Suction Cups are active.";
                    }
                    else if (pval == 0)
                    {
                        Cups_btn.BackColor = Color.Red;
                        cups_psi_label.Text = "0 psi";
                        suctionCup_checkBox.Checked = false;
                        richTextBox_cupStatus.Text = "PSI at 0 and Suction Cups are not active.";
                    }
                    break;
                case "VSL":
                    if (pval == 1)
                    {
                        airCyl_status_btn.BackColor = Color.LimeGreen;
                        richTextBox_cupSolStatus.Text = "The fixture has been elevated.";
                    }
                    else if (pval == 0)
                    {
                        airCyl_status_btn.BackColor = Color.Red;
                        richTextBox_cupSolStatus.Text = "The fixture has been lowered.";
                    }
                    break;
                case "CLR":
                    if (pval == 1)
                    {
                        clmpR_btn.BackColor = Color.Red;
                        richTextBox_clmp_status.Text = "The Left Clamp is not holding the Substrate";
                    }
                    else if (pval == 0)
                    {
                        clmpR_btn.BackColor = Color.LimeGreen;
                        richTextBox_clmp_status.Text = "The Right Clamp is holding the Substrate";
                    }
                    break;
                case "CLL":
                    if (pval == 1)
                    {
                        clmpL_btn.BackColor = Color.Red;
                        richTextBox_clmp_status.Text = "The Left Clamp is not holding the Substrate.";
                    }
                    if (pval == 0)
                    {
                        clmpR_btn.BackColor = Color.LimeGreen;
                        richTextBox_clmp_status.Text = "The Left Clamp is holding the Substrate";
                    }
                    break;
                case "POS":
                    if (pval == 1)
                    {
                        pos1_btn.BackColor = Color.LimeGreen;
                        pos2_btn.BackColor = Color.Red;
                        pos1_checkBox.Checked = true;
                        pos2_checkBox.Checked = false;
                        richTextBox_leadScrew.Text = "The Fixture is at position 1.";
                    }
                    else if (pval == 2)
                    {
                        pos1_btn.BackColor = Color.Red;
                        pos2_btn.BackColor = Color.LimeGreen;
                        pos1_checkBox.Checked = false;
                        pos2_checkBox.Checked = true;
                        richTextBox_leadScrew.Text = "The Fixture is at position 2";
                    }
                    break;
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
            checkParse(readArduino);
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
            temprature += 1;
        }

/// <summary>
/// Button To decrease the temprature
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Decr_btn_Click(object sender, EventArgs e)
        {
            temprature -= 1;
        }

/// <summary>
/// Timer in regards to our heater
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Timer_temp_Tick(object sender, EventArgs e)
        {
            // Set the caption to the current time.  
            currTmp_Heater_label.Text = temprature.ToString() + "ºC";
        }

        private void suctionCupStatus_Click(object sender, EventArgs e)
        {
            if(Cups_btn.BackColor == Color.Green)
            {
                
            }
        }

        private void tmp_chart_Click(object sender, EventArgs e)
        {

        }


    }




}
