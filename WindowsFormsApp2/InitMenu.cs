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
    public partial class InitMenu : Form
    {
        public InitMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new Floor1().Show();
            this.Hide();
        }
    }
}
