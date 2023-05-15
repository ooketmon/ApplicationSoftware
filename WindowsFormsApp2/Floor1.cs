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
    public partial class Floor1 : Form
    {
        int playerSpeed = 10;
        bool goLeft, goRight, goUp, goDown;
        public Floor1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Up) goUp = true;
            if (e.KeyCode == Keys.Down) goDown = true;
        }

        private void Play_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
        }

        private void timerGMain_Tick(object sender, EventArgs e) //게임 메인 타이머
        {
            if (goLeft==true&&player.Left>0) player.Left -= playerSpeed;
            if (goRight==true&&player.Left<1160) player.Left += playerSpeed;
            if (goUp==true&&player.Top>0) player.Top -= playerSpeed;
            if (goDown==true&&player.Top<755) player.Top += playerSpeed;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Name == "stairs1")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds))
                    {
                        new Floor2().Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
