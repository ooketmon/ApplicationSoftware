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

    public partial class Floor8UDC : UserControl
    {
        public delegate void Chasing();

        private PlayerControl playerMove;
        bool playerisOnStair = false;
        bool playerisOnElevator = false;
        bool convHitTest = false;
        public bool puzzleOn = false;

        List<Control> jumpscarePoint = new List<Control>();

        Chaser chaser = null;

        System.Threading.Timer chaser_timer;

        public delegate void chase_delegate();

        public Floor8UDC()
        {
            InitializeComponent();

        }
        private void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            playerMove.ForceToStop();
            if (e.KeyCode == Keys.I)
            {
                if ((this.Parent as InitMenu).inventory.Visible)
                {
                    (this.Parent as InitMenu).inventory.Hide();
                }
                else
                {
                    (this.Parent as InitMenu).inventory.Show();
                }
            }

        }

        private void ShowInventory()
        {
            // 호출할 폼의 인스턴스 생성
            Inventory inventory = new Inventory();
            // 폼을 보여줌
            inventory.Show();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {

                // playerMove.PlayerKeyDown(new object[] { }, new KeyEventArgs(keyData));
                Floor8_KeyDown(new object[] { }, new KeyEventArgs(keyData));
                return true;
            }else if (keyData == Keys.I)
            {
                Inventory_KeyDown(new object[] {},new KeyEventArgs(keyData));
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void Floor8_Load(object sender, EventArgs e)
        {
            playerisOnStair = false;
            playerisOnElevator = false;
            playerMove = new PlayerControl(player);
            if ((this.Parent as InitMenu).assistantChasing)
            {
                chaser = new Chaser();
                foreach (Control c in this.Controls)
                {
                    if ((string)c.Tag == "labenter")
                    {
                        jumpscarePoint.Add(c);
                    }
                }

                Random rand = new Random();
                Control spawnPoint = jumpscarePoint[rand.Next(jumpscarePoint.Count)];

                if (spawnPoint.Left <= 250 && spawnPoint.Top <= 300)
                {
                    chaser.Left = spawnPoint.Left + 50;
                    chaser.Top = spawnPoint.Top;
                }
                else if (spawnPoint.Left >= 800 && spawnPoint.Top <= 300)
                {
                    chaser.Left = spawnPoint.Left - 50;
                    chaser.Top = spawnPoint.Top;
                }
                else if (spawnPoint.Top > 300)
                {
                    chaser.Left = spawnPoint.Left;
                    chaser.Top = spawnPoint.Top - 50;
                }

                Controls.Add(chaser);

                chaser_timer = new System.Threading.Timer(Chaser_Move_CallBack);
                chaser_timer.Change(0, 30);

            }

        }
        private void Floor8_KeyUp(object sender, KeyEventArgs e)
        {
            if (!puzzleOn)
            {
                playerMove.PlayerKeyUp(sender, e);
            }
        }

        private void Floor8_KeyDown(object sender, KeyEventArgs e)
        {
            if (!puzzleOn)
            {
                playerMove.MovePlayerWithoutBool(e);
            }

        }

        private void timerFloor8_Tick(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Name == "elevator")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !playerisOnElevator)
                    {
                        playerisOnElevator = true;
                        ((InitMenu)this.Parent).ElevatorCall(8);
                        return;
                    }
                }
                if (x is PictureBox && (x.Name as string)=="lab_1")
                {
                    if(player.Bounds.IntersectsWith(x.Bounds)&&!convHitTest&&!(this.Parent as InitMenu).knowLab1PW)
                    {
                        convHitTest = true;
                        player.Left += 70;
                        MessageBox.Show("1연구실 비밀번호를 알아와야 한다.");
                        convHitTest = false;
                        break;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).knowLab1PW && !(this.Parent as InitMenu).openLab1)
                    {
                        //퀴즈UDC 호출
                        convHitTest = true;
                        player.Left += 70;
                        puzzle p = new puzzle("lab1_enter");
                        p.Left = this.Width / 2 - p.Width / 2;
                        p.Top=this.Height/2-p.Height/2;
                        Controls.Add(p);
                        p.BringToFront();
                        convHitTest = false;
                        puzzleOn = true;
                        break;

                    }
                    else if(player.Bounds.IntersectsWith(x.Bounds)&&!convHitTest &&(this.Parent as InitMenu).openLab1)
                    {
                        convHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }
                if (x is PictureBox && (x.Name as string) == "lab_2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && !(this.Parent as InitMenu).knowLab2PW)
                    {
                        convHitTest = true;
                        player.Left += 70;
                        MessageBox.Show("2연구실 비밀번호를 알아와야 한다.");
                        convHitTest = false;
                        break;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).knowLab2PW && !(this.Parent as InitMenu).openLab2)
                    {
                        //퀴즈UDC 호출

                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).openLab2)
                    {
                        convHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }
                if (x is PictureBox && (x.Name as string) == "lab_3")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && !(this.Parent as InitMenu).knowLab3PW)
                    {
                        convHitTest = true;
                        player.Left += 70;
                        MessageBox.Show("3연구실 비밀번호를 알아와야 한다.");
                        convHitTest = false;
                        break;
                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).knowLab3PW && !(this.Parent as InitMenu).openLab3)
                    {
                        //퀴즈UDC 호출

                    }
                    else if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest && (this.Parent as InitMenu).openLab3)
                    {
                        convHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }
                if (x is PictureBox && (x.Name as string) == "lab_4")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest )
                    {
                        convHitTest = true;
                        ((InitMenu)this.Parent).CallConvMode(x.Name.ToString());
                        return;
                    }
                }
                if(x is PictureBox && !x.Name.StartsWith("lab") && (string)x.Tag=="labenter")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !convHitTest)
                    {
                        convHitTest = true;
                        if (x.Left <= 250 && x.Top <= 300)
                        {
                            player.Left += 50;
                        }
                        else if (x.Left >= 800 && x.Top <= 300)
                        {
                            player.Left -= 50;
                        }
                        else if (x.Top > 300)
                        {
                            player.Top -=50;
                        }
                        MessageBox.Show("이 연구실에는 볼 일이 없을 듯 하다.");
                        convHitTest = false;
                    }
                }
            }

        }

        public void Chaser_Move_CallBack(object status)
        {
            BeginInvoke(new chase_delegate(
                () =>
                {
                    if (chaser != null)
                    {
                        chaser.chaser_move();
                    }
                }));
        }

    }

}

