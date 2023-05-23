namespace VehicleTraffic
{
    partial class AddDriverForm
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
            this.Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DriverName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(125, 103);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(121, 23);
            this.Phone.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Телефон";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(125, 40);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(121, 23);
            this.Surname.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Прізвище";
            // 
            // DriverName
            // 
            this.DriverName.Location = new System.Drawing.Point(125, 11);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(121, 23);
            this.DriverName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ім\'я";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(125, 71);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(121, 23);
            this.Address.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Адреса";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(16, 144);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(230, 33);
            this.CreateButton.TabIndex = 31;
            this.CreateButton.Text = "Створити";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AddDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 201);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DriverName);
            this.Controls.Add(this.label1);
            this.Name = "AddDriverForm";
            this.Text = "AddDriverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Phone;
        private Label label4;
        private TextBox Surname;
        private Label label2;
        private TextBox DriverName;
        private Label label1;
        private TextBox Address;
        private Label label3;
        private Button CreateButton;
    }
}