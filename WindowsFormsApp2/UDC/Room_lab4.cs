﻿using System;
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
    public partial class Room_lab4 : UserControl
    {

        ControlConversationUDC controller = null;
        public Room_lab4(ControlConversationUDC controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        public void Lockcase_Click(object sender, EventArgs e)
        {
            //클릭할경우 그림과 함께 정답을 입력하는 udc가 뜸
            //정답을 입력하면 시험지가 인벤토리에 생김
        }

        private void lock_case_Click(object sender, EventArgs e)
        {
            if (!StaticItem.mTest4)
            {
                controller.Lab4_LockCasePuzzle();
            }
            else
            {
                controller.Lab4_LockCasePuzzleAfterSolve();
            }
        }

        private void Room_lab4_Load(object sender, EventArgs e)
        {
            clock_roma.Parent = pictureBox1;
            clock_roma.BackColor = Color.Transparent;
        }
    }

}
