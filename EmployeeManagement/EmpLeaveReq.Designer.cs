namespace EmployeeManagement
{
    partial class EmpLeaveReq
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
            this.label1 = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.RichTextBox();
            this.surecheck = new System.Windows.Forms.CheckBox();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.Notify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(208, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "=== Leave Request Table ===";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reason
            // 
            this.reason.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.reason.Location = new System.Drawing.Point(78, 141);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(736, 310);
            this.reason.TabIndex = 2;
            this.reason.Text = "Input Reason Here";
            this.reason.Click += new System.EventHandler(this.reason_Click);
            this.reason.TextChanged += new System.EventHandler(this.reason_TextChanged);
            // 
            // surecheck
            // 
            this.surecheck.AutoSize = true;
            this.surecheck.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.surecheck.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.surecheck.Location = new System.Drawing.Point(90, 479);
            this.surecheck.Name = "surecheck";
            this.surecheck.Size = new System.Drawing.Size(399, 29);
            this.surecheck.TabIndex = 3;
            this.surecheck.Text = "I\'m SURE I WANT to upload this request";
            this.surecheck.UseVisualStyleBackColor = true;
            this.surecheck.CheckedChanged += new System.EventHandler(this.surecheck_CheckedChanged);
            // 
            // uploadbtn
            // 
            this.uploadbtn.BackColor = System.Drawing.Color.Red;
            this.uploadbtn.Enabled = false;
            this.uploadbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.uploadbtn.Location = new System.Drawing.Point(198, 527);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(176, 53);
            this.uploadbtn.TabIndex = 4;
            this.uploadbtn.Text = "UPLOAD";
            this.uploadbtn.UseVisualStyleBackColor = false;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Green;
            this.backbtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backbtn.Location = new System.Drawing.Point(512, 527);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(176, 53);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "&Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Notify
            // 
            this.Notify.AutoSize = true;
            this.Notify.ForeColor = System.Drawing.Color.Red;
            this.Notify.Location = new System.Drawing.Point(371, 101);
            this.Notify.Name = "Notify";
            this.Notify.Size = new System.Drawing.Size(0, 24);
            this.Notify.TabIndex = 6;
            // 
            // EmpLeaveReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(884, 604);
            this.Controls.Add(this.Notify);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.surecheck);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label1);
            this.Name = "EmpLeaveReq";
            this.Text = "EmpLeaveReq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox reason;
        private System.Windows.Forms.CheckBox surecheck;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label Notify;
    }
}