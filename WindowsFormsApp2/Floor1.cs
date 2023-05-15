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
        int playerSpeed = 8;
        bool goLeft, goRight, goUp, goDown;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        public Floor1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Floor1_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
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
            MovePlayer();

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Name == "stairs1")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds)&&!playerisOnStair)
                    {
                        playerisOnStair = true;
                        Floor2 floor2 = new Floor2();
                        floor2.Show();
                        this.Hide();
                        return;
                    }
                }
            }
        }
        private void MovePlayer()
        {
            int playerX = player.Left;
            int playerY = player.Top;

            if (goLeft && playerX > 4) { playerX -= playerSpeed; };
            if (goRight && playerX < 1014) { playerX += playerSpeed; };
            if (goUp&&playerY > 4) { playerY -= playerSpeed; };
            if (goDown && playerY < 604) { playerY += playerSpeed; };

            Rectangle playerBounds = new Rectangle(playerX, playerY, player.Width, player.Height);
            bool isCollision = false;
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    if (playerBounds.IntersectsWith(x.Bounds))
                    {
                        isCollision = true;
                        break;
                    }
                }
            }
            if (!isCollision)
            {
                player.Left = playerX;
                player.Top = playerY;
            }
        }
    }
}
