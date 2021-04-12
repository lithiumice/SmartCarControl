
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_openSerialPort = new System.Windows.Forms.Button();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receive_text = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_reboot = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button18 = new System.Windows.Forms.Button();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.speed_value = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button17 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.speed_max = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.speed_min = new System.Windows.Forms.NumericUpDown();
            this.param1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.param4 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.param2 = new System.Windows.Forms.NumericUpDown();
            this.param3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kp_max = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.kp_j = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.basic_kp = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.servo_kd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.servo_ki = new System.Windows.Forms.NumericUpDown();
            this.servo_debug = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.diff_p = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.motor_ki = new System.Windows.Forms.NumericUpDown();
            this.motor_kd = new System.Windows.Forms.NumericUpDown();
            this.motor_kp = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.motor_debug = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SrcPicture = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pic_type = new System.Windows.Forms.ComboBox();
            this.button13 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kp_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kp_j)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_kp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_kd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_ki)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diff_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_ki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_kd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_kp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("宋体", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1292, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 16);
            this.toolStripStatusLabel1.Text = "tips";
            // 
            // button_openSerialPort
            // 
            this.button_openSerialPort.Location = new System.Drawing.Point(303, 18);
            this.button_openSerialPort.Name = "button_openSerialPort";
            this.button_openSerialPort.Size = new System.Drawing.Size(87, 23);
            this.button_openSerialPort.TabIndex = 0;
            this.button_openSerialPort.Text = "open";
            this.button_openSerialPort.UseVisualStyleBackColor = true;
            this.button_openSerialPort.Click += new System.EventHandler(this.button_openSerialPort_Click);
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(83, 18);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 23);
            this.comboBox_PortName.TabIndex = 2;
            this.comboBox_PortName.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PortNmae";
            // 
            // receive_text
            // 
            this.receive_text.Location = new System.Drawing.Point(12, 96);
            this.receive_text.Multiline = true;
            this.receive_text.Name = "receive_text";
            this.receive_text.ReadOnly = true;
            this.receive_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receive_text.Size = new System.Drawing.Size(396, 470);
            this.receive_text.TabIndex = 5;
            this.receive_text.WordWrap = false;
            this.receive_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.receive_text_KeyPress);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(210, 18);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(88, 23);
            this.button_refresh.TabIndex = 8;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(302, 46);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 24);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_openSerialPort);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button_refresh);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.comboBox_PortName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_reboot);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "serial";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(210, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 23);
            this.button9.TabIndex = 38;
            this.button9.Text = "ps";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(111, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "help";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_reboot
            // 
            this.btn_reboot.Location = new System.Drawing.Point(18, 47);
            this.btn_reboot.Name = "btn_reboot";
            this.btn_reboot.Size = new System.Drawing.Size(87, 23);
            this.btn_reboot.TabIndex = 36;
            this.btn_reboot.Text = "reboot";
            this.btn_reboot.UseVisualStyleBackColor = true;
            this.btn_reboot.Click += new System.EventHandler(this.btn_reboot_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.zedGraphControl2);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SERVO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(642, 80);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 4;
            this.button18.Text = "clear";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(46, 109);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(671, 337);
            this.zedGraphControl2.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(15, 10);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Navy;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(732, 93);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PARAMS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.speed_value);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.trackBar1);
            this.groupBox6.Controls.Add(this.button17);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(415, 270);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(298, 213);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SPEED";
            // 
            // speed_value
            // 
            this.speed_value.AutoSize = true;
            this.speed_value.Location = new System.Drawing.Point(133, 27);
            this.speed_value.Name = "speed_value";
            this.speed_value.Size = new System.Drawing.Size(15, 15);
            this.speed_value.TabIndex = 50;
            this.speed_value.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(227, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 15);
            this.label20.TabIndex = 49;
            this.label20.Text = "3.0m/s";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 15);
            this.label19.TabIndex = 48;
            this.label19.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(27, 45);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(255, 56);
            this.trackBar1.TabIndex = 47;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(190, 112);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 27);
            this.button17.TabIndex = 37;
            this.button17.Text = "stop";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "speed\r\n(m/s)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.speed_max);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.speed_min);
            this.groupBox5.Controls.Add(this.param1);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.param4);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.param2);
            this.groupBox5.Controls.Add(this.param3);
            this.groupBox5.Location = new System.Drawing.Point(60, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 213);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DYM SPEED";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 15);
            this.label18.TabIndex = 49;
            this.label18.Text = "speed_max";
            // 
            // speed_max
            // 
            this.speed_max.DecimalPlaces = 3;
            this.speed_max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speed_max.Location = new System.Drawing.Point(210, 103);
            this.speed_max.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.speed_max.Name = "speed_max";
            this.speed_max.Size = new System.Drawing.Size(120, 25);
            this.speed_max.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(207, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "speed_min";
            // 
            // speed_min
            // 
            this.speed_min.DecimalPlaces = 3;
            this.speed_min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speed_min.Location = new System.Drawing.Point(210, 35);
            this.speed_min.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.speed_min.Name = "speed_min";
            this.speed_min.Size = new System.Drawing.Size(120, 25);
            this.speed_min.TabIndex = 46;
            // 
            // param1
            // 
            this.param1.DecimalPlaces = 3;
            this.param1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.param1.Location = new System.Drawing.Point(71, 25);
            this.param1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.param1.Name = "param1";
            this.param1.Size = new System.Drawing.Size(120, 25);
            this.param1.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "param1";
            // 
            // param4
            // 
            this.param4.DecimalPlaces = 3;
            this.param4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.param4.Location = new System.Drawing.Point(71, 134);
            this.param4.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.param4.Name = "param4";
            this.param4.Size = new System.Drawing.Size(120, 25);
            this.param4.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "param2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "param4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 40;
            this.label13.Text = "param3";
            // 
            // param2
            // 
            this.param2.DecimalPlaces = 3;
            this.param2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.param2.Location = new System.Drawing.Point(71, 64);
            this.param2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.param2.Name = "param2";
            this.param2.Size = new System.Drawing.Size(120, 25);
            this.param2.TabIndex = 42;
            // 
            // param3
            // 
            this.param3.DecimalPlaces = 3;
            this.param3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.param3.Location = new System.Drawing.Point(71, 103);
            this.param3.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.param3.Name = "param3";
            this.param3.Size = new System.Drawing.Size(120, 25);
            this.param3.TabIndex = 43;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kp_max);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.kp_j);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.basic_kp);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.servo_kd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.servo_ki);
            this.groupBox3.Controls.Add(this.servo_debug);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(60, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 239);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SERVO PARAMS";
            // 
            // kp_max
            // 
            this.kp_max.DecimalPlaces = 2;
            this.kp_max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kp_max.Location = new System.Drawing.Point(301, 57);
            this.kp_max.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.kp_max.Name = "kp_max";
            this.kp_max.Size = new System.Drawing.Size(120, 25);
            this.kp_max.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "KpMax";
            // 
            // kp_j
            // 
            this.kp_j.DecimalPlaces = 3;
            this.kp_j.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.kp_j.Location = new System.Drawing.Point(86, 92);
            this.kp_j.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.kp_j.Name = "kp_j";
            this.kp_j.Size = new System.Drawing.Size(120, 25);
            this.kp_j.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "KpJ";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(145, 173);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 34;
            this.button14.Text = "start";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // basic_kp
            // 
            this.basic_kp.DecimalPlaces = 2;
            this.basic_kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.basic_kp.Location = new System.Drawing.Point(86, 55);
            this.basic_kp.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.basic_kp.Name = "basic_kp";
            this.basic_kp.Size = new System.Drawing.Size(120, 25);
            this.basic_kp.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "BasicKp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ki";
            // 
            // servo_kd
            // 
            this.servo_kd.DecimalPlaces = 2;
            this.servo_kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.servo_kd.Location = new System.Drawing.Point(46, 133);
            this.servo_kd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.servo_kd.Name = "servo_kd";
            this.servo_kd.Size = new System.Drawing.Size(120, 25);
            this.servo_kd.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kd";
            // 
            // servo_ki
            // 
            this.servo_ki.DecimalPlaces = 2;
            this.servo_ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.servo_ki.Location = new System.Drawing.Point(204, 135);
            this.servo_ki.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.servo_ki.Name = "servo_ki";
            this.servo_ki.Size = new System.Drawing.Size(120, 25);
            this.servo_ki.TabIndex = 32;
            // 
            // servo_debug
            // 
            this.servo_debug.AutoSize = true;
            this.servo_debug.Location = new System.Drawing.Point(46, 173);
            this.servo_debug.Name = "servo_debug";
            this.servo_debug.Size = new System.Drawing.Size(69, 19);
            this.servo_debug.TabIndex = 19;
            this.servo_debug.Text = "debug";
            this.servo_debug.UseVisualStyleBackColor = true;
            this.servo_debug.CheckedChanged += new System.EventHandler(this.servo_debug_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diff_p);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.motor_ki);
            this.groupBox2.Controls.Add(this.motor_kd);
            this.groupBox2.Controls.Add(this.motor_kp);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.motor_debug);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(504, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 239);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MOTOR PARAMS";
            // 
            // diff_p
            // 
            this.diff_p.DecimalPlaces = 2;
            this.diff_p.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.diff_p.Location = new System.Drawing.Point(65, 162);
            this.diff_p.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.diff_p.Name = "diff_p";
            this.diff_p.Size = new System.Drawing.Size(120, 25);
            this.diff_p.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 164);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 15);
            this.label21.TabIndex = 36;
            this.label21.Text = "DiffP";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(65, 24);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 35;
            this.button15.Text = "start";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // motor_ki
            // 
            this.motor_ki.DecimalPlaces = 2;
            this.motor_ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.motor_ki.Location = new System.Drawing.Point(65, 92);
            this.motor_ki.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.motor_ki.Name = "motor_ki";
            this.motor_ki.Size = new System.Drawing.Size(120, 25);
            this.motor_ki.TabIndex = 21;
            // 
            // motor_kd
            // 
            this.motor_kd.DecimalPlaces = 2;
            this.motor_kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.motor_kd.Location = new System.Drawing.Point(65, 131);
            this.motor_kd.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.motor_kd.Name = "motor_kd";
            this.motor_kd.Size = new System.Drawing.Size(120, 25);
            this.motor_kd.TabIndex = 22;
            // 
            // motor_kp
            // 
            this.motor_kp.DecimalPlaces = 2;
            this.motor_kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.motor_kp.Location = new System.Drawing.Point(65, 53);
            this.motor_kp.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.motor_kp.Name = "motor_kp";
            this.motor_kp.Size = new System.Drawing.Size(120, 25);
            this.motor_kp.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ki";
            // 
            // motor_debug
            // 
            this.motor_debug.AutoSize = true;
            this.motor_debug.Location = new System.Drawing.Point(36, 202);
            this.motor_debug.Name = "motor_debug";
            this.motor_debug.Size = new System.Drawing.Size(69, 19);
            this.motor_debug.TabIndex = 11;
            this.motor_debug.Text = "debug";
            this.motor_debug.UseVisualStyleBackColor = true;
            this.motor_debug.CheckedChanged += new System.EventHandler(this.motor_debug_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(414, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 554);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button12);
            this.tabPage6.Controls.Add(this.zedGraphControl1);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(858, 525);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "MOTOR";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(659, 16);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "clear";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(16, 52);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(730, 431);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.SrcPicture);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.pic_type);
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(858, 525);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "IMAGE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SrcPicture
            // 
            this.SrcPicture.Location = new System.Drawing.Point(82, 70);
            this.SrcPicture.Name = "SrcPicture";
            this.SrcPicture.Size = new System.Drawing.Size(725, 393);
            this.SrcPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SrcPicture.TabIndex = 57;
            this.SrcPicture.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 56;
            this.button4.Text = "uncompressed";
            this.button4.Click += new System.EventHandler(this.up_uncomp_Click);
            // 
            // pic_type
            // 
            this.pic_type.FormattingEnabled = true;
            this.pic_type.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.pic_type.Location = new System.Drawing.Point(613, 7);
            this.pic_type.Name = "pic_type";
            this.pic_type.Size = new System.Drawing.Size(121, 23);
            this.pic_type.TabIndex = 54;
            this.pic_type.Text = "pic_type";
            this.pic_type.SelectedIndexChanged += new System.EventHandler(this.pic_type_SelectedIndexChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(382, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 55;
            this.button13.Text = "binimage";
            this.button13.Click += new System.EventHandler(this.up_comp_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(284, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 58;
            this.button5.Text = "grayimage";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(284, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 59;
            this.button6.Text = "save";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.receive_text);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLHS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kp_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kp_j)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_kp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_kd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_ki)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diff_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_ki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_kd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_kp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button_openSerialPort;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receive_text;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reboot;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown basic_kp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown servo_kd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown servo_ki;
        private System.Windows.Forms.CheckBox servo_debug;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown motor_ki;
        private System.Windows.Forms.NumericUpDown motor_kd;
        private System.Windows.Forms.NumericUpDown motor_kp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox motor_debug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.NumericUpDown kp_j;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown kp_max;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown param4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown param2;
        private System.Windows.Forms.NumericUpDown param3;
        private System.Windows.Forms.NumericUpDown param1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown speed_min;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown speed_max;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown diff_p;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label speed_value;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox SrcPicture;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox pic_type;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

