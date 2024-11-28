namespace roomms
{
    partial class customer
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cIDtxt = new System.Windows.Forms.TextBox();
            this.cNametxt = new System.Windows.Forms.TextBox();
            this.cPhonetxt = new System.Windows.Forms.TextBox();
            this.cTotaltxt = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(50, 47);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 27;
            this.DataGridView1.Size = new System.Drawing.Size(646, 478);
            this.DataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "연락처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "누적 사용시간";
            // 
            // cIDtxt
            // 
            this.cIDtxt.Location = new System.Drawing.Point(870, 73);
            this.cIDtxt.Name = "cIDtxt";
            this.cIDtxt.Size = new System.Drawing.Size(137, 25);
            this.cIDtxt.TabIndex = 5;
            // 
            // cNametxt
            // 
            this.cNametxt.Location = new System.Drawing.Point(870, 130);
            this.cNametxt.Name = "cNametxt";
            this.cNametxt.Size = new System.Drawing.Size(137, 25);
            this.cNametxt.TabIndex = 6;
            // 
            // cPhonetxt
            // 
            this.cPhonetxt.Location = new System.Drawing.Point(870, 189);
            this.cPhonetxt.Name = "cPhonetxt";
            this.cPhonetxt.Size = new System.Drawing.Size(137, 25);
            this.cPhonetxt.TabIndex = 7;
            // 
            // cTotaltxt
            // 
            this.cTotaltxt.Location = new System.Drawing.Point(870, 245);
            this.cTotaltxt.Name = "cTotaltxt";
            this.cTotaltxt.Size = new System.Drawing.Size(137, 25);
            this.cTotaltxt.TabIndex = 8;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(830, 328);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(80, 37);
            this.Addbtn.TabIndex = 9;
            this.Addbtn.Text = "추가";
            this.Addbtn.UseVisualStyleBackColor = true;
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(831, 385);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(80, 37);
            this.Editbtn.TabIndex = 10;
            this.Editbtn.Text = "수정";
            this.Editbtn.UseVisualStyleBackColor = true;
            // 
            // Delbtn
            // 
            this.Delbtn.Location = new System.Drawing.Point(832, 443);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(80, 37);
            this.Delbtn.TabIndex = 11;
            this.Delbtn.Text = "삭제";
            this.Delbtn.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 578);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.cTotaltxt);
            this.Controls.Add(this.cPhonetxt);
            this.Controls.Add(this.cNametxt);
            this.Controls.Add(this.cIDtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "customer";
            this.Text = "customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.customer_FormClosed);
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cIDtxt;
        private System.Windows.Forms.TextBox cNametxt;
        private System.Windows.Forms.TextBox cPhonetxt;
        private System.Windows.Forms.TextBox cTotaltxt;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Delbtn;
    }
}