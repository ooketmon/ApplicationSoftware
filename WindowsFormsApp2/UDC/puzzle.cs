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
        public puzzle(string info,ControlConversationUDC controller)
        {
            InitializeComponent();
            this.info = info;
            this.controller = controller;
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
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            if (info == "PC_2")
            {
                controller.Room2_2PuzzleQuit();
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
                string problem="";
                Random random = new Random();
                pc2_answer = random.Next(128);
                for(int i = 7; i >= 0; i--)
                {
                    problem += ((pc2_answer>>i) & 1).ToString();
                }
                pc2_problem.Text= problem;

                pc2_problem.Parent = pictureBox1;
                pc2_problem.BackColor = Color.Transparent;
                pc2_problem.BringToFront();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
