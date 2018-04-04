namespace PID_Application
{
    partial class MainForm
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
                temperatureController.Dispose();
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TempPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.TempLbl = new System.Windows.Forms.Label();
            this.ControlPnl = new System.Windows.Forms.Panel();
            this.TsetLbl = new System.Windows.Forms.Label();
            this.TempSetBx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TimeStepBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TempUnitLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DerivativeBx = new System.Windows.Forms.TextBox();
            this.IntegralBx = new System.Windows.Forms.TextBox();
            this.ProportionalBx = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeviceRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSelectUnitDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUnitCelsius = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUnitFarenheit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConstantLocks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLockAParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLockBParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLockCParameter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLockTimeStepSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDisplaysHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProgramHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StartStopBttn = new System.Windows.Forms.Button();
            this.VisualControlStatus = new System.Windows.Forms.PictureBox();
            this.VisualControlStatusLbl = new System.Windows.Forms.Label();
            this.TempPlotExpanded = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeStepsLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TimeToEqLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DerivativeContributionLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IntegralContributionLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProportionalContributionLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeviceBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TempChnnlBx = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.VoltChnnlBx = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.MeasureTypeBx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TempPlot)).BeginInit();
            this.ControlPnl.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisualControlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPlotExpanded)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TempPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.TempPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TempPlot.Legends.Add(legend1);
            this.TempPlot.Location = new System.Drawing.Point(353, 31);
            this.TempPlot.Name = "TempPlot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.TempPlot.Series.Add(series1);
            this.TempPlot.Size = new System.Drawing.Size(457, 211);
            this.TempPlot.TabIndex = 0;
            this.TempPlot.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Value:";
            // 
            // TempLbl
            // 
            this.TempLbl.AutoSize = true;
            this.TempLbl.Location = new System.Drawing.Point(109, 32);
            this.TempLbl.Name = "TempLbl";
            this.TempLbl.Size = new System.Drawing.Size(22, 13);
            this.TempLbl.TabIndex = 3;
            this.TempLbl.Text = "--.--";
            // 
            // ControlPnl
            // 
            this.ControlPnl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControlPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPnl.Controls.Add(this.TsetLbl);
            this.ControlPnl.Controls.Add(this.TempSetBx);
            this.ControlPnl.Controls.Add(this.label14);
            this.ControlPnl.Controls.Add(this.TimeStepBx);
            this.ControlPnl.Controls.Add(this.label7);
            this.ControlPnl.Controls.Add(this.TempUnitLbl);
            this.ControlPnl.Controls.Add(this.label5);
            this.ControlPnl.Controls.Add(this.label4);
            this.ControlPnl.Controls.Add(this.label3);
            this.ControlPnl.Controls.Add(this.DerivativeBx);
            this.ControlPnl.Controls.Add(this.IntegralBx);
            this.ControlPnl.Controls.Add(this.TempLbl);
            this.ControlPnl.Controls.Add(this.ProportionalBx);
            this.ControlPnl.Controls.Add(this.label2);
            this.ControlPnl.Location = new System.Drawing.Point(125, 31);
            this.ControlPnl.Name = "ControlPnl";
            this.ControlPnl.Size = new System.Drawing.Size(209, 211);
            this.ControlPnl.TabIndex = 4;
            // 
            // TsetLbl
            // 
            this.TsetLbl.AutoSize = true;
            this.TsetLbl.Location = new System.Drawing.Point(3, 54);
            this.TsetLbl.Name = "TsetLbl";
            this.TsetLbl.Size = new System.Drawing.Size(51, 13);
            this.TsetLbl.TabIndex = 14;
            this.TsetLbl.Text = "Tset (°C):";
            // 
            // TempSetBx
            // 
            this.TempSetBx.Location = new System.Drawing.Point(59, 51);
            this.TempSetBx.Name = "TempSetBx";
            this.TempSetBx.Size = new System.Drawing.Size(104, 20);
            this.TempSetBx.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 26);
            this.label14.TabIndex = 12;
            this.label14.Text = "   Time \r\nStep (ms):\r\n";
            // 
            // TimeStepBx
            // 
            this.TimeStepBx.Location = new System.Drawing.Point(59, 176);
            this.TimeStepBx.Name = "TimeStepBx";
            this.TimeStepBx.Size = new System.Drawing.Size(104, 20);
            this.TimeStepBx.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(44, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "PID Tuning Parameters";
            // 
            // TempUnitLbl
            // 
            this.TempUnitLbl.AutoSize = true;
            this.TempUnitLbl.Location = new System.Drawing.Point(149, 32);
            this.TempUnitLbl.Name = "TempUnitLbl";
            this.TempUnitLbl.Size = new System.Drawing.Size(18, 13);
            this.TempUnitLbl.TabIndex = 9;
            this.TempUnitLbl.Text = "°C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A:";
            // 
            // DerivativeBx
            // 
            this.DerivativeBx.Location = new System.Drawing.Point(59, 137);
            this.DerivativeBx.Name = "DerivativeBx";
            this.DerivativeBx.Size = new System.Drawing.Size(104, 20);
            this.DerivativeBx.TabIndex = 2;
            // 
            // IntegralBx
            // 
            this.IntegralBx.Location = new System.Drawing.Point(59, 111);
            this.IntegralBx.Name = "IntegralBx";
            this.IntegralBx.Size = new System.Drawing.Size(104, 20);
            this.IntegralBx.TabIndex = 1;
            // 
            // ProportionalBx
            // 
            this.ProportionalBx.Location = new System.Drawing.Point(59, 85);
            this.ProportionalBx.Name = "ProportionalBx";
            this.ProportionalBx.Size = new System.Drawing.Size(104, 20);
            this.ProportionalBx.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuList,
            this.MenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(820, 24);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuList
            // 
            this.MenuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDeviceRefresh,
            this.toolStripSeparator2,
            this.MenuSelectUnitDisplay,
            this.MenuConstantLocks,
            this.toolStripSeparator1,
            this.MenuQuit});
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(50, 20);
            this.MenuList.Text = "&Menu";
            // 
            // MenuDeviceRefresh
            // 
            this.MenuDeviceRefresh.Name = "MenuDeviceRefresh";
            this.MenuDeviceRefresh.Size = new System.Drawing.Size(172, 22);
            this.MenuDeviceRefresh.Text = "Refresh Device List";
            this.MenuDeviceRefresh.Click += new System.EventHandler(this.MenuDeviceRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // MenuSelectUnitDisplay
            // 
            this.MenuSelectUnitDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUnitCelsius,
            this.MenuUnitFarenheit});
            this.MenuSelectUnitDisplay.Name = "MenuSelectUnitDisplay";
            this.MenuSelectUnitDisplay.Size = new System.Drawing.Size(172, 22);
            this.MenuSelectUnitDisplay.Text = "Unit Display";
            // 
            // MenuUnitCelsius
            // 
            this.MenuUnitCelsius.Name = "MenuUnitCelsius";
            this.MenuUnitCelsius.Size = new System.Drawing.Size(123, 22);
            this.MenuUnitCelsius.Text = "Celsius";
            this.MenuUnitCelsius.Click += new System.EventHandler(this.MenuUnitCelsius_Click);
            // 
            // MenuUnitFarenheit
            // 
            this.MenuUnitFarenheit.Name = "MenuUnitFarenheit";
            this.MenuUnitFarenheit.Size = new System.Drawing.Size(123, 22);
            this.MenuUnitFarenheit.Text = "Farenheit";
            this.MenuUnitFarenheit.Click += new System.EventHandler(this.MenuUnitFarenheit_Click);
            // 
            // MenuConstantLocks
            // 
            this.MenuConstantLocks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLockAParameter,
            this.MenuLockBParameter,
            this.MenuLockCParameter,
            this.MenuLockTimeStepSize});
            this.MenuConstantLocks.Name = "MenuConstantLocks";
            this.MenuConstantLocks.Size = new System.Drawing.Size(172, 22);
            this.MenuConstantLocks.Text = "Constant Lock";
            // 
            // MenuLockAParameter
            // 
            this.MenuLockAParameter.Name = "MenuLockAParameter";
            this.MenuLockAParameter.Size = new System.Drawing.Size(190, 22);
            this.MenuLockAParameter.Text = "Lock A Parameter";
            this.MenuLockAParameter.Click += new System.EventHandler(this.MenuLockAParameter_Click);
            // 
            // MenuLockBParameter
            // 
            this.MenuLockBParameter.Name = "MenuLockBParameter";
            this.MenuLockBParameter.Size = new System.Drawing.Size(190, 22);
            this.MenuLockBParameter.Text = "Lock B Parameter";
            this.MenuLockBParameter.Click += new System.EventHandler(this.MenuLockBParameter_Click);
            // 
            // MenuLockCParameter
            // 
            this.MenuLockCParameter.Name = "MenuLockCParameter";
            this.MenuLockCParameter.Size = new System.Drawing.Size(190, 22);
            this.MenuLockCParameter.Text = "Lock C Parameter";
            this.MenuLockCParameter.Click += new System.EventHandler(this.MenuLockCParameter_Click);
            // 
            // MenuLockTimeStepSize
            // 
            this.MenuLockTimeStepSize.Name = "MenuLockTimeStepSize";
            this.MenuLockTimeStepSize.Size = new System.Drawing.Size(190, 22);
            this.MenuLockTimeStepSize.Text = "Unlock Time Step Size";
            this.MenuLockTimeStepSize.Click += new System.EventHandler(this.MenuLockTimeStepSize_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // MenuQuit
            // 
            this.MenuQuit.Name = "MenuQuit";
            this.MenuQuit.Size = new System.Drawing.Size(172, 22);
            this.MenuQuit.Text = "Quit";
            this.MenuQuit.Click += new System.EventHandler(this.MenuQuit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDisplaysHelp,
            this.MenuProgramHelp});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "&Help";
            // 
            // MenuDisplaysHelp
            // 
            this.MenuDisplaysHelp.Name = "MenuDisplaysHelp";
            this.MenuDisplaysHelp.Size = new System.Drawing.Size(178, 22);
            this.MenuDisplaysHelp.Text = "Displays";
            this.MenuDisplaysHelp.Click += new System.EventHandler(this.MenuDisplaysHelp_Click);
            // 
            // MenuProgramHelp
            // 
            this.MenuProgramHelp.Name = "MenuProgramHelp";
            this.MenuProgramHelp.Size = new System.Drawing.Size(178, 22);
            this.MenuProgramHelp.Text = "About this program";
            this.MenuProgramHelp.Click += new System.EventHandler(this.MenuProgramHelp_Click);
            // 
            // StartStopBttn
            // 
            this.StartStopBttn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartStopBttn.Location = new System.Drawing.Point(21, 355);
            this.StartStopBttn.Name = "StartStopBttn";
            this.StartStopBttn.Size = new System.Drawing.Size(79, 55);
            this.StartStopBttn.TabIndex = 6;
            this.StartStopBttn.Text = "Turn Control \r\nOn";
            this.StartStopBttn.UseVisualStyleBackColor = false;
            this.StartStopBttn.Click += new System.EventHandler(this.StartStopBttn_Click);
            // 
            // VisualControlStatus
            // 
            this.VisualControlStatus.BackColor = System.Drawing.Color.Red;
            this.VisualControlStatus.Location = new System.Drawing.Point(21, 288);
            this.VisualControlStatus.Name = "VisualControlStatus";
            this.VisualControlStatus.Size = new System.Drawing.Size(79, 50);
            this.VisualControlStatus.TabIndex = 7;
            this.VisualControlStatus.TabStop = false;
            // 
            // VisualControlStatusLbl
            // 
            this.VisualControlStatusLbl.AutoSize = true;
            this.VisualControlStatusLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.VisualControlStatusLbl.Location = new System.Drawing.Point(49, 306);
            this.VisualControlStatusLbl.Name = "VisualControlStatusLbl";
            this.VisualControlStatusLbl.Size = new System.Drawing.Size(21, 13);
            this.VisualControlStatusLbl.TabIndex = 8;
            this.VisualControlStatusLbl.Text = "Off";
            // 
            // TempPlotExpanded
            // 
            chartArea2.Name = "ChartArea1";
            this.TempPlotExpanded.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.TempPlotExpanded.Legends.Add(legend2);
            this.TempPlotExpanded.Location = new System.Drawing.Point(353, 248);
            this.TempPlotExpanded.Name = "TempPlotExpanded";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.TempPlotExpanded.Series.Add(series2);
            this.TempPlotExpanded.Size = new System.Drawing.Size(457, 215);
            this.TempPlotExpanded.TabIndex = 9;
            this.TempPlotExpanded.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TimeStepsLbl);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.TimeToEqLbl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.DerivativeContributionLbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.IntegralContributionLbl);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ProportionalContributionLbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(125, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 215);
            this.panel1.TabIndex = 10;
            // 
            // TimeStepsLbl
            // 
            this.TimeStepsLbl.AutoSize = true;
            this.TimeStepsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeStepsLbl.Location = new System.Drawing.Point(91, 153);
            this.TimeStepsLbl.Name = "TimeStepsLbl";
            this.TimeStepsLbl.Size = new System.Drawing.Size(43, 15);
            this.TimeStepsLbl.TabIndex = 23;
            this.TimeStepsLbl.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "# of time steps:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "time(s):";
            // 
            // TimeToEqLbl
            // 
            this.TimeToEqLbl.AutoSize = true;
            this.TimeToEqLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeToEqLbl.Location = new System.Drawing.Point(91, 135);
            this.TimeToEqLbl.Name = "TimeToEqLbl";
            this.TimeToEqLbl.Size = new System.Drawing.Size(43, 15);
            this.TimeToEqLbl.TabIndex = 20;
            this.TimeToEqLbl.Text = "label14";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Time To Equilibrium:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "C:";
            // 
            // DerivativeContributionLbl
            // 
            this.DerivativeContributionLbl.AutoSize = true;
            this.DerivativeContributionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DerivativeContributionLbl.Location = new System.Drawing.Point(91, 88);
            this.DerivativeContributionLbl.Name = "DerivativeContributionLbl";
            this.DerivativeContributionLbl.Size = new System.Drawing.Size(37, 15);
            this.DerivativeContributionLbl.TabIndex = 17;
            this.DerivativeContributionLbl.Text = "label9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "B:";
            // 
            // IntegralContributionLbl
            // 
            this.IntegralContributionLbl.AutoSize = true;
            this.IntegralContributionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntegralContributionLbl.Location = new System.Drawing.Point(91, 71);
            this.IntegralContributionLbl.Name = "IntegralContributionLbl";
            this.IntegralContributionLbl.Size = new System.Drawing.Size(37, 15);
            this.IntegralContributionLbl.TabIndex = 15;
            this.IntegralContributionLbl.Text = "label9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Parameter Contributions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "A:";
            // 
            // ProportionalContributionLbl
            // 
            this.ProportionalContributionLbl.AutoSize = true;
            this.ProportionalContributionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProportionalContributionLbl.Location = new System.Drawing.Point(91, 54);
            this.ProportionalContributionLbl.Name = "ProportionalContributionLbl";
            this.ProportionalContributionLbl.Size = new System.Drawing.Size(37, 15);
            this.ProportionalContributionLbl.TabIndex = 12;
            this.ProportionalContributionLbl.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(44, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "PID Status Information";
            // 
            // DeviceBx
            // 
            this.DeviceBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceBx.FormattingEnabled = true;
            this.DeviceBx.Location = new System.Drawing.Point(21, 57);
            this.DeviceBx.Name = "DeviceBx";
            this.DeviceBx.Size = new System.Drawing.Size(79, 21);
            this.DeviceBx.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Device";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(22, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Temp Channel";
            // 
            // TempChnnlBx
            // 
            this.TempChnnlBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TempChnnlBx.FormattingEnabled = true;
            this.TempChnnlBx.Location = new System.Drawing.Point(21, 114);
            this.TempChnnlBx.Name = "TempChnnlBx";
            this.TempChnnlBx.Size = new System.Drawing.Size(79, 21);
            this.TempChnnlBx.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(17, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "Voltage Channel";
            // 
            // VoltChnnlBx
            // 
            this.VoltChnnlBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoltChnnlBx.FormattingEnabled = true;
            this.VoltChnnlBx.Location = new System.Drawing.Point(21, 170);
            this.VoltChnnlBx.Name = "VoltChnnlBx";
            this.VoltChnnlBx.Size = new System.Drawing.Size(79, 21);
            this.VoltChnnlBx.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(8, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "Temp Measure Type";
            // 
            // MeasureTypeBx
            // 
            this.MeasureTypeBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeasureTypeBx.FormattingEnabled = true;
            this.MeasureTypeBx.Location = new System.Drawing.Point(22, 221);
            this.MeasureTypeBx.Name = "MeasureTypeBx";
            this.MeasureTypeBx.Size = new System.Drawing.Size(79, 21);
            this.MeasureTypeBx.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(820, 476);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.MeasureTypeBx);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.VoltChnnlBx);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TempChnnlBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceBx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TempPlotExpanded);
            this.Controls.Add(this.VisualControlStatusLbl);
            this.Controls.Add(this.VisualControlStatus);
            this.Controls.Add(this.StartStopBttn);
            this.Controls.Add(this.ControlPnl);
            this.Controls.Add(this.TempPlot);
            this.Controls.Add(this.MenuStrip);
            this.Name = "MainForm";
            this.Text = "PID Control Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TempPlot)).EndInit();
            this.ControlPnl.ResumeLayout(false);
            this.ControlPnl.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisualControlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPlotExpanded)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TempPlot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TempLbl;
        private System.Windows.Forms.Panel ControlPnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DerivativeBx;
        private System.Windows.Forms.TextBox IntegralBx;
        private System.Windows.Forms.TextBox ProportionalBx;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuList;
        private System.Windows.Forms.ToolStripMenuItem MenuSelectUnitDisplay;
        private System.Windows.Forms.ToolStripMenuItem MenuConstantLocks;
        private System.Windows.Forms.ToolStripMenuItem MenuLockAParameter;
        private System.Windows.Forms.ToolStripMenuItem MenuLockBParameter;
        private System.Windows.Forms.ToolStripMenuItem MenuLockCParameter;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuQuit;
        private System.Windows.Forms.ToolStripMenuItem MenuDisplaysHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuProgramHelp;
        private System.Windows.Forms.Button StartStopBttn;
        private System.Windows.Forms.PictureBox VisualControlStatus;
        private System.Windows.Forms.Label VisualControlStatusLbl;
        private System.Windows.Forms.Label TempUnitLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempPlotExpanded;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TimeStepsLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label TimeToEqLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label DerivativeContributionLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IntegralContributionLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ProportionalContributionLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TimeStepBx;
        private System.Windows.Forms.Label TsetLbl;
        private System.Windows.Forms.TextBox TempSetBx;
        private System.Windows.Forms.ToolStripMenuItem MenuLockTimeStepSize;
        private System.Windows.Forms.ComboBox DeviceBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox TempChnnlBx;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox VoltChnnlBx;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox MeasureTypeBx;
        private System.Windows.Forms.ToolStripMenuItem MenuDeviceRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuUnitCelsius;
        private System.Windows.Forms.ToolStripMenuItem MenuUnitFarenheit;

    }
}

