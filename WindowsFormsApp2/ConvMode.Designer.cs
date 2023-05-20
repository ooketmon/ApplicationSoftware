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
            this.imgConvPlc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvPlc)).BeginInit();
            this.SuspendLayout();
            // 
            // imgChar
            // 
            this.imgChar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imgChar.Location = new System.Drawing.Point(557, 188);
            this.imgChar.Name = "imgChar";
            this.imgChar.Size = new System.Drawing.Size(363, 614);
            this.imgChar.TabIndex = 1;
            this.imgChar.TabStop = false;
            // 
            // imgConvPlc
            // 
            this.imgConvPlc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgConvPlc.Location = new System.Drawing.Point(-1, -2);
            this.imgConvPlc.Name = "imgConvPlc";
            this.imgConvPlc.Size = new System.Drawing.Size(1200, 816);
            this.imgConvPlc.TabIndex = 0;
            this.imgConvPlc.TabStop = false;
            // 
            // ConvMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.imgChar);
            this.Controls.Add(this.imgConvPlc);
            this.Name = "ConvMode";
            this.Text = "ConvMode";
            ((System.ComponentModel.ISupportInitialize)(this.imgChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvPlc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgConvPlc;
        private System.Windows.Forms.PictureBox imgChar;
    }
}