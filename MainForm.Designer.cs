
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
            this.speed_value = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.fore_max = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fore_min = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.s_huan = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.s_cross = new System.Windows.Forms.NumericUpDown();
            this.s_zhi = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.s_wan2 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.s_max = new System.Windows.Forms.NumericUpDown();
            this.s_wan1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kp_max = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.kp_j = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
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
            this.motor_ki = new System.Windows.Forms.NumericUpDown();
            this.motor_kd = new System.Windows.Forms.NumericUpDown();
            this.motor_kp = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.motor_debug = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fore_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fore_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_huan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_zhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_wan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_wan1)).BeginInit();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(963, 22);
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
            this.button_openSerialPort.Text = "打开";
            this.button_openSerialPort.UseVisualStyleBackColor = true;
            this.button_openSerialPort.Click += new System.EventHandler(this.button_openSerialPort_Click);
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(58, 18);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 23);
            this.comboBox_PortName.TabIndex = 2;
            this.comboBox_PortName.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "端口";
            // 
            // receive_text
            // 
            this.receive_text.Location = new System.Drawing.Point(12, 96);
            this.receive_text.Multiline = true;
            this.receive_text.Name = "receive_text";
            this.receive_text.ReadOnly = true;
            this.receive_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receive_text.Size = new System.Drawing.Size(396, 398);
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
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(302, 46);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 24);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "清空接收区";
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
            this.groupBox1.Text = "串口操作";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(210, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 23);
            this.button9.TabIndex = 38;
            this.button9.Text = "任务列表";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(111, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "命令列表";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_reboot
            // 
            this.btn_reboot.Location = new System.Drawing.Point(18, 47);
            this.btn_reboot.Name = "btn_reboot";
            this.btn_reboot.Size = new System.Drawing.Size(87, 23);
            this.btn_reboot.TabIndex = 36;
            this.btn_reboot.Text = "重启单片机";
            this.btn_reboot.UseVisualStyleBackColor = true;
            this.btn_reboot.Click += new System.EventHandler(this.btn_reboot_Click);
            // 
            // speed_value
            // 
            this.speed_value.AutoSize = true;
            this.speed_value.Location = new System.Drawing.Point(565, 410);
            this.speed_value.Name = "speed_value";
            this.speed_value.Size = new System.Drawing.Size(15, 15);
            this.speed_value.TabIndex = 50;
            this.speed_value.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(600, 410);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 15);
            this.label20.TabIndex = 49;
            this.label20.Text = "300cm/s";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(448, 428);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(229, 56);
            this.trackBar1.TabIndex = 47;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "恒速模式速度";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.fore_max);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.fore_min);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.s_huan);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.s_cross);
            this.groupBox5.Controls.Add(this.s_zhi);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.s_wan2);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.s_max);
            this.groupBox5.Controls.Add(this.s_wan1);
            this.groupBox5.Location = new System.Drawing.Point(440, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 384);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "动态速度(cm/s)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 53;
            this.label19.Text = "最大前瞻";
            // 
            // fore_max
            // 
            this.fore_max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fore_max.Location = new System.Drawing.Point(103, 302);
            this.fore_max.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.fore_max.Name = "fore_max";
            this.fore_max.Size = new System.Drawing.Size(120, 25);
            this.fore_max.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "最小前瞻";
            // 
            // fore_min
            // 
            this.fore_min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fore_min.Location = new System.Drawing.Point(103, 263);
            this.fore_min.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.fore_min.Name = "fore_min";
            this.fore_min.Size = new System.Drawing.Size(120, 25);
            this.fore_min.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 49;
            this.label18.Text = "环岛速度";
            // 
            // s_huan
            // 
            this.s_huan.DecimalPlaces = 2;
            this.s_huan.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.s_huan.Location = new System.Drawing.Point(103, 224);
            this.s_huan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s_huan.Name = "s_huan";
            this.s_huan.Size = new System.Drawing.Size(120, 25);
            this.s_huan.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "十字速度";
            // 
            // s_cross
            // 
            this.s_cross.DecimalPlaces = 2;
            this.s_cross.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.s_cross.Location = new System.Drawing.Point(103, 185);
            this.s_cross.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s_cross.Name = "s_cross";
            this.s_cross.Size = new System.Drawing.Size(120, 25);
            this.s_cross.TabIndex = 46;
            // 
            // s_zhi
            // 
            this.s_zhi.DecimalPlaces = 2;
            this.s_zhi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.s_zhi.Location = new System.Drawing.Point(103, 29);
            this.s_zhi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s_zhi.Name = "s_zhi";
            this.s_zhi.Size = new System.Drawing.Size(120, 25);
            this.s_zhi.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "上传";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "直道速度";
            // 
            // s_wan2
            // 
            this.s_wan2.DecimalPlaces = 2;
            this.s_wan2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.s_wan2.Location = new System.Drawing.Point(103, 146);
            this.s_wan2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s_wan2.Name = "s_wan2";
            this.s_wan2.Size = new System.Drawing.Size(120, 25);
            this.s_wan2.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "最大速度";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "弯道速度2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 40;
            this.label13.Text = "弯道速度";
            // 
            // s_max
            // 
            this.s_max.DecimalPlaces = 2;
            this.s_max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.s_max.Location = new System.Drawing.Point(103, 68);
            this.s_max.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s_max.Name = "s_max";
            this.s_max.Size = new System.Drawing.Size(120, 25);
            this.s_max.TabIndex = 42;
            // 
            // s_wan1
            // 
            this.s_wan1.DecimalPlaces = 2;
            this.s_wan1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.s_wan1.Location = new System.Drawing.Point(103, 107);
            this.s_wan1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.s_wan1.Name = "s_wan1";
            this.s_wan1.Size = new System.Drawing.Size(120, 25);
            this.s_wan1.TabIndex = 43;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kp_max);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.kp_j);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.basic_kp);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.servo_kd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.servo_ki);
            this.groupBox3.Controls.Add(this.servo_debug);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(699, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 253);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "舵机PID";
            // 
            // kp_max
            // 
            this.kp_max.DecimalPlaces = 2;
            this.kp_max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kp_max.Location = new System.Drawing.Point(86, 105);
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
            this.label12.Location = new System.Drawing.Point(33, 107);
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
            this.kp_j.Location = new System.Drawing.Point(86, 67);
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
            this.label11.Location = new System.Drawing.Point(49, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "KpJ";
            // 
            // basic_kp
            // 
            this.basic_kp.DecimalPlaces = 2;
            this.basic_kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.basic_kp.Location = new System.Drawing.Point(86, 29);
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
            this.label10.Location = new System.Drawing.Point(17, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "BasicKp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 183);
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
            this.servo_kd.Location = new System.Drawing.Point(86, 143);
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
            this.label8.Location = new System.Drawing.Point(57, 145);
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
            this.servo_ki.Location = new System.Drawing.Point(86, 181);
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
            this.servo_debug.Location = new System.Drawing.Point(56, 216);
            this.servo_debug.Name = "servo_debug";
            this.servo_debug.Size = new System.Drawing.Size(69, 19);
            this.servo_debug.TabIndex = 19;
            this.servo_debug.Text = "debug";
            this.servo_debug.UseVisualStyleBackColor = true;
            this.servo_debug.CheckedChanged += new System.EventHandler(this.servo_debug_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.diff_p);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.motor_ki);
            this.groupBox2.Controls.Add(this.motor_kd);
            this.groupBox2.Controls.Add(this.motor_kp);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.motor_debug);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(699, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 219);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "电机PID";
            // 
            // diff_p
            // 
            this.diff_p.DecimalPlaces = 2;
            this.diff_p.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.diff_p.Location = new System.Drawing.Point(86, 141);
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
            this.label21.Location = new System.Drawing.Point(33, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 15);
            this.label21.TabIndex = 36;
            this.label21.Text = "DiffP";
            // 
            // motor_ki
            // 
            this.motor_ki.DecimalPlaces = 2;
            this.motor_ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.motor_ki.Location = new System.Drawing.Point(86, 69);
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
            this.motor_kd.Location = new System.Drawing.Point(86, 105);
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
            this.motor_kp.Location = new System.Drawing.Point(86, 33);
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
            this.button1.Location = new System.Drawing.Point(131, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "上传";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ki";
            // 
            // motor_debug
            // 
            this.motor_debug.AutoSize = true;
            this.motor_debug.Location = new System.Drawing.Point(60, 182);
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
            this.label4.Location = new System.Drawing.Point(57, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 519);
            this.Controls.Add(this.speed_value);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fore_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fore_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_huan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_zhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_wan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_wan1)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown kp_j;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown kp_max;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown s_wan2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown s_max;
        private System.Windows.Forms.NumericUpDown s_wan1;
        private System.Windows.Forms.NumericUpDown s_zhi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown s_cross;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown s_huan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown diff_p;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label speed_value;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown fore_max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown fore_min;
    }
}

