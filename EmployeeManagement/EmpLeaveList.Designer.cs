namespace EmployeeManagement
{
    partial class EmpLeaveList
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
            this.lrview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.rfbtn = new System.Windows.Forms.Button();
            this.bkbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lrview
            // 
            this.lrview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lrview.FullRowSelect = true;
            this.lrview.HideSelection = false;
            this.lrview.Location = new System.Drawing.Point(76, 103);
            this.lrview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lrview.MultiSelect = false;
            this.lrview.Name = "lrview";
            this.lrview.Size = new System.Drawing.Size(644, 454);
            this.lrview.TabIndex = 0;
            this.lrview.UseCompatibleStateImageBehavior = false;
            this.lrview.View = System.Windows.Forms.View.Details;
            this.lrview.DoubleClick += new System.EventHandler(this.lrview_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name(Department)";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reason";
            this.columnHeader2.Width = 710;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(257, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "=== Leave Request List ===";
            // 
            // rfbtn
            // 
            this.rfbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.rfbtn.Location = new System.Drawing.Point(193, 599);
            this.rfbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rfbtn.Name = "rfbtn";
            this.rfbtn.Size = new System.Drawing.Size(116, 44);
            this.rfbtn.TabIndex = 2;
            this.rfbtn.Text = "&Refresh";
            this.rfbtn.UseVisualStyleBackColor = false;
            this.rfbtn.Click += new System.EventHandler(this.rfbtn_Click);
            // 
            // bkbtn
            // 
            this.bkbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.bkbtn.Location = new System.Drawing.Point(488, 599);
            this.bkbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bkbtn.Name = "bkbtn";
            this.bkbtn.Size = new System.Drawing.Size(116, 44);
            this.bkbtn.TabIndex = 3;
            this.bkbtn.Text = "&Back";
            this.bkbtn.UseVisualStyleBackColor = false;
            this.bkbtn.Click += new System.EventHandler(this.bkbtn_Click);
            // 
            // EmpLeaveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(790, 674);
            this.Controls.Add(this.bkbtn);
            this.Controls.Add(this.rfbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lrview);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmpLeaveList";
            this.Text = "EmpLeaveList";
            this.Load += new System.EventHandler(this.EmpLeaveList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lrview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rfbtn;
        private System.Windows.Forms.Button bkbtn;
    }
}