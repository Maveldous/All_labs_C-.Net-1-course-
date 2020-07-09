using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string filename;
        public Form2()
        {
            InitializeComponent();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ft = new OpenFileDialog();
            if(ft.ShowDialog() == DialogResult.OK)
            {
                filename = ft.FileName;
                Close();
            }
        }
    }
}
