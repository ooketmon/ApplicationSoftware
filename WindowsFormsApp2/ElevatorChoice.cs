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
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
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

        }

        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(53, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 39);
            this.button5.TabIndex = 1;
            this.button5.Text = "8F";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(183, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "4F";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "3F";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "2F";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "1F";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ElevatorChoice
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ElevatorChoice";
            this.ResumeLayout(false);

        }
    }
}
