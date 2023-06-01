using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Floor8UDC;

namespace WindowsFormsApp2
{
    public partial class Floor1UDC : UserControl
    {
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        bool convHitTest = false;

        System.Threading.Timer wood_timer;

        public delegate void wood_delegate();


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {


                switch (msg.Msg)
                {
                    case 0x100:
                    case 0x104:
                        UserControl1_KeyDown(new object[] {},new KeyEventArgs(keyData)); break;
                    case 0x101:
                    case 0x105:
                        UserControl1_KeyUp(new object[] {},new KeyEventArgs(keyData));  break;
                }
     
                return true;
            }else if (keyData == Keys.I)
            {
                Inventory_KeyDown(new object[] {},new KeyEventArgs(keyData));
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        public Floor1UDC()
        {
            InitializeComponent();
            //this.KeyPreview = true; // KeyPreview 속성을 true로 설정
            //this.KeyDown += Inventory_KeyDown; // 이벤트 핸들러 등록
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
            wood_timer = new System.Threading.Timer(WoodCallBack);
            wood_timer.Change(0, 10);

        }

        private void UserControl1_KeyUp(object sender, KeyEventArgs e) { playerMove.PlayerKeyUp(sender, e); }
        private void UserControl1_KeyDown(object sender, KeyEventArgs e) { playerMove.PlayerKeyDown(sender, e); }

        private void timerFloor1_Tick(object sender, EventArgs e)
        {
            playerMove.MovePlayer();
               
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stair")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        ((InitMenu)this.Parent).StairCall(1);
                        return;
                    }
                }
                if (x is PictureBox && (string)x.Name == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ((InitMenu)this.Parent).ElevatorCall(1);
                        return;
                    }
                }
                if (x is PictureBox && ((x.Name as string)=="guardroom" || (x.Name as string)=="hintNPC_1"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest)
                    {
                        convHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }



            }
        }

        private void convWindowUDC1_Load(object sender, EventArgs e)
        {

        }

        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.ForceToStop();
           
            if (e.KeyCode == Keys.I)
            {
                if((this.Parent as InitMenu).inventory.Visible)
                {
                    (this.Parent as InitMenu).inventory.Hide();
                }
                else
                {
                    (this.Parent as InitMenu).inventory.Show();
                }
            }

        }

        private void ShowInventory()
        {
            // 호출할 폼의 인스턴스 생성
            Inventory inventory = new Inventory();
            // 폼을 보여줌
            inventory.Show();

        }

        private void player_Click(object sender, EventArgs e)
        {

        }
        public void WoodCallBack(object status)
        {
            BeginInvoke(new wood_delegate(
                () =>
                {
                    foreach (Control x in this.Controls)
                    {
                        if (x.Name.Equals("pic1"))
                        {
                            if (player.Bounds.IntersectsWith(x.Bounds))
                            {
                                Bitmap background_image = Properties.Resources.IMG_0808;
                                Rectangle rect = Rectangle.Intersect(x.Bounds, player.Bounds);
                                Size image_size = new Size(rect.Width, rect.Height);

                                Bitmap resized_image=new Bitmap(background_image, image_size);
                                Bitmap final_image = new Bitmap(player.Width, player.Height);
                                player.BackgroundImageLayout = ImageLayout.None;
                                if (!x.Bounds.Contains(player.Bounds)&&player.Top - x.Top < 0 && player.Left - x.Left < 0)
                                {
                                    int resized_y = 1;
                                    int resized_x = 1;
                                    for (int i = player.Height-1 ; i >=0; i--)
                                    {
                                        for (int j = player.Width-1; j >=0; j--)
                                        {
                                            if (resized_y >= resized_image.Height || resized_x>=resized_image.Width)
                                            {
                                                break;
                                            }

                                            final_image.SetPixel(j, i, resized_image.GetPixel(resized_x, resized_y));
                                            resized_x++;
                                        }
                                        resized_y++;
                                        resized_x = 0;
                                    }
                                    player.BackgroundImage = final_image;
                                }
                                else if (!x.Bounds.Contains(player.Bounds)&&player.Top - x.Top < 0)
                                {
                                    int resized_y = 1;
                                    for(int i = player.Height-1; i >= 0; i--)
                                    {
                                        for(int j = 0; j < player.Width; j++)
                                        {
                                            if(resized_y >= resized_image.Height || image_size.Width <=j)
                                            {
                                                break;
                                            }
                                    
                                            final_image.SetPixel(j, i, resized_image.GetPixel(j, resized_y));
                                            
                                        }
                                        resized_y++;
                                    }
                                    player.BackgroundImage = final_image;
                                }else if (!x.Bounds.Contains(player.Bounds)&&player.Left-x.Left<0)
                                {
                                    int resized_x = 1;
                                    for (int i = player.Width-1; i >=0; i--)
                                    {
                                        for (int j = 0; j < player.Height; j++)
                                        {
                                            if (resized_x >= resized_image.Width || image_size.Height<=j)
                                            {
                                                break;
                                            }
                                            final_image.SetPixel(i, j, resized_image.GetPixel(resized_x, j));

                                        }
                                        resized_x++;
                                    }
                                    player.BackgroundImage = final_image;
                                }
                                else
                                {
                                    player.BackgroundImage = resized_image;
                                }
                                

                                return;
                            }
                            else
                            {
                                player.BackgroundImage = null;
                                
                                return;
                            }
                        }


                    }
                }));
        }
    }
}
