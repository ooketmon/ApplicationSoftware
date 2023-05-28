using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class PlayerControl
    {
        private PictureBox player;
        int playerSpeed = 8;
        bool goLeft, goRight, goUp, goDown;

        private IEnumerable<Control> Controls;

        public PlayerControl(PictureBox player)
        {
            this.player = player;
        }
        public void PlayerKeyDown(object sender, KeyEventArgs e)
        {
      
            if (e.KeyCode==Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Up) goUp = true;
            if (e.KeyCode == Keys.Down) goDown = true;
        }
        public void PlayerKeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
        }
        public void MovePlayer()
        {
            
            int playerX = player.Left;
            int playerY = player.Top;

            if (goLeft && playerX > 4) { playerX -= playerSpeed; };
            if (goRight && playerX < 1014) { playerX += playerSpeed; };
            if (goUp && playerY > 4) { playerY -= playerSpeed; };
            if (goDown && playerY < 604) { playerY += playerSpeed; };

            Rectangle playerBounds = new Rectangle(playerX, playerY, player.Width, player.Height);
            bool isCollision = false;
            foreach (Control x in player.Parent.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
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

            //foreach (Control x in this.Controls)
            //{
            //    if(x is PictureBox && (string)x.Tag =="LockedDoor")
            //    {
            //        if (player.Bounds.IntersectsWith(x.Bounds))
            //        {
            //            InitMenu.collision = 1; 
            //        }
            //    }
            //}
        }


    }
}
