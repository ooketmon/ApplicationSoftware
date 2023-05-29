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

            if (mPapper1 == true) { Papper_1.Visible = true; }
            else { Papper_1.Visible = false;}
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
