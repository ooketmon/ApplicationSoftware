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
    public partial class Pc_lock : UserControl
    {
        string whoCallme = "";
        ControlConversationUDC controller=null;

        public Pc_lock()
        {
            InitializeComponent();
        }

        public Pc_lock(string place, ControlConversationUDC controller)
        {
            InitializeComponent();
            whoCallme = place;
            this.controller = controller;
        }

        private void Pc_lock_Load(object sender, EventArgs e)
        {
            if (whoCallme == "lecture2_2")
            {
                img_lock.BackgroundImage = Properties.Resources._2_computer_lock;
                img_lock.BackgroundImageLayout = ImageLayout.Stretch;
            }else if (whoCallme == "lab_2")
            {
                img_lock.BackgroundImage = Properties.Resources._2_test_lock;
                img_lock.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (whoCallme == "lecture2_2")
            {
                if (txt_password.Text == "4367")
                {
                    controller.Room2_2PuzzleSolved();
                }
                else
                {
                    controller.Room2_2PuzzleWrong();
                }
            }
            else if (whoCallme == "lab_2")
            {
                if (txt_password.Text == "8721")
                {
                    controller.Lab2_PcPuzzleSolve();
                }
                else
                {
                    controller.Lab2_PcPuzzleWrong();
                }
            }
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            if (whoCallme == "lecture2_2")
            {
                controller.Room2_2PuzzleQuit();
            }else if (whoCallme == "lab_2")
            {
                controller.Lab2_PcPuzzleQuit();
            }
        }
    }
}
