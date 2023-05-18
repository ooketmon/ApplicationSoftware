namespace WindowsFormsApp2
{
    partial class ConvMode
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
            this.imgChar = new System.Windows.Forms.PictureBox();
            this.imgPlaceBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlaceBack)).BeginInit();
            this.SuspendLayout();
            // 
            // imgChar
            // 
            this.imgChar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgChar.Image = global::WindowsFormsApp2.Properties.Resources.char_example2;
            this.imgChar.Location = new System.Drawing.Point(111, 221);
            this.imgChar.Name = "imgChar";
            this.imgChar.Size = new System.Drawing.Size(330, 473);
            this.imgChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgChar.TabIndex = 1;
            this.imgChar.TabStop = false;
            this.imgChar.Click += new System.EventHandler(this.imgChar_Click);
            // 
            // imgPlaceBack
            // 
            this.imgPlaceBack.BackColor = System.Drawing.Color.AntiqueWhite;
            this.imgPlaceBack.Location = new System.Drawing.Point(-1, -2);
            this.imgPlaceBack.MinimumSize = new System.Drawing.Size(1200, 816);
            this.imgPlaceBack.Name = "imgPlaceBack";
            this.imgPlaceBack.Size = new System.Drawing.Size(1200, 816);
            this.imgPlaceBack.TabIndex = 0;
            this.imgPlaceBack.TabStop = false;
            // 
            // ConvMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.imgChar);
            this.Controls.Add(this.imgPlaceBack);
            this.Name = "ConvMode";
            this.Text = "ConvMode";
            ((System.ComponentModel.ISupportInitialize)(this.imgChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlaceBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlaceBack;
        private System.Windows.Forms.PictureBox imgChar;
    }
}