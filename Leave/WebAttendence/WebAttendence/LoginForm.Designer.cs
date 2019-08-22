namespace WebAttendence
{
    partial class LoginForm
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
            this.maillabel = new System.Windows.Forms.Label();
            this.pwlabel = new System.Windows.Forms.Label();
            this.mailtext = new System.Windows.Forms.TextBox();
            this.pwtext = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maillabel
            // 
            this.maillabel.Location = new System.Drawing.Point(30, 60);
            this.maillabel.Name = "maillabel";
            this.maillabel.Size = new System.Drawing.Size(100, 23);
            this.maillabel.TabIndex = 0;
            this.maillabel.Text = "Email";
            this.maillabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwlabel
            // 
            this.pwlabel.Location = new System.Drawing.Point(30, 108);
            this.pwlabel.Name = "pwlabel";
            this.pwlabel.Size = new System.Drawing.Size(100, 23);
            this.pwlabel.TabIndex = 1;
            this.pwlabel.Text = "Password";
            // 
            // mailtext
            // 
            this.mailtext.Location = new System.Drawing.Point(153, 57);
            this.mailtext.Multiline = true;
            this.mailtext.Name = "mailtext";
            this.mailtext.Size = new System.Drawing.Size(162, 33);
            this.mailtext.TabIndex = 2;
            // 
            // pwtext
            // 
            this.pwtext.Location = new System.Drawing.Point(153, 105);
            this.pwtext.Multiline = true;
            this.pwtext.Name = "pwtext";
            this.pwtext.Size = new System.Drawing.Size(162, 33);
            this.pwtext.TabIndex = 3;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(98, 163);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(92, 34);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pwtext);
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.maillabel);
            this.panel1.Controls.Add(this.pwlabel);
            this.panel1.Controls.Add(this.mailtext);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 262);
            this.panel1.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(391, 288);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label maillabel;
        private System.Windows.Forms.Label pwlabel;
        private System.Windows.Forms.TextBox mailtext;
        private System.Windows.Forms.TextBox pwtext;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

