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
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (whoCallMe=="lecture2_1"&&txt_password.Text == "201")
            {
                (this.Parent.Parent as InitMenu).openLecture2_1 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("room2_1");
            }
            else if (whoCallMe == "lab_1" && txt_password.Text == "0303")
            {

                    (this.Parent.Parent as InitMenu).openLab1 = true;
                    (this.Parent.Parent as InitMenu).CallConvMode("lab_1");
                
            }
            else if (whoCallMe == "lab_2" && txt_password.Text == "142259")
            {
  
                    (this.Parent.Parent as InitMenu).openLab2 = true;
                    (this.Parent.Parent as InitMenu).CallConvMode("lab_2");
                
            }
            else if (whoCallMe == "lab_3" && txt_password.Text == "0212")
            {

                (this.Parent.Parent as InitMenu).openLab3 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("lab_3");

            }
            else if (whoCallMe == "practice3_1" && txt_password.Text == "5614")
            {

                (this.Parent.Parent as InitMenu).openPractice1 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_1");

            }
            else if (whoCallMe == "practice3_2" && txt_password.Text == "1234")
            {

                (this.Parent.Parent as InitMenu).openPractice2 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_2");

            }
            else if (whoCallMe == "practice3_3" && txt_password.Text == "4319")
            {

                (this.Parent.Parent as InitMenu).openPractice3 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_3");

            }
            else if (whoCallMe == "practice3_4" && txt_password.Text == "4567")
            {

                (this.Parent.Parent as InitMenu).openPractice4 = true;
                (this.Parent.Parent as InitMenu).CallConvMode("practice3_4");

            }
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
    }
}
