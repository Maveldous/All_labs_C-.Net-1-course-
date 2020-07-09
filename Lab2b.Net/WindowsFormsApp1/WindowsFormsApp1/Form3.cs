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
    public partial class Form3 : Form
    {
        public string filename;
        public Form3()
        {
            InitializeComponent();
        }

        private void nobtn2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yesbtn2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                filename = save.FileName;
                Close();
            }
        }
    }
}
