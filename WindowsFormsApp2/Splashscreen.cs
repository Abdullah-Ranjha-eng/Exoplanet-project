using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Splashscreen : Form
    {
        int progress = 0;
        public Splashscreen()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Start();
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;
            if (progress >= 100)
            {
                timer1.Stop();
                this.Close();
            }
            progressBar1.Value = progress;
            label2.Text= progress.ToString() + "%";
        }
    }
}
