﻿namespace WindowsFormsApp2.Forms
{
    partial class test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.room_lab41 = new WindowsFormsApp2.UDC.Room_lab4();
            this.SuspendLayout();
            // 
            // room_lab41
            // 
            this.room_lab41.Location = new System.Drawing.Point(3, -2);
            this.room_lab41.Name = "room_lab41";
            this.room_lab41.Size = new System.Drawing.Size(1200, 800);
            this.room_lab41.TabIndex = 0;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.room_lab41);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private UDC.Room_lab4 room_lab41;
    }
}