using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Abdullah\\source\\repos\\WindowsFormsApp2\\JYM Database1.mdf\";Integrated Security=True");
        public Register()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Nametext_Text_Enter(object sender, EventArgs e)
        {
            if(Nametext.Text=="Enter your Name")
            {
                Nametext.Text = "";
                Nametext.ForeColor = Color.Black;
            }
        }

        private void Nametext_Text_Leave(object sender, EventArgs e)
        {
            if (Nametext.Text == "")
            {
                Nametext.Text = "Enter your Name";
                Nametext.ForeColor = Color.Gray;
            }
        }

        private void Agetext_Text_Enter(object sender, EventArgs e)
        {
            if (Agetext.Text == "Enter your Age")
            {
                Agetext.Text = "";
                Agetext.ForeColor = Color.Black;
            }
        }
        private void Agetext_Text_Leave(object sender, EventArgs e)
        {
            if (Agetext.Text == "")
            {
                Agetext.Text = "Enter your Age";
                Agetext.ForeColor = Color.Gray;
            }
        }

        private void Gendertext_Enter(object sender, EventArgs e)
        {
            if (Gendertext.Text == "Enter your Gender")
            {
                Gendertext.Text = "";
                Gendertext.ForeColor = Color.Black;
            }
        }

        private void Gendertext_Leave(object sender, EventArgs e)
        {
            if (Gendertext.Text == "")
            {
                Gendertext.Text = "Enter your Gender";
                Gendertext.ForeColor = Color.Gray;
            }
        }

        private void Localitytext_Enter(object sender, EventArgs e)
        {
            if (Localitytext.Text == "Enter your Locality")
            {
                Localitytext.Text = "";
                Localitytext.ForeColor = Color.Black;
            }
        }

        private void Localitytext_Leave(object sender, EventArgs e)
        {
            if (Localitytext.Text == "")
            {
                Localitytext.Text = "Enter your Locality";
                Localitytext.ForeColor = Color.Gray;
            }
        }

        private void Phonetext_Enter(object sender, EventArgs e)
        {
            if (Phonetext.Text == "Enter Phone NO")
            {
                Phonetext.Text = "";
                Phonetext.ForeColor = Color.Black;
            }
        }

        private void Phonetext_Leave(object sender, EventArgs e)
        {
            if (Phonetext.Text == "")
            {
                Phonetext.Text = "Enter Phone NO";
                Phonetext.ForeColor = Color.Gray;
            }
        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {
            if (Nametext.Text == "Enter your Name" || Nametext.Text == "")
            {
                tick.Visible = false;
                cross.Visible = false;
                return;
            }

            if (Regex.IsMatch(Nametext.Text, @"^[a-zA-Z]+$"))
            {
                tick.Visible = true;
                cross.Visible = false;
            }
            else
            {
                tick.Visible = false;
                cross.Visible = true;
            }
        }

        private void Agetext_TextChanged(object sender, EventArgs e)
        {
            if (Agetext.Text == "Enter your Age" || Agetext.Text == "")
            {
                tickage.Visible = false;
                crossage.Visible = false;
                return;
            }

            if (Regex.IsMatch(Agetext.Text, @"^\d+$"))
            {
                tickage.Visible = true;
                crossage.Visible = false;
            }
            else
            {
                tickage.Visible = false;
                crossage.Visible = true;
            }
        }
        private void Gendertext_TextChanged_1(object sender, EventArgs e)
        {
            if (Gendertext.Text == "Enter your Gender" || Gendertext.Text == "")
            {
                tickgender.Visible = false;
                crossgender.Visible = false;
                return;
            }

            if (Regex.IsMatch(Gendertext.Text, @"^[a-zA-Z]+$"))
            {
                tickgender.Visible = true;
                crossgender.Visible = false;
            }
            else
            {
                tickgender.Visible = false;
                crossgender.Visible = true;
            }
        }
        private void Localitytext_TextChanged(object sender, EventArgs e)
        {
            if (Localitytext.Text == "Enter your Locality" || Localitytext.Text == "")
            {
                ticklocality.Visible = false;
                crosslocality.Visible = false;
                return;
            }
            else
            {
                ticklocality.Visible = true;
                crosslocality.Visible = false;
            }
        }
        private void Phonetext_TextChanged(object sender, EventArgs e)
        {
            if (Phonetext.Text == "Enter Phone NO" || Phonetext.Text == "")
            {
                tickphone.Visible = false;
                crossphone.Visible = false;
                return;
            }

            if (Regex.IsMatch(Phonetext.Text, @"^\d+$"))
            {
                tickphone.Visible = true;
                crossphone.Visible = false;
            }
            else
            {
                tickphone.Visible = false;
                crossphone.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Required field
            if (Nametext.Text == "" || Nametext.Text == "Enter your Name" || Agetext.Text == "" || Agetext.Text == "Enter your Age" || Gendertext.Text == "" || Gendertext.Text == "Enter your Gender" || Localitytext.Text == "" || Localitytext.Text == "Enter your Locality" || Phonetext.Text == "" || Phonetext.Text == "Enter Phone NO")
            {
                MessageBox.Show("Please fill all required fields", "Message");
                return;
            }
            //Name field
            if (!Regex.IsMatch(Nametext.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Name using Alphabet", "Message");
                return;
            }
            //Age field
            if (!Regex.IsMatch(Agetext.Text, @"^\d+$"))
            {
                MessageBox.Show("Please Enter age in digits", "Message");
                return;
            }
            //Gender field
            if (!Regex.IsMatch(Gendertext.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please Enter Gender in Alphabet(Male/Female)", "Message");
                return;
            }
            //Phone field
            if (!Regex.IsMatch(Phonetext.Text, @"^\d+$"))
            {
                MessageBox.Show("Please Enter Phone NO using digits", "Message");
                return;
            }
            MessageBox.Show("You are Registered successfully", "Message");


            //connection
            SqlCommand cmd = new SqlCommand("INSERT INTO Register VALUES('" + Nametext.Text + "','" + Agetext.Text + "','" + Gendertext.Text + "','" + Localitytext.Text + "','" + Phonetext.Text + "')", con);
            //openning connection
            con.Open();
            //Execute connection
            cmd.ExecuteNonQuery();
            //closing connection
            con.Close();
        }
    }
}
