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
    public partial class StairChoice : UserControl
    {
        int currentFloor = 0;
        public StairChoice()
        {
            InitializeComponent();
        }
        public StairChoice(int floor)
        {
            InitializeComponent();
            currentFloor = floor;
        }

        private void StairChoiceUDC_Load(object sender, EventArgs e)
        {
        }

        private void down_Click(object sender, EventArgs e)
        {
            switch (currentFloor)
            {
                case 1: MessageBox.Show("더 내려갈 수 없어.");
                    break;
                case 2:
                    if ((this.Parent as InitMenu).guardmanChasing)
                    {
                        //경비아저씨 추적 이벤트
                        (this.Parent as InitMenu).CallConvMode("guardmanEvent");
                    }
                    else
                    {
                        (this.Parent as InitMenu).FloorChange(1);
                    }
                    break;
                case 3: (this.Parent as InitMenu).FloorChange(2); break;
                case 4: (this.Parent as InitMenu).FloorChange(3); break;
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            switch (currentFloor)
            {
                case 1: (this.Parent as InitMenu).FloorChange(2); break;
                case 2: (this.Parent as InitMenu).FloorChange(3); break;
                case 3: (this.Parent as InitMenu).FloorChange(4); break;
                case 4: MessageBox.Show("다른데나 더 둘러보자");
                    break;
            }
        }
    }
}