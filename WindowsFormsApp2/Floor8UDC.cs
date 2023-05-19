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
        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;

        public Floor8UDC()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {

                playerMove.PlayerKeyDown(new object[] { }, new KeyEventArgs(keyData));

                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
        }
        private void UserControl5_KeyUp(object sender, KeyEventArgs e)
        {
            playerMove.PlayerKeyUp(sender, e);
        }

        private void UserControl5_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.PlayerKeyDown(sender, e);
        }

        private void timerFloor8_Tick(object sender, EventArgs e)
        {
            playerMove.MovePlayer();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "stairs2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnStair)
                    {

                    }
                }
            }
        }
    }
}
