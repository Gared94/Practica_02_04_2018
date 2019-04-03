using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica02_04_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 4;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                progressBar1.PerformStep();
            }
           
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            button3.UseVisualStyleBackColor = true;
            button4.UseVisualStyleBackColor = true;
            button2.BackColor = Color.Red;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            button2.UseVisualStyleBackColor = true;
            button3.UseVisualStyleBackColor = true;
            button4.BackColor = Color.Green;

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = true;
            button4.UseVisualStyleBackColor = true;
            button3.BackColor = Color.Yellow;
            timer2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }
    }
}
