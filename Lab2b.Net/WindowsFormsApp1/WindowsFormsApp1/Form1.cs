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
    public partial class Form1 : Form
    {
        Triangle[] triangles = new Triangle[100];
        Triangleright[] trianglesright;
        int I = 0, num = 0, n = 0;
        bool choice;
        double S = 0, H = 2147483647;
        public string filen;
        public Form1()
        {
            InitializeComponent();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            string path = frm2.filename;
            object mb = 1;
            if (path != null)
            {
                BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
                choice = true;
                numberbox.Text = reader.ReadString();
                while (reader.PeekChar() > -1)
                {
                    double firstside = reader.ReadDouble();
                    double secondside = reader.ReadDouble();
                    double thirdside = reader.ReadDouble();
                    string title = reader.ReadString();
                    triangles[I] = new Triangle(firstside, secondside, thirdside, title);
                    I++;
                    num++;
                    firsttxtbox.Text = firstside.ToString();
                    secondtxtbox.Text = secondside.ToString();
                    thirdtxtbox.Text = thirdside.ToString();
                    titletxtbox.Text = title;
                    //saveBtn_Click(mb, EventArgs.Empty);
                }

                taskbox.Text = "Task1(regular triangles)";
                taskbox.Enabled = false;
                numberbox.Enabled = false;
                numberbtn.Enabled = false;
                firsttxtbox.Enabled = true;
                secondtxtbox.Enabled = true;
                thirdtxtbox.Enabled = true;
                titletxtbox.Enabled = true;
                saveBtn.Enabled = true;
                if (Int32.Parse(numberbox.Text) == I)
                {
                    firsttxtbox.Enabled = false;
                    secondtxtbox.Enabled = false;
                    thirdtxtbox.Enabled = false;
                    titletxtbox.Enabled = false;
                    saveBtn.Enabled = false;
                    resultbtn.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void saveBtn_Click(object sender, EventArgs e)
        {
            double firstside = Convert.ToDouble(firsttxtbox.Text);
            double secondside = Convert.ToDouble(secondtxtbox.Text);
            double thirdside = Convert.ToDouble(thirdtxtbox.Text);
            string title = Convert.ToString(titletxtbox.Text);
            if (choice == true)
                triangles[I] = new Triangle(firstside, secondside, thirdside, title);
            else
                trianglesright[I] = new Triangleright(firstside, secondside, thirdside, title);
            I++;
            num++;
            MessageBox.Show($"Triangle number {num} saved!");
            if (Int32.Parse(numberbox.Text) == I)
            {
                firsttxtbox.Enabled = false;
                secondtxtbox.Enabled = false;
                thirdtxtbox.Enabled = false;
                titletxtbox.Enabled = false;
                saveBtn.Enabled = false;
                resultbtn.Enabled = true;
            }
        }

        private void taskbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskbox.Text == "Task1(regular triangles)")
            {
                choice = true;
                taskbox.Enabled = false;
            }
            else
            {
                choice = false;
                taskbox.Enabled = false;
            }
            numberbtn.Enabled = true;
            numberbox.Enabled = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void closebtn_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            if (frm3.ShowDialog().Equals(DialogResult.OK))
            {
                string path = frm3.filename;
                try
                {
                    BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate));
                    writer.Write(numberbox.Text);
                    foreach (Triangle t in triangles)
                    {
                        writer.Write(t.Firstside);
                        writer.Write(t.Secondside);
                        writer.Write(t.Thirdside);
                        writer.Write(t.Title);
                    }
                }
                catch (Exception s)
                {
                    Console.WriteLine(s.Message);
                }
                Close();
            }
        }

        private void resultbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < I; i++)
            {
                if (choice == true)
                {
                    if (triangles[i].Existence() && triangles[i].Area() > S)
                    {
                        S = triangles[i].Area();
                        n = i;
                    }
                }
                else
                {
                    if (trianglesright[i].Existence() && trianglesright[i].Check() && trianglesright[i].Hypotenuse() < H)
                    {
                        H = trianglesright[i].Hypotenuse();
                        n = i;
                    }
                }

            }
            if (choice == true)
                resultbox.AppendText($"Name of the triangle with the largest area: {triangles[n].Title}");
            else
                resultbox.AppendText($"Name of the triangle with the least hypotenuse: {trianglesright[n].Title}");

            resultbtn.Enabled = false;
            taskbox.Enabled = true;
            num = 0;
            I = 0;
        }

        private void numberbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (choice == true)
                    triangles = new Triangle[Int32.Parse(numberbox.Text)];
                else
                    trianglesright = new Triangleright[Int32.Parse(numberbox.Text)];
                resultbox.Text = "Number of triangles: " + Int32.Parse(numberbox.Text) + "\n";
                I = 0;

                numberbox.Enabled = false;
                numberbtn.Enabled = false;
                firsttxtbox.Enabled = true;
                secondtxtbox.Enabled = true;
                thirdtxtbox.Enabled = true;
                titletxtbox.Enabled = true;
                saveBtn.Enabled = true;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
