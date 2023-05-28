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
    public partial class lecture1 : UserControl
    {
        public lecture1()
        {
            InitializeComponent();

            clue_example.BackColor = Color.Transparent;
            clue_example.Parent = pictureBox1;
        }

        public void clue_example_Click(object sender, EventArgs e)
        {
            // 단서 example 함수 _ 클릭 이벤트 발생시
            mPapper1 = true;
            inventory_set();
            clue_example.Visible = false;

        }
    }
}
