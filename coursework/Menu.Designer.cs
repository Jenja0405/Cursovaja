namespace coursework
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.adres_file = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adrFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sort = new System.Windows.Forms.Button();
            this.Checed_cofe = new System.Windows.Forms.RadioButton();
            this.Checed_tea = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Poisk = new System.Windows.Forms.TextBox();
            this.New = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adres_file
            // 
            this.adres_file.Location = new System.Drawing.Point(13, 26);
            this.adres_file.Name = "adres_file";
            this.adres_file.Size = new System.Drawing.Size(160, 20);
            this.adres_file.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(218, 227);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // adrFile
            // 
            this.adrFile.Location = new System.Drawing.Point(169, 24);
            this.adrFile.Name = "adrFile";
            this.adrFile.Size = new System.Drawing.Size(93, 23);
            this.adrFile.TabIndex = 3;
            this.adrFile.Text = "Выбрать файл";
            this.adrFile.UseVisualStyleBackColor = true;
            this.adrFile.Click += new System.EventHandler(this.adrFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Sort);
            this.groupBox1.Controls.Add(this.Checed_cofe);
            this.groupBox1.Controls.Add(this.Checed_tea);
            this.groupBox1.Location = new System.Drawing.Point(237, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "По какому виду выполнить сортровку?";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(89, 71);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(84, 23);
            this.Sort.TabIndex = 2;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Checed_cofe
            // 
            this.Checed_cofe.AutoSize = true;
            this.Checed_cofe.Location = new System.Drawing.Point(6, 54);
            this.Checed_cofe.Name = "Checed_cofe";
            this.Checed_cofe.Size = new System.Drawing.Size(51, 17);
            this.Checed_cofe.TabIndex = 1;
            this.Checed_cofe.TabStop = true;
            this.Checed_cofe.Text = "кофе";
            this.Checed_cofe.UseVisualStyleBackColor = true;
            // 
            // Checed_tea
            // 
            this.Checed_tea.AutoSize = true;
            this.Checed_tea.Location = new System.Drawing.Point(6, 31);
            this.Checed_tea.Name = "Checed_tea";
            this.Checed_tea.Size = new System.Drawing.Size(42, 17);
            this.Checed_tea.TabIndex = 0;
            this.Checed_tea.TabStop = true;
            this.Checed_tea.Text = "чай";
            this.Checed_tea.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Poisk);
            this.groupBox2.Location = new System.Drawing.Point(237, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по названию";
            // 
            // Poisk
            // 
            this.Poisk.Location = new System.Drawing.Point(6, 19);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(167, 20);
            this.Poisk.TabIndex = 0;
            this.Poisk.TextChanged += new System.EventHandler(this.Poisk_TextChanged);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(238, 227);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 5;
            this.New.Text = "Добавить";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(238, 267);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(326, 249);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(84, 23);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "Обновление";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 306);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.New);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adrFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adres_file);
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adrFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.RadioButton Checed_cofe;
        private System.Windows.Forms.RadioButton Checed_tea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Poisk;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button refresh;
    }
}