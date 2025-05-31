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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void joinbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
