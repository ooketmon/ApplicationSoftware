using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2.UDC
{
    public partial class Doorlock : UserControl
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData==Keys.Enter)
            {
                  Doorlock_KeyDown(new object[] { }, new KeyEventArgs(keyData));

                

                return true;
            }

            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        string whoCallMe = "";
        public Doorlock()
        {
            InitializeComponent();
            room_number.Parent = pictureBox1;
            room_number.BackColor = Color.Transparent;
        }

        public Doorlock(string place)
        {
            InitializeComponent();
            whoCallMe= place;
            room_number.Parent = pictureBox1;
            room_number.BackColor = Color.Transparent;
        }

        private void Doorlock_Load(object sender, EventArgs e)
        {
            if (whoCallMe == "lecture2_1")
            {
                room_number.Text = "201호";
            }else if (whoCallMe=="lab_1")
            {
                room_number.Text = "1연구실";
            }
            else if (whoCallMe == "lab_2")
            {
                room_number.Text = "2연구실";
            }
            else if (whoCallMe == "lab_3")
            {
                room_number.Text = "3연구실";
            }else if (whoCallMe == "practice3_1")
            {
                room_number.Text = "1실습실";
            }
            else if (whoCallMe == "practice3_2")
            {
                room_number.Text = "2실습실";
            }
            else if (whoCallMe == "practice3_3")
            {
                room_number.Text = "3실습실";
            }
            else if (whoCallMe == "practice3_4")
            {
                room_number.Text = "4실습실";
            }
            txt_password.Focus();
        }

        public void checkAnswer()
        {
            if (whoCallMe == "lecture2_1" && txt_password.Text.Trim() == "201")
            {
                (this.Parent.Parent as InitMenu).openLecture2_1 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("room2_1");
            }
            else if (whoCallMe == "lab_1" && txt_password.Text.Trim() == "0303")
            {

                (this.Parent.Parent as InitMenu).openLab1 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("lab_1");

            }
            else if (whoCallMe == "lab_2" && txt_password.Text.Trim() == "142259")
            {

                (this.Parent.Parent as InitMenu).openLab2 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("lab_2");

            }
            else if (whoCallMe == "lab_3" && txt_password.Text.Trim() == "0212")
            {

                (this.Parent.Parent as InitMenu).openLab3 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("lab_3");

            }
            else if (whoCallMe == "practice3_1" && txt_password.Text.Trim() == "5614")
            {

                (this.Parent.Parent as InitMenu).openPractice1 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_1");

            }
            else if (whoCallMe == "practice3_2" && txt_password.Text.Trim() == "1234")
            {

                (this.Parent.Parent as InitMenu).openPractice2 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_2");

            }
            else if (whoCallMe == "practice3_3" && txt_password.Text.Trim() == "4319")
            {

                (this.Parent.Parent as InitMenu).openPractice3 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_3");

            }
            else if (whoCallMe == "practice3_4" && txt_password.Text.Trim() == "4567")
            {

                (this.Parent.Parent as InitMenu).openPractice4 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_4");

            }
            else
            {
                txt_password.Text = "";
            }
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            if (whoCallMe == "lecture2_1")
            {
                (this.Parent as Floor2UDC).puzzleOn = false;
                (this.Parent.Parent as InitMenu).GetRidofPuzzleInFloor();
            }else if (whoCallMe.Contains("lab"))
            {
                (this.Parent as Floor8UDC).puzzleOn = false;
                (this.Parent.Parent as InitMenu).GetRidofPuzzleInFloor();
            }else if (whoCallMe.Contains("practice"))
            {
                (this.Parent as Floor3UDC).puzzleOn = false;
                (this.Parent.Parent as InitMenu).GetRidofPuzzleInFloor();
            }
        }

        private void Doorlock_KeyDown(object sender, KeyEventArgs e)
        {
            checkAnswer();
        }
    }
}
