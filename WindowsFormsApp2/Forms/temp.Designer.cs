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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.endingSucceed1 = new WindowsFormsApp2.UDC.EndingSucceed();
            this.SuspendLayout();
            // 
            // endingSucceed1
            // 
            this.endingSucceed1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endingSucceed1.Font = new System.Drawing.Font("굴림", 15F);
            this.endingSucceed1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endingSucceed1.Location = new System.Drawing.Point(-28, -57);
            this.endingSucceed1.Margin = new System.Windows.Forms.Padding(5);
            this.endingSucceed1.Name = "endingSucceed1";
            this.endingSucceed1.Size = new System.Drawing.Size(2100, 1333);
            this.endingSucceed1.TabIndex = 0;
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.endingSucceed1);
            this.Name = "temp";
            this.Text = "temp";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private UDC.EndingSucceed endingSucceed1;
    }
}