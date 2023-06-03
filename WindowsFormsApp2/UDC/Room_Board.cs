using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.UDC
{
    public partial class Room_Board : UserControl
    {
        ControlConversationUDC controller = null;
        public Room_Board(ControlConversationUDC controller)
        {
            InitializeComponent();
            this.controller = controller;

        }

        private void Poster_1_Click(object sender, EventArgs e)
        {
            controller.SecondFloorBoard1();
        }

        private void Poster_4_Click(object sender, EventArgs e)
        {
            controller.FourthFloorBoard1();
        }
    }
}
