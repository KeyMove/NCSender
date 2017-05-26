namespace NCSend
{
    partial class Form1
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
            this.OpenPort = new System.Windows.Forms.Button();
            this.ComSelect = new System.Windows.Forms.ComboBox();
            this.SelectNC = new System.Windows.Forms.TextBox();
            this.OpenNCFile = new System.Windows.Forms.Button();
            this.SendPanle = new System.Windows.Forms.Panel();
            this.SendNewLine = new System.Windows.Forms.CheckBox();
            this.B1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.TextBox();
            this.SendNCCode = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenImage = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FastMoveChecked = new System.Windows.Forms.CheckBox();
            this.absRChecked = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PosSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.INCValueBox = new System.Windows.Forms.TextBox();
            this.RValueBox = new System.Windows.Forms.TextBox();
            this.ZValueBox = new System.Windows.Forms.TextBox();
            this.YValueBox = new System.Windows.Forms.TextBox();
            this.XValueBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ydec = new System.Windows.Forms.Button();
            this.Xadd = new System.Windows.Forms.Button();
            this.Xdec = new System.Windows.Forms.Button();
            this.Yadd = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Zdown = new System.Windows.Forms.Button();
            this.Zup = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IOGroup = new System.Windows.Forms.GroupBox();
            this.IOSaveChecked = new System.Windows.Forms.CheckBox();
            this.PortO1 = new System.Windows.Forms.Button();
            this.PortC1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SendPanle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.IOGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenPort
            // 
            this.OpenPort.Location = new System.Drawing.Point(132, 133);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(75, 23);
            this.OpenPort.TabIndex = 0;
            this.OpenPort.Text = "打开串口";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // ComSelect
            // 
            this.ComSelect.FormattingEnabled = true;
            this.ComSelect.Location = new System.Drawing.Point(5, 136);
            this.ComSelect.Name = "ComSelect";
            this.ComSelect.Size = new System.Drawing.Size(121, 20);
            this.ComSelect.TabIndex = 1;
            // 
            // SelectNC
            // 
            this.SelectNC.Location = new System.Drawing.Point(6, 6);
            this.SelectNC.Multiline = true;
            this.SelectNC.Name = "SelectNC";
            this.SelectNC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SelectNC.Size = new System.Drawing.Size(378, 124);
            this.SelectNC.TabIndex = 2;
            // 
            // OpenNCFile
            // 
            this.OpenNCFile.Location = new System.Drawing.Point(309, 159);
            this.OpenNCFile.Name = "OpenNCFile";
            this.OpenNCFile.Size = new System.Drawing.Size(75, 23);
            this.OpenNCFile.TabIndex = 3;
            this.OpenNCFile.Text = "打开NC文件";
            this.OpenNCFile.UseVisualStyleBackColor = true;
            this.OpenNCFile.Click += new System.EventHandler(this.OpenNCFile_Click);
            // 
            // SendPanle
            // 
            this.SendPanle.AutoScroll = true;
            this.SendPanle.Controls.Add(this.SendNewLine);
            this.SendPanle.Controls.Add(this.B1);
            this.SendPanle.Controls.Add(this.T1);
            this.SendPanle.Location = new System.Drawing.Point(6, 6);
            this.SendPanle.Name = "SendPanle";
            this.SendPanle.Size = new System.Drawing.Size(377, 175);
            this.SendPanle.TabIndex = 4;
            // 
            // SendNewLine
            // 
            this.SendNewLine.AutoSize = true;
            this.SendNewLine.Checked = true;
            this.SendNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SendNewLine.Location = new System.Drawing.Point(269, 6);
            this.SendNewLine.Name = "SendNewLine";
            this.SendNewLine.Size = new System.Drawing.Size(72, 16);
            this.SendNewLine.TabIndex = 2;
            this.SendNewLine.Text = "发送新行";
            this.SendNewLine.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(322, 3);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(25, 21);
            this.B1.TabIndex = 1;
            this.B1.Text = "12";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Visible = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(3, 3);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(313, 21);
            this.T1.TabIndex = 0;
            this.T1.Visible = false;
            // 
            // SendNCCode
            // 
            this.SendNCCode.Enabled = false;
            this.SendNCCode.Location = new System.Drawing.Point(213, 133);
            this.SendNCCode.Name = "SendNCCode";
            this.SendNCCode.Size = new System.Drawing.Size(75, 23);
            this.SendNCCode.TabIndex = 3;
            this.SendNCCode.Text = "发送NC代码";
            this.SendNCCode.UseVisualStyleBackColor = true;
            this.SendNCCode.Click += new System.EventHandler(this.SendNCCode_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 211);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SelectNC);
            this.tabPage1.Controls.Add(this.OpenPort);
            this.tabPage1.Controls.Add(this.SendNCCode);
            this.tabPage1.Controls.Add(this.ComSelect);
            this.tabPage1.Controls.Add(this.OpenImage);
            this.tabPage1.Controls.Add(this.OpenNCFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(393, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NC代码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(309, 133);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(75, 23);
            this.OpenImage.TabIndex = 3;
            this.OpenImage.Text = "打开图片";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SendPanle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(393, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "串口发送";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(393, 185);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "位置模式";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FastMoveChecked);
            this.groupBox3.Controls.Add(this.absRChecked);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.PosSaveButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.INCValueBox);
            this.groupBox3.Controls.Add(this.RValueBox);
            this.groupBox3.Controls.Add(this.ZValueBox);
            this.groupBox3.Controls.Add(this.YValueBox);
            this.groupBox3.Controls.Add(this.XValueBox);
            this.groupBox3.Location = new System.Drawing.Point(125, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 156);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pos";
            // 
            // FastMoveChecked
            // 
            this.FastMoveChecked.AutoSize = true;
            this.FastMoveChecked.Checked = true;
            this.FastMoveChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FastMoveChecked.Location = new System.Drawing.Point(180, 107);
            this.FastMoveChecked.Name = "FastMoveChecked";
            this.FastMoveChecked.Size = new System.Drawing.Size(72, 16);
            this.FastMoveChecked.TabIndex = 7;
            this.FastMoveChecked.Text = "快速定位";
            this.FastMoveChecked.UseVisualStyleBackColor = true;
            // 
            // absRChecked
            // 
            this.absRChecked.AutoSize = true;
            this.absRChecked.Location = new System.Drawing.Point(69, 102);
            this.absRChecked.Name = "absRChecked";
            this.absRChecked.Size = new System.Drawing.Size(72, 16);
            this.absRChecked.TabIndex = 7;
            this.absRChecked.Text = "绝对角度";
            this.absRChecked.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "复位";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PosSaveButton
            // 
            this.PosSaveButton.Location = new System.Drawing.Point(180, 127);
            this.PosSaveButton.Name = "PosSaveButton";
            this.PosSaveButton.Size = new System.Drawing.Size(75, 23);
            this.PosSaveButton.TabIndex = 6;
            this.PosSaveButton.Text = "记录位置";
            this.PosSaveButton.UseVisualStyleBackColor = true;
            this.PosSaveButton.Click += new System.EventHandler(this.PosSaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "增量:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // INCValueBox
            // 
            this.INCValueBox.Location = new System.Drawing.Point(47, 129);
            this.INCValueBox.Name = "INCValueBox";
            this.INCValueBox.Size = new System.Drawing.Size(43, 21);
            this.INCValueBox.TabIndex = 4;
            this.INCValueBox.Text = "1";
            // 
            // RValueBox
            // 
            this.RValueBox.Location = new System.Drawing.Point(29, 100);
            this.RValueBox.Name = "RValueBox";
            this.RValueBox.Size = new System.Drawing.Size(34, 21);
            this.RValueBox.TabIndex = 4;
            this.RValueBox.Text = "90";
            this.RValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateAngle);
            // 
            // ZValueBox
            // 
            this.ZValueBox.Location = new System.Drawing.Point(29, 73);
            this.ZValueBox.Name = "ZValueBox";
            this.ZValueBox.Size = new System.Drawing.Size(100, 21);
            this.ZValueBox.TabIndex = 4;
            this.ZValueBox.Text = "100";
            this.ZValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdatePos);
            // 
            // YValueBox
            // 
            this.YValueBox.Location = new System.Drawing.Point(29, 48);
            this.YValueBox.Name = "YValueBox";
            this.YValueBox.Size = new System.Drawing.Size(100, 21);
            this.YValueBox.TabIndex = 4;
            this.YValueBox.Text = "0";
            this.YValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdatePos);
            // 
            // XValueBox
            // 
            this.XValueBox.Location = new System.Drawing.Point(29, 21);
            this.XValueBox.Name = "XValueBox";
            this.XValueBox.Size = new System.Drawing.Size(100, 21);
            this.XValueBox.TabIndex = 4;
            this.XValueBox.Text = "300";
            this.XValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdatePos);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ydec);
            this.groupBox2.Controls.Add(this.Xadd);
            this.groupBox2.Controls.Add(this.Xdec);
            this.groupBox2.Controls.Add(this.Yadd);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(11, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XY";
            // 
            // Ydec
            // 
            this.Ydec.Location = new System.Drawing.Point(69, 46);
            this.Ydec.Name = "Ydec";
            this.Ydec.Size = new System.Drawing.Size(25, 21);
            this.Ydec.TabIndex = 0;
            this.Ydec.Text = "Y-";
            this.Ydec.UseVisualStyleBackColor = true;
            this.Ydec.Click += new System.EventHandler(this.PosClick);
            // 
            // Xadd
            // 
            this.Xadd.Location = new System.Drawing.Point(38, 17);
            this.Xadd.Name = "Xadd";
            this.Xadd.Size = new System.Drawing.Size(25, 21);
            this.Xadd.TabIndex = 0;
            this.Xadd.Text = "X+";
            this.Xadd.UseVisualStyleBackColor = true;
            this.Xadd.Click += new System.EventHandler(this.PosClick);
            // 
            // Xdec
            // 
            this.Xdec.Location = new System.Drawing.Point(38, 73);
            this.Xdec.Name = "Xdec";
            this.Xdec.Size = new System.Drawing.Size(25, 21);
            this.Xdec.TabIndex = 0;
            this.Xdec.Text = "X-";
            this.Xdec.UseVisualStyleBackColor = true;
            this.Xdec.Click += new System.EventHandler(this.PosClick);
            // 
            // Yadd
            // 
            this.Yadd.Location = new System.Drawing.Point(7, 46);
            this.Yadd.Name = "Yadd";
            this.Yadd.Size = new System.Drawing.Size(25, 21);
            this.Yadd.TabIndex = 0;
            this.Yadd.Text = "Y+";
            this.Yadd.UseVisualStyleBackColor = true;
            this.Yadd.Click += new System.EventHandler(this.PosClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(38, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 21);
            this.button7.TabIndex = 0;
            this.button7.Text = "S";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Zdown);
            this.groupBox1.Controls.Add(this.Zup);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Z";
            // 
            // Zdown
            // 
            this.Zdown.Location = new System.Drawing.Point(69, 20);
            this.Zdown.Name = "Zdown";
            this.Zdown.Size = new System.Drawing.Size(25, 21);
            this.Zdown.TabIndex = 0;
            this.Zdown.Text = "Z-";
            this.Zdown.UseVisualStyleBackColor = true;
            this.Zdown.Click += new System.EventHandler(this.PosClick);
            // 
            // Zup
            // 
            this.Zup.Location = new System.Drawing.Point(7, 20);
            this.Zup.Name = "Zup";
            this.Zup.Size = new System.Drawing.Size(25, 21);
            this.Zup.TabIndex = 0;
            this.Zup.Text = "Z+";
            this.Zup.UseVisualStyleBackColor = true;
            this.Zup.Click += new System.EventHandler(this.PosClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.IOGroup);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(393, 185);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "端口";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(3, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 93);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "端口检测";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "1低";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PortClose);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "1高";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PortOpen);
            // 
            // IOGroup
            // 
            this.IOGroup.Controls.Add(this.IOSaveChecked);
            this.IOGroup.Controls.Add(this.PortO1);
            this.IOGroup.Controls.Add(this.PortC1);
            this.IOGroup.Location = new System.Drawing.Point(3, 3);
            this.IOGroup.Name = "IOGroup";
            this.IOGroup.Size = new System.Drawing.Size(383, 83);
            this.IOGroup.TabIndex = 1;
            this.IOGroup.TabStop = false;
            this.IOGroup.Text = "IO控制";
            // 
            // IOSaveChecked
            // 
            this.IOSaveChecked.AutoSize = true;
            this.IOSaveChecked.Location = new System.Drawing.Point(311, 9);
            this.IOSaveChecked.Name = "IOSaveChecked";
            this.IOSaveChecked.Size = new System.Drawing.Size(72, 16);
            this.IOSaveChecked.TabIndex = 1;
            this.IOSaveChecked.Text = "操作记录";
            this.IOSaveChecked.UseVisualStyleBackColor = true;
            // 
            // PortO1
            // 
            this.PortO1.Location = new System.Drawing.Point(6, 20);
            this.PortO1.Name = "PortO1";
            this.PortO1.Size = new System.Drawing.Size(31, 23);
            this.PortO1.TabIndex = 0;
            this.PortO1.Text = "开1";
            this.PortO1.UseVisualStyleBackColor = true;
            this.PortO1.Click += new System.EventHandler(this.PortOpen);
            // 
            // PortC1
            // 
            this.PortC1.Location = new System.Drawing.Point(6, 49);
            this.PortC1.Name = "PortC1";
            this.PortC1.Size = new System.Drawing.Size(31, 23);
            this.PortC1.TabIndex = 0;
            this.PortC1.Text = "关1";
            this.PortC1.UseVisualStyleBackColor = true;
            this.PortC1.Click += new System.EventHandler(this.PortClose);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(393, 185);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "视觉追踪";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 229);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SendPanle.ResumeLayout(false);
            this.SendPanle.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.IOGroup.ResumeLayout(false);
            this.IOGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.ComboBox ComSelect;
        private System.Windows.Forms.TextBox SelectNC;
        private System.Windows.Forms.Button OpenNCFile;
        private System.Windows.Forms.Panel SendPanle;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.CheckBox SendNewLine;
        private System.Windows.Forms.Button SendNCCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Xadd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INCValueBox;
        private System.Windows.Forms.TextBox ZValueBox;
        private System.Windows.Forms.TextBox YValueBox;
        private System.Windows.Forms.TextBox XValueBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Ydec;
        private System.Windows.Forms.Button Xdec;
        private System.Windows.Forms.Button Yadd;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Zdown;
        private System.Windows.Forms.Button Zup;
        private System.Windows.Forms.Button PosSaveButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button PortC1;
        private System.Windows.Forms.Button PortO1;
        private System.Windows.Forms.GroupBox IOGroup;
        private System.Windows.Forms.CheckBox IOSaveChecked;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox absRChecked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RValueBox;
        private System.Windows.Forms.CheckBox FastMoveChecked;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

