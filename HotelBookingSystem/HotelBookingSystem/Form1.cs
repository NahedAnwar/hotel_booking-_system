using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    
    public partial class Form1 : Form
    {
        int move;
        int movx;
        int movy;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Coolection input value
            string name = textName.Text;
            string password = textPassword.Text;
            string loginas = comboLogin.SelectedItem?.ToString() ?? "Not Selected";
            


            //Validate Name
            if(string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textName.Focus();
                return;
            }
            //Validate Password
            if (textPassword.Text.Length <9)
            {
                MessageBox.Show("Password must be at Least 9 Charachters!", "Validation Error ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.Focus();
                return;
            }
            //Validate Login as
            if (comboLogin.SelectedItem == null)
            {
                MessageBox.Show("Please Selected a Login !","Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboLogin.Focus();
                return;

            }

            //Validate  is "Admin" or "Client"
            if (loginas == "Admin")
            {
                if (name=="rosa"&&password=="admin1234") {
                  //  Form4 form4 = new Form4();
                   // form4.ShowDialog();
                } else
                {
                    MessageBox.Show("username or password is not true ", "Valiation Error ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    }
            else if (loginas == "Client")
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy=e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move==1)
            {
                this.SetDesktopLocation(MousePosition.X-movx, MousePosition.Y - movy);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
