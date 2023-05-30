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

    public partial class Floor8UDC : UserControl
    {
        public delegate void Chasing();

        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        bool convHitTest = false;

        List<Control> jumpscarePoint = new List<Control>();

        Chaser chaser = null;

        System.Threading.Timer chaser_timer;

        public delegate void chase_delegate();

        public Floor8UDC()
        {
            InitializeComponent();

        }
        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.ForceToStop();
            foreach (Form f in Application.OpenForms)
             {
                    if (f.GetType() == typeof(Inventory))
                    {
                        f.Close();
                        return;
                    }
            }

             ShowInventory();
            
        }

        private void ShowInventory()
        {
            // 호출할 폼의 인스턴스 생성
            Inventory inventory = new Inventory();
            // 폼을 보여줌
            inventory.Show();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {

                // playerMove.PlayerKeyDown(new object[] { }, new KeyEventArgs(keyData));
                Floor8_KeyDown(new object[] { }, new KeyEventArgs(keyData));
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
        private void Floor8_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
            if ((this.Parent as InitMenu).assistantChasing)
            {
                chaser = new Chaser();
                foreach (Control c in this.Controls)
                {
                    if ((string)c.Tag == "labenter")
                    {
                        jumpscarePoint.Add(c);
                    }
                }

                Random rand = new Random();
                Control spawnPoint = jumpscarePoint[rand.Next(jumpscarePoint.Count)];

                if (spawnPoint.Left <= 250 && spawnPoint.Top <= 300)
                {
                    chaser.Left = spawnPoint.Left + 50;
                    chaser.Top = spawnPoint.Top;
                }
                else if (spawnPoint.Left >= 800 && spawnPoint.Top <= 300)
                {
                    chaser.Left = spawnPoint.Left - 50;
                    chaser.Top = spawnPoint.Top;
                }
                else if (spawnPoint.Top > 300)
                {
                    chaser.Left = spawnPoint.Left;
                    chaser.Top = spawnPoint.Top - 50;
                }

                Controls.Add(chaser);

                chaser_timer = new System.Threading.Timer(Chaser_Move_CallBack);
                chaser_timer.Change(0, 30);

            }

        }
        private void Floor8_KeyUp(object sender, KeyEventArgs e)
        {
            playerMove.PlayerKeyUp(sender, e);
        }

        private void Floor8_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.MovePlayerWithoutBool(e);
        }

        private void timerFloor8_Tick(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ((InitMenu)this.Parent).ElevatorCall(8);
                        return;
                    }
                }
                if (x is PictureBox && ((x.Name as string).StartsWith("room") || (x.Name as string).StartsWith("board")))
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

        public void Chaser_Move_CallBack(object status)
        {
            BeginInvoke(new chase_delegate(
                () =>
                {
                    if (chaser != null)
                    {
                        chaser.chaser_move();
                    }
                }));
        }

    }

}

