namespace WindowsFormsApp2.Forms
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
            this.room_Board1 = new WindowsFormsApp2.UDC.Room_Board();
            this.SuspendLayout();
            // 
            // room_Board1
            // 
            this.room_Board1.Location = new System.Drawing.Point(0, 0);
            this.room_Board1.Name = "room_Board1";
            this.room_Board1.Size = new System.Drawing.Size(1200, 800);
            this.room_Board1.TabIndex = 0;
            // 
            // test
            // 
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.room_Board1);
            this.Name = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private UDC.DoorLockUDC passwordInptUDC1;
        private UDC.Room_Board room_Board1;
    }
}