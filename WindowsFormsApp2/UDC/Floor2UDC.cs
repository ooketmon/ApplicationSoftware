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
        bool roomHitTest=false;
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
            else
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
            playerMove.MovePlayerWithoutBool(e);
        }


        private void timerFloor2_Tick(object sender, EventArgs e)
        {
            //playerMove.MovePlayer();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stairs2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        ((InitMenu)this.Parent).FloorChange(3);
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
                if (x is PictureBox && (x.Name as string).StartsWith("room"))
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)&&!roomHitTest)
                    {
                        roomHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }
            }
        }


    }
}
