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
            this.st = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(208, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "=== Leave Request Table ===";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reason
            // 
            this.reason.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.reason.Location = new System.Drawing.Point(78, 242);
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
            this.surecheck.Location = new System.Drawing.Point(90, 580);
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
            this.uploadbtn.Location = new System.Drawing.Point(198, 628);
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
            this.backbtn.Location = new System.Drawing.Point(512, 628);
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
            // st
            // 
            this.st.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.st.Location = new System.Drawing.Point(99, 188);
            this.st.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.st.MinDate = new System.DateTime(2022, 11, 15, 0, 0, 0, 0);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(300, 30);
            this.st.TabIndex = 7;
            this.st.Value = new System.DateTime(2022, 11, 15, 0, 0, 0, 0);
            this.st.ValueChanged += new System.EventHandler(this.st_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(108, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(478, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duration";
            // 
            // expire
            // 
            this.expire.Location = new System.Drawing.Point(478, 188);
            this.expire.MaxLength = 1;
            this.expire.Name = "expire";
            this.expire.Size = new System.Drawing.Size(44, 30);
            this.expire.TabIndex = 11;
            this.expire.TextChanged += new System.EventHandler(this.expire_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(528, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Day(s)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmpLeaveReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(893, 732);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.st);
            this.Controls.Add(this.Notify);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.surecheck);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label1);
            this.Name = "EmpLeaveReq";
            this.Text = "EmpLeaveReq";
            this.Load += new System.EventHandler(this.EmpLeaveReq_Load);
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
        private System.Windows.Forms.DateTimePicker st;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox expire;
        private System.Windows.Forms.Label label4;
    }
}