namespace WindowsFormsApp2
{
    partial class temp
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
            this.room_department1 = new WindowsFormsApp2.UDC.Room_department();
            this.SuspendLayout();
            // 
            // room_department1

            this.room_department1.Location = new System.Drawing.Point(0, 0);
            this.room_department1.Name = "room_department1";
            this.room_department1.Size = new System.Drawing.Size(1200, 800);
            this.room_department1.TabIndex = 0;
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.room_department1);
            this.Name = "temp";
            this.Text = "temp";
            this.ResumeLayout(false);

        }

        #endregion

        private UDC.Room_department room_department1;
    }
}