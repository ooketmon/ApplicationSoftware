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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {



                puzzle_KeyDown(new object[] { }, new KeyEventArgs(keyData));



                return true;
            }

            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
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
            checkAnswer();
        }

        public void checkAnswer()
        {
            if (textBox1.Text.Trim() == "1611")
            {
                controller.Lab4_LockCasePuzzleSolve();
            }
            else
            {
                textBox1.Text = "";
                controller.Lab4_LockCasePuzzleWrong();
            }
        }
        private void btn_quit_Click(object sender, EventArgs e)
        {
            controller.Lab4_LockCasePuzzleQuit();
        }
        private void puzzle_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void puzzle_KeyDown(object sender, KeyEventArgs e)
        {
            checkAnswer();
        }
    }
}
