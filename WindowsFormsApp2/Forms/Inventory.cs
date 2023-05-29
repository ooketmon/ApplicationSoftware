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
            Papper_1.Location = new Point(3, 10);

            Cardkey_3.BackColor = Color.Transparent;
            Cardkey_3.Parent = box_cardkey;
            Cardkey_3.Location = new Point(6, 10);

            Papper_4.BackColor = Color.Transparent;
            Papper_4.Parent = box_papper_4;
            Papper_4.Location = new Point(6, 10);

            Safecard_4.BackColor = Color.Transparent;
            Safecard_4.Parent = box_safecard;
            Safecard_4.Location = new Point(6, 10);

            Key_4.BackColor = Color.Transparent;
            Key_4.Parent = box_key;
            Key_4.Location = new Point(6, 10);

            Cardkey_5.BackColor = Color.Transparent;
            Cardkey_5.Parent = box_cardkey_2;
            Cardkey_5.Location = new Point(6, 10);

            //"Papper_1","Test_1","Test_2","Papper_3","Cardkey_3","Poster_3","Test_3","Papper_4","Safecard_4","Key_4","Test_4","Cardkey_5"
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

        }
        public void Inventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                this.Close();
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
    }
    
}
