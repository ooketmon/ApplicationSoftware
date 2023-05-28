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
            this.components = new System.ComponentModel.Container();
            this.btnSkip = new System.Windows.Forms.Button();
            this.contentConv = new System.Windows.Forms.Label();
            this.nameCharacter = new System.Windows.Forms.Label();
            this.timerLetter = new System.Windows.Forms.Timer(this.components);
            this.imgConvWindowBack = new System.Windows.Forms.PictureBox();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.imgCharBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWindowBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(1115, 671);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 100);
            this.btnSkip.TabIndex = 6;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // contentConv
            // 
            this.contentConv.AutoSize = true;
            this.contentConv.BackColor = System.Drawing.SystemColors.MenuText;
            this.contentConv.Font = new System.Drawing.Font("굴림", 20F);
            this.contentConv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentConv.Location = new System.Drawing.Point(9, 671);
            this.contentConv.MinimumSize = new System.Drawing.Size(1100, 100);
            this.contentConv.Name = "contentConv";
            this.contentConv.Size = new System.Drawing.Size(1100, 100);
            this.contentConv.TabIndex = 4;
            this.contentConv.Text = "contentConv";
            this.contentConv.UseWaitCursor = true;
            this.contentConv.Click += new System.EventHandler(this.contentConv_Click);
            // 
            // nameCharacter
            // 
            this.nameCharacter.AutoSize = true;
            this.nameCharacter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameCharacter.Font = new System.Drawing.Font("굴림", 20F);
            this.nameCharacter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameCharacter.Location = new System.Drawing.Point(9, 626);
            this.nameCharacter.Name = "nameCharacter";
            this.nameCharacter.Size = new System.Drawing.Size(254, 34);
            this.nameCharacter.TabIndex = 5;
            this.nameCharacter.Text = "nameCharacter";
            // 
            // timerLetter
            // 
            this.timerLetter.Tick += new System.EventHandler(this.timerLetter_Tick);
            // 
            // imgConvWindowBack
            // 
            this.imgConvWindowBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgConvWindowBack.Location = new System.Drawing.Point(-3, 617);
            this.imgConvWindowBack.Name = "imgConvWindowBack";
            this.imgConvWindowBack.Size = new System.Drawing.Size(1202, 187);
            this.imgConvWindowBack.TabIndex = 3;
            this.imgConvWindowBack.TabStop = false;
            // 
            // imgCharacter
            // 
            this.imgCharacter.BackColor = System.Drawing.Color.Transparent;
            this.imgCharacter.Location = new System.Drawing.Point(121, 226);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(289, 480);
            this.imgCharacter.TabIndex = 1;
            this.imgCharacter.TabStop = false;
            // 
            // imgCharBack
            // 
            this.imgCharBack.BackColor = System.Drawing.Color.Transparent;
            this.imgCharBack.Location = new System.Drawing.Point(147, 237);
            this.imgCharBack.Name = "imgCharBack";
            this.imgCharBack.Size = new System.Drawing.Size(289, 480);
            this.imgCharBack.TabIndex = 7;
            this.imgCharBack.TabStop = false;
            // 
            // ConvMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.contentConv);
            this.Controls.Add(this.nameCharacter);
            this.Controls.Add(this.imgConvWindowBack);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.imgCharBack);
            this.Name = "ConvMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvMode";
            this.Load += new System.EventHandler(this.ConvMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWindowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Timer timerLetter;
        public System.Windows.Forms.Label contentConv;
        public System.Windows.Forms.Label nameCharacter;
        public System.Windows.Forms.PictureBox imgCharacter;
        public System.Windows.Forms.PictureBox imgConvWindowBack;
        public System.Windows.Forms.PictureBox imgCharBack;
    }
}