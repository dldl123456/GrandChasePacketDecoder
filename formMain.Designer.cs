namespace GrandChasePacketDecode
{
    partial class formMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupHistory = new System.Windows.Forms.GroupBox();
            this.listHistory = new System.Windows.Forms.ListView();
            this.groupDecoder = new System.Windows.Forms.GroupBox();
            this.textKey = new System.Windows.Forms.TextBox();
            this.textPacket = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupHistory.SuspendLayout();
            this.groupDecoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHistory
            // 
            this.groupHistory.Controls.Add(this.listHistory);
            this.groupHistory.Location = new System.Drawing.Point(12, 12);
            this.groupHistory.Name = "groupHistory";
            this.groupHistory.Size = new System.Drawing.Size(252, 416);
            this.groupHistory.TabIndex = 0;
            this.groupHistory.TabStop = false;
            this.groupHistory.Text = "히스토리";
            // 
            // listHistory
            // 
            this.listHistory.Location = new System.Drawing.Point(6, 20);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(240, 390);
            this.listHistory.TabIndex = 0;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            // 
            // groupDecoder
            // 
            this.groupDecoder.Controls.Add(this.textBox1);
            this.groupDecoder.Controls.Add(this.textPacket);
            this.groupDecoder.Controls.Add(this.textKey);
            this.groupDecoder.Location = new System.Drawing.Point(270, 12);
            this.groupDecoder.Name = "groupDecoder";
            this.groupDecoder.Size = new System.Drawing.Size(565, 416);
            this.groupDecoder.TabIndex = 1;
            this.groupDecoder.TabStop = false;
            this.groupDecoder.Text = "디코더";
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(6, 20);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(553, 21);
            this.textKey.TabIndex = 0;
            this.textKey.Text = "DES 키";
            // 
            // textPacket
            // 
            this.textPacket.Location = new System.Drawing.Point(6, 47);
            this.textPacket.Multiline = true;
            this.textPacket.Name = "textPacket";
            this.textPacket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPacket.Size = new System.Drawing.Size(279, 363);
            this.textPacket.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(268, 363);
            this.textBox1.TabIndex = 2;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 438);
            this.Controls.Add(this.groupDecoder);
            this.Controls.Add(this.groupHistory);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "그체 패킷 디코더";
            this.groupHistory.ResumeLayout(false);
            this.groupDecoder.ResumeLayout(false);
            this.groupDecoder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupHistory;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.GroupBox groupDecoder;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textPacket;
    }
}

