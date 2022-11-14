namespace EmployeeManagement
{
    partial class EmpLeaveDtl
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
            this.content = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nl = new System.Windows.Forms.Label();
            this.el = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accc = new System.Windows.Forms.CheckBox();
            this.rejc = new System.Windows.Forms.CheckBox();
            this.accbtn = new System.Windows.Forms.Button();
            this.rejbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Notify = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ed = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Enabled = false;
            this.content.Location = new System.Drawing.Point(107, 242);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(780, 385);
            this.content.TabIndex = 0;
            this.content.Text = "";
            this.content.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(151, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nl
            // 
            this.nl.AutoSize = true;
            this.nl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nl.Location = new System.Drawing.Point(223, 136);
            this.nl.Name = "nl";
            this.nl.Size = new System.Drawing.Size(62, 24);
            this.nl.TabIndex = 2;
            this.nl.Text = "Name";
            // 
            // el
            // 
            this.el.AutoSize = true;
            this.el.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.el.Location = new System.Drawing.Point(601, 136);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(62, 24);
            this.el.TabIndex = 4;
            this.el.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(478, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "EmployeeID : ";
            // 
            // accc
            // 
            this.accc.AutoSize = true;
            this.accc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accc.Location = new System.Drawing.Point(128, 663);
            this.accc.Name = "accc";
            this.accc.Size = new System.Drawing.Size(164, 28);
            this.accc.TabIndex = 5;
            this.accc.Text = "Choose Accept";
            this.accc.UseVisualStyleBackColor = true;
            this.accc.Click += new System.EventHandler(this.accc_Click);
            // 
            // rejc
            // 
            this.rejc.AutoSize = true;
            this.rejc.Checked = true;
            this.rejc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rejc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rejc.Location = new System.Drawing.Point(422, 663);
            this.rejc.Name = "rejc";
            this.rejc.Size = new System.Drawing.Size(157, 28);
            this.rejc.TabIndex = 6;
            this.rejc.Text = "Choose Reject";
            this.rejc.UseVisualStyleBackColor = true;
            this.rejc.CheckedChanged += new System.EventHandler(this.rejc_CheckedChanged);
            this.rejc.Click += new System.EventHandler(this.rejc_Click);
            // 
            // accbtn
            // 
            this.accbtn.BackColor = System.Drawing.Color.Red;
            this.accbtn.Enabled = false;
            this.accbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accbtn.Location = new System.Drawing.Point(128, 730);
            this.accbtn.Name = "accbtn";
            this.accbtn.Size = new System.Drawing.Size(182, 47);
            this.accbtn.TabIndex = 7;
            this.accbtn.Text = "Accept";
            this.accbtn.UseVisualStyleBackColor = false;
            this.accbtn.Click += new System.EventHandler(this.accbtn_Click);
            // 
            // rejbtn
            // 
            this.rejbtn.BackColor = System.Drawing.Color.Green;
            this.rejbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rejbtn.Location = new System.Drawing.Point(422, 730);
            this.rejbtn.Name = "rejbtn";
            this.rejbtn.Size = new System.Drawing.Size(182, 47);
            this.rejbtn.TabIndex = 8;
            this.rejbtn.Text = "Reject";
            this.rejbtn.UseVisualStyleBackColor = false;
            this.rejbtn.Click += new System.EventHandler(this.rejbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Black;
            this.backbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backbtn.Location = new System.Drawing.Point(705, 730);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(182, 47);
            this.backbtn.TabIndex = 9;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(233, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "=== Leave Request Handle ===";
            // 
            // Notify
            // 
            this.Notify.AutoSize = true;
            this.Notify.BackColor = System.Drawing.Color.Navy;
            this.Notify.ForeColor = System.Drawing.Color.Crimson;
            this.Notify.Location = new System.Drawing.Point(705, 665);
            this.Notify.Name = "Notify";
            this.Notify.Size = new System.Drawing.Size(64, 24);
            this.Notify.TabIndex = 11;
            this.Notify.Text = "Notify";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(128, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "StartDate";
            // 
            // sd
            // 
            this.sd.Enabled = false;
            this.sd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sd.Location = new System.Drawing.Point(233, 187);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(180, 30);
            this.sd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(460, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "EndDate";
            // 
            // ed
            // 
            this.ed.Enabled = false;
            this.ed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ed.Location = new System.Drawing.Point(550, 187);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(180, 30);
            this.ed.TabIndex = 15;
            // 
            // EmpLeaveDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(996, 839);
            this.Controls.Add(this.ed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Notify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.rejbtn);
            this.Controls.Add(this.accbtn);
            this.Controls.Add(this.rejc);
            this.Controls.Add(this.accc);
            this.Controls.Add(this.el);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content);
            this.Name = "EmpLeaveDtl";
            this.Text = "EmpLeaveDtl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nl;
        private System.Windows.Forms.Label el;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox accc;
        private System.Windows.Forms.CheckBox rejc;
        private System.Windows.Forms.Button accbtn;
        private System.Windows.Forms.Button rejbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Notify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker sd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ed;
    }
}