using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.UDC;

namespace WindowsFormsApp2
{
    public partial class Floor3UDC : UserControl
    {
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        bool convHitTest = false;
        public bool puzzleOn = false;

        public Floor3UDC()
        {
            InitializeComponent();
            this.KeyDown += Inventory_KeyDown;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {

                UserControl3_KeyDown(new object[] { }, new KeyEventArgs(keyData));

                return true;
            }else if (keyData == Keys.I)
            {
                Inventory_KeyDown(new object[] {}, new KeyEventArgs(keyData));
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.ForceToStop();
            Form target = new Inventory(); ;
            if (e.KeyCode == Keys.I)
            {
                if ((this.Parent as InitMenu).inventory.Visible)
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
        private void UserControl3_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
        }
        private void UserControl3_KeyUp(object sender, KeyEventArgs e)
        {
            playerMove.PlayerKeyUp(sender, e);
        }

        private void UserControl3_KeyDown(object sender, KeyEventArgs e)
        {
            //playerMove.PlayerKeyDown(sender, e);
            if (!puzzleOn)
            {
                playerMove.MovePlayerWithoutBool(e);
            }
        }

        private void timerFloor3_Tick(object sender, EventArgs e)
        {
            //playerMove.MovePlayer();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stair")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        ((InitMenu)this.Parent).StairCall(3);
                        return;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ((InitMenu)this.Parent).ElevatorCall(3);
                        return;
                    }
                }
                if (x is PictureBox && ((x.Name as string)=="practice3_1"))
                {
                    if ( player.Bounds.IntersectsWith(x.Bounds)&&!convHitTest && StaticItem.mSafekey4 && !(this.Parent as InitMenu).openPractice1)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        Doorlock p = new Doorlock("practice3_1");
                        p.Left = this.Width / 2 - p.Width / 2;
                        p.Top = this.Height / 2 - p.Height / 2;
                        Controls.Add(p);
                        p.BringToFront();
                        convHitTest = false;
                        puzzleOn = true;
                        return;
                    }
                    else if(player.Bounds.IntersectsWith(x.Bounds)&&!convHitTest && !StaticItem.mSafekey4)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        MessageBox.Show("카드키로 잠겨있다.");
                        convHitTest = false;
                        break;
                    }else if(player.Bounds.IntersectsWith(x.Bounds)&&!convHitTest&&(this.Parent as InitMenu).openPractice1)
                    {
                        convHitTest = true;
                        (this.Parent as InitMenu).CallConvMode(x.Name);
                    }
                }
                if (x is PictureBox && ((x.Name as string) == "practice3_2"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && StaticItem.mSafekey4 && !(this.Parent as InitMenu).openPractice2)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        Doorlock p = new Doorlock("practice3_2");
                        p.Left = this.Width / 2 - p.Width / 2;
                        p.Top = this.Height / 2 - p.Height / 2;
                        Controls.Add(p);
                        p.BringToFront();
                        convHitTest = false;
                        puzzleOn = true;
                        return;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && !StaticItem.mSafekey4)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        MessageBox.Show("카드키로 잠겨있다.");
                        convHitTest = false;
                        break;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).openPractice2)
                    {
                        convHitTest = true;
                        (this.Parent as InitMenu).CallConvMode(x.Name);
                    }
                }

                if (x is PictureBox && ((x.Name as string) == "practice3_3"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && StaticItem.mSafekey4 && !(this.Parent as InitMenu).openPractice3)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        Doorlock p = new Doorlock("practice3_3");
                        p.Left = this.Width / 2 - p.Width / 2;
                        p.Top = this.Height / 2 - p.Height / 2;
                        Controls.Add(p);
                        p.BringToFront();
                        convHitTest = false;
                        puzzleOn = true;
                        return;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && !StaticItem.mSafekey4)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        MessageBox.Show("카드키로 잠겨있다.");
                        convHitTest = false;
                        break;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).openPractice3)
                    {
                        convHitTest = true;
                        (this.Parent as InitMenu).CallConvMode(x.Name);
                    }
                }
                if (x is PictureBox && ((x.Name as string) == "practice3_4"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && StaticItem.mSafekey4 && !(this.Parent as InitMenu).openPractice4)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        Doorlock p = new Doorlock("practice3_4");
                        p.Left = this.Width / 2 - p.Width / 2;
                        p.Top = this.Height / 2 - p.Height / 2;
                        Controls.Add(p);
                        p.BringToFront();
                        convHitTest = false;
                        puzzleOn = true;
                        return;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && !StaticItem.mSafekey4)
                    {
                        convHitTest = true;
                        player.Top -= 50;
                        MessageBox.Show("카드키로 잠겨있다.");
                        convHitTest = false;
                        break;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).openPractice4)
                    {
                        convHitTest = true;
                        (this.Parent as InitMenu).CallConvMode(x.Name);
                    }
                }
                if (x is PictureBox && (string)x.Tag == "lock")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds)&&!convHitTest) {
                        convHitTest = true;
                        player.Top += 50;
                        MessageBox.Show("이 방은 잠겨있다.");
                        convHitTest = false;
                        break;
                    
                    }
                }
            }
        }
    }
}
