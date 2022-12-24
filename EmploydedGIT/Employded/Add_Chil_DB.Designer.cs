
namespace Employded
{
    partial class Add_Chil_DB
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
            this.BirthDay_text = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.BirthSert_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BirthDay_text
            // 
            this.BirthDay_text.Location = new System.Drawing.Point(136, 159);
            this.BirthDay_text.Name = "BirthDay_text";
            this.BirthDay_text.Size = new System.Drawing.Size(236, 22);
            this.BirthDay_text.TabIndex = 21;
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(136, 120);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(236, 22);
            this.Name_text.TabIndex = 20;
            // 
            // BirthSert_text
            // 
            this.BirthSert_text.Location = new System.Drawing.Point(136, 80);
            this.BirthSert_text.Name = "BirthSert_text";
            this.BirthSert_text.Size = new System.Drawing.Size(236, 22);
            this.BirthSert_text.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Birthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label8.Location = new System.Drawing.Point(24, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "BirthSert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Creating a new child record";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(136, 217);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(102, 35);
            this.Save.TabIndex = 23;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add_Chil_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(409, 264);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDay_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.BirthSert_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "Add_Chil_DB";
            this.Text = "Add_Chil_DB";
            this.Load += new System.EventHandler(this.Add_Chil_DB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BirthDay_text;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox BirthSert_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
    }
}