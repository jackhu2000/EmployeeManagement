namespace EmployeeManagement
{
    partial class MsgDtlForm
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
            this.MsgBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.notify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MsgBox
            // 
            this.MsgBox.Location = new System.Drawing.Point(94, 110);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.ReadOnly = true;
            this.MsgBox.Size = new System.Drawing.Size(956, 452);
            this.MsgBox.TabIndex = 0;
            this.MsgBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(236, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Read It !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(689, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notify
            // 
            this.notify.AutoSize = true;
            this.notify.ForeColor = System.Drawing.Color.LimeGreen;
            this.notify.Location = new System.Drawing.Point(533, 50);
            this.notify.Name = "notify";
            this.notify.Size = new System.Drawing.Size(0, 24);
            this.notify.TabIndex = 3;
            // 
            // MsgDtlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1129, 752);
            this.Controls.Add(this.notify);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MsgBox);
            this.Name = "MsgDtlForm";
            this.Text = "MsgDtlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MsgBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label notify;
    }
}