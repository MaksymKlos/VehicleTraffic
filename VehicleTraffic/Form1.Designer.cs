namespace VehicleTraffic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DriversButton = new System.Windows.Forms.Button();
            this.RoutesButton = new System.Windows.Forms.Button();
            this.ShippingButton = new System.Windows.Forms.Button();
            this.TransportButton = new System.Windows.Forms.Button();
            this.FineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DriversButton
            // 
            this.DriversButton.Location = new System.Drawing.Point(12, 12);
            this.DriversButton.Name = "DriversButton";
            this.DriversButton.Size = new System.Drawing.Size(109, 23);
            this.DriversButton.TabIndex = 0;
            this.DriversButton.Text = "Водії";
            this.DriversButton.UseVisualStyleBackColor = true;
            this.DriversButton.Click += new System.EventHandler(this.DriversButton_Click);
            // 
            // RoutesButton
            // 
            this.RoutesButton.Location = new System.Drawing.Point(12, 41);
            this.RoutesButton.Name = "RoutesButton";
            this.RoutesButton.Size = new System.Drawing.Size(75, 23);
            this.RoutesButton.TabIndex = 1;
            this.RoutesButton.Text = "Маршрути";
            this.RoutesButton.UseVisualStyleBackColor = true;
            this.RoutesButton.Click += new System.EventHandler(this.RoutesButton_Click);
            // 
            // ShippingButton
            // 
            this.ShippingButton.Location = new System.Drawing.Point(93, 41);
            this.ShippingButton.Name = "ShippingButton";
            this.ShippingButton.Size = new System.Drawing.Size(90, 23);
            this.ShippingButton.TabIndex = 2;
            this.ShippingButton.Text = "Перевезення";
            this.ShippingButton.UseVisualStyleBackColor = true;
            this.ShippingButton.Click += new System.EventHandler(this.ShippingButton_Click);
            // 
            // TransportButton
            // 
            this.TransportButton.Location = new System.Drawing.Point(127, 12);
            this.TransportButton.Name = "TransportButton";
            this.TransportButton.Size = new System.Drawing.Size(137, 23);
            this.TransportButton.TabIndex = 3;
            this.TransportButton.Text = "Транспортні засоби";
            this.TransportButton.UseVisualStyleBackColor = true;
            this.TransportButton.Click += new System.EventHandler(this.TransportButton_Click);
            // 
            // FineButton
            // 
            this.FineButton.Location = new System.Drawing.Point(189, 41);
            this.FineButton.Name = "FineButton";
            this.FineButton.Size = new System.Drawing.Size(75, 23);
            this.FineButton.TabIndex = 4;
            this.FineButton.Text = "Штрафи";
            this.FineButton.UseVisualStyleBackColor = true;
            this.FineButton.Click += new System.EventHandler(this.FineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 78);
            this.Controls.Add(this.FineButton);
            this.Controls.Add(this.TransportButton);
            this.Controls.Add(this.ShippingButton);
            this.Controls.Add(this.RoutesButton);
            this.Controls.Add(this.DriversButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button DriversButton;
        private Button RoutesButton;
        private Button ShippingButton;
        private Button TransportButton;
        private Button FineButton;
    }
}