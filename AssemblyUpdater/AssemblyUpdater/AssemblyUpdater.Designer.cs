namespace AssemblyUpdater
{
    partial class AssemblyUpdater
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnUncheck = new System.Windows.Forms.Button();
            this.btnAssemblyUpdate = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(253, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(700, 900);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 50);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "폴더 선택";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(118, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 77);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 50);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "모두 선택";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.Location = new System.Drawing.Point(118, 77);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(100, 50);
            this.btnUncheck.TabIndex = 1;
            this.btnUncheck.Text = "모두 해제";
            this.btnUncheck.UseVisualStyleBackColor = true;
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // btnAssemblyUpdate
            // 
            this.btnAssemblyUpdate.Location = new System.Drawing.Point(12, 133);
            this.btnAssemblyUpdate.Name = "btnAssemblyUpdate";
            this.btnAssemblyUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnAssemblyUpdate.TabIndex = 1;
            this.btnAssemblyUpdate.Text = "Run";
            this.btnAssemblyUpdate.UseVisualStyleBackColor = true;
            this.btnAssemblyUpdate.Click += new System.EventHandler(this.btnAssemblyUpdate_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(118, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 50);
            this.button6.TabIndex = 1;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 217);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(14, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "주석입력";
            // 
            // AssemblyUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnAssemblyUpdate);
            this.Controls.Add(this.btnUncheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "AssemblyUpdater";
            this.Text = "AssemblyUpdater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUncheck;
        private System.Windows.Forms.Button btnAssemblyUpdate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

