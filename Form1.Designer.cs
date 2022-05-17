
namespace Teleporter_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_ctrl = new System.Windows.Forms.TabControl();
            this.main_prog_tab = new System.Windows.Forms.TabPage();
            this.rst_btn = new System.Windows.Forms.Button();
            this.main_prog_groupBox = new System.Windows.Forms.GroupBox();
            this.pos2_checkBox = new System.Windows.Forms.CheckBox();
            this.pos1_checkBox = new System.Windows.Forms.CheckBox();
            this.suctionCup_checkBox = new System.Windows.Forms.CheckBox();
            this.clmp_checkBox = new System.Windows.Forms.CheckBox();
            this.heater_checkBox = new System.Windows.Forms.CheckBox();
            this.portInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.progressBar_statusBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.main_prog_picBox = new System.Windows.Forms.PictureBox();
            this.percentage_lable = new System.Windows.Forms.Label();
            this.mainProg_richTextBox = new System.Windows.Forms.RichTextBox();
            this.main_prog_progressBar = new System.Windows.Forms.ProgressBar();
            this.stage_lable = new System.Windows.Forms.Label();
            this.heater_tab = new System.Windows.Forms.TabPage();
            this.temprature_groupBox = new System.Windows.Forms.GroupBox();
            this.desTmp_label = new System.Windows.Forms.Label();
            this.tmp_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.enter_tmp_label = new System.Windows.Forms.Label();
            this.Decr_btn = new System.Windows.Forms.Button();
            this.currTmp_Heater_label = new System.Windows.Forms.Label();
            this.Incr_btn = new System.Windows.Forms.Button();
            this.EnterTemp_textBox = new System.Windows.Forms.TextBox();
            this.substrate_tab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.leadScrew_pictureBox = new System.Windows.Forms.PictureBox();
            this.pause_leadScrew_btn = new System.Windows.Forms.Button();
            this.substrate_groupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox_leadScrew = new System.Windows.Forms.RichTextBox();
            this.pos2_btn = new System.Windows.Forms.Button();
            this.pos1_btn = new System.Windows.Forms.Button();
            this.run_leadScrew_btn = new System.Windows.Forms.Button();
            this.subs_status_btn = new System.Windows.Forms.Button();
            this.cup_tab = new System.Windows.Forms.TabPage();
            this.vac_groupBox = new System.Windows.Forms.GroupBox();
            this.airCyl_status_btn = new System.Windows.Forms.Button();
            this.Cups_btn = new System.Windows.Forms.Button();
            this.richTextBox_cupSolStatus = new System.Windows.Forms.RichTextBox();
            this.cups_psi_label = new System.Windows.Forms.Label();
            this.richTextBox_cupStatus = new System.Windows.Forms.RichTextBox();
            this.cup_sol_err = new System.Windows.Forms.Label();
            this.cup_err = new System.Windows.Forms.Label();
            this.suctionCupStatus = new System.Windows.Forms.Button();
            this.cups_status_gif = new System.Windows.Forms.PictureBox();
            this.clmp_tab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clmpDebug_btn = new System.Windows.Forms.Button();
            this.clmpL_btn = new System.Windows.Forms.Button();
            this.richTextBox_clmp_status = new System.Windows.Forms.RichTextBox();
            this.clmp_err = new System.Windows.Forms.Label();
            this.clmpR_btn = new System.Windows.Forms.Button();
            this.clmp_status = new System.Windows.Forms.Button();
            this.clmps_status_gif = new System.Windows.Forms.PictureBox();
            this.main_prog_imgList = new System.Windows.Forms.ImageList(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.Timer_MainProg = new System.Windows.Forms.Timer(this.components);
            this.Timer_temp = new System.Windows.Forms.Timer(this.components);
            this.tab_ctrl.SuspendLayout();
            this.main_prog_tab.SuspendLayout();
            this.main_prog_groupBox.SuspendLayout();
            this.portInfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_prog_picBox)).BeginInit();
            this.heater_tab.SuspendLayout();
            this.temprature_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmp_chart)).BeginInit();
            this.substrate_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadScrew_pictureBox)).BeginInit();
            this.substrate_groupBox.SuspendLayout();
            this.cup_tab.SuspendLayout();
            this.vac_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cups_status_gif)).BeginInit();
            this.clmp_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clmps_status_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_ctrl
            // 
            this.tab_ctrl.Controls.Add(this.main_prog_tab);
            this.tab_ctrl.Controls.Add(this.heater_tab);
            this.tab_ctrl.Controls.Add(this.substrate_tab);
            this.tab_ctrl.Controls.Add(this.cup_tab);
            this.tab_ctrl.Controls.Add(this.clmp_tab);
            this.tab_ctrl.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_ctrl.Location = new System.Drawing.Point(3, 3);
            this.tab_ctrl.Name = "tab_ctrl";
            this.tab_ctrl.SelectedIndex = 0;
            this.tab_ctrl.Size = new System.Drawing.Size(1376, 691);
            this.tab_ctrl.TabIndex = 0;
            // 
            // main_prog_tab
            // 
            this.main_prog_tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.main_prog_tab.Controls.Add(this.rst_btn);
            this.main_prog_tab.Controls.Add(this.main_prog_groupBox);
            this.main_prog_tab.Controls.Add(this.portInfo_groupBox);
            this.main_prog_tab.Controls.Add(this.main_prog_picBox);
            this.main_prog_tab.Controls.Add(this.percentage_lable);
            this.main_prog_tab.Controls.Add(this.mainProg_richTextBox);
            this.main_prog_tab.Controls.Add(this.main_prog_progressBar);
            this.main_prog_tab.Controls.Add(this.stage_lable);
            this.main_prog_tab.Location = new System.Drawing.Point(4, 38);
            this.main_prog_tab.Name = "main_prog_tab";
            this.main_prog_tab.Padding = new System.Windows.Forms.Padding(3);
            this.main_prog_tab.Size = new System.Drawing.Size(1368, 649);
            this.main_prog_tab.TabIndex = 0;
            this.main_prog_tab.Text = "Main Progress";
            // 
            // rst_btn
            // 
            this.rst_btn.BackColor = System.Drawing.Color.Red;
            this.rst_btn.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst_btn.Location = new System.Drawing.Point(338, 13);
            this.rst_btn.Name = "rst_btn";
            this.rst_btn.Size = new System.Drawing.Size(266, 93);
            this.rst_btn.TabIndex = 10;
            this.rst_btn.Text = "RESET";
            this.rst_btn.UseVisualStyleBackColor = false;
            this.rst_btn.Click += new System.EventHandler(this.rst_btn_Click);
            // 
            // main_prog_groupBox
            // 
            this.main_prog_groupBox.Controls.Add(this.pos2_checkBox);
            this.main_prog_groupBox.Controls.Add(this.pos1_checkBox);
            this.main_prog_groupBox.Controls.Add(this.suctionCup_checkBox);
            this.main_prog_groupBox.Controls.Add(this.clmp_checkBox);
            this.main_prog_groupBox.Controls.Add(this.heater_checkBox);
            this.main_prog_groupBox.ForeColor = System.Drawing.Color.Black;
            this.main_prog_groupBox.Location = new System.Drawing.Point(6, 305);
            this.main_prog_groupBox.Name = "main_prog_groupBox";
            this.main_prog_groupBox.Size = new System.Drawing.Size(157, 212);
            this.main_prog_groupBox.TabIndex = 9;
            this.main_prog_groupBox.TabStop = false;
            this.main_prog_groupBox.Text = "Subsystems";
            // 
            // pos2_checkBox
            // 
            this.pos2_checkBox.AutoSize = true;
            this.pos2_checkBox.Location = new System.Drawing.Point(6, 160);
            this.pos2_checkBox.Name = "pos2_checkBox";
            this.pos2_checkBox.Size = new System.Drawing.Size(124, 33);
            this.pos2_checkBox.TabIndex = 9;
            this.pos2_checkBox.Text = "Position 2";
            this.pos2_checkBox.UseVisualStyleBackColor = true;
            // 
            // pos1_checkBox
            // 
            this.pos1_checkBox.AutoSize = true;
            this.pos1_checkBox.Location = new System.Drawing.Point(6, 130);
            this.pos1_checkBox.Name = "pos1_checkBox";
            this.pos1_checkBox.Size = new System.Drawing.Size(121, 33);
            this.pos1_checkBox.TabIndex = 9;
            this.pos1_checkBox.Text = "Position 1";
            this.pos1_checkBox.UseVisualStyleBackColor = true;
            // 
            // suctionCup_checkBox
            // 
            this.suctionCup_checkBox.AutoSize = true;
            this.suctionCup_checkBox.Location = new System.Drawing.Point(6, 100);
            this.suctionCup_checkBox.Name = "suctionCup_checkBox";
            this.suctionCup_checkBox.Size = new System.Drawing.Size(141, 33);
            this.suctionCup_checkBox.TabIndex = 9;
            this.suctionCup_checkBox.Text = "Suction Cup";
            this.suctionCup_checkBox.UseVisualStyleBackColor = true;
            // 
            // clmp_checkBox
            // 
            this.clmp_checkBox.AutoSize = true;
            this.clmp_checkBox.Location = new System.Drawing.Point(6, 70);
            this.clmp_checkBox.Name = "clmp_checkBox";
            this.clmp_checkBox.Size = new System.Drawing.Size(100, 33);
            this.clmp_checkBox.TabIndex = 9;
            this.clmp_checkBox.Text = "Clamps";
            this.clmp_checkBox.UseVisualStyleBackColor = true;
            // 
            // heater_checkBox
            // 
            this.heater_checkBox.AutoSize = true;
            this.heater_checkBox.Enabled = false;
            this.heater_checkBox.Location = new System.Drawing.Point(6, 40);
            this.heater_checkBox.Name = "heater_checkBox";
            this.heater_checkBox.Size = new System.Drawing.Size(96, 33);
            this.heater_checkBox.TabIndex = 9;
            this.heater_checkBox.Text = "Heater";
            this.heater_checkBox.UseVisualStyleBackColor = true;
            // 
            // portInfo_groupBox
            // 
            this.portInfo_groupBox.Controls.Add(this.button_close);
            this.portInfo_groupBox.Controls.Add(this.button_open);
            this.portInfo_groupBox.Controls.Add(this.progressBar_statusBar);
            this.portInfo_groupBox.Controls.Add(this.label4);
            this.portInfo_groupBox.Controls.Add(this.comboBox_baudRate);
            this.portInfo_groupBox.Controls.Add(this.label3);
            this.portInfo_groupBox.Controls.Add(this.label_status);
            this.portInfo_groupBox.Controls.Add(this.comboBox_comPort);
            this.portInfo_groupBox.Controls.Add(this.label1);
            this.portInfo_groupBox.Location = new System.Drawing.Point(6, 6);
            this.portInfo_groupBox.Name = "portInfo_groupBox";
            this.portInfo_groupBox.Size = new System.Drawing.Size(279, 293);
            this.portInfo_groupBox.TabIndex = 8;
            this.portInfo_groupBox.TabStop = false;
            this.portInfo_groupBox.Text = "PORT INFO";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(128, 225);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(98, 47);
            this.button_close.TabIndex = 18;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(20, 225);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(102, 47);
            this.button_open.TabIndex = 17;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // progressBar_statusBar
            // 
            this.progressBar_statusBar.Location = new System.Drawing.Point(128, 136);
            this.progressBar_statusBar.Name = "progressBar_statusBar";
            this.progressBar_statusBar.Size = new System.Drawing.Size(121, 31);
            this.progressBar_statusBar.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "STATUS:";
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(128, 89);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(121, 37);
            this.comboBox_baudRate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "BAUD RATE:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(91, 179);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(158, 29);
            this.label_status.TabIndex = 12;
            this.label_status.Text = "DISCONNECTED";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(128, 38);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(121, 37);
            this.comboBox_comPort.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "COM PORT:";
            // 
            // main_prog_picBox
            // 
            this.main_prog_picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.main_prog_picBox.Image = global::Teleporter_GUI.Properties.Resources.Exploded_Gif;
            this.main_prog_picBox.InitialImage = global::Teleporter_GUI.Properties.Resources.Exploded_Gif;
            this.main_prog_picBox.Location = new System.Drawing.Point(710, 122);
            this.main_prog_picBox.Name = "main_prog_picBox";
            this.main_prog_picBox.Size = new System.Drawing.Size(595, 346);
            this.main_prog_picBox.TabIndex = 5;
            this.main_prog_picBox.TabStop = false;
            // 
            // percentage_lable
            // 
            this.percentage_lable.AutoSize = true;
            this.percentage_lable.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage_lable.Location = new System.Drawing.Point(435, 273);
            this.percentage_lable.Name = "percentage_lable";
            this.percentage_lable.Size = new System.Drawing.Size(71, 48);
            this.percentage_lable.TabIndex = 4;
            this.percentage_lable.Text = "0%";
            // 
            // mainProg_richTextBox
            // 
            this.mainProg_richTextBox.Location = new System.Drawing.Point(283, 422);
            this.mainProg_richTextBox.Name = "mainProg_richTextBox";
            this.mainProg_richTextBox.Size = new System.Drawing.Size(379, 124);
            this.mainProg_richTextBox.TabIndex = 2;
            this.mainProg_richTextBox.Text = "";
            // 
            // main_prog_progressBar
            // 
            this.main_prog_progressBar.Location = new System.Drawing.Point(338, 345);
            this.main_prog_progressBar.Name = "main_prog_progressBar";
            this.main_prog_progressBar.Size = new System.Drawing.Size(272, 38);
            this.main_prog_progressBar.TabIndex = 1;
            // 
            // stage_lable
            // 
            this.stage_lable.AutoSize = true;
            this.stage_lable.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_lable.Location = new System.Drawing.Point(373, 216);
            this.stage_lable.Name = "stage_lable";
            this.stage_lable.Size = new System.Drawing.Size(204, 48);
            this.stage_lable.TabIndex = 0;
            this.stage_lable.Text = "Set Up Stage";
            // 
            // heater_tab
            // 
            this.heater_tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.heater_tab.Controls.Add(this.temprature_groupBox);
            this.heater_tab.Location = new System.Drawing.Point(4, 38);
            this.heater_tab.Name = "heater_tab";
            this.heater_tab.Padding = new System.Windows.Forms.Padding(3);
            this.heater_tab.Size = new System.Drawing.Size(1368, 649);
            this.heater_tab.TabIndex = 1;
            this.heater_tab.Text = "Heater";
            // 
            // temprature_groupBox
            // 
            this.temprature_groupBox.Controls.Add(this.desTmp_label);
            this.temprature_groupBox.Controls.Add(this.tmp_chart);
            this.temprature_groupBox.Controls.Add(this.enter_tmp_label);
            this.temprature_groupBox.Controls.Add(this.Decr_btn);
            this.temprature_groupBox.Controls.Add(this.currTmp_Heater_label);
            this.temprature_groupBox.Controls.Add(this.Incr_btn);
            this.temprature_groupBox.Controls.Add(this.EnterTemp_textBox);
            this.temprature_groupBox.Location = new System.Drawing.Point(6, 6);
            this.temprature_groupBox.Name = "temprature_groupBox";
            this.temprature_groupBox.Size = new System.Drawing.Size(1318, 391);
            this.temprature_groupBox.TabIndex = 11;
            this.temprature_groupBox.TabStop = false;
            this.temprature_groupBox.Text = "Temprature Information";
            // 
            // desTmp_label
            // 
            this.desTmp_label.AutoSize = true;
            this.desTmp_label.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desTmp_label.Location = new System.Drawing.Point(6, 40);
            this.desTmp_label.Name = "desTmp_label";
            this.desTmp_label.Size = new System.Drawing.Size(279, 29);
            this.desTmp_label.TabIndex = 2;
            this.desTmp_label.Text = "Designated Temprature: ... ºC";
            // 
            // tmp_chart
            // 
            this.tmp_chart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.tmp_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tmp_chart.Legends.Add(legend1);
            this.tmp_chart.Location = new System.Drawing.Point(684, 20);
            this.tmp_chart.Name = "tmp_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Sitka Heading", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Temprature";
            series1.ShadowColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tmp_chart.Series.Add(series1);
            this.tmp_chart.Size = new System.Drawing.Size(616, 316);
            this.tmp_chart.TabIndex = 0;
            this.tmp_chart.Text = "Temprature Level";
            title1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Temprature and Time";
            this.tmp_chart.Titles.Add(title1);
            // 
            // enter_tmp_label
            // 
            this.enter_tmp_label.AutoSize = true;
            this.enter_tmp_label.Location = new System.Drawing.Point(97, 143);
            this.enter_tmp_label.Name = "enter_tmp_label";
            this.enter_tmp_label.Size = new System.Drawing.Size(263, 29);
            this.enter_tmp_label.TabIndex = 8;
            this.enter_tmp_label.Text = "Enter the Temperature here";
            // 
            // Decr_btn
            // 
            this.Decr_btn.BackColor = System.Drawing.Color.Red;
            this.Decr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decr_btn.ForeColor = System.Drawing.Color.Black;
            this.Decr_btn.Location = new System.Drawing.Point(28, 188);
            this.Decr_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Decr_btn.Name = "Decr_btn";
            this.Decr_btn.Size = new System.Drawing.Size(87, 82);
            this.Decr_btn.TabIndex = 7;
            this.Decr_btn.Text = "-";
            this.Decr_btn.UseVisualStyleBackColor = false;
            this.Decr_btn.Click += new System.EventHandler(this.Decr_btn_Click);
            // 
            // currTmp_Heater_label
            // 
            this.currTmp_Heater_label.AutoSize = true;
            this.currTmp_Heater_label.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTmp_Heater_label.Location = new System.Drawing.Point(6, 75);
            this.currTmp_Heater_label.Name = "currTmp_Heater_label";
            this.currTmp_Heater_label.Size = new System.Drawing.Size(339, 29);
            this.currTmp_Heater_label.TabIndex = 9;
            this.currTmp_Heater_label.Text = "Current Temprature of Heater: ... ºC";
            // 
            // Incr_btn
            // 
            this.Incr_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.Incr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Incr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incr_btn.ForeColor = System.Drawing.Color.Black;
            this.Incr_btn.Location = new System.Drawing.Point(340, 188);
            this.Incr_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Incr_btn.Name = "Incr_btn";
            this.Incr_btn.Size = new System.Drawing.Size(88, 82);
            this.Incr_btn.TabIndex = 6;
            this.Incr_btn.Text = "+";
            this.Incr_btn.UseVisualStyleBackColor = false;
            this.Incr_btn.Click += new System.EventHandler(this.Incr_btn_Click);
            // 
            // EnterTemp_textBox
            // 
            this.EnterTemp_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTemp_textBox.Location = new System.Drawing.Point(200, 211);
            this.EnterTemp_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterTemp_textBox.Name = "EnterTemp_textBox";
            this.EnterTemp_textBox.Size = new System.Drawing.Size(55, 53);
            this.EnterTemp_textBox.TabIndex = 5;
            // 
            // substrate_tab
            // 
            this.substrate_tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.substrate_tab.Controls.Add(this.label2);
            this.substrate_tab.Controls.Add(this.leadScrew_pictureBox);
            this.substrate_tab.Controls.Add(this.pause_leadScrew_btn);
            this.substrate_tab.Controls.Add(this.substrate_groupBox);
            this.substrate_tab.Controls.Add(this.run_leadScrew_btn);
            this.substrate_tab.Controls.Add(this.subs_status_btn);
            this.substrate_tab.Location = new System.Drawing.Point(4, 38);
            this.substrate_tab.Name = "substrate_tab";
            this.substrate_tab.Padding = new System.Windows.Forms.Padding(3);
            this.substrate_tab.Size = new System.Drawing.Size(1368, 649);
            this.substrate_tab.TabIndex = 2;
            this.substrate_tab.Text = "Substrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current Temprature of Heater: ... ºC";
            // 
            // leadScrew_pictureBox
            // 
            this.leadScrew_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leadScrew_pictureBox.Image = global::Teleporter_GUI.Properties.Resources.Movement_Gif;
            this.leadScrew_pictureBox.InitialImage = global::Teleporter_GUI.Properties.Resources.Movement_Gif;
            this.leadScrew_pictureBox.Location = new System.Drawing.Point(691, 124);
            this.leadScrew_pictureBox.Name = "leadScrew_pictureBox";
            this.leadScrew_pictureBox.Size = new System.Drawing.Size(612, 343);
            this.leadScrew_pictureBox.TabIndex = 13;
            this.leadScrew_pictureBox.TabStop = false;
            // 
            // pause_leadScrew_btn
            // 
            this.pause_leadScrew_btn.Location = new System.Drawing.Point(776, 38);
            this.pause_leadScrew_btn.Name = "pause_leadScrew_btn";
            this.pause_leadScrew_btn.Size = new System.Drawing.Size(104, 56);
            this.pause_leadScrew_btn.TabIndex = 12;
            this.pause_leadScrew_btn.Text = "STOP";
            this.pause_leadScrew_btn.UseVisualStyleBackColor = true;
            // 
            // substrate_groupBox
            // 
            this.substrate_groupBox.Controls.Add(this.richTextBox_leadScrew);
            this.substrate_groupBox.Controls.Add(this.pos2_btn);
            this.substrate_groupBox.Controls.Add(this.pos1_btn);
            this.substrate_groupBox.Location = new System.Drawing.Point(17, 106);
            this.substrate_groupBox.Name = "substrate_groupBox";
            this.substrate_groupBox.Size = new System.Drawing.Size(519, 473);
            this.substrate_groupBox.TabIndex = 11;
            this.substrate_groupBox.TabStop = false;
            this.substrate_groupBox.Text = "Lead Screw";
            // 
            // richTextBox_leadScrew
            // 
            this.richTextBox_leadScrew.Location = new System.Drawing.Point(6, 144);
            this.richTextBox_leadScrew.Name = "richTextBox_leadScrew";
            this.richTextBox_leadScrew.Size = new System.Drawing.Size(441, 298);
            this.richTextBox_leadScrew.TabIndex = 10;
            this.richTextBox_leadScrew.Text = "";
            // 
            // pos2_btn
            // 
            this.pos2_btn.BackColor = System.Drawing.Color.Red;
            this.pos2_btn.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos2_btn.ForeColor = System.Drawing.Color.Black;
            this.pos2_btn.Location = new System.Drawing.Point(157, 44);
            this.pos2_btn.Name = "pos2_btn";
            this.pos2_btn.Size = new System.Drawing.Size(115, 67);
            this.pos2_btn.TabIndex = 9;
            this.pos2_btn.Text = "Position 2";
            this.pos2_btn.UseVisualStyleBackColor = false;
            // 
            // pos1_btn
            // 
            this.pos1_btn.BackColor = System.Drawing.Color.Red;
            this.pos1_btn.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos1_btn.ForeColor = System.Drawing.Color.Black;
            this.pos1_btn.Location = new System.Drawing.Point(6, 44);
            this.pos1_btn.Name = "pos1_btn";
            this.pos1_btn.Size = new System.Drawing.Size(125, 67);
            this.pos1_btn.TabIndex = 8;
            this.pos1_btn.Text = "Position 1";
            this.pos1_btn.UseVisualStyleBackColor = false;
            // 
            // run_leadScrew_btn
            // 
            this.run_leadScrew_btn.Location = new System.Drawing.Point(650, 36);
            this.run_leadScrew_btn.Name = "run_leadScrew_btn";
            this.run_leadScrew_btn.Size = new System.Drawing.Size(108, 58);
            this.run_leadScrew_btn.TabIndex = 11;
            this.run_leadScrew_btn.Text = "RUN";
            this.run_leadScrew_btn.UseVisualStyleBackColor = true;
            // 
            // subs_status_btn
            // 
            this.subs_status_btn.BackColor = System.Drawing.Color.Red;
            this.subs_status_btn.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subs_status_btn.ForeColor = System.Drawing.Color.Black;
            this.subs_status_btn.Location = new System.Drawing.Point(23, 17);
            this.subs_status_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subs_status_btn.Name = "subs_status_btn";
            this.subs_status_btn.Size = new System.Drawing.Size(186, 68);
            this.subs_status_btn.TabIndex = 5;
            this.subs_status_btn.Text = "Not Ready";
            this.subs_status_btn.UseVisualStyleBackColor = false;
            // 
            // cup_tab
            // 
            this.cup_tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cup_tab.Controls.Add(this.vac_groupBox);
            this.cup_tab.Controls.Add(this.suctionCupStatus);
            this.cup_tab.Controls.Add(this.cups_status_gif);
            this.cup_tab.Location = new System.Drawing.Point(4, 38);
            this.cup_tab.Name = "cup_tab";
            this.cup_tab.Padding = new System.Windows.Forms.Padding(3);
            this.cup_tab.Size = new System.Drawing.Size(1368, 649);
            this.cup_tab.TabIndex = 3;
            this.cup_tab.Text = "Vaccum";
            // 
            // vac_groupBox
            // 
            this.vac_groupBox.Controls.Add(this.airCyl_status_btn);
            this.vac_groupBox.Controls.Add(this.Cups_btn);
            this.vac_groupBox.Controls.Add(this.richTextBox_cupSolStatus);
            this.vac_groupBox.Controls.Add(this.cups_psi_label);
            this.vac_groupBox.Controls.Add(this.richTextBox_cupStatus);
            this.vac_groupBox.Controls.Add(this.cup_sol_err);
            this.vac_groupBox.Controls.Add(this.cup_err);
            this.vac_groupBox.Location = new System.Drawing.Point(37, 111);
            this.vac_groupBox.Name = "vac_groupBox";
            this.vac_groupBox.Size = new System.Drawing.Size(483, 515);
            this.vac_groupBox.TabIndex = 37;
            this.vac_groupBox.TabStop = false;
            this.vac_groupBox.Text = "Vaccum Status";
            // 
            // airCyl_status_btn
            // 
            this.airCyl_status_btn.BackColor = System.Drawing.Color.Red;
            this.airCyl_status_btn.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airCyl_status_btn.Location = new System.Drawing.Point(150, 97);
            this.airCyl_status_btn.Name = "airCyl_status_btn";
            this.airCyl_status_btn.Size = new System.Drawing.Size(160, 52);
            this.airCyl_status_btn.TabIndex = 31;
            this.airCyl_status_btn.Text = "Cups Solenoid";
            this.airCyl_status_btn.UseVisualStyleBackColor = false;
            // 
            // Cups_btn
            // 
            this.Cups_btn.BackColor = System.Drawing.Color.Red;
            this.Cups_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cups_btn.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cups_btn.Location = new System.Drawing.Point(20, 97);
            this.Cups_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cups_btn.Name = "Cups_btn";
            this.Cups_btn.Size = new System.Drawing.Size(111, 50);
            this.Cups_btn.TabIndex = 28;
            this.Cups_btn.Text = "CUPS";
            this.Cups_btn.UseVisualStyleBackColor = false;
            // 
            // richTextBox_cupSolStatus
            // 
            this.richTextBox_cupSolStatus.Location = new System.Drawing.Point(20, 381);
            this.richTextBox_cupSolStatus.Name = "richTextBox_cupSolStatus";
            this.richTextBox_cupSolStatus.Size = new System.Drawing.Size(422, 107);
            this.richTextBox_cupSolStatus.TabIndex = 36;
            this.richTextBox_cupSolStatus.Text = "";
            // 
            // cups_psi_label
            // 
            this.cups_psi_label.AutoSize = true;
            this.cups_psi_label.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cups_psi_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cups_psi_label.Location = new System.Drawing.Point(13, 36);
            this.cups_psi_label.Name = "cups_psi_label";
            this.cups_psi_label.Size = new System.Drawing.Size(162, 40);
            this.cups_psi_label.TabIndex = 30;
            this.cups_psi_label.Text = "Force: 0 psi";
            // 
            // richTextBox_cupStatus
            // 
            this.richTextBox_cupStatus.Location = new System.Drawing.Point(20, 207);
            this.richTextBox_cupStatus.Name = "richTextBox_cupStatus";
            this.richTextBox_cupStatus.Size = new System.Drawing.Size(422, 110);
            this.richTextBox_cupStatus.TabIndex = 35;
            this.richTextBox_cupStatus.Text = "";
            // 
            // cup_sol_err
            // 
            this.cup_sol_err.AutoSize = true;
            this.cup_sol_err.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cup_sol_err.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cup_sol_err.Location = new System.Drawing.Point(6, 338);
            this.cup_sol_err.Name = "cup_sol_err";
            this.cup_sol_err.Size = new System.Drawing.Size(289, 40);
            this.cup_sol_err.TabIndex = 32;
            this.cup_sol_err.Text = "Cup Sol Status Details";
            // 
            // cup_err
            // 
            this.cup_err.AutoSize = true;
            this.cup_err.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cup_err.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cup_err.Location = new System.Drawing.Point(6, 164);
            this.cup_err.Name = "cup_err";
            this.cup_err.Size = new System.Drawing.Size(242, 40);
            this.cup_err.TabIndex = 29;
            this.cup_err.Text = "Cup status Details";
            // 
            // suctionCupStatus
            // 
            this.suctionCupStatus.BackColor = System.Drawing.Color.Red;
            this.suctionCupStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.suctionCupStatus.Font = new System.Drawing.Font("Sitka Heading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suctionCupStatus.Location = new System.Drawing.Point(62, 19);
            this.suctionCupStatus.Margin = new System.Windows.Forms.Padding(4);
            this.suctionCupStatus.Name = "suctionCupStatus";
            this.suctionCupStatus.Size = new System.Drawing.Size(223, 60);
            this.suctionCupStatus.TabIndex = 27;
            this.suctionCupStatus.Text = "NOT ACTIVE";
            this.suctionCupStatus.UseVisualStyleBackColor = false;
            // 
            // cups_status_gif
            // 
            this.cups_status_gif.Image = ((System.Drawing.Image)(resources.GetObject("cups_status_gif.Image")));
            this.cups_status_gif.Location = new System.Drawing.Point(604, 121);
            this.cups_status_gif.Name = "cups_status_gif";
            this.cups_status_gif.Size = new System.Drawing.Size(725, 452);
            this.cups_status_gif.TabIndex = 33;
            this.cups_status_gif.TabStop = false;
            // 
            // clmp_tab
            // 
            this.clmp_tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clmp_tab.Controls.Add(this.groupBox1);
            this.clmp_tab.Controls.Add(this.clmp_status);
            this.clmp_tab.Controls.Add(this.clmps_status_gif);
            this.clmp_tab.Location = new System.Drawing.Point(4, 38);
            this.clmp_tab.Name = "clmp_tab";
            this.clmp_tab.Padding = new System.Windows.Forms.Padding(3);
            this.clmp_tab.Size = new System.Drawing.Size(1368, 649);
            this.clmp_tab.TabIndex = 4;
            this.clmp_tab.Text = "Clamps";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clmpDebug_btn);
            this.groupBox1.Controls.Add(this.clmpL_btn);
            this.groupBox1.Controls.Add(this.richTextBox_clmp_status);
            this.groupBox1.Controls.Add(this.clmp_err);
            this.groupBox1.Controls.Add(this.clmpR_btn);
            this.groupBox1.Location = new System.Drawing.Point(25, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 470);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // clmpDebug_btn
            // 
            this.clmpDebug_btn.Location = new System.Drawing.Point(225, 77);
            this.clmpDebug_btn.Name = "clmpDebug_btn";
            this.clmpDebug_btn.Size = new System.Drawing.Size(105, 59);
            this.clmpDebug_btn.TabIndex = 13;
            this.clmpDebug_btn.Text = "Debug";
            this.clmpDebug_btn.UseVisualStyleBackColor = true;
            this.clmpDebug_btn.Click += new System.EventHandler(this.clmpDebug_btn_Click);
            // 
            // clmpL_btn
            // 
            this.clmpL_btn.BackColor = System.Drawing.Color.Red;
            this.clmpL_btn.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmpL_btn.Location = new System.Drawing.Point(6, 114);
            this.clmpL_btn.Name = "clmpL_btn";
            this.clmpL_btn.Size = new System.Drawing.Size(160, 46);
            this.clmpL_btn.TabIndex = 12;
            this.clmpL_btn.Text = "Left Clamp";
            this.clmpL_btn.UseVisualStyleBackColor = false;
            // 
            // richTextBox_clmp_status
            // 
            this.richTextBox_clmp_status.Location = new System.Drawing.Point(6, 240);
            this.richTextBox_clmp_status.Name = "richTextBox_clmp_status";
            this.richTextBox_clmp_status.Size = new System.Drawing.Size(367, 195);
            this.richTextBox_clmp_status.TabIndex = 10;
            this.richTextBox_clmp_status.Text = "";
            // 
            // clmp_err
            // 
            this.clmp_err.AutoSize = true;
            this.clmp_err.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clmp_err.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmp_err.ForeColor = System.Drawing.Color.Black;
            this.clmp_err.Location = new System.Drawing.Point(6, 197);
            this.clmp_err.Name = "clmp_err";
            this.clmp_err.Size = new System.Drawing.Size(285, 40);
            this.clmp_err.TabIndex = 8;
            this.clmp_err.Text = "Clamps status Details";
            // 
            // clmpR_btn
            // 
            this.clmpR_btn.BackColor = System.Drawing.Color.Red;
            this.clmpR_btn.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmpR_btn.Location = new System.Drawing.Point(6, 62);
            this.clmpR_btn.Name = "clmpR_btn";
            this.clmpR_btn.Size = new System.Drawing.Size(160, 46);
            this.clmpR_btn.TabIndex = 11;
            this.clmpR_btn.Text = "Right Clamp";
            this.clmpR_btn.UseVisualStyleBackColor = false;
            // 
            // clmp_status
            // 
            this.clmp_status.BackColor = System.Drawing.Color.Red;
            this.clmp_status.Font = new System.Drawing.Font("Sitka Heading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmp_status.Location = new System.Drawing.Point(49, 25);
            this.clmp_status.Name = "clmp_status";
            this.clmp_status.Size = new System.Drawing.Size(238, 80);
            this.clmp_status.TabIndex = 7;
            this.clmp_status.Text = "NOT ACTIVE";
            this.clmp_status.UseVisualStyleBackColor = false;
            this.clmp_status.Click += new System.EventHandler(this.clmp_status_Click);
            // 
            // clmps_status_gif
            // 
            this.clmps_status_gif.Image = ((System.Drawing.Image)(resources.GetObject("clmps_status_gif.Image")));
            this.clmps_status_gif.Location = new System.Drawing.Point(539, 218);
            this.clmps_status_gif.Name = "clmps_status_gif";
            this.clmps_status_gif.Size = new System.Drawing.Size(765, 270);
            this.clmps_status_gif.TabIndex = 9;
            this.clmps_status_gif.TabStop = false;
            // 
            // main_prog_imgList
            // 
            this.main_prog_imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.main_prog_imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.main_prog_imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM4";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Timer_MainProg
            // 
            this.Timer_MainProg.Tick += new System.EventHandler(this.Timer_MainProg_Tick);
            // 
            // Timer_temp
            // 
            this.Timer_temp.Enabled = true;
            this.Timer_temp.Interval = 50;
            this.Timer_temp.Tick += new System.EventHandler(this.Timer_temp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1383, 697);
            this.Controls.Add(this.tab_ctrl);
            this.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Teleporter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_ctrl.ResumeLayout(false);
            this.main_prog_tab.ResumeLayout(false);
            this.main_prog_tab.PerformLayout();
            this.main_prog_groupBox.ResumeLayout(false);
            this.main_prog_groupBox.PerformLayout();
            this.portInfo_groupBox.ResumeLayout(false);
            this.portInfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_prog_picBox)).EndInit();
            this.heater_tab.ResumeLayout(false);
            this.temprature_groupBox.ResumeLayout(false);
            this.temprature_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmp_chart)).EndInit();
            this.substrate_tab.ResumeLayout(false);
            this.substrate_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadScrew_pictureBox)).EndInit();
            this.substrate_groupBox.ResumeLayout(false);
            this.cup_tab.ResumeLayout(false);
            this.vac_groupBox.ResumeLayout(false);
            this.vac_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cups_status_gif)).EndInit();
            this.clmp_tab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clmps_status_gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ctrl;
        private System.Windows.Forms.TabPage main_prog_tab;
        private System.Windows.Forms.TabPage heater_tab;
        private System.Windows.Forms.TabPage substrate_tab;
        private System.Windows.Forms.TabPage cup_tab;
        private System.Windows.Forms.TabPage clmp_tab;
        private System.Windows.Forms.Label stage_lable;
        private System.Windows.Forms.RichTextBox mainProg_richTextBox;
        private System.Windows.Forms.ProgressBar main_prog_progressBar;
        private System.Windows.Forms.Label percentage_lable;
        private System.Windows.Forms.DataVisualization.Charting.Chart tmp_chart;
        private System.Windows.Forms.PictureBox main_prog_picBox;
        private System.Windows.Forms.ImageList main_prog_imgList;
        private System.Windows.Forms.Label desTmp_label;
        private System.Windows.Forms.Button Incr_btn;
        private System.Windows.Forms.TextBox EnterTemp_textBox;
        private System.Windows.Forms.Button Decr_btn;
        private System.Windows.Forms.Label enter_tmp_label;
        private System.Windows.Forms.RichTextBox richTextBox_leadScrew;
        private System.Windows.Forms.Button pos2_btn;
        private System.Windows.Forms.Button pos1_btn;
        private System.Windows.Forms.Button subs_status_btn;
        private System.Windows.Forms.RichTextBox richTextBox_cupSolStatus;
        private System.Windows.Forms.RichTextBox richTextBox_cupStatus;
        private System.Windows.Forms.PictureBox cups_status_gif;
        private System.Windows.Forms.Label cup_sol_err;
        private System.Windows.Forms.Button airCyl_status_btn;
        private System.Windows.Forms.Label cups_psi_label;
        private System.Windows.Forms.Label cup_err;
        private System.Windows.Forms.Button Cups_btn;
        private System.Windows.Forms.Button suctionCupStatus;
        private System.Windows.Forms.RichTextBox richTextBox_clmp_status;
        private System.Windows.Forms.PictureBox clmps_status_gif;
        private System.Windows.Forms.Label clmp_err;
        private System.Windows.Forms.Button clmp_status;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox portInfo_groupBox;
        private System.Windows.Forms.ProgressBar progressBar_statusBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button clmpL_btn;
        private System.Windows.Forms.Button clmpR_btn;
        private System.Windows.Forms.Label currTmp_Heater_label;
        private System.Windows.Forms.Timer Timer_MainProg;
        private System.Windows.Forms.Timer Timer_temp;
        private System.Windows.Forms.GroupBox main_prog_groupBox;
        private System.Windows.Forms.CheckBox pos2_checkBox;
        private System.Windows.Forms.CheckBox pos1_checkBox;
        private System.Windows.Forms.CheckBox suctionCup_checkBox;
        private System.Windows.Forms.CheckBox clmp_checkBox;
        private System.Windows.Forms.CheckBox heater_checkBox;
        private System.Windows.Forms.GroupBox temprature_groupBox;
        private System.Windows.Forms.GroupBox substrate_groupBox;
        private System.Windows.Forms.Button pause_leadScrew_btn;
        private System.Windows.Forms.Button run_leadScrew_btn;
        private System.Windows.Forms.GroupBox vac_groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox leadScrew_pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clmpDebug_btn;
        private System.Windows.Forms.Button rst_btn;
    }
}

