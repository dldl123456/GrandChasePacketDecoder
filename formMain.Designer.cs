namespace GrandChasePacketDecoder
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
            this.buttonRemoveHistory = new System.Windows.Forms.Button();
            this.groupDecoder = new System.Windows.Forms.GroupBox();
            this.textDecode = new System.Windows.Forms.TextBox();
            this.textPacket = new System.Windows.Forms.TextBox();
            this.textKey = new System.Windows.Forms.TextBox();
            this.groupUtil = new System.Windows.Forms.GroupBox();
            this.textUnicodeString = new System.Windows.Forms.TextBox();
            this.textString = new System.Windows.Forms.TextBox();
            this.textIntBE = new System.Windows.Forms.TextBox();
            this.textInt = new System.Windows.Forms.TextBox();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.groupHistory.SuspendLayout();
            this.groupDecoder.SuspendLayout();
            this.groupUtil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHistory
            // 
            this.groupHistory.Controls.Add(this.listHistory);
            this.groupHistory.Controls.Add(this.buttonRemoveHistory);
            this.groupHistory.Location = new System.Drawing.Point(12, 12);
            this.groupHistory.Name = "groupHistory";
            this.groupHistory.Size = new System.Drawing.Size(252, 416);
            this.groupHistory.TabIndex = 0;
            this.groupHistory.TabStop = false;
            this.groupHistory.Text = "히스토리";
            // 
            // buttonRemoveHistory
            // 
            this.buttonRemoveHistory.Location = new System.Drawing.Point(171, 383);
            this.buttonRemoveHistory.Name = "buttonRemoveHistory";
            this.buttonRemoveHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveHistory.TabIndex = 1;
            this.buttonRemoveHistory.Text = "지우기";
            this.buttonRemoveHistory.UseVisualStyleBackColor = true;
            // 
            // groupDecoder
            // 
            this.groupDecoder.Controls.Add(this.textDecode);
            this.groupDecoder.Controls.Add(this.textPacket);
            this.groupDecoder.Controls.Add(this.textKey);
            this.groupDecoder.Location = new System.Drawing.Point(270, 12);
            this.groupDecoder.Name = "groupDecoder";
            this.groupDecoder.Size = new System.Drawing.Size(565, 416);
            this.groupDecoder.TabIndex = 1;
            this.groupDecoder.TabStop = false;
            this.groupDecoder.Text = "디코더";
            // 
            // textDecode
            // 
            this.textDecode.Location = new System.Drawing.Point(291, 47);
            this.textDecode.Multiline = true;
            this.textDecode.Name = "textDecode";
            this.textDecode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDecode.Size = new System.Drawing.Size(268, 363);
            this.textDecode.TabIndex = 2;
            // 
            // textPacket
            // 
            this.textPacket.Location = new System.Drawing.Point(6, 47);
            this.textPacket.Multiline = true;
            this.textPacket.Name = "textPacket";
            this.textPacket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPacket.Size = new System.Drawing.Size(279, 363);
            this.textPacket.TabIndex = 1;
            this.textPacket.TextChanged += new System.EventHandler(this.textPacket_TextChanged);
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(6, 20);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(553, 21);
            this.textKey.TabIndex = 0;
            this.textKey.Text = "DES 키";
            // 
            // groupUtil
            // 
            this.groupUtil.Controls.Add(this.textUnicodeString);
            this.groupUtil.Controls.Add(this.textString);
            this.groupUtil.Controls.Add(this.textIntBE);
            this.groupUtil.Controls.Add(this.textInt);
            this.groupUtil.Location = new System.Drawing.Point(12, 434);
            this.groupUtil.Name = "groupUtil";
            this.groupUtil.Size = new System.Drawing.Size(823, 44);
            this.groupUtil.TabIndex = 2;
            this.groupUtil.TabStop = false;
            // 
            // textUnicodeString
            // 
            this.textUnicodeString.Location = new System.Drawing.Point(594, 15);
            this.textUnicodeString.Name = "textUnicodeString";
            this.textUnicodeString.ReadOnly = true;
            this.textUnicodeString.Size = new System.Drawing.Size(223, 21);
            this.textUnicodeString.TabIndex = 3;
            // 
            // textString
            // 
            this.textString.Location = new System.Drawing.Point(350, 15);
            this.textString.Name = "textString";
            this.textString.ReadOnly = true;
            this.textString.Size = new System.Drawing.Size(223, 21);
            this.textString.TabIndex = 2;
            // 
            // textIntBE
            // 
            this.textIntBE.Location = new System.Drawing.Point(180, 15);
            this.textIntBE.Name = "textIntBE";
            this.textIntBE.ReadOnly = true;
            this.textIntBE.Size = new System.Drawing.Size(151, 21);
            this.textIntBE.TabIndex = 1;
            // 
            // textInt
            // 
            this.textInt.Location = new System.Drawing.Point(6, 15);
            this.textInt.Name = "textInt";
            this.textInt.ReadOnly = true;
            this.textInt.Size = new System.Drawing.Size(151, 21);
            this.textInt.TabIndex = 0;
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 12;
            this.listHistory.Location = new System.Drawing.Point(6, 20);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(240, 352);
            this.listHistory.TabIndex = 2;
            this.listHistory.DoubleClick += new System.EventHandler(this.listHistory_DoubleClick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 488);
            this.Controls.Add(this.groupUtil);
            this.Controls.Add(this.groupDecoder);
            this.Controls.Add(this.groupHistory);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "그체 패킷 디코더";
            this.groupHistory.ResumeLayout(false);
            this.groupDecoder.ResumeLayout(false);
            this.groupDecoder.PerformLayout();
            this.groupUtil.ResumeLayout(false);
            this.groupUtil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupHistory;
        private System.Windows.Forms.GroupBox groupDecoder;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.TextBox textDecode;
        private System.Windows.Forms.TextBox textPacket;
        private System.Windows.Forms.Button buttonRemoveHistory;
        private System.Windows.Forms.GroupBox groupUtil;
        private System.Windows.Forms.TextBox textUnicodeString;
        private System.Windows.Forms.TextBox textString;
        private System.Windows.Forms.TextBox textIntBE;
        private System.Windows.Forms.TextBox textInt;
        private System.Windows.Forms.ListBox listHistory;
    }
}

