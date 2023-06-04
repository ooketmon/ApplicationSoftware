using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.UDC
{
    public partial class DoorLockUDC : UserControl
    {
        public DoorLockUDC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text +"6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text +"0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            inputPassword.Clear();  
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "*";
        }

        private void buttonSharp_Click(object sender, EventArgs e)
        {
            inputPassword.Text = inputPassword.Text + "#";
        }

        public void checkPassword()
        {
            string Password = ""; // password 살정 
            if (inputPassword.Text == Password) {
            }
            else {
                inputPassword.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible= false;
        }
    }
}
