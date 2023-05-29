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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temp));
            this.floor1UDC1 = new WindowsFormsApp2.Floor1UDC();
            this.lecture11 = new WindowsFormsApp2.Room_lecture1();
            this.SuspendLayout();
            // 
            // floor1UDC1
            // 
            this.floor1UDC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.floor1UDC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("floor1UDC1.BackgroundImage")));
            this.floor1UDC1.Cursor = System.Windows.Forms.Cursors.Default;
            this.floor1UDC1.Location = new System.Drawing.Point(243, 3);
            this.floor1UDC1.MaximumSize = new System.Drawing.Size(1200, 800);
            this.floor1UDC1.MinimumSize = new System.Drawing.Size(1200, 800);
            this.floor1UDC1.Name = "floor1UDC1";
            this.floor1UDC1.Size = new System.Drawing.Size(1200, 800);
            this.floor1UDC1.TabIndex = 1;
            // 
            // lecture11
            // 
            this.lecture11.Location = new System.Drawing.Point(12, 23);
            this.lecture11.Name = "lecture11";
            this.lecture11.Size = new System.Drawing.Size(1003, 428);
            this.lecture11.TabIndex = 0;
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 649);
            this.Controls.Add(this.floor1UDC1);
            this.Controls.Add(this.lecture11);
            this.Name = "temp";
            this.Text = "temp";
            this.ResumeLayout(false);

        }

        #endregion

        private Room_lecture1 lecture11;
        private Floor1UDC floor1UDC1;
    }
}