namespace NCSend
{
    partial class ImageToGCode
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
            this.map = new System.Windows.Forms.PictureBox();
            this.th = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.GetGCode = new System.Windows.Forms.Button();
            this.xstart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ystart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xscal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yscal = new System.Windows.Forms.TextBox();
            this.zpan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zmove = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.White;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(320, 320);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // th
            // 
            this.th.Location = new System.Drawing.Point(338, 31);
            this.th.Maximum = 255;
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(104, 45);
            this.th.TabIndex = 1;
            this.th.Value = 128;
            this.th.Scroll += new System.EventHandler(this.th_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "阈值";
            // 
            // GetGCode
            // 
            this.GetGCode.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GetGCode.Location = new System.Drawing.Point(340, 309);
            this.GetGCode.Name = "GetGCode";
            this.GetGCode.Size = new System.Drawing.Size(102, 23);
            this.GetGCode.TabIndex = 3;
            this.GetGCode.Text = "生成G代码";
            this.GetGCode.UseVisualStyleBackColor = true;
            this.GetGCode.Click += new System.EventHandler(this.GetGCode_Click);
            // 
            // xstart
            // 
            this.xstart.Location = new System.Drawing.Point(338, 84);
            this.xstart.Name = "xstart";
            this.xstart.Size = new System.Drawing.Size(100, 21);
            this.xstart.TabIndex = 4;
            this.xstart.Text = "0";
            this.xstart.TextChanged += new System.EventHandler(this.xstart_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "X起点";
            // 
            // ystart
            // 
            this.ystart.Location = new System.Drawing.Point(338, 126);
            this.ystart.Name = "ystart";
            this.ystart.Size = new System.Drawing.Size(100, 21);
            this.ystart.TabIndex = 6;
            this.ystart.Text = "0";
            this.ystart.TextChanged += new System.EventHandler(this.xstart_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y起点";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "X缩放";
            // 
            // xscal
            // 
            this.xscal.Location = new System.Drawing.Point(338, 164);
            this.xscal.Name = "xscal";
            this.xscal.Size = new System.Drawing.Size(100, 21);
            this.xscal.TabIndex = 4;
            this.xscal.Text = "1";
            this.xscal.TextChanged += new System.EventHandler(this.xstart_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Y缩放";
            // 
            // yscal
            // 
            this.yscal.Location = new System.Drawing.Point(338, 206);
            this.yscal.Name = "yscal";
            this.yscal.Size = new System.Drawing.Size(100, 21);
            this.yscal.TabIndex = 6;
            this.yscal.Text = "1";
            this.yscal.TextChanged += new System.EventHandler(this.xstart_TextChanged);
            // 
            // zpan
            // 
            this.zpan.Location = new System.Drawing.Point(358, 246);
            this.zpan.Name = "zpan";
            this.zpan.Size = new System.Drawing.Size(33, 21);
            this.zpan.TabIndex = 10;
            this.zpan.Text = "0";
            this.zpan.TextChanged += new System.EventHandler(this.xstart_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Z轴 运行  移动 高度";
            // 
            // zmove
            // 
            this.zmove.Location = new System.Drawing.Point(394, 246);
            this.zmove.Name = "zmove";
            this.zmove.Size = new System.Drawing.Size(33, 21);
            this.zmove.TabIndex = 10;
            this.zmove.Text = "10";
            this.zmove.TextChanged += new System.EventHandler(this.xstart_TextChanged);
            // 
            // ImageToGCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 347);
            this.Controls.Add(this.zmove);
            this.Controls.Add(this.zpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yscal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ystart);
            this.Controls.Add(this.xscal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xstart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GetGCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.th);
            this.Controls.Add(this.map);
            this.Name = "ImageToGCode";
            this.Text = "图片转G代码";
            this.Load += new System.EventHandler(this.ImageToGCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.TrackBar th;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetGCode;
        private System.Windows.Forms.TextBox xstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ystart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xscal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yscal;
        private System.Windows.Forms.TextBox zpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zmove;
    }
}