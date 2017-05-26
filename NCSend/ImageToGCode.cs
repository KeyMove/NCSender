using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace NCSend
{
    public partial class ImageToGCode : Form
    {
        Bitmap outmap;
        Graphics mapDraw;
        Image<Gray,byte> sourMap;
        Image<Gray, byte> mainMap =null;
        VectorOfVectorOfPoint vpp = new VectorOfVectorOfPoint();
        public string ImagePath { get; set; }
        public string GCode {
            get;private set;
        }
        public ImageToGCode()
        {
            InitializeComponent();
            outmap = new Bitmap(map.Width, map.Height);
            mapDraw = Graphics.FromImage(outmap);
            if (CvInvoke.HaveOpenCL)
            {
                sourMap = null;
                mainMap = null;
            }
        }

        private void th_Scroll(object sender, EventArgs e)
        {
            if (mainMap != null) mainMap.Dispose();
            mainMap = sourMap.Clone();
            CvInvoke.Threshold(sourMap, mainMap, th.Value, 256, Emgu.CV.CvEnum.ThresholdType.Binary);
            vpp.Clear();
            CvInvoke.FindContours(mainMap, vpp, null, RetrType.Tree, ChainApproxMethod.ChainApproxNone);
            mainMap.SetZero();
            for (int i = 1; i < vpp.Size; i++)
            {
                mainMap.DrawPolyline(vpp[i].ToArray(), true, new Gray(255));
            }            
            map.Image = mainMap.Bitmap;
        }

        private void ImageToGCode_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnShown(EventArgs e)
        {
            if (ImagePath == null)
            {
                this.Hide();
                MessageBox.Show("路径不可用");
            }
            else
            {

                sourMap = new Image<Gray, byte>(ImagePath);
                sourMap=sourMap.Flip(FlipType.Horizontal);
                th_Scroll(null, null);
                base.OnShown(e);
            }
        }

        string vppToGCode(double x, double y, double xscal, double yscal, double z, double zh, VectorOfVectorOfPoint vpp)
        {
            StringBuilder sb = new StringBuilder();
            double lx = x, ly = y;
            bool firstpoint = true;
            sb.AppendLine("G0 X" + x + "Y" + y + "Z" + zh);
            for (int i = 1; i < vpp.Size; i++)
            {
                Point[] ps = vpp[i].ToArray();
                firstpoint = true;
                foreach(Point p in ps)
                {
                    double xv = x - p.X * xscal;
                    double yv = y - p.Y * yscal;
                    if (firstpoint)
                    {
                        lx = xv;
                        ly = yv;
                        sb.AppendLine("G0 X" + xv + "Y" + yv);
                        sb.AppendLine("G1 Z" + z);
                        firstpoint = false;
                    }
                    else
                        sb.AppendLine("G1 X" + xv + "Y" + yv);
                }
                sb.AppendLine("G1 X" + lx + "Y" + ly);
                sb.AppendLine("G1 Z" + zh);
            }


            return sb.ToString();
        }


        private void GetGCode_Click(object sender, EventArgs e)
        {
            GCode = vppToGCode(double.Parse(xstart.Text), double.Parse(ystart.Text), double.Parse(xscal.Text), double.Parse(yscal.Text), double.Parse(zmove.Text), double.Parse(zpan.Text), vpp);
        }

        private void xstart_TextChanged(object sender, EventArgs e)
        {
            try {
                double dv = double.Parse(((Control)sender).Text);
                ((Control)sender).Tag = ((Control)sender).Text;

            }
            catch { ((Control)sender).Text= ((Control)sender).Tag!=null?((Control)sender).Tag.ToString():"0"; }

        }
    }
}
