using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WindowsFormsApp2.StaticItem;

namespace WindowsFormsApp2
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            this.KeyDown += Inventory_KeyDown; // 이벤트 핸들러 등록

            //배경 투명하게
            Papper_1.BackColor = Color.Transparent;
            Papper_1.Parent = box_papper_1;

            Cardkey_3.BackColor = Color.Transparent;
            Cardkey_3.Parent = box_cardkey;

            Papper_4.BackColor = Color.Transparent;
            Papper_4.Parent = box_papper_4;

            Safecard_4.BackColor = Color.Transparent;
            Safecard_4.Parent = box_safecard;

            Key_4.BackColor = Color.Transparent;
            Key_4.Parent = box_key;

            //Cardkey_5.BackColor = Color.Transparent;
            //Cardkey_5.Parent = box_cardkey_2;
           
            Papper_1.Location = new Point(3, 10);
            Cardkey_3.Location = new Point(6, 10);
            Papper_4.Location = new Point(6, 10);
            Safecard_4.Location = new Point(6, 10);
            Key_4.Location = new Point(6, 10);
            //Cardkey_5.Location = new Point(6, 10);

            Papper_1.Size = new Size(60, 60);
            Test_1.Size = new Size(50, 60);
            Test_2.Size = new Size(50, 60);
            Papper_3.Size = new Size(60, 60);
            Cardkey_3.Size = new Size(75, 60);
            Poster_3.Size = new Size(50, 60);
            Test_3.Size = new Size(50, 60);
            Papper_4.Size = new Size(60, 60);
            Safecard_4.Size = new Size(75, 60);
            Key_4.Size = new Size(75, 75);
            Test_4.Size = new Size(50, 60);
            //Cardkey_5.Size = new Size(75, 60);

            //"Papper_1","Test_1","Test_2","Papper_3","Cardkey_3","Poster_3","Test_3","Papper_4","Safecard_4","Key_4","Test_4","Cardkey_5"

            /*
            if (inventory[0] == true) { Papper_1.Visible = true; }
            else { Papper_1.Visible = false;}
            if (inventory[1] == true) { Test_1.Visible = true; }
            else { Test_1.Visible = false; }
            if (inventory[2] == true) { Test_2.Visible = true; }
            else { Test_2.Visible = false; }
            if (inventory[3] == true) { Papper_3.Visible = true; }
            else { Papper_3.Visible = false; }
            if (inventory[4] == true) { Cardkey_3.Visible = true; }
            else { Cardkey_3.Visible = false; }
            if (inventory[5] == true) { Poster_3.Visible = true; }
            else { Poster_3.Visible = false; }
            if (inventory[6] == true) { Test_3.Visible = true; }
            else { Test_3.Visible = false; }
            if (inventory[7] == true) { Papper_4.Visible = true; }
            else { Papper_4.Visible = false; }
            if (inventory[8] == true) { Safecard_4.Visible = true; }
            else { Safecard_4.Visible = false; }
            if (inventory[9] == true) { Key_4.Visible = true; }
            else { Key_4.Visible = false; }
            if (inventory[10] == true) { Test_4.Visible = true; }
            else { Test_4.Visible = false; }
            if (inventory[11] == true) { Cardkey_5.Visible = true; }
            else { Cardkey_5.Visible = false; }
            */

        }
        public void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                this.Hide();
            }
        }

        public void CancelMaximize()
        {
            Control target = null;
            foreach(Control c in this.Controls)
            {
                if (c.GetType() == typeof(inventory_item))
                {
                    target = c;
                    break;
                }
            }
            Controls.Remove(target);
            this.Focus();
        }
        public void Item_Press(object sender, EventArgs e)
        {
            string itemName = (sender as Control).Name;
            inventory_item maximizedItem=new inventory_item();
            
            Bitmap resourceName = null;
            string description = "";
            if (itemName == items[0] && inventory[0])
            {
                resourceName = Properties.Resources._1_Papper;
                description = "찢어진 포스터 조각이다.";
            } else if (itemName == items[1] && inventory[1])
            {
                MessageBox.Show(string.Format("{0} 시험지다."), STUDENT_INFO.low_grade_courses[0]);
                return;
            }
            else if (itemName == items[2] && inventory[2])
            {
                MessageBox.Show(string.Format("{0} 시험지다."), STUDENT_INFO.low_grade_courses[1]);
                return;
            }
            else if (itemName == items[3] && inventory[3])
            {
                resourceName = Properties.Resources._3_Papper;
                description = "알 수 없는 글이다. 이리저리 조합해보자.";

            } else if (itemName == items[4] && inventory[4])
            {
                MessageBox.Show(string.Format("강의실에 쓰는 키인 듯 하다."));
                return;
            }
            else if (itemName == items[5] && inventory[5])
            {
                resourceName = Properties.Resources._3_Poster;
                description = "연구실 홍보 포스터다.";
            } else if (itemName == items[6] && inventory[6])
            {
                MessageBox.Show(string.Format("{0} 시험지다."), STUDENT_INFO.low_grade_courses[2]);
                return;
            }
            else if (itemName == items[7] && inventory[7])
            {
                resourceName = Properties.Resources._4_Papper_open;
                description = "조교님이 쓰신 쪽지다.";
            }
            else if (itemName == items[8] && inventory[8])
            {
                resourceName = Properties.Resources._4_Safecard;
            } else if (itemName == items[9] && inventory[9]) {
                MessageBox.Show(string.Format("연구실에 쓰는 열쇠인 거 같다."));
                return;
            } else if (itemName == items[10] && inventory[10])
            {
                MessageBox.Show(string.Format("{0} 시험지다."), STUDENT_INFO.low_grade_courses[3]);
                return;
            }
            /*
            else if (itemName == items[11] && inventory[11])
            {
                resourceName = Properties.Resources._5_Cardkey_;
            }*/
            else
            {
                return;
            }
            
            maximizedItem.setMainItem(resourceName,description);
            Controls.Add(maximizedItem);

            maximizedItem.Dock = DockStyle.Fill;
            maximizedItem.BringToFront();


        }

        public void Inventory_ItemVisibility_Check()
        {
            inventory_set();
            if (inventory[0] == true) { Papper_1.Visible = true; }
            else { Papper_1.Visible = false; }
            if (inventory[1] == true) { Test_1.Visible = true; }
            else { Test_1.Visible = false; }
            if (inventory[2] == true) { Test_2.Visible = true; }
            else { Test_2.Visible = false; }
            if (inventory[3] == true) { Papper_3.Visible = true; }
            else { Papper_3.Visible = false; }
            if (inventory[4] == true) { Cardkey_3.Visible = true; }
            else { Cardkey_3.Visible = false; }
            if (inventory[5] == true) { Poster_3.Visible = true; }
            else { Poster_3.Visible = false; }
            if (inventory[6] == true) { Test_3.Visible = true; }
            else { Test_3.Visible = false; }
            if (inventory[7] == true) { Papper_4.Visible = true; }
            else { Papper_4.Visible = false; }
            if (inventory[8] == true) { Safecard_4.Visible = true; }
            else { Safecard_4.Visible = false; }
            if (inventory[9] == true) { Key_4.Visible = true; }
            else { Key_4.Visible = false; }
            if (inventory[10] == true) { Test_4.Visible = true; }
            else { Test_4.Visible = false; }
            /*
            if (inventory[11] == true) { Cardkey_5.Visible = true; }
            else { Cardkey_5.Visible = false; }*/
            
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            Inventory_ItemVisibility_Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void box_cardkey_Click(object sender, EventArgs e)
        {

        }

        private void box_test_2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
