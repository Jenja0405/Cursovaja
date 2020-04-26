namespace coursework
{
    partial class Vid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vid));
            this.vid_form = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sohr = new System.Windows.Forms.Button();
            this._id = new System.Windows.Forms.Label();
            this.opisanie_ = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vid_new = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vid_form
            // 
            this.vid_form.BackColor = System.Drawing.Color.Transparent;
            this.vid_form.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vid_form.Location = new System.Drawing.Point(89, 9);
            this.vid_form.Name = "vid_form";
            this.vid_form.Size = new System.Drawing.Size(181, 60);
            this.vid_form.TabIndex = 0;
            this.vid_form.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vid_form.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Sohr);
            this.groupBox1.Controls.Add(this._id);
            this.groupBox1.Controls.Add(this.opisanie_);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(13, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Id, Название и описание";
            // 
            // Sohr
            // 
            this.Sohr.Location = new System.Drawing.Point(233, 133);
            this.Sohr.Name = "Sohr";
            this.Sohr.Size = new System.Drawing.Size(75, 23);
            this.Sohr.TabIndex = 4;
            this.Sohr.Text = "Сохранить";
            this.Sohr.UseVisualStyleBackColor = true;
            // 
            // _id
            // 
            this._id.Location = new System.Drawing.Point(7, 19);
            this._id.Name = "_id";
            this._id.Size = new System.Drawing.Size(26, 23);
            this._id.TabIndex = 2;
            this._id.Visible = false;
            // 
            // opisanie_
            // 
            this.opisanie_.Location = new System.Drawing.Point(52, 56);
            this.opisanie_.Multiline = true;
            this.opisanie_.Name = "opisanie_";
            this.opisanie_.Size = new System.Drawing.Size(256, 66);
            this.opisanie_.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(53, 19);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(225, 21);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вид";
            this.label1.Visible = false;
            // 
            // vid_new
            // 
            this.vid_new.FormattingEnabled = true;
            this.vid_new.Items.AddRange(new object[] {
            "Чай",
            "Кофе"});
            this.vid_new.Location = new System.Drawing.Point(53, 56);
            this.vid_new.Name = "vid_new";
            this.vid_new.Size = new System.Drawing.Size(121, 21);
            this.vid_new.TabIndex = 4;
            this.vid_new.Visible = false;
            // 
            // Vid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(360, 275);
            this.Controls.Add(this.vid_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vid_form);
            this.Name = "Vid";
            this.Text = "Добавление/Редактирование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vid_form;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox opisanie_;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _id;
        private System.Windows.Forms.Button Sohr;
        private System.Windows.Forms.ComboBox vid_new;
    }
}