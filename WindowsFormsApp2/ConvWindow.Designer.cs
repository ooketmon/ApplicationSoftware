namespace WindowsFormsApp2
{
    partial class ConvWindow
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
            this.imgConvBg = new System.Windows.Forms.PictureBox();
            this.txtCharName = new System.Windows.Forms.Label();
            this.txtConv = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvBg)).BeginInit();
            this.SuspendLayout();
            // 
            // imgConvBg
            // 
            this.imgConvBg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgConvBg.Location = new System.Drawing.Point(0, 0);
            this.imgConvBg.Name = "imgConvBg";
            this.imgConvBg.Size = new System.Drawing.Size(1202, 275);
            this.imgConvBg.TabIndex = 0;
            this.imgConvBg.TabStop = false;
            // 
            // txtCharName
            // 
            this.txtCharName.AutoSize = true;
            this.txtCharName.Font = new System.Drawing.Font("굴림", 20F);
            this.txtCharName.Location = new System.Drawing.Point(12, 20);
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(218, 34);
            this.txtCharName.TabIndex = 1;
            this.txtCharName.Text = "txtCharName";
            // 
            // txtConv
            // 
            this.txtConv.AutoSize = true;
            this.txtConv.Font = new System.Drawing.Font("굴림", 20F);
            this.txtConv.Location = new System.Drawing.Point(12, 89);
            this.txtConv.MinimumSize = new System.Drawing.Size(1100, 150);
            this.txtConv.Name = "txtConv";
            this.txtConv.Size = new System.Drawing.Size(1100, 150);
            this.txtConv.TabIndex = 1;
            this.txtConv.Text = "txtConv";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1113, 171);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 49);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "▼";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(1113, 12);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 27);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(1113, 103);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 49);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "▲";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // ConvWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 273);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtConv);
            this.Controls.Add(this.txtCharName);
            this.Controls.Add(this.imgConvBg);
            this.Name = "ConvWindow";
            this.Text = "ConvWindow";
            ((System.ComponentModel.ISupportInitialize)(this.imgConvBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgConvBg;
        private System.Windows.Forms.Label txtConv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label txtCharName;
        private System.Windows.Forms.Button btnPrev;
    }
}