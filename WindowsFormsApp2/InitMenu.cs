using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            FloorChange(1);
        }

        public void FloorChange(int floor)
        {
            this.Controls.Clear();
            Control tmp = null;
            switch (floor)
            {
                case 1:
                    tmp = new Floor1UDC();
                    this.Controls.Add(tmp);
                    break;
                case 2:
                    tmp = new Floor2UDC();
                    this.Controls.Add(tmp);
                    break;
                case 3:
                    tmp = new Floor3UDC();
                    this.Controls.Add(tmp);
                    break;
                case 4:
                    tmp = new Floor4UDC();
                    this.Controls.Add(tmp);
                    break;
                case 8:
                    tmp = new Floor8UDC();
                    this.Controls.Add(tmp);
                    break;
            }
            tmp.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            LoginStartUDC crawling = new LoginStartUDC();


            this.Controls.Add(crawling);

            crawling.Focus();
            
        }

        private void InitMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
