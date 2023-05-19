using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ElevatorChoice : Form
    {
        List<Button> buttons;
        int index = 0;
        int currentFloor = 0;

        public ElevatorChoice()
        {
            InitializeComponent();
        }

        public ElevatorChoice(int floor)
        {
            InitializeComponent();
            currentFloor = floor;

        }

        private void ElevatorChoice_Load(object sender, EventArgs e)
        {
            var allControls = this.Controls;
            buttons=new List<Button>();
            foreach (var button in allControls)
            {
                if((button as Button).Text[0] - '0' != currentFloor)
                {
                    buttons.Add((Button)button);
                }
                else
                {
                    this.Controls.Remove((Button)button);
                }
            }
        }

        private void ElevatorChoice_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
                    if(index<buttons.Count)
                    {
                        index--;
                    }
                    else
                    {
                        index = 0;
                    }
                    buttons[index].Focus();
                    break;
                case Keys.Left:
                    if (index >= 0)
                    {
                        index++;
                    }
                    else
                    {
                        index = buttons.Count-1;
                    }
                    buttons[index].Focus();
                    break;
                case Keys.Up:
                    if (index < buttons.Count - 1)
                    {
                        index -= 2;
                    }
                    else if(index==buttons.Count-1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index = 1;
                    }
                    buttons[index].Focus();
                    break;
                case Keys.Down:
                    if(index > 1)
                    {
                        index += 2;
                    }else if (index == 1)
                    {
                        index=buttons.Count-1;
                    }
                    else
                    {
                        index = buttons.Count - 2;
                    }
                    buttons[index].Focus();
                    break;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            string buttonText=(sender as Button).Text;
            switch(buttonText) {
                case "1F":

                    new Floor1().Show();
                    break;
                case "2F":

                    new Floor2().Show();
                    break;
                case "3F":

                    new Floor3().Show();

                    break;
                case "4F":

                    new Floor4().Show();

                    break;
                case "8F":

                    new Floor8().Show();

                    break; 

            }
            this.Close();
        }
    }
}
