namespace roomms
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.고객관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.방관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기계관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수입지출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.고객관리ToolStripMenuItem,
            this.방관리ToolStripMenuItem,
            this.기계관리ToolStripMenuItem,
            this.수입지출관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 고객관리ToolStripMenuItem
            // 
            this.고객관리ToolStripMenuItem.Name = "고객관리ToolStripMenuItem";
            this.고객관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.고객관리ToolStripMenuItem.Text = "고객 관리";
            this.고객관리ToolStripMenuItem.ToolTipText = "고객을 관리합니다.";
            this.고객관리ToolStripMenuItem.Click += new System.EventHandler(this.고객관리ToolStripMenuItem_Click);
            // 
            // 방관리ToolStripMenuItem
            // 
            this.방관리ToolStripMenuItem.Name = "방관리ToolStripMenuItem";
            this.방관리ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.방관리ToolStripMenuItem.Text = "방 관리";
            this.방관리ToolStripMenuItem.ToolTipText = "방을 관리합니다.";
            this.방관리ToolStripMenuItem.Click += new System.EventHandler(this.방관리ToolStripMenuItem_Click);
            // 
            // 기계관리ToolStripMenuItem
            // 
            this.기계관리ToolStripMenuItem.Name = "기계관리ToolStripMenuItem";
            this.기계관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.기계관리ToolStripMenuItem.Text = "기계 관리";
            this.기계관리ToolStripMenuItem.ToolTipText = "기계를 관리합니다.";
            this.기계관리ToolStripMenuItem.Click += new System.EventHandler(this.기계관리ToolStripMenuItem_Click);
            // 
            // 수입지출관리ToolStripMenuItem
            // 
            this.수입지출관리ToolStripMenuItem.Name = "수입지출관리ToolStripMenuItem";
            this.수입지출관리ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.수입지출관리ToolStripMenuItem.Text = "정산 ";
            this.수입지출관리ToolStripMenuItem.ToolTipText = "정산 정보를 보여줍니다.";
            this.수입지출관리ToolStripMenuItem.Click += new System.EventHandler(this.정산ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 622);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "노래방 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 고객관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 방관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기계관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수입지출관리ToolStripMenuItem;
    }
}

