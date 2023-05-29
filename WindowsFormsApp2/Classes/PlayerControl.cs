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
        int playerSpeed = 5;
        bool goLeft, goRight, goUp, goDown;

        private Dictionary<Keys, Image[]> directionImages;
        private Keys currentDirection;
        private int currentImageIndex = 0;
        private Image[] stopImages;

        private IEnumerable<Control> Controls;

        public PlayerControl(PictureBox player)
        {
            this.player = player;

            directionImages = new Dictionary<Keys, Image[]>
            {
                { Keys.Left, new Image[] { Properties.Resources.left1, Properties.Resources.left2, Properties.Resources.left3, Properties.Resources.left4 } },
                { Keys.Right, new Image[] { Properties.Resources.right1, Properties.Resources.right2, Properties.Resources.right3, Properties.Resources.right4 } },
                { Keys.Up, new Image[] { Properties.Resources.back1, Properties.Resources.back2, Properties.Resources.back3, Properties.Resources.back4 } },
                { Keys.Down, new Image[] { Properties.Resources.front1, Properties.Resources.front2, Properties.Resources.front3, Properties.Resources.front4 } }
            };
            stopImages = new Image[] { Properties.Resources.front1, Properties.Resources.back1,  Properties.Resources.left1, Properties.Resources.right1 };
            // 초기 이미지 설정
            player.Image = stopImages[0];
            currentDirection = Keys.Left;
        }
        public void PlayerKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left) { goLeft = true; currentDirection = Keys.Left; }
            if (e.KeyCode == Keys.Right) { goRight = true; currentDirection = Keys.Right; }
            if (e.KeyCode == Keys.Up) { goUp = true; currentDirection = Keys.Up; }
            if (e.KeyCode == Keys.Down) { goDown = true; currentDirection = Keys.Down; }
        }
        public void PlayerKeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left) { goLeft = false; ResetPlayerImage(); }
            if (e.KeyCode == Keys.Right) {goRight = false; ResetPlayerImage(); }
            if (e.KeyCode == Keys.Up) { goUp = false; ResetPlayerImage(); }
            if (e.KeyCode == Keys.Down) { goDown = false; ResetPlayerImage(); }
        }
        private void ResetPlayerImage()
        {
            currentImageIndex = 0;
            player.Image = directionImages[currentDirection][currentImageIndex];
        }
        public void MovePlayer()
        {
            
            int playerX = player.Left;
            int playerY = player.Top;

            if (goLeft && playerX > 4) { playerX -= playerSpeed; };
            if (goRight && playerX < 1014) { playerX += playerSpeed; };
            if (goUp && playerY > 4) { playerY -= playerSpeed; };
            if (goDown && playerY < 604) { playerY += playerSpeed; };
            
            if (!goLeft && !goRight && !goUp && !goDown)
            {
                // 정지 이미지 표시
                player.Image = stopImages[currentImageIndex];
            }
            

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
                if (!goLeft && !goRight && !goUp && !goDown)
                {
                    // 정지 이미지 표시
                    player.Image = stopImages[currentImageIndex];
                }
                else
                {
                    currentImageIndex = (currentImageIndex + 1) % directionImages[currentDirection].Length;
                    player.Image = directionImages[currentDirection][currentImageIndex];
                }
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

        public void MovePlayerWithoutBool(KeyEventArgs e)
        {
            int playerX = player.Left;
            int playerY = player.Top;
            if (e.KeyCode == Keys.Left && player.Left > 4) { playerX -= playerSpeed; currentDirection = Keys.Left;goLeft = true; };
            if (e.KeyCode == Keys.Right && player.Left < 1014) { playerX += playerSpeed; currentDirection = Keys.Right; goRight = true; };
            if (e.KeyCode == Keys.Up && player.Top > 4) { playerY -= playerSpeed; currentDirection = Keys.Up; goUp = true; };
            if (e.KeyCode == Keys.Down && player.Top < 604) { playerY += playerSpeed; currentDirection = Keys.Down; goDown = true; };

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
                if (!goLeft && !goRight && !goUp && !goDown)
                {
                    // 정지 이미지 표시
                    player.Image = stopImages[currentImageIndex];
                }
                else
                {

                        currentImageIndex++;
                        currentImageIndex = (currentImageIndex) % directionImages[currentDirection].Length;
                        player.Image = directionImages[currentDirection][currentImageIndex];
                    
                }
            }
        }


    }
}
