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

        public Room_lab4()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            //dl.Visible = false;

            //lock_case.BringToFront();
        }
        public void Lockcase_Click(object sender, EventArgs e)
        {
            //클릭할경우 그림과 함께 정답을 입력하는 udc가 뜸
            //정답을 입력하면 시험지가 인벤토리에 생김
        }

        private void lock_case_Click(object sender, EventArgs e)
        {
            //클릭시 비밀번호가 적힌 컴퓨터 화면과 입력 창이 뜨도록
            //정답을 맞출경우 코드가 적힌 화면이 등장함
            doorLockUDC1.Location = new Point(0, 0);
            doorLockUDC1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
