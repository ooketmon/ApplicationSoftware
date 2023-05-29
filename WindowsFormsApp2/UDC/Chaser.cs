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
        int chaser_speed = 3;
        public Chaser()
        {
            InitializeComponent();
        }
        public void chaser_move()
        {
            Control player = null;
            Control chaser1 = null;
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
            int player_x = player.Left;
            int player_y = player.Top;
            int chaser_x = chaser1.Left;
            int chaser_y = chaser1.Top;
            bool chaser_go_left = false;
            bool chaser_go_right = false;
            bool chaser_go_top = false;
            bool chaser_go_bottom = false;

            int diff_x = chaser_x - player_x;
            int diff_y = chaser_y - player_y;

            if (Math.Abs(diff_x) > Math.Abs(diff_y))
            {
                if (diff_x > 0)
                {
                    chaser1.Left -= chaser_speed;
                    chaser_go_left = true;
                }
                else
                {
                    chaser1.Left += chaser_speed;
                    chaser_go_right = true;
                }
            }
            else
            {
                if (diff_y > 0)
                {
                    chaser1.Top -= chaser_speed;
                    chaser_go_bottom = true;
                }
                else
                {
                    chaser1.Top += chaser_speed;
                    chaser_go_top = true;
                }
            }

            foreach (Control x in this.Parent.Controls)
            {
                if (x is PictureBox && (string)x.Name != "player" && chaser1.Bounds.IntersectsWith(x.Bounds))
                {
                    if (chaser_go_left)
                    {
                        if (diff_y > 0)
                        {
                            /*
                            chaser_go_left = false;
                            chaser_go_right = true;
                            chaser_go_bottom = true;
                            */
                            chaser1.Top -= chaser_speed;
                            chaser1.Left += chaser_speed;

                        }
                        else
                        {
                            /*
                            chaser_go_left = false;
                            chaser_go_right = true;
                            chaser_go_top = true;
                            */
                            chaser1.Top += chaser_speed;
                            chaser1.Left += chaser_speed;
                        }
                    }
                    else if (chaser_go_right)
                    {
                        if (diff_y > 0)
                        {
                            /*
                            chaser_go_right = false;
                            chaser_go_left = true;
                            chaser_go_bottom = true;
                            */
                            chaser1.Top -= chaser_speed;
                            chaser1.Left -= chaser_speed;

                        }
                        else
                        {
                            /*
                            chaser_go_right = false;
                            chaser_go_left = true;
                            chaser_go_top = true;
                            */
                            chaser1.Top += chaser_speed;
                            chaser1.Left -= chaser_speed;
                        }
                    }
                    else if (chaser_go_top)
                    {
                        if (diff_x > 0)
                        {
                            /*
                            chaser_go_top = false;
                            chaser_go_bottom = true;
                            chaser_go_left = true;
                            */
                            chaser1.Top -= chaser_speed;
                            chaser1.Left -= chaser_speed;
                            chaser_go_left = true;
                        }
                        else
                        {
                            /*
                            chaser_go_top = false;
                            chaser_go_bottom = true;
                            chaser_go_right = true;
                            */
                            chaser1.Top -= chaser_speed;
                            chaser1.Left += chaser_speed;
     
                        }
                    }
                    else if (chaser_go_bottom)
                    {
                        if (diff_x > 0)
                        {
                            /*
                            chaser_go_bottom = false;
                            chaser_go_top = true;
                            chaser_go_left = true;
                            */
                            chaser1.Top += chaser_speed;
                            chaser1.Left -= chaser_speed;
                            chaser_go_left = true;
                        }
                        else
                        {
                            /*
                            chaser_go_bottom = false;
                            chaser_go_top = true;
                            chaser_go_right = true;
                            */
                            chaser1.Top += chaser_speed;
                            chaser1.Left += chaser_speed;
                            chaser_go_right = true;
                        }
                    }

                }

            }
        }
    }
}
