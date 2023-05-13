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
            this.boxBg = new System.Windows.Forms.PictureBox();
            this.boxChar = new System.Windows.Forms.PictureBox();
            this.boxConv = new System.Windows.Forms.PictureBox();
            this.txtCName = new System.Windows.Forms.Label();
            this.txtConv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxConv)).BeginInit();
            this.SuspendLayout();
            // 
            // boxBg
            // 
            this.boxBg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxBg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boxBg.Location = new System.Drawing.Point(-4, 0);
            this.boxBg.Name = "boxBg";
            this.boxBg.Size = new System.Drawing.Size(1205, 801);
            this.boxBg.TabIndex = 0;
            this.boxBg.TabStop = false;
            // 
            // boxChar
            // 
            this.boxChar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.boxChar.Location = new System.Drawing.Point(687, 166);
            this.boxChar.Name = "boxChar";
            this.boxChar.Size = new System.Drawing.Size(300, 450);
            this.boxChar.TabIndex = 1;
            this.boxChar.TabStop = false;
            // 
            // boxConv
            // 
            this.boxConv.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.boxConv.Location = new System.Drawing.Point(-4, 584);
            this.boxConv.Name = "boxConv";
            this.boxConv.Size = new System.Drawing.Size(1205, 226);
            this.boxConv.TabIndex = 2;
            this.boxConv.TabStop = false;
            // 
            // txtCName
            // 
            this.txtCName.AutoSize = true;
            this.txtCName.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCName.Location = new System.Drawing.Point(23, 593);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(291, 28);
            this.txtCName.TabIndex = 3;
            this.txtCName.Text = "대화하는 캐릭터 이름 ";
            // 
            // txtConv
            // 
            this.txtConv.AutoSize = true;
            this.txtConv.Location = new System.Drawing.Point(28, 650);
            this.txtConv.Name = "txtConv";
            this.txtConv.Size = new System.Drawing.Size(67, 15);
            this.txtConv.TabIndex = 4;
            this.txtConv.Text = "대화내용";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 754);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1096, 754);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1096, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "SKIP";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ConvMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConv);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.boxConv);
            this.Controls.Add(this.boxChar);
            this.Controls.Add(this.boxBg);
            this.Name = "ConvMode";
            this.Text = "ConversationMode";
            ((System.ComponentModel.ISupportInitialize)(this.boxBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxConv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxBg;
        private System.Windows.Forms.PictureBox boxChar;
        private System.Windows.Forms.PictureBox boxConv;
        private System.Windows.Forms.Label txtCName;
        private System.Windows.Forms.Label txtConv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}