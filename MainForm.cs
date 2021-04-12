using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        void refreshSerialPort()
        {
            RegistryKey tempRegist = Registry.LocalMachine.OpenSubKey("HARDWARE").OpenSubKey("DEVICEMAP").OpenSubKey("SERIALCOMM");
            if (tempRegist != null && tempRegist.ValueCount > 0)
            {
                string[] tempRegistComs = tempRegist.GetValueNames();
                comboBox_PortName.Items.Clear(); //清除Combox中的项
                foreach (string tempStrName in tempRegistComs)
                {
                    string tempCom = Convert.ToString(tempRegist.GetValue(tempStrName));
                    comboBox_PortName.Items.Add(tempCom); //添加Com名称
                }
                if (comboBox_PortName.Items.Count > 0)
                {
                    comboBox_PortName.SelectedIndex = 0; //默认的索引
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "ready";
            refreshSerialPort();


            timer1.Enabled = true;
            timer1.Interval = 100;//ms

            InitParameter();

        }
        
        private void InitParameter()
        {
            //bool isFirstRun = bool.Parse(ConfigurationManager.AppSettings["first_run"]);
            motor_kp.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["motor_kp"]);
            motor_ki.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["motor_ki"]);
            motor_kd.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["motor_kd"]);

            basic_kp.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["servo_kp"]);
            servo_ki.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["servo_ki"]);
            servo_kd.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["servo_kd"]);
        }
        
        private void button_openSerialPort_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = comboBox_PortName.Text;
                try
                {
                    serialPort.Open();    
                    button_openSerialPort.Text = "close";
                    comboBox_PortName.Enabled = false;
                    button_refresh.Enabled = false;

                    //isOpened = true;
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(post_DataReceived);
                }
                catch
                {
                    toolStripStatusLabel1.Text="failed to open serial port";
                }
            }
            else
            {
                try
                {
                    serialPort.Close();   
                    button_openSerialPort.Text = "open";
                    comboBox_PortName.Enabled = true;
                    button_refresh.Enabled = true;
                    //isOpened = false;
                }
                catch
                {
                    toolStripStatusLabel1.Text = "failed to close serial port";
                }
            }
        }

        private void post_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string txt = serialPort.ReadExisting();
                if (txt.IndexOf("\r\n") == -1)
                {
                    if (txt.IndexOf("\n") != -1)
                    {
                        txt = txt.Replace("\n", "\r\n");

                    }
                }
                receive_text.AppendText(txt);

               
            }
            catch (Exception)
            {

            }
            
        }
        
        private void send_text(string txt)
        {
            if (serialPort.IsOpen)
            {
                if ( txt!= "")
                {
                    serialPort.Write(txt+"\n");
                    Console.WriteLine("send_txt: " + txt);
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "open serial port first";
            }
        }
       
        private void button_refresh_Click(object sender, EventArgs e)
        {
            refreshSerialPort();
        }
        
        private void button_clear_Click(object sender, EventArgs e)
        {
            receive_text.Text = "";
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            send_cmd("set_chassis_pid_param_cmd", motor_kp.Value, motor_ki.Value, motor_kd.Value,diff_p.Value);

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["motor_kp"].Value = motor_kp.Value.ToString();
            cfa.AppSettings.Settings["motor_ki"].Value = motor_ki.Value.ToString(); 
            cfa.AppSettings.Settings["motor_kd"].Value = motor_kd.Value.ToString(); 
            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            send_cmd("set_steer_pid_param_cmd", basic_kp.Value,kp_j.Value,kp_max.Value, servo_ki.Value, servo_kd.Value);

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["servo_kp"].Value = basic_kp.Value.ToString();
            cfa.AppSettings.Settings["servo_ki"].Value = servo_ki.Value.ToString();
            cfa.AppSettings.Settings["servo_kd"].Value = servo_kd.Value.ToString();
            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btn_reboot_Click(object sender, EventArgs e)
        {
            send_text("reboot");
        }
        
        private void receive_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (serialPort.IsOpen) { 
                serialPort.Write(e.KeyChar.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            send_text("help");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            send_text("ps");
        }

        private void motor_debug_CheckedChanged(object sender, EventArgs e)
        {
            send_cmd("set_chassis_debug_cmd", motor_debug.Checked);
        }
        
        public void send_cmd(params object[] list)
        {

            List<string> cmd = new List<string>();
            foreach (object o in list)
            {
                if (o.GetType() == typeof(bool))
                {
                    cmd.Add(((bool)o ? "1" : "0"));
                }
                else
                {
                    cmd.Add(o.ToString());

                }
            }
            string tmp= string.Join(" ", cmd.ToArray());
            send_text(tmp);
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            send_cmd("chassis_thread_init_cmd");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            send_cmd("set_velocity_cmd", 0);
        }

        private void servo_debug_CheckedChanged(object sender, EventArgs e)
        {
            send_cmd("set_steer_debug_cmd", servo_debug.Checked);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            send_cmd("dym_param_set_cmd",
                s_zhi.Value,
                s_max.Value,
                s_wan1.Value,
                s_wan2.Value,
                s_cross.Value,
                s_huan.Value,

                fore_min.Value,
                fore_max.Value
                );
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            send_cmd("set_velocity_cmd", trackBar1.Value);
        }

        //private void pic_type_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    send_cmd("set_disp_pic_type_cmd", pic_type.SelectedItem);
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            send_cmd("upload_my_gray");

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void up_comp_Click(object sender, EventArgs e)
        {
            send_cmd("upload_my_bin");
        }

        private void up_uncomp_Click(object sender, EventArgs e)
        {
            send_cmd("upload_uncompbinimage");

        }
    }
}
