using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ElevatorChoiceUDC : UserControl
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {
                this.ElevatorChoiceUDC_KeyUp(new object[] { },new KeyEventArgs(keyData));

                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        int currentFloor = 0;
        List<Button> buttons=new List<Button>();
        int index = 0;

        public ElevatorChoiceUDC()
        {
            InitializeComponent();
        }
        public ElevatorChoiceUDC(int floor)
        {
            InitializeComponent();
            currentFloor= floor;
        }

        private void ElevatorChoiceUDC_Load(object sender, EventArgs e)
        {
            var allControls = this.Controls;

            foreach (var button in allControls)
            {
                if (button.GetType()==typeof(Label))
                {
                    continue;
                }
                if ((button as Button).Text[0] - '0' == currentFloor)
                {
                    this.Controls.Remove((Button)button);
                }
                else
                {
                    buttons.Add((Button)button);
                }
            }
        }

        private void ElevatorChoiceUDC_KeyUp(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (index <buttons.Count-1)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                    buttons[index].Focus();
                    break;
                case Keys.Right:
                    if (index>0)
                    {
                        index--;
                    }
                    else
                    {
                        index = buttons.Count-1;
                    }
                    buttons[index].Focus();
                    break;
                case Keys.Down:
                    if (index <buttons.Count-2)
                    {
                        index += 2;
                    }
                    else if (index == buttons.Count-2)
                    {
                        index = 0;
                    }
                    else
                    {
                        index =1;
                    }
                    buttons[index].Focus();
                    break;
                case Keys.Up:
                    if (index >1)
                    {
                        index -= 2;
                    }
                    else if (index ==1)
                    {
                        index = buttons.Count-1;
                    }
                    else
                    {
                        index =buttons.Count-2;
                    }
                    buttons[index].Focus();
                    break;
            }
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            switch (buttonText)
            {
                case "1F":
                    (this.Parent as InitMenu).FloorChange(1);
                    break;
                case "2F":

                    (this.Parent as InitMenu).FloorChange(2);
                    break;
                case "3F":
                    (this.Parent as InitMenu).FloorChange(3);

                    break;
                case "4F":

                    (this.Parent as InitMenu).FloorChange(4);

                    break;
                case "8F":

                    (this.Parent as InitMenu).FloorChange(8);

                    break;

            }
        }

    }
}
