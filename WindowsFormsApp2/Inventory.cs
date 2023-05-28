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
        }
        private void Inventory_KeyDown(object sender, KeyEventArgs e)
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

    class Inven
    {
        bool[] inventory = new bool[11];
        

        public Inven()
        {
            for(int i = 0; i < 11; i++){
                inventory[i] = false;
            }
        }
    }

    
}
