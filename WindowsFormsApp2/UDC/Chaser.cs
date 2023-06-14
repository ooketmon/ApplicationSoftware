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
    public partial class Chaser : UserControl
    {
        int chaser_speed = 8;
        Control player = null;
        Control chaser1 = null;
        private int currentImageIndex = 0;
        Dictionary<Keys, Image[]> directionImages = new Dictionary<Keys, Image[]>();
        string WhoAmI = "";
        public Chaser()
        {
            InitializeComponent();
        }

        public Chaser(string info)
        {
            InitializeComponent();
            WhoAmI =info;
        }
        
        public void chaser_move()
        {
            bool chaser_go_left = false;
            bool chaser_go_right = false;
            bool chaser_go_top = false;
            bool chaser_go_bottom = false;

            int player_x = player.Left;
            int player_y = player.Top;
            int chaser_x = chaser1.Left;
            int chaser_y = chaser1.Top;

            int diff_x = chaser_x - player_x;
            int diff_y = chaser_y - player_y;





            if (Math.Abs(diff_x) > Math.Abs(diff_y))
            {
                if (diff_x > 0)
                {
                    chaser_x -= chaser_speed;
                    chaser_go_left = true;
                }
                else
                {
                    chaser_x += chaser_speed;
                    chaser_go_right = true;
                }
            }
            else
            {
                if (diff_y > 0)
                {
                    chaser_y -= chaser_speed;
                    chaser_go_top = true;
                }
                else
                {
                    chaser_y += chaser_speed;
                    chaser_go_bottom = true;
                }
            }

            Rectangle chaserBounds = new Rectangle(chaser_x, chaser_y, chaser1.Width, chaser1.Height);
            bool isCollision = false;
            foreach (Control x in this.Parent.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "obstacle"||x.Name.Contains("NPC")))
                {
                    if (chaserBounds.IntersectsWith(x.Bounds))
                    {
                        if (chaser_go_left)
                        {
                            if (diff_y > 0)
                            {
                                chaser_go_left = false;
                                chaser_go_bottom = true;
                                
                                chaser_y -= chaser_speed;
                            }
                            else
                            {
                                
                                chaser_go_left = false;
                                chaser_go_top = true;
                                
                                chaser_y += chaser_speed;
                            }
                        }
                        else if (chaser_go_right)
                        {
                            if (diff_y > 0)
                            {
                                
                                chaser_go_right = false;
                                chaser_go_top = true;
                                
                                chaser_y -= chaser_speed;

                            }
                            else
                            {
                                
                                chaser_go_right = false;
                                chaser_go_bottom = true;
                                
                                chaser_y += chaser_speed;
                            }
                        }
                        else if (chaser_go_top)
                        {
                            if (diff_x > 0)
                            {
                                
                                chaser_go_top = false;
                                chaser_go_left = true;
                                
                                chaser_x -= chaser_speed;

                            }
                            else
                            {
                                
                                chaser_go_top = false;
                                chaser_go_right = true;
                                
                                chaser_x += chaser_speed;
                     

                            }
                        }
                        else if (chaser_go_bottom)
                        {
                            if (diff_x > 0)
                            {
                                
                                chaser_go_bottom = false;
                                chaser_go_left = true;
                                
                                chaser_x -= chaser_speed;
                     
                            }
                            else
                            {
                                
                                chaser_go_bottom = false;
                                chaser_go_right = true;
                                
                                chaser_x += chaser_speed;
                            
                            }
                        }
                        isCollision = true;
                        break;
                    }
                }
                if(x is PictureBox && (string)x.Name == "player")
                {
                    if (x.Bounds.IntersectsWith(this.Bounds))
                    {
                        switch (WhoAmI)
                        {
                            case "guardman":
                                //경비원 붙잡힐 때 엔딩
                                break;
                            case "assistant":
                                //행정조교 붙잡힐 때 엔딩
                                break;
                        }
                    }
                }

            }
            Keys currentDirection = new Keys();
            if (chaser_go_left)
            {
                currentDirection = Keys.Left;
            }
            else if (chaser_go_right)
            {
                currentDirection = Keys.Right;
            }
            else if (chaser_go_bottom)
            {
                currentDirection = Keys.Down;
            }
            else if (chaser_go_top)
            {
                currentDirection = Keys.Up;
            }
            currentImageIndex = (currentImageIndex + 1) % directionImages[currentDirection].Length;
            character.Image = directionImages[currentDirection][currentImageIndex];
            if (isCollision)
            {
                if (!(chaser_go_bottom || chaser_go_top))
                {
                    chaser1.Left = chaser_x;
                }
                else if (!(chaser_go_left || chaser_go_right))
                {
                    chaser1.Top = chaser_y;
                }
            }
            else
            {
                chaser1.Top = chaser_y;
                chaser1.Left = chaser_x;
            }
        }

        private void Chaser_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Parent.Controls)
            {
                if (c.Name == "player")
                {
                    player = c;
                }
                if (c.GetType() == typeof(Chaser))
                {
                    chaser1 = c;
                }
            }
            if (WhoAmI == "guardman")
            {
                directionImages = new Dictionary<Keys, Image[]>()             {
                { Keys.Left, new Image[] { Properties.Resources.guard_left1, Properties.Resources.guard_left1, Properties.Resources.guard_left1, Properties.Resources.guard_left2, Properties.Resources.guard_left2, Properties.Resources.guard_left2, Properties.Resources.guard_left3, Properties.Resources.guard_left3, Properties.Resources.guard_left3, Properties.Resources.guard_left4, Properties.Resources.guard_left4, Properties.Resources.guard_left4 } },
                { Keys.Right, new Image[] { Properties.Resources.guard_right1, Properties.Resources.guard_right1, Properties.Resources.guard_right1, Properties.Resources.guard_right2, Properties.Resources.guard_right2, Properties.Resources.guard_right2, Properties.Resources.guard_right3, Properties.Resources.guard_right3, Properties.Resources.guard_right3, Properties.Resources.guard_right4, Properties.Resources.guard_right4, Properties.Resources.guard_right4 } },
                { Keys.Up, new Image[] { Properties.Resources.guard_back1, Properties.Resources.guard_back1, Properties.Resources.guard_back1, Properties.Resources.guard_back2, Properties.Resources.guard_back2, Properties.Resources.guard_back2, Properties.Resources.guard_back3, Properties.Resources.guard_back3, Properties.Resources.guard_back3, Properties.Resources.guard_back4, Properties.Resources.guard_back4, Properties.Resources.guard_back4 } },
                { Keys.Down, new Image[] { Properties.Resources.guard_front1, Properties.Resources.guard_front1, Properties.Resources.guard_front1, Properties.Resources.guard_front2, Properties.Resources.guard_front2, Properties.Resources.guard_front2, Properties.Resources.guard_front3, Properties.Resources.guard_front3, Properties.Resources.guard_front3, Properties.Resources.guard_front4, Properties.Resources.guard_front4, Properties.Resources.guard_front4 } }
                 };
            }
            else
            {
                directionImages = new Dictionary<Keys, Image[]>()             {
                { Keys.Left, new Image[] { Properties.Resources.assistant_left1, Properties.Resources.assistant_left1, Properties.Resources.assistant_left1, Properties.Resources.assistant_left2, Properties.Resources.assistant_left2, Properties.Resources.assistant_left2, Properties.Resources.assistant_left3, Properties.Resources.assistant_left3, Properties.Resources.assistant_left3, Properties.Resources.assistant_left4, Properties.Resources.assistant_left4, Properties.Resources.assistant_left4 } },
                { Keys.Right, new Image[] { Properties.Resources.assistant_right1, Properties.Resources.assistant_right1, Properties.Resources.assistant_right1, Properties.Resources.assistant_right2, Properties.Resources.assistant_right2, Properties.Resources.assistant_right2, Properties.Resources.assistant_right3, Properties.Resources.assistant_right3, Properties.Resources.assistant_right3, Properties.Resources.assistant_right4, Properties.Resources.assistant_right4, Properties.Resources.assistant_right4 } },
                { Keys.Up, new Image[] { Properties.Resources.assistant_back1, Properties.Resources.assistant_back1, Properties.Resources.assistant_back1, Properties.Resources.assistant_back2, Properties.Resources.assistant_back2, Properties.Resources.assistant_back2, Properties.Resources.assistant_back3, Properties.Resources.assistant_back3, Properties.Resources.assistant_back3, Properties.Resources.assistant_back4, Properties.Resources.assistant_back4, Properties.Resources.assistant_back4 } },
                { Keys.Down, new Image[] { Properties.Resources.assistant_front1, Properties.Resources.assistant_front1, Properties.Resources.assistant_front1, Properties.Resources.assistant_front2, Properties.Resources.assistant_front2, Properties.Resources.assistant_front2, Properties.Resources.assistant_front3, Properties.Resources.assistant_front3, Properties.Resources.assistant_front3, Properties.Resources.assistant_front4, Properties.Resources.assistant_front4, Properties.Resources.assistant_front4 } }
                 };
            }
        }
    }
}
