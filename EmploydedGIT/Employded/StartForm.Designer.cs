namespace Employded
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employes_ViewDataSet = new Employded.Employes_ViewDataSet();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employesTableAdapter = new Employded.Employes_ViewDataSetTableAdapters.employesTableAdapter();
            this.text_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gender_Combo = new System.Windows.Forms.ComboBox();
            this.Amount_text = new System.Windows.Forms.TextBox();
            this.Position_text = new System.Windows.Forms.TextBox();
            this.Birthday_text = new System.Windows.Forms.TextBox();
            this.Pasp_text = new System.Windows.Forms.TextBox();
            this.FIO_text = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.upd_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employes_ViewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employes_ViewDataSet
            // 
            this.employes_ViewDataSet.DataSetName = "Employes_ViewDataSet";
            this.employes_ViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "employes";
            this.employesBindingSource.DataSource = this.employes_ViewDataSet;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(770, 21);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(211, 40);
            this.text_search.TabIndex = 1;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(115, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employes View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.dataGridView1.Location = new System.Drawing.Point(118, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 356);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ID_text);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Gender_Combo);
            this.panel1.Controls.Add(this.Amount_text);
            this.panel1.Controls.Add(this.Position_text);
            this.panel1.Controls.Add(this.Birthday_text);
            this.panel1.Controls.Add(this.Pasp_text);
            this.panel1.Controls.Add(this.FIO_text);
            this.panel1.Location = new System.Drawing.Point(45, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 338);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label8.Location = new System.Drawing.Point(3, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gender";
            // 
            // ID_text
            // 
            this.ID_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ID_text.Location = new System.Drawing.Point(149, 17);
            this.ID_text.Name = "ID_text";
            this.ID_text.ReadOnly = true;
            this.ID_text.Size = new System.Drawing.Size(408, 22);
            this.ID_text.TabIndex = 13;
            this.ID_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label7.Location = new System.Drawing.Point(3, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Amount of children";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "FIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label5.Location = new System.Drawing.Point(3, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pasport data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label3.Location = new System.Drawing.Point(3, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // Gender_Combo
            // 
            this.Gender_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gender_Combo.FormattingEnabled = true;
            this.Gender_Combo.Location = new System.Drawing.Point(149, 274);
            this.Gender_Combo.Name = "Gender_Combo";
            this.Gender_Combo.Size = new System.Drawing.Size(408, 24);
            this.Gender_Combo.TabIndex = 5;
            // 
            // Amount_text
            // 
            this.Amount_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Amount_text.Location = new System.Drawing.Point(199, 229);
            this.Amount_text.Name = "Amount_text";
            this.Amount_text.Size = new System.Drawing.Size(358, 22);
            this.Amount_text.TabIndex = 4;
            this.Amount_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Position_text
            // 
            this.Position_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Position_text.Location = new System.Drawing.Point(149, 185);
            this.Position_text.Name = "Position_text";
            this.Position_text.Size = new System.Drawing.Size(408, 22);
            this.Position_text.TabIndex = 3;
            this.Position_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Birthday_text
            // 
            this.Birthday_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Birthday_text.Location = new System.Drawing.Point(149, 140);
            this.Birthday_text.Name = "Birthday_text";
            this.Birthday_text.Size = new System.Drawing.Size(408, 22);
            this.Birthday_text.TabIndex = 2;
            this.Birthday_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pasp_text
            // 
            this.Pasp_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Pasp_text.Location = new System.Drawing.Point(149, 99);
            this.Pasp_text.Name = "Pasp_text";
            this.Pasp_text.Size = new System.Drawing.Size(408, 22);
            this.Pasp_text.TabIndex = 1;
            this.Pasp_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FIO_text
            // 
            this.FIO_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.FIO_text.Location = new System.Drawing.Point(149, 56);
            this.FIO_text.Name = "FIO_text";
            this.FIO_text.Size = new System.Drawing.Size(408, 22);
            this.FIO_text.TabIndex = 0;
            this.FIO_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Controls.Add(this.upd_button);
            this.panel2.Controls.Add(this.del_button);
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Location = new System.Drawing.Point(627, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 338);
            this.panel2.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label9.Location = new System.Drawing.Point(52, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Records managment";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.save_button.Location = new System.Drawing.Point(70, 212);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(223, 41);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // upd_button
            // 
            this.upd_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.upd_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upd_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.upd_button.Location = new System.Drawing.Point(70, 167);
            this.upd_button.Name = "upd_button";
            this.upd_button.Size = new System.Drawing.Size(223, 39);
            this.upd_button.TabIndex = 2;
            this.upd_button.Text = "Update";
            this.upd_button.UseVisualStyleBackColor = false;
            this.upd_button.Click += new System.EventHandler(this.upd_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.del_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.del_button.Location = new System.Drawing.Point(70, 123);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(223, 38);
            this.del_button.TabIndex = 1;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(70, 79);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(223, 38);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "New record";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label10.Location = new System.Drawing.Point(634, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 43);
            this.label10.TabIndex = 18;
            this.label10.Text = "Search";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.pictureBox4.Image = global::Employded.Properties.Resources.baby_boy;
            this.pictureBox4.Location = new System.Drawing.Point(45, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.Add_Chil_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.pictureBox3.Image = global::Employded.Properties.Resources.data_searching1;
            this.pictureBox3.Location = new System.Drawing.Point(45, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.pictureBox2.Image = global::Employded.Properties.Resources.refresh_page_option1;
            this.pictureBox2.Location = new System.Drawing.Point(45, 367);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employded.Properties.Resources.self_employed1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1025, 815);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_search);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StartForm";
            this.Text = "Employes_View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employes_ViewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Employes_ViewDataSet employes_ViewDataSet;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private Employes_ViewDataSetTableAdapters.employesTableAdapter employesTableAdapter;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Gender_Combo;
        private System.Windows.Forms.TextBox Amount_text;
        private System.Windows.Forms.TextBox Position_text;
        private System.Windows.Forms.TextBox Birthday_text;
        private System.Windows.Forms.TextBox Pasp_text;
        private System.Windows.Forms.TextBox FIO_text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button upd_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

