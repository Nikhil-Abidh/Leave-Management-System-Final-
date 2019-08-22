namespace WebAttendence
{
    partial class UserForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addmembtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.remobebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // addmembtn
            // 
            this.addmembtn.Location = new System.Drawing.Point(485, 79);
            this.addmembtn.Name = "addmembtn";
            this.addmembtn.Size = new System.Drawing.Size(119, 41);
            this.addmembtn.TabIndex = 1;
            this.addmembtn.Text = "Add Member";
            this.addmembtn.UseVisualStyleBackColor = true;
            this.addmembtn.Click += new System.EventHandler(this.addmembtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(485, 146);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(119, 41);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.Text = "Update Info";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // remobebtn
            // 
            this.remobebtn.Location = new System.Drawing.Point(485, 222);
            this.remobebtn.Name = "remobebtn";
            this.remobebtn.Size = new System.Drawing.Size(119, 41);
            this.remobebtn.TabIndex = 3;
            this.remobebtn.Text = "Remove";
            this.remobebtn.UseVisualStyleBackColor = true;
            this.remobebtn.Click += new System.EventHandler(this.remobebtn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 486);
            this.Controls.Add(this.remobebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addmembtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addmembtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button remobebtn;
    }
}