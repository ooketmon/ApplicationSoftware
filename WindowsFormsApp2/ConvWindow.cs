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
    public partial class ConvWindow : Form
    {
        public ConvWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvWindow_Load(object sender, EventArgs e)
        {
            nameCharacter.Parent = imgConvWin;
            nameCharacter.BackColor = Color.Transparent;

            contentConv.Parent = imgConvWin;
            contentConv.BackColor = Color.Transparent;
        }
    }
}


