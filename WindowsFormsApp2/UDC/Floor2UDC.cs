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
    public partial class Floor2UDC : UserControl
    {
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        bool convHitTest=false;
        public Floor2UDC()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {

              //  playerMove.PlayerKeyDown(new object[] { }, new KeyEventArgs(keyData));
              UserControl2_KeyDown(new object[] {},new KeyEventArgs(keyData));  
                return true;
            }
            else if (keyData == Keys.I)
            {
                Inventory_KeyDown(new object[] {},new KeyEventArgs(keyData));
                return true;
            }else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);

        }
        private void UserControl2_KeyUp(object sender, KeyEventArgs e)
        {
            playerMove.PlayerKeyUp(sender, e);
        }

        private void UserControl2_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.PlayerKeyDown(sender, e);
            //playerMove.MovePlayerWithoutBool(e);
        }

        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.ForceToStop();
            //Form target = null;
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
        private void timerFloor2_Tick(object sender, EventArgs e)
        {
            playerMove.MovePlayer();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stair")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        ((InitMenu)this.Parent).StairCall(2);
                        return;
                    }
                }
                if (x is PictureBox && (string)x.Name == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ((InitMenu)this.Parent).ElevatorCall(2);
                        return;
                    }
                }
                if (x is PictureBox && ((x.Name as string).StartsWith("board")|| (x.Name as string)=="meetingplace" || (x.Name as string).StartsWith("room")))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)&&!convHitTest)
                    {
                        convHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }
            }
        }


    }
}
