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
    public partial class Floor2 : Form
    {
        public Floor2()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Floor2_Load(object sender, EventArgs e)
        {

        }
    }
}
