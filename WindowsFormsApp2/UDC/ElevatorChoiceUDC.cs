using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ElevatorChoiceUDC : UserControl
    {

        string where = "";
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
        int index = 0;
        List<Button> buttons;
        public ElevatorChoiceUDC()
        {
            InitializeComponent();
            buttons = new List<Button>();
        }
        public ElevatorChoiceUDC(int floor,string where)
        {
            InitializeComponent();
            currentFloor= floor;
            buttons = new List<Button>();
            this.where = where;
        }

        private void ElevatorChoiceUDC_Load(object sender, EventArgs e)
        {
            switch (currentFloor)
            {
                case 1:
                    buttons.Add(button2);
                    buttons.Add(button3);
                    buttons.Add(button4);
                    buttons.Add(button5);
                    this.Controls.Remove(button1);
                    break;
                case 2:
                    buttons.Add(button1);
                    buttons.Add(button3);
                    buttons.Add(button4);
                    buttons.Add(button5);
                    this.Controls.Remove(button2);
                    break;
                case 3:
                    buttons.Add(button1);
                    buttons.Add(button2);
                    buttons.Add(button4);
                    buttons.Add(button5);
                    this.Controls.Remove(button3);
                    break;
                case 4:
                    buttons.Add(button1);
                    buttons.Add(button2);
                    buttons.Add(button3);
                    buttons.Add(button5);
                    this.Controls.Remove(button4);
                    break;
                case 8:
                    buttons.Add(button1);
                    buttons.Add(button2);
                    buttons.Add(button3);
                    buttons.Add(button4);
                    this.Controls.Remove(button5);
                    break; ;
            }
            //buttons.Reverse();
            index = buttons.Count-1;

        }

        private void ElevatorChoiceUDC_KeyUp(object sender, KeyEventArgs e)
        {
            switch (currentFloor) {
                case 1:
                    switch (e.KeyCode)
                    {
                        case Keys.Right:
                        case Keys.Left:
                            if (index==1)
                            {
                                index=2;
                            }
                            else if (index==2)
                            {
                                index = 1;
                            }
                            buttons[index].Focus();
                            break;
                        case Keys.Up:
                            if (index < buttons.Count - 2)
                            {
                                index += 2;
                            }
                            else if (index == buttons.Count - 2)
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
                            if (index > 1)
                            {
                                index -= 2;
                            }
                            else if (index == 1)
                            {
                                index = buttons.Count - 1;
                            }
                            else
                            {
                                index = buttons.Count - 2;
                            }
                            buttons[index].Focus();
                            break;
                    }
                    break;
                case 2:
                    switch (e.KeyCode)
                    {
                        case Keys.Right:
                        case Keys.Left:
                            if (index==1)
                            {
                                index=2;
                            }
                            else if(index==2)
                            {
                                index=1;
                            }
                            buttons[index].Focus();
                            break;
                        case Keys.Down:
                            if (index ==0 )
                            {
                                index =1;
                            }
                            else if (index==1)
                            {
                                index = 3;
                            }
                            else if(index==3)
                            {
                                index = 0;
                            }
                            buttons[index].Focus();
                            break;
                        case Keys.Up:
                            if (index==3)
                            {
                                index =1;
                            }
                            else if (index == 1)
                            {
                                index = 0;
                            }
                            else if(index==0)
                            {
                                index = 3;
                            }
                            buttons[index].Focus();
                            break;
                    }
                    break;
                case 3:
                    switch (e.KeyCode)
                    {
                        case Keys.Right:
                        case Keys.Left:
                            if (index == 0)
                            {
                                index = 1;
                            }
                            else if(index==1)
                            {
                                index=0;
                            }
                            buttons[index].Focus();
                            break;
                        case Keys.Down:
                            if (index == 0)
                            {
                                index = 3;
                            }
                            else if (index == 1)
                            {
                                index = 2;
                            }else if(index==3)
                            {
                                index = 0;
                            }
                            buttons[index].Focus();
                            break;
                        case Keys.Up:
                            if (index == 0)
                            {
                                index = 3;
                            }
                            else if (index == 3)
                            {
                                index = 0;
                            }
                            else if(index==2)
                            {
                                index = 1;
                            }
                            else
                            {
                                index = 2;
                            }
                            buttons[index].Focus();
                            break;
                    }
                    break;
                case 4:
                    switch (e.KeyCode)
                    {
                        case Keys.Right:
                        case Keys.Left:
                            if (index == 0)
                            {
                                index = 1;
                            }
                            else if (index == 1)
                            {
                                index = 0;
                            }
                            buttons[index].Focus();
                            break;
                        case Keys.Down:
                            if (index == 0)
                            {
                                index = 2;
                            }
                            else if (index == 2)
                            {
                                index = 3;
                            }
                            else if (index == 3)
                            {
                                index = 0;
                            }
                            buttons[index].Focus();
                            break;
                        case Keys.Up:
                            if (index == 3)
                            {
                                index = 2;
                            }
                            else if (index == 2)
                            {
                                index = 0;
                            }
                            else if (index == 0)
                            {
                                index = 3;
                            }
                            buttons[index].Focus();
                            break;
                    }
                    break;
                case 8:
                    switch (e.KeyCode)
                    {
                        case Keys.Right:
                        case Keys.Left:
                            if (index == 0)
                            {
                                index = 1;
                            }
                            else if (index == 1)
                            {
                                index = 0;
                            }
                            else if (index == 3)
                            {
                                index = 2;
                            }
                            else
                            {
                                index = 3;
                            }

                            buttons[index].Focus();
                            break;
                        case Keys.Down:
                        case Keys.Up:
                            if (index > 1)
                            {
                                index -= 2;
                            }
                            else if (index == 1)
                            {
                                index = 3;
                            }
                            else if (index == 0)
                            {
                                index = 2;
                            }
                            buttons[index].Focus();
                            break;
                    }
                    break;
        }
            
     }

        private void Button_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Name;
            switch (buttonText)
            {
                case "button1":
                    if ((this.Parent as InitMenu).guardmanChasing)
                    {
                        //경비아저씨 추적 이벤트
                        (this.Parent as InitMenu).CallConvMode("guardmanEvent");
                    }
                    else
                    {
                        if (where == "front")
                        {
                            (this.Parent as InitMenu).FloorChange(1);
                        }
                        else
                        {
                            (this.Parent as InitMenu).FloorChangeForBackElevator(1);
                        }
                    }
                    break;
                case "button2":
                    if (where == "front")
                    {
                        (this.Parent as InitMenu).FloorChange(2);
                    }
                    else
                    {
                        (this.Parent as InitMenu).FloorChangeForBackElevator(2);
                    }
                    break;
                case "button3":
                    if (where == "front")
                    {
                        (this.Parent as InitMenu).FloorChange(3);
                    }
                    else
                    {
                        (this.Parent as InitMenu).FloorChangeForBackElevator(3);
                    }

                    break;
                case "button4":

                    if (where == "front")
                    {
                        (this.Parent as InitMenu).FloorChange(4);
                    }
                    else
                    {
                        (this.Parent as InitMenu).FloorChangeForBackElevator(4);
                    }

                    break;
                case "button5":
                    if ((this.Parent as InitMenu).assistantChasing)
                    {
                        MessageBox.Show("빨리 나가야된다고..!");
                    }
                    else
                    {
                        if (where == "front")
                        {
                            (this.Parent as InitMenu).FloorChange(8);
                        }
                        else
                        {
                            (this.Parent as InitMenu).FloorChangeForBackElevator(8);
                        }
                    }


                    break;

            }
        }

    }
}
