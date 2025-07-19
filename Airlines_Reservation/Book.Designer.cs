namespace Airlines_Reservation
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.compField = new System.Windows.Forms.ComboBox();
            this.noField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.typeField = new System.Windows.Forms.ComboBox();
            this.depField = new System.Windows.Forms.ComboBox();
            this.destField = new System.Windows.Forms.ComboBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // compField
            // 
            this.compField.FormattingEnabled = true;
            this.compField.Items.AddRange(new object[] {
            "Air Arabia Egypt.",
            "EasyJet.",
            "Corendon Airlines Europe.",
            "TUIfly."});
            this.compField.Location = new System.Drawing.Point(383, 160);
            this.compField.Name = "compField";
            this.compField.Size = new System.Drawing.Size(192, 23);
            this.compField.TabIndex = 13;
            this.compField.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // noField
            // 
            this.noField.Location = new System.Drawing.Point(383, 90);
            this.noField.Name = "noField";
            this.noField.Size = new System.Drawing.Size(192, 23);
            this.noField.TabIndex = 11;
            this.noField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(383, 61);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(192, 23);
            this.nameField.TabIndex = 12;
            this.nameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Komika Axis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(279, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Komika Axis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(365, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "Book Now";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // typeField
            // 
            this.typeField.FormattingEnabled = true;
            this.typeField.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "First Class"});
            this.typeField.Location = new System.Drawing.Point(383, 123);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(192, 23);
            this.typeField.TabIndex = 13;
            this.typeField.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // depField
            // 
            this.depField.FormattingEnabled = true;
            this.depField.Items.AddRange(new object[] {
            "Cairo",
            "Borg El Arab",
            "Toronto",
            "Luxomborg",
            "Sudan"});
            this.depField.Location = new System.Drawing.Point(383, 258);
            this.depField.Name = "depField";
            this.depField.Size = new System.Drawing.Size(192, 23);
            this.depField.TabIndex = 13;
            this.depField.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // destField
            // 
            this.destField.FormattingEnabled = true;
            this.destField.Items.AddRange(new object[] {
            "Cairo",
            "Borg El Arab",
            "Toronto",
            "Luxomborg",
            "Sudan"});
            this.destField.Location = new System.Drawing.Point(383, 316);
            this.destField.Name = "destField";
            this.destField.Size = new System.Drawing.Size(192, 23);
            this.destField.TabIndex = 13;
            this.destField.SelectedIndexChanged += new System.EventHandler(this.destField_SelectedIndexChanged);
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(383, 200);
            this.dateField.MinDate = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(192, 23);
            this.dateField.TabIndex = 16;
            this.dateField.Value = new System.DateTime(2023, 1, 10, 0, 0, 0, 0);
            this.dateField.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Komika Axis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(246, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Komika Axis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(279, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Komika Axis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(263, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Company";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Komika Axis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(279, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(263, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 468);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.depField);
            this.Controls.Add(this.destField);
            this.Controls.Add(this.compField);
            this.Controls.Add(this.noField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox compField;
        private TextBox noField;
        private TextBox nameField;
        private Label label1;
        private Button button2;
        private ComboBox typeField;
        private ComboBox depField;
        private ComboBox destField;
        private DateTimePicker dateField;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}