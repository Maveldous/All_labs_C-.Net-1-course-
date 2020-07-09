using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pushbtn_Click(object sender, EventArgs e)
        {
            double Ax = Convert.ToDouble(abox1.Text);
            double Ay = Convert.ToDouble(abox2.Text);
            int Az = Convert.ToInt32(aPredbox.Text);
            double Bx = Convert.ToDouble(bbox1.Text);
            double By = Convert.ToDouble(bbox2.Text);
            int Bz = Convert.ToInt32(bPredbox.Text);
            double Cx = Convert.ToDouble(cbox1.Text);
            double Cy = Convert.ToDouble(cbox2.Text);
            int Cz = Convert.ToInt32(cPredbox.Text);
            double Dx = Convert.ToDouble(dbox1.Text);
            double Dy = Convert.ToDouble(dbox2.Text);
            int Dz = Convert.ToInt32(dPredbox.Text);
            ComplexNum a = new ComplexNum(Az, Ax, Ay);
            ComplexNum b = new ComplexNum(Bz, Bx, By);
            ComplexNum c = new ComplexNum(Cz, Cx, Cy);
            ComplexNum d = new ComplexNum(Dz, Dx, Dy);
            ComplexNum result = ((a + b) * c * c) / (b - a);

            abox1.Text = null;
            abox2.Text = null;
            aPredbox.Text = null;
            bbox1.Text = null;
            bbox2.Text = null;
            bPredbox.Text = null;
            cbox1.Text = null;
            cbox2.Text = null;
            cPredbox.Text = null;
            dbox1.Text = null;
            dbox2.Text = null;
            dPredbox.Text = null;

            Resultbox.Text = result.Showresult();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
