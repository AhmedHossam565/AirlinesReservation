namespace Airlines_Reservation
{
    partial class Last
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Last));
            this.nameField = new System.Windows.Forms.TextBox();
            this.typeField = new System.Windows.Forms.TextBox();
            this.depField = new System.Windows.Forms.TextBox();
            this.destField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.TextBox();
            this.gateField = new System.Windows.Forms.TextBox();
            this.IdField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(49, 198);
            this.nameField.Name = "nameField";
            this.nameField.ReadOnly = true;
            this.nameField.Size = new System.Drawing.Size(448, 23);
            this.nameField.TabIndex = 0;
            // 
            // typeField
            // 
            this.typeField.Location = new System.Drawing.Point(40, 298);
            this.typeField.Name = "typeField";
            this.typeField.ReadOnly = true;
            this.typeField.Size = new System.Drawing.Size(223, 23);
            this.typeField.TabIndex = 0;
            this.typeField.TextChanged += new System.EventHandler(this.typeField_TextChanged);
            // 
            // depField
            // 
            this.depField.Location = new System.Drawing.Point(47, 401);
            this.depField.Name = "depField";
            this.depField.ReadOnly = true;
            this.depField.Size = new System.Drawing.Size(216, 23);
            this.depField.TabIndex = 0;
            // 
            // destField
            // 
            this.destField.Location = new System.Drawing.Point(40, 504);
            this.destField.Name = "destField";
            this.destField.ReadOnly = true;
            this.destField.Size = new System.Drawing.Size(223, 23);
            this.destField.TabIndex = 0;
            // 
            // dateField
            // 
            this.dateField.Location = new System.Drawing.Point(603, 198);
            this.dateField.Name = "dateField";
            this.dateField.ReadOnly = true;
            this.dateField.Size = new System.Drawing.Size(162, 23);
            this.dateField.TabIndex = 0;
            this.dateField.TextChanged += new System.EventHandler(this.dateField_TextChanged);
            // 
            // gateField
            // 
            this.gateField.Location = new System.Drawing.Point(603, 298);
            this.gateField.Name = "gateField";
            this.gateField.ReadOnly = true;
            this.gateField.Size = new System.Drawing.Size(162, 23);
            this.gateField.TabIndex = 0;
            this.gateField.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // IdField
            // 
            this.IdField.Location = new System.Drawing.Point(603, 401);
            this.IdField.Name = "IdField";
            this.IdField.ReadOnly = true;
            this.IdField.Size = new System.Drawing.Size(162, 23);
            this.IdField.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Komika Axis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(650, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.destField);
            this.Controls.Add(this.depField);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.gateField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.nameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Last";
            this.Text = "Last";
            this.Load += new System.EventHandler(this.Last_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameField;
        private TextBox typeField;
        private TextBox depField;
        private TextBox destField;
        private TextBox dateField;
        private TextBox gateField;
        private TextBox IdField;
        private Button button1;
    }
}