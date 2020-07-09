using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Создать поток, который управляет перемещением кнопки/панели. Кнопка движется по Х. Создать 3 кнопки и устроить "тараканьи" бега среди них.

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Thread myThread, myThread1, myThread2;
        public static int counter1 = 0, counter2 = 0, counter3 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public static void btn1_rush(object x)
        {
            for (int i = 0; i < 600; i++)
            {
                counter1++;
                Thread.Sleep(10);
            }
        }

        public static void btn2_rush(object x)
        {
            for (int i = 0; i < 600; i++)
            {
                counter2++;
                Thread.Sleep(10);
            }
        }

        public static void btn3_rush(object x)
        {
            for (int i = 0; i < 600; i++)
            {
                counter3++;
                Thread.Sleep(10);
            }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            myThread = new Thread(new ParameterizedThreadStart(btn1_rush));
            myThread1 = new Thread(new ParameterizedThreadStart(btn2_rush));
            myThread2 = new Thread(new ParameterizedThreadStart(btn3_rush));
            myThread.Start(counter1);
            myThread1.Start(counter2);
            myThread2.Start(counter3);
            while (myThread.IsAlive)
            {
                button1.Location = new Point(counter1, 100);
                button2.Location = new Point(counter2, 200);
                button3.Location = new Point(counter3, 300);
            }
        }
    }
}
