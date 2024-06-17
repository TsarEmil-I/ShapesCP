using NetTopologySuite.Geometries;
using System.Resources;
using System.Runtime.Intrinsics.Arm;

namespace ConcurrentProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rdm = new Random();

        Thread t1;
        Thread t2;
        Thread t3;

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(ThreadM);
            t1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t2 = new Thread(ThreadMB);
            t2.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            t3 = new Thread(ThreadMC);
            t3.Start();
        }

        public void ThreadM()
        { 
            for (int i = 0; i < 100; i++)
            {
                Color cl = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));

                this.CreateGraphics().DrawRectangle(new Pen(cl, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), rdm.Next(0, 20), rdm.Next(0, 20)));
                Thread.Sleep(3000);
            }

            MessageBox.Show("completed");
        }

        public void ThreadMB()
        {
            
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2000);
            }

            MessageBox.Show("completed");
        }

        public void ThreadMC()
        {
            for (int i = 0; i < 100; i++)
            {
                Color cl = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));

                this.CreateGraphics().DrawEllipse(new Pen(cl, 4), rdm.Next(0, this.Width), rdm.Next(0, this.Height), rdm.Next(0, 20), rdm.Next(0, 20));
                Thread.Sleep(4000);
            }

            MessageBox.Show("completed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

    }
}