using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steal_the_exam
{
    public partial class _3rd_floor : Form
    {
        List<Control> controls;
        public _3rd_floor()
        {
            InitializeComponent();
            var ctrl_col = this.Controls;
            var iter = ctrl_col.GetEnumerator();
            controls = new List<Control>();
            while (iter.MoveNext())
            {
                Control item = (Control)iter.Current;
                if (item.Name != "character")
                {
                    controls.Add(item);
                }
            }
            character.Left = stair_enter.Left - (character.Width);
            character.Top = stair_enter.Top;

        }
        public _3rd_floor(string place)
        {
            InitializeComponent();
            var ctrl_col = this.Controls;
            var iter = ctrl_col.GetEnumerator();
            controls = new List<Control>();
            while (iter.MoveNext())
            {
                Control item = (Control)iter.Current;
                if (item.Name != "character")
                {
                    controls.Add(item);
                }
            }
            if (place == "ele")
            {
                character.Left = ele_enter.Left + (character.Width);
                character.Top = ele_enter.Top;
            }
            if (place == "stair")
            {
                character.Left = stair_enter.Left - (character.Width);
                character.Top = stair_enter.Top;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _3rd_floor_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void _3rd_floor_KeyDown(object sender, KeyEventArgs e)
        {
            int arrow = (int)e.KeyCode;

            switch (arrow)
            {
                case 37:
                    character.Left -= 10;
                    break;
                case 38:
                    character.Top -= 10;
                    break;
                case 39:
                    character.Left += 10;
                    break;
                case 40:
                    character.Top += 10;
                    break;
            }
            foreach (Control control in controls)
            {
                if (control is Panel && character.Bounds.IntersectsWith(control.Bounds))
                {
                    switch (arrow)
                    {
                        case 37:
                            character.Left += 10;
                            break;
                        case 38:
                            character.Top += 10;
                            break;
                        case 39:
                            character.Left -= 10;
                            break;
                        case 40:
                            character.Top -= 10;
                            break;
                    }
                }
            }

        }




    }
}
