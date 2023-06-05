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
    public partial class puzzle : UserControl
    {
        string info;
        ControlConversationUDC controller=null;
        Label pc2_problem = null;
        int pc2_answer = -1;
        int lab1_pw = -1;
        int lab2_pw= -1;
        int lab3_pw = -1;
        int lab2_pc_answer = -1;
        int lab4_lockcase_answer = -1;

        public puzzle(string info,ControlConversationUDC controller)
        {
            InitializeComponent();
            this.info = info;
            this.controller = controller;
        }

        public puzzle(string info)
        {
            InitializeComponent();
            this.info = info;
        }
        private void btn_input_Click(object sender, EventArgs e)
        {
            
            if (info == "PC_2")
            {
                if (textBox1.Text == pc2_answer.ToString())
                {
                    controller.Room2_2PuzzleSolved();
                }
                else
                {
                    controller.Room2_2PuzzleWrong();
                }
            }else if (info == "lecture2_1_enter")
            {
                if (textBox1.Text=="201")
                {
                    (this.Parent.Parent as InitMenu).openLecture2_1= true;
                    (this.Parent.Parent as InitMenu).CallConvMode("room2_1");
                }

            }
            else if (info == "lab1_enter")
            {
                if (lab1_pw.ToString() == textBox1.Text)
                {
                    (this.Parent.Parent as InitMenu).openLab1 = true;
                    (this.Parent.Parent as InitMenu).CallConvMode("lab_1");
                }
            }
            else if (info == "lab2_enter")
            {
                if (lab2_pw.ToString() == textBox1.Text)
                {
                    (this.Parent.Parent as InitMenu).openLab2 = true;
                    (this.Parent.Parent as InitMenu).CallConvMode("lab_2");
                }
            }
            else if (info == "lab2_PC")
            {
                if (textBox1.Text == lab2_pc_answer.ToString())
                {
                    (this.Parent.Parent as InitMenu).Lab2PcSolved = true;
                    controller.Lab2_PcPuzzleSolve();
                }
                else
                {
                    controller.Lab2_PcPuzzleWrong();
                }

            }
            else if (info == "lab3_enter")
            {
                if (lab3_pw.ToString() == textBox1.Text)
                {
                    (this.Parent.Parent as InitMenu).openLab3 = true;
                    (this.Parent.Parent as InitMenu).CallConvMode("lab_3");
                }
            }
            else if (info == "lab4_LockCase")
            {
                if (textBox1.Text == lab4_lockcase_answer.ToString())
                {
                    (this.Parent.Parent as InitMenu).Lab4LockCaseSolve = true;
                    controller.Lab4_LockCasePuzzleSolve();
                }
                else
                {
                    controller.Lab4_LockCasePuzzleWrong();
                }
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            
            if (info == "PC_2")
            {
                controller.Room2_2PuzzleQuit();
            }else if (info=="lecture2_1_enter")
            {
                (this.Parent as Floor2UDC).puzzleOn = false;
                (this.Parent.Parent as InitMenu).GetRidofPuzzleInFloor();
            }
            else if (info == "lab1_enter")
            {
                (this.Parent as Floor8UDC).puzzleOn = false;
                (this.Parent.Parent as InitMenu).GetRidofPuzzleInFloor();
            }
            else if (info == "lab2_enter")
            {
                (this.Parent as Floor8UDC).puzzleOn = false;
                (this.Parent.Parent as InitMenu).GetRidofPuzzleInFloor();
            }
            else if (info == "lab2_PC")
            {
                controller.Lab2_PcPuzzleQuit();
            }
            else if (info == "lab3_enter")
            {
                (this.Parent as Floor8UDC).puzzleOn = false;
                (this.Parent.Parent as InitMenu).GetRidofPuzzleInFloor();
            }
            else if (info == "lab4_LockCase")
            {
                controller.Lab4_LockCasePuzzleQuit();
            }
        }
        private void puzzle_Load(object sender, EventArgs e)
            {
            
            if (info == "PC_2")
            {
                pc2_problem = new Label();
                pictureBox1.BackgroundImage = Properties.Resources.pc2pwd;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pc2_problem.AutoSize = true;
                pc2_problem.Font = new Font("Gulim", 30);
                pc2_problem.Top = this.Height / 5;
                pc2_problem.Left = this.Width / 5;
                this.Controls.Add(pc2_problem);
                pc2_problem.ForeColor = Color.White;
                pc2_problem.Text= (this.Parent.Parent as InitMenu).lecture2_problem;
                pc2_answer = (this.Parent.Parent as InitMenu).lecture2_answer;
                pc2_problem.Parent = pictureBox1;
                pc2_problem.BackColor = Color.Transparent;
                pc2_problem.BringToFront();

            }else if (info == "lecture2_1_enter")
            {
                pictureBox1.BackgroundImage = Properties.Resources.pwdpad;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                Label intro = new Label();
                intro.AutoSize = true;
                intro.Font = new Font("Gulim", 15, FontStyle.Bold);
                intro.ForeColor = Color.White;
                intro.Text = "1강의실 비밀번호를 아래 입력창에 입력";
                intro.Top = pictureBox1.Bottom - intro.Height - 15;
                intro.Left = pictureBox1.Left - 15;
                this.Controls.Add(intro);
                intro.Parent = pictureBox1;
                intro.BackColor = Color.Transparent;
                intro.BringToFront();
            }
            else if (info == "lab1_enter")
            {
                pictureBox1.BackgroundImage = Properties.Resources.pwdpad;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                Label intro = new Label();
                intro.AutoSize = true;
                intro.Font = new Font("Gulim", 15, FontStyle.Bold);
                intro.ForeColor = Color.White;
                intro.Text = "1연구실 비밀번호를 1234 입력";
                intro.Top = pictureBox1.Bottom - intro.Height - 15;
                intro.Left = pictureBox1.Left - 15;
                this.Controls.Add(intro);
                intro.Parent = pictureBox1;
                intro.BackColor = Color.Transparent;
                intro.BringToFront();
                lab1_pw = (this.Parent.Parent as InitMenu).Lab1PW;
            }
            else if (info == "lab2_enter")
            {
                pictureBox1.BackgroundImage = Properties.Resources.pwdpad;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                Label intro = new Label();
                intro.AutoSize = true;
                intro.Font = new Font("Gulim", 15, FontStyle.Bold);
                intro.ForeColor = Color.White;
                intro.Text = "2연구실 비밀번호를 5678 입력";
                intro.Top = pictureBox1.Bottom - intro.Height - 15;
                intro.Left = pictureBox1.Left - 15;
                this.Controls.Add(intro);
                intro.Parent = pictureBox1;
                intro.BackColor = Color.Transparent;
                intro.BringToFront();
                lab2_pw = (this.Parent.Parent as InitMenu).Lab2PW;
            }
            else if (info == "lab2_PC")
            {
                pc2_problem = new Label();
                pictureBox1.BackgroundImage = Properties.Resources.pc2pwd;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pc2_problem.AutoSize = true;
                pc2_problem.Font = new Font("Gulim", 30);
                pc2_problem.Top = this.Height / 7;
                pc2_problem.Left = this.Width / 5;
                this.Controls.Add(pc2_problem);
                pc2_problem.ForeColor = Color.White;
                pc2_problem.Text = "06 68 88 ?? 98\r\n?? 91 11 90 10";
                lab2_pc_answer = (this.Parent.Parent as InitMenu).Lab2PCPW;
                pc2_problem.Parent = pictureBox1;
                pc2_problem.BackColor = Color.Transparent;
                pc2_problem.BringToFront();

            }
            else if (info == "lab3_enter")
            {
                pictureBox1.BackgroundImage = Properties.Resources.pwdpad;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                Label intro = new Label();
                intro.AutoSize = true;
                intro.Font = new Font("Gulim", 15, FontStyle.Bold);
                intro.ForeColor = Color.White;
                intro.Text = "3연구실 비밀번호 9876 입력";
                intro.Top = pictureBox1.Bottom - intro.Height - 15;
                intro.Left = pictureBox1.Left - 15;
                this.Controls.Add(intro);
                intro.Parent = pictureBox1;
                intro.BackColor = Color.Transparent;
                intro.BringToFront();
                lab3_pw = (this.Parent.Parent as InitMenu).Lab3PW;
            }
            else if (info == "lab4_LockCase")
            {
                pictureBox1.BackgroundImage = Properties.Resources.hint;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                lab4_lockcase_answer = (this.Parent.Parent as InitMenu).Lab4LockCasePW;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
