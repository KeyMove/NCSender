using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCSend
{
    public partial class Form1 : Form
    {
        SerialPort COM=new SerialPort();
        List<string> NCCode = null;
        volatile string[] GCode;
        int writePos;
        public Form1()
        {
            InitializeComponent();
            COM.BaudRate = 115200;
            COM.DataBits = 8;
            COM.StopBits = StopBits.One;
            COM.Parity = Parity.None;
            COM.DataReceived += COM_DataReceived;
            INCValueBox.MouseWheel += (object s, MouseEventArgs e) => {
                try
                {
                    if (e.Delta > 0)
                        INCValueBox.Text =""+ double.Parse(INCValueBox.Text) * 10;
                    else
                        INCValueBox.Text = "" + double.Parse(INCValueBox.Text) / 10;
                }
                catch { }
                
            };
            XValueBox.MouseWheel += ValueBox_MouseWheel;
            YValueBox.MouseWheel += ValueBox_MouseWheel;
            ZValueBox.MouseWheel += ValueBox_MouseWheel;
            RValueBox.MouseWheel += RotValueBox_MouseWheel;
            foreach (string com in SerialPort.GetPortNames())
            {
                ComSelect.Items.Add(com);
            }
            if (ComSelect.Items.Count != 0)
            {
                ComSelect.SelectedIndex = 0;
            }
            try
            {
                double x = double.Parse(XValueBox.Text);
                double y = double.Parse(YValueBox.Text);
                double z = double.Parse(ZValueBox.Text);
                lastx = x;
                lasty = y;
                lastz = z;
            }
            catch { }
            for(int i = 1; i < 17; i++)
            {
                Button b = new Button();
                b.Size = new System.Drawing.Size(25, 21);
                b.Location = new System.Drawing.Point(322, 3 + i * 25); ;
                b.Text = "" + i;
                b.Click += B1_Click;
                TextBox t = new TextBox();
                t.Size = new System.Drawing.Size(313, 21);
                t.Location = new System.Drawing.Point(3, 3+i*25);
                b.Tag = t;
                SendPanle.Controls.Add(t);
                SendPanle.Controls.Add(b);
            }
            for (int i = 1; i < 8; i++)
            {
                Button b = new Button();
                b.Size = new System.Drawing.Size(PortC1.Width, PortC1.Height);
                b.Location = new System.Drawing.Point(PortC1.Location.X+i* (PortC1.Width+5), PortC1.Location.Y); ;
                b.Text = "关" + (i + 1);
                b.Click += PortClose;
                IOGroup.Controls.Add(b);
                b = new Button();
                b.Size = new System.Drawing.Size(PortO1.Width, PortO1.Height);
                b.Location = new System.Drawing.Point(PortO1.Location.X + i * (PortO1.Width + 5), PortO1.Location.Y); ;
                b.Text = "开" + (i+1);
                b.Click += PortOpen;
                IOGroup.Controls.Add(b);
            }
            Timer tx = new Timer();
            tx.Interval = 500;
            tx.Tick += (object s,EventArgs e) => {
                string[] coms = SerialPort.GetPortNames();
                if (coms.Length != ComSelect.Items.Count)
                {
                    ComSelect.Items.Clear();
                    foreach (string com in coms)
                    {
                        ComSelect.Items.Add(com);
                    }
                }
            };
            tx.Start();
            Timer loopsend = new Timer();
            loopsend.Interval = 300;
            loopsend.Tick += (object s, EventArgs e) =>
            {
                if (!isFull)
                    if (GCode != null)
                    {
                        if (GCode.Length <= writePos)
                        {
                            GCode = null;
                            return;
                        }
                        while (GCode[writePos].Length <= 1)
                        {
                            if (++writePos == GCode.Length)
                            {
                                GCode = null;
                                return;
                            }

                        }
                        if (!COM.IsOpen)
                        {
                            GCode = null;
                            return;
                        }
                        COM.Write(GCode[writePos++] + '\n');
                    }
            };
            loopsend.Start();
        }

        private void RotValueBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (COM.IsOpen)
            {
                double r = double.Parse(RValueBox.Text);
                r+=(e.Delta>0?1:-1);
                RValueBox.Text = r + "";
                if (absRChecked.Checked)
                {
                    double dir = Math.Acos(lastx / Math.Sqrt(lastx * lastx + lasty * lasty));
                    dir = (lasty < 0) ? -dir : dir;
                    r += (dir * 180 / Math.PI);
                }
                COM.Write("M104R" + r + "\r\n");
            }
        }

        private void ValueBox_MouseWheel(object sender, MouseEventArgs e)
        {
            string n = ((TextBox)sender).Name[0]+(e.Delta>0?"+":"-");
            double inc = 1;
            try
            {
                inc = double.Parse(INCValueBox.Text);
            }
            catch { }
            double x = 0, y = 0, z = 0;
            switch (n[0])
            {
                case 'X': if (n[1] == '+') x = inc; else x = -inc; break;
                case 'Y': if (n[1] == '+') y = inc; else y = -inc; break;
                case 'Z': if (n[1] == '+') z = inc; else z = -inc; break;
            }
            lastx += x;
            lasty += y;
            lastz += z;
            XValueBox.Text = lastx.ToString();
            YValueBox.Text = lasty.ToString();
            ZValueBox.Text = lastz.ToString();
            if (COM.IsOpen)
            {
                COM.Write("G" + ((FastMoveChecked.Checked) ? "0" : "1") + "X" + lastx.ToString("f2") + "Y" + lasty.ToString("f2") + "Z" + lastz.ToString("f2") + "\r\n");
            }
        }

        private void COM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int c = COM.ReadByte() - '0';
            if (c < 2)
                isFull = true;
            else
                isFull = false;
        }

        private void OpenPort_Click(object sender, EventArgs e)
        {
            if (COM.IsOpen)
            {
                COM.Close();
                OpenPort.Text = "打开串口";
                ComSelect.Enabled = true;
                SendNCCode.Enabled = false;
            }
            else
            {
                COM.PortName = ComSelect.SelectedItem.ToString();
                try
                {
                    COM.Open();
                    OpenPort.Text = "关闭串口";
                    ComSelect.Enabled = false;
                    SendNCCode.Enabled = true;
                }
                catch { MessageBox.Show("打开失败"); }
            }
        }
        OpenFileDialog of = new OpenFileDialog();
        private void OpenNCFile_Click(object sender, EventArgs e)
        {
            of.Filter = "NC文件|*.nc|所有文件|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                SelectNC.Text = sr.ReadToEnd();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (COM.IsOpen)
            {
                try { 
                COM.Write(((Control)(((Button)sender).Tag)).Text+(SendNewLine.Checked?"\r\n":""));
                }
                catch
                {
                    MessageBox.Show("发送失败");
                }
            }
        }

        private void SendNCCode_Click(object sender, EventArgs e)
        {
            GCode = SelectNC.Text.Split('\n');
            if (GCode.Length <= 1)
            {
                GCode = null;
                MessageBox.Show("发送区为空");
                return;
            }
            writePos = 0;
            COM.Write(GCode[writePos++]+'\n');
        }

        ImageToGCode P2G = null;

        volatile bool isFull;

        private void OpenImage_Click(object sender, EventArgs e)
        {
            if (P2G == null)
            {
                try
                {
                    P2G = new ImageToGCode();
                }
                catch { MessageBox.Show("该功能无法使用");return; }
            }
            of.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.dib";
            if (of.ShowDialog() == DialogResult.OK)
            {
                P2G.ImagePath = of.FileName;
                if (P2G.ShowDialog() == DialogResult.OK)
                {
                    SelectNC.Text = P2G.GCode;
                }
            }
        }

        private void PortOpen(object sender, EventArgs e)
        {
            int index = ((Control)sender).Text[1] - '0';
            string code = "";
            if (index <= 8)
            {
                code = "M101Y" + (char)(((Control)sender).Text[1]-1) + "\r\n";
                if (COM.IsOpen)
                    COM.Write(code);
                if (IOSaveChecked.Checked)
                    SelectNC.AppendText(code);
            }
        }

        private void PortClose(object sender, EventArgs e)
        {
            int index = ((Control)sender).Text[1] - '0';
            string code = "";
            if (index < 8)
            {
                code = "M102Y" + (char)(((Control)sender).Text[1] - 1) + "\r\n";
                if (COM.IsOpen)
                    COM.Write(code);
                if (IOSaveChecked.Checked)
                    SelectNC.AppendText(code);
            }
        }
        double lastx=0, lasty=0, lastz=0;

        private void UpdateAngle(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (COM.IsOpen)
                    {
                        double r = double.Parse(RValueBox.Text);
                        if (absRChecked.Checked)
                        {
                            double dir = Math.Acos(lastx/Math.Sqrt(lastx * lastx + lasty * lasty));
                            dir = (lasty < 0) ? -dir : dir;
                            r += (dir*180/Math.PI);
                        }
                        COM.Write("M104R" + r+"\r\n");
                    }
                }
                catch { }
            }
        }

        private void PosSaveButton_Click(object sender, EventArgs e)
        {
            string code= ("G" + ((FastMoveChecked.Checked) ? "0" : "1") + "X" + lastx.ToString("f2") + "Y" + lasty.ToString("f2") + "Z" + lastz.ToString("f2") + "\r\n");
            SelectNC.AppendText(code);
        }

        private void PosClick(object sender, EventArgs e)
        {
            string n = ((Button)sender).Text;
            double inc = 1;
            try
            {
                inc=double.Parse(INCValueBox.Text);
            }
            catch { }
            double x=0, y=0, z=0;
            switch (n[0])
            {
                case 'X':if (n[1] == '+') x = inc; else x = -inc; break;
                case 'Y': if (n[1] == '+') y = inc; else y = -inc; break;
                case 'Z': if (n[1] == '+') z = inc; else z = -inc; break;
            }
            lastx += x;
            lasty += y;
            lastz += z;
            XValueBox.Text = lastx.ToString();
            YValueBox.Text = lasty.ToString();
            ZValueBox.Text = lastz.ToString();
            if (COM.IsOpen)
            {
                COM.Write("G" + ((FastMoveChecked.Checked) ? "0" : "1") + "X" + lastx.ToString("f2") + "Y" + lasty.ToString("f2") + "Z" + lastz.ToString("f2") + "\r\n");
            }
        }

        private void UpdatePos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (COM.IsOpen)
                    {
                        double x = double.Parse(XValueBox.Text);
                        double y = double.Parse(YValueBox.Text);
                        double z = double.Parse(ZValueBox.Text);
                        lastx = x;
                        lasty = y;
                        lastz = z;
                        COM.Write("G" + ((FastMoveChecked.Checked) ? "0" : "1") + "X" + lastx.ToString("f2") + "Y" + lasty.ToString("f2") + "Z" + lastz.ToString("f2") + "\r\n");
                    }
                }
                catch { }
            }
        }
    }
}
