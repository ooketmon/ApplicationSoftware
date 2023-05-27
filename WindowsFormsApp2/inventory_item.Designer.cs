namespace WindowsFormsApp2
{
    partial class inventory_item
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
            this.btn_iclose = new System.Windows.Forms.Button();
            this.pic_Item = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iclose
            // 
            this.btn_iclose.Location = new System.Drawing.Point(115, 260);
            this.btn_iclose.Name = "btn_iclose";
            this.btn_iclose.Size = new System.Drawing.Size(70, 30);
            this.btn_iclose.TabIndex = 0;
            this.btn_iclose.Text = "닫기";
            this.btn_iclose.UseVisualStyleBackColor = true;
            // 
            // pic_Item
            // 
            this.pic_Item.Location = new System.Drawing.Point(0, 0);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(300, 250);
            this.pic_Item.TabIndex = 1;
            this.pic_Item.TabStop = false;
            // 
            // inventory_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_Item);
            this.Controls.Add(this.btn_iclose);
            this.Name = "inventory_item";
            this.Size = new System.Drawing.Size(300, 300);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iclose;
        private System.Windows.Forms.PictureBox pic_Item;
    }
}
