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

        int x_pos = 0, x_pos2 = 0;
        string pattern = @"\bwheel:(?<lrpm>\d+),(?<lout>\d+),(?<rrpm>\d+),(?<rout>\d+)\b";
        string pattern2 = @"\bsteer:(?<theta>\d+),(?<rho>\d+),(?<fps>\d+),(?<out>\d+)\b";
        string serial_string_endEnter;
        private Bitmap SrcBmp;
        int ImageHeight = 120, ImageWidth = 160;

        PointPairList list_lrpm = new PointPairList();
        PointPairList list_lout = new PointPairList();
        PointPairList list_rrpm = new PointPairList();
        PointPairList list_rout = new PointPairList();
        PointPairList list_theta = new PointPairList();
        PointPairList list_rho = new PointPairList();
        PointPairList list_fps = new PointPairList();
        PointPairList list_out = new PointPairList();

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

            CreateGraph(zedGraphControl1);
            CreateGraph2(zedGraphControl2);

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

        private Bitmap CreateGrayBitmap(int Width, int Height)
        {
            //创建8位深度的灰度图像
            Bitmap Bmp = new Bitmap(Width, Height, PixelFormat.Format8bppIndexed);
            ColorPalette Pal = Bmp.Palette;
            for (int Y = 0; Y < Pal.Entries.Length; Y++)
            {
                Pal.Entries[Y] = Color.FromArgb(255, Y, Y, Y);//将RGB转化为灰度调色板
            }
            Bmp.Palette = Pal;
            return Bmp;
        }

        public void SaveImage(string name)
        {
            string Path;
            Path = System.IO.Directory.GetCurrentDirectory();

            SrcPicture.Image.Save(Path+ name + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);//指定图片格式   
        }
        void SaveImage(Image Src, string name)
        {
            string Path;
            Path = System.IO.Directory.GetCurrentDirectory();

            Src.Save(Path  + name + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);//指定图片格式   
        }
        public void SaveImage(string name, string SavePath)
        {
            string Path;
            Path = System.IO.Directory.GetCurrentDirectory();
            SrcPicture.Image.Save(Path + "\\" + SavePath + "\\" + name + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);//指定图片格式   
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

                foreach (char c in txt)
                {
                    serial_string_endEnter += c;
                    if (c == '\n')
                    {
                        if (serial_string_endEnter.StartsWith("START")
                            && serial_string_endEnter.EndsWith("END\r\n")
                            )
                        {
                            int i = 0;
                            //serial_string_endEnter.TrimStart("START".ToCharArray());
                            //serial_string_endEnter.TrimEnd("END\r\n".ToCharArray());
                            serial_string_endEnter = serial_string_endEnter.Replace("START", "");
                            serial_string_endEnter = serial_string_endEnter.Replace("END\r\n", "");

                            Console.WriteLine(serial_string_endEnter);

                            if (SrcBmp != null)
                            {
                                SrcBmp.Dispose();

                            }
                            //SrcBmp.Dispose();
                            SrcBmp = CreateGrayBitmap(ImageWidth, ImageHeight);
                            BitmapData SrcData = SrcBmp.LockBits(new Rectangle(0, 0, ImageWidth, ImageHeight),
                            ImageLockMode.ReadWrite, SrcBmp.PixelFormat);
                            int SrcStride = SrcData.Stride;
                            unsafe
                            {
                                byte* SrcP;
                                for (int Y = 0; Y < ImageHeight; Y++)
                                {
                                    SrcP = (byte*)SrcData.Scan0 + Y * SrcStride;
                                    for (int X = 0; X < ImageWidth; SrcP++, X++)
                                    {
                                        *SrcP = (byte)serial_string_endEnter[i];
                                        i++;
                                    }
                                }
                            }
                            SrcBmp.UnlockBits(SrcData);
                            SrcPicture.Image = SrcBmp;
                            //SaveImage("autosave");
                        }

                        MatchCollection matchs = Regex.Matches(serial_string_endEnter, pattern);
                        if (matchs.Count > 0)
                        {
                            Match match = matchs[0];
                            int lrpm = Convert.ToInt32(match.Groups["lrpm"].Value);
                            int lout = Convert.ToInt32(match.Groups["lout"].Value);
                            int rrpm = Convert.ToInt32(match.Groups["rrpm"].Value);
                            int rout = Convert.ToInt32(match.Groups["rout"].Value);

                            //list_lrpm.Append()
                            list_lrpm.Add(x_pos, lrpm);
                            list_lout.Add(x_pos, lout);
                            list_rrpm.Add(x_pos, rrpm);
                            list_rout.Add(x_pos, rout);
                            x_pos++;
                        }

                        MatchCollection matchs2 = Regex.Matches(serial_string_endEnter, pattern2);
                        if (matchs2.Count > 0)
                        {
                            Match match = matchs2[0];

                            int theta = Convert.ToInt32(match.Groups["theta"].Value);
                            int rho = Convert.ToInt32(match.Groups["rho"].Value);
                            int fps = Convert.ToInt32(match.Groups["fps"].Value);
                            int servo_out = Convert.ToInt32(match.Groups["out"].Value);

                            list_lrpm.Add(x_pos2, theta);
                            list_rho.Add(x_pos2, rho);
                            list_fps.Add(x_pos2, fps);
                            list_out.Add(x_pos2, servo_out);
                            x_pos2++;

                        }
                        serial_string_endEnter = "";
                    }
                }
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

        private void CreateGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "PID OUT PLOT";
            myPane.XAxis.Title.Text = "time";
            myPane.YAxis.Title.Text = "pid info";

            //SymbolType.Circle 
            //SymbolType.Diamond
            LineItem myCurve = myPane.AddCurve("lrpm",
                 list_lrpm, Color.Red, SymbolType.None);

            LineItem myCurve2 = myPane.AddCurve("lout",
                 list_lout, Color.Blue, SymbolType.None);

            LineItem myCurve3 = myPane.AddCurve("rrpm",
                 list_rrpm, Color.Purple, SymbolType.None);

            LineItem myCurve4 = myPane.AddCurve("rout",
                 list_rout, Color.Yellow, SymbolType.None);

            //zgc.AxisChange();


        }
        
        private void CreateGraph2(ZedGraphControl zgc)

        {
            GraphPane myPane = zgc.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "PID OUT PLOT";
            myPane.XAxis.Title.Text = "time";
            myPane.YAxis.Title.Text = "pid info";

            //SymbolType.Circle 
            //SymbolType.Diamond
            LineItem myCurve = myPane.AddCurve("theta",
                 list_theta, Color.Red, SymbolType.None);

            LineItem myCurve2 = myPane.AddCurve("rho",
                 list_rho, Color.Blue, SymbolType.None);

            LineItem myCurve3 = myPane.AddCurve("fps",
                 list_fps, Color.Purple, SymbolType.None);

            LineItem myCurve4 = myPane.AddCurve("out",
                 list_out, Color.Yellow, SymbolType.None);

            //zgc.AxisChange();


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            zedGraphControl1.Refresh();
            zedGraphControl1.AxisChange();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            send_text("help");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            send_text("ps");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            list_lrpm.Clear();
            list_lout.Clear();
            list_rrpm.Clear();
            list_rout.Clear();
            x_pos = 0;
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

        private void button18_Click(object sender, EventArgs e)
        {
            list_theta.Clear();
            list_rho .Clear();
            list_fps .Clear();
            list_out .Clear();
            x_pos2 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            send_cmd("set_dym_speed_param_cmd",
                param1.Value,
                param2.Value,
                param3.Value,
                param4.Value,
                speed_min.Value,
                speed_max.Value
                );
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            send_cmd("set_velocity_cmd", trackBar1.Value/100);
        }

        private void pic_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            send_cmd("set_disp_pic_type_cmd", pic_type.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            send_cmd("upload_my_gray");

        }

        private void button6_Click(object sender, EventArgs e)
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
