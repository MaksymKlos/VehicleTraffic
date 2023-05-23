namespace VehicleTraffic
{
    partial class AddRouteForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RouteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(12, 149);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(264, 33);
            this.CreateButton.TabIndex = 38;
            this.CreateButton.Text = "Створити";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(155, 76);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(121, 23);
            this.End.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Кінцева точка";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(155, 47);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(121, 23);
            this.Start.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Початкова точка";
            // 
            // RouteName
            // 
            this.RouteName.Location = new System.Drawing.Point(155, 16);
            this.RouteName.Name = "RouteName";
            this.RouteName.Size = new System.Drawing.Size(121, 23);
            this.RouteName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Назва маршруту";
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(155, 105);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(121, 23);
            this.Duration.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Протяжність маршруту";
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 201);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.End);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RouteName);
            this.Controls.Add(this.label1);
            this.Name = "AddRouteForm";
            this.Text = "AddRouteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateButton;
        private TextBox End;
        private Label label3;
        private TextBox Start;
        private Label label2;
        private TextBox RouteName;
        private Label label1;
        private TextBox Duration;
        private Label label4;
    }
}