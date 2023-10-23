using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("- Thread Start -");

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread A Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();


            Console.WriteLine("- End Thread -");
            label1.Text = "- End Thread -";
        }
    }
}
