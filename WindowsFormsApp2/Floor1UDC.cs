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

namespace WindowsFormsApp2
{
    public partial class Floor1UDC : UserControl
    {
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {
                //this.UserControl1_KeyUp(new object[] {},new KeyEventArgs(keyData));
                playerMove.PlayerKeyDown(new object[] { }, new KeyEventArgs(keyData));
      
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
         
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
        }

        private void UserControl1_KeyUp(object sender, KeyEventArgs e) { playerMove.PlayerKeyUp(sender, e); }
        private void UserControl1_KeyDown(object sender, KeyEventArgs e) { playerMove.PlayerKeyDown(sender, e); }

        private void timerFloor1_Tick(object sender, EventArgs e)
        {
            playerMove.MovePlayer();
               
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stairs1")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {
                        playerisOnStair = true;
                        ((InitMenu)this.Parent).FloorChange(2);
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
            }
        }

        private void convWindowUDC1_Load(object sender, EventArgs e)
        {

        }
    }
}
