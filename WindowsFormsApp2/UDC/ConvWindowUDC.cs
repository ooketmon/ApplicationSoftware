﻿using System;
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
    public partial class ConvWindowUDC : UserControl
    {
        public ConvWindowUDC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ConvWindowUDC_Load(object sender, EventArgs e)
        {
            nameCharacter.Parent = imgConvWin;
            nameCharacter.BackColor = Color.Transparent;


            contentConv.Parent = imgConvWin;
            contentConv.BackColor = Color.Transparent;
        }
    }
}
