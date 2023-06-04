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
    public partial class ShowCode : UserControl
    {
        ControlConversationUDC controller;
        public ShowCode(ControlConversationUDC c)
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            controller = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.SecondFloorCodeOff();
        }
    }
}
