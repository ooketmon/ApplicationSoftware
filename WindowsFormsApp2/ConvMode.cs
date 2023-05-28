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
    public partial class ConvMode : Form
    {
        public ConvMode()
        {
            InitializeComponent();
        }

        private void ConvMode_Load(object sender, EventArgs e)
        {
            nameCharacter.Parent = imgConvWindowBack;
            nameCharacter.BackColor = Color.Transparent;
            nameCharacter.Text = "please anything";

            contentConv.Parent = imgConvWindowBack;
            contentConv.BackColor = Color.Transparent;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
            //InitMenu InitMenu = new InitMenu();
            //InitMenu.FloorChange(1);
        }
    }
}
