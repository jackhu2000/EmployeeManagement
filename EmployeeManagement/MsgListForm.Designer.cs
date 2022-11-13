namespace EmployeeManagement
{
    partial class MsgListForm
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
            this.msgl = new System.Windows.Forms.ListView();
            this.eic = new System.Windows.Forms.ColumnHeader();
            this.mc = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.RfBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgl
            // 
            this.msgl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eic,
            this.mc,
            this.columnHeader1});
            this.msgl.FullRowSelect = true;
            this.msgl.HideSelection = false;
            this.msgl.Location = new System.Drawing.Point(64, 103);
            this.msgl.Margin = new System.Windows.Forms.Padding(2);
            this.msgl.MultiSelect = false;
            this.msgl.Name = "msgl";
            this.msgl.Size = new System.Drawing.Size(665, 428);
            this.msgl.TabIndex = 0;
            this.msgl.UseCompatibleStateImageBehavior = false;
            this.msgl.View = System.Windows.Forms.View.Details;
            this.msgl.SelectedIndexChanged += new System.EventHandler(this.msgl_SelectedIndexChanged);
            this.msgl.Click += new System.EventHandler(this.msgl_Click);
            this.msgl.DoubleClick += new System.EventHandler(this.msgl_DoubleClick);
            // 
            // eic
            // 
            this.eic.Text = "Employee Info";
            this.eic.Width = 350;
            // 
            // mc
            // 
            this.mc.Text = "Message";
            this.mc.Width = 450;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(206, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "=== Message List ===";
            // 
            // RfBtn
            // 
            this.RfBtn.Location = new System.Drawing.Point(187, 565);
            this.RfBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RfBtn.Name = "RfBtn";
            this.RfBtn.Size = new System.Drawing.Size(103, 46);
            this.RfBtn.TabIndex = 2;
            this.RfBtn.Text = "Refresh";
            this.RfBtn.UseVisualStyleBackColor = true;
            this.RfBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(420, 565);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 46);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MsgListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(781, 642);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.RfBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msgl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MsgListForm";
            this.Text = "MsgListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView msgl;
        private System.Windows.Forms.ColumnHeader eic;
        private System.Windows.Forms.ColumnHeader mc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button RfBtn;
        private System.Windows.Forms.Button Back;
    }
}