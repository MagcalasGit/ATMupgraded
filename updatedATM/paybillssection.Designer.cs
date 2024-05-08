namespace updatedATM
{
    partial class paybillssection
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paybillssection));
            ElectricBillBtn = new Guna.UI2.WinForms.Guna2Button();
            WaterBillBtn = new Guna.UI2.WinForms.Guna2Button();
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // ElectricBillBtn
            // 
            ElectricBillBtn.BackColor = Color.Transparent;
            ElectricBillBtn.BorderColor = Color.DarkSlateGray;
            ElectricBillBtn.BorderRadius = 15;
            ElectricBillBtn.BorderThickness = 2;
            ElectricBillBtn.CustomizableEdges = customizableEdges1;
            ElectricBillBtn.DisabledState.BorderColor = Color.DarkGray;
            ElectricBillBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ElectricBillBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ElectricBillBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ElectricBillBtn.FillColor = Color.Teal;
            ElectricBillBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ElectricBillBtn.ForeColor = Color.White;
            ElectricBillBtn.Location = new Point(54, 494);
            ElectricBillBtn.Margin = new Padding(3, 4, 3, 4);
            ElectricBillBtn.Name = "ElectricBillBtn";
            ElectricBillBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ElectricBillBtn.Size = new Size(301, 85);
            ElectricBillBtn.TabIndex = 8;
            ElectricBillBtn.Text = "Electricity Bill";
            ElectricBillBtn.Click += ElectricBillBtn_Click;
            // 
            // WaterBillBtn
            // 
            WaterBillBtn.BackColor = Color.Transparent;
            WaterBillBtn.BorderColor = Color.DarkSlateGray;
            WaterBillBtn.BorderRadius = 15;
            WaterBillBtn.BorderThickness = 2;
            WaterBillBtn.CustomizableEdges = customizableEdges3;
            WaterBillBtn.DisabledState.BorderColor = Color.DarkGray;
            WaterBillBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            WaterBillBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            WaterBillBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            WaterBillBtn.FillColor = Color.Teal;
            WaterBillBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WaterBillBtn.ForeColor = Color.White;
            WaterBillBtn.Location = new Point(54, 385);
            WaterBillBtn.Margin = new Padding(3, 4, 3, 4);
            WaterBillBtn.Name = "WaterBillBtn";
            WaterBillBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            WaterBillBtn.Size = new Size(301, 85);
            WaterBillBtn.TabIndex = 9;
            WaterBillBtn.Text = "Water Bill";
            WaterBillBtn.Click += WaterBillBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.CustomizableEdges = customizableEdges5;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.FillColor = Color.FromArgb(192, 0, 0);
            exitBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(375, 3);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            exitBtn.Size = new Size(34, 37);
            exitBtn.TabIndex = 19;
            exitBtn.Text = "X";
            exitBtn.Click += exitBtn_Click;
            // 
            // paybillssection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(410, 700);
            Controls.Add(exitBtn);
            Controls.Add(WaterBillBtn);
            Controls.Add(ElectricBillBtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "paybillssection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "paybillssection";
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ElectricBillBtn;
        private Guna.UI2.WinForms.Guna2Button WaterBillBtn;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
    }
}