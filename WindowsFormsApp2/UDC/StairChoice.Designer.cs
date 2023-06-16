namespace WindowsFormsApp2.UDC
{
    partial class StairChoice
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Transparent;
            this.up.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.IMG_0919;
            this.up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.up.FlatAppearance.BorderSize = 0;
            this.up.Location = new System.Drawing.Point(184, 77);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(60, 60);
            this.up.TabIndex = 3;
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Transparent;
            this.down.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.IMG_0920;
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.down.FlatAppearance.BorderSize = 0;
            this.down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.down.ForeColor = System.Drawing.Color.Transparent;
            this.down.Location = new System.Drawing.Point(55, 92);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(60, 60);
            this.down.TabIndex = 2;
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // StairChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Stair;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.up);
            this.Controls.Add(this.down);
            this.DoubleBuffered = true;
            this.Name = "StairChoice";
            this.Size = new System.Drawing.Size(298, 218);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
    }
}
