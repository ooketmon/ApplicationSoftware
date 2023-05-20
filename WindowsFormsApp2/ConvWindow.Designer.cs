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
            this.nameCharacter = new System.Windows.Forms.Label();
            this.contentConv = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.imgConvWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWin)).BeginInit();
            this.SuspendLayout();
            // 
            // nameCharacter
            // 
            this.nameCharacter.AutoSize = true;
            this.nameCharacter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameCharacter.Font = new System.Drawing.Font("굴림", 20F);
            this.nameCharacter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameCharacter.Location = new System.Drawing.Point(12, 20);
            this.nameCharacter.Name = "nameCharacter";
            this.nameCharacter.Size = new System.Drawing.Size(254, 34);
            this.nameCharacter.TabIndex = 1;
            this.nameCharacter.Text = "nameCharacter";
            this.nameCharacter.Click += new System.EventHandler(this.label1_Click);
            // 
            // contentConv
            // 
            this.contentConv.AutoSize = true;
            this.contentConv.BackColor = System.Drawing.SystemColors.MenuText;
            this.contentConv.Font = new System.Drawing.Font("굴림", 20F);
            this.contentConv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentConv.Location = new System.Drawing.Point(12, 89);
            this.contentConv.MinimumSize = new System.Drawing.Size(1100, 150);
            this.contentConv.Name = "contentConv";
            this.contentConv.Size = new System.Drawing.Size(1100, 150);
            this.contentConv.TabIndex = 1;
            this.contentConv.Text = "contentConv";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(1018, 212);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 49);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1113, 212);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 49);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
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
            // imgConvWin
            // 
            this.imgConvWin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgConvWin.Location = new System.Drawing.Point(0, 0);
            this.imgConvWin.Name = "imgConvWin";
            this.imgConvWin.Size = new System.Drawing.Size(1202, 275);
            this.imgConvWin.TabIndex = 0;
            this.imgConvWin.TabStop = false;
            // 
            // ConvWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 273);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.contentConv);
            this.Controls.Add(this.nameCharacter);
            this.Controls.Add(this.imgConvWin);
            this.Location = new System.Drawing.Point(1205, 0);
            this.Name = "ConvWindow";
            this.Text = "ConvWindow";
            this.Load += new System.EventHandler(this.ConvWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgConvWin;
        private System.Windows.Forms.Label nameCharacter;
        private System.Windows.Forms.Label contentConv;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSkip;
    }
}