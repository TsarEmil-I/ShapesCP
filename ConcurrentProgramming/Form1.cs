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
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("completed");
        }

        public void ThreadMB()
        {
            
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawPolygon(new Pen(Brushes.Yellow, 4), new Polygon(rdm.Next(0, Width), rdm.Next(0, this.Height), 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("completed");
        }

        public void ThreadMC()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new (rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(100);
            }

            MessageBox.Show("completed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

    }
}