namespace updatedATM
{
    partial class checkBalanceSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkBalanceSection));
            lblSavingsbalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblChequebalance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblSavingsbalance
            // 
            lblSavingsbalance.BackColor = Color.Transparent;
            lblSavingsbalance.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic);
            lblSavingsbalance.ForeColor = SystemColors.ButtonHighlight;
            lblSavingsbalance.Location = new Point(191, 325);
            lblSavingsbalance.Margin = new Padding(3, 4, 3, 4);
            lblSavingsbalance.Name = "lblSavingsbalance";
            lblSavingsbalance.Size = new Size(33, 36);
            lblSavingsbalance.TabIndex = 0;
            lblSavingsbalance.Text = "---";
            // 
            // lblChequebalance
            // 
            lblChequebalance.BackColor = Color.Transparent;
            lblChequebalance.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic);
            lblChequebalance.ForeColor = SystemColors.ButtonHighlight;
            lblChequebalance.Location = new Point(191, 433);
            lblChequebalance.Margin = new Padding(3, 4, 3, 4);
            lblChequebalance.Name = "lblChequebalance";
            lblChequebalance.Size = new Size(33, 36);
            lblChequebalance.TabIndex = 1;
            lblChequebalance.Text = "---";
            // 
            // exitBtn
            // 
            exitBtn.CustomizableEdges = customizableEdges1;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.FillColor = Color.FromArgb(192, 0, 0);
            exitBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(460, 4);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            exitBtn.Size = new Size(34, 37);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "X";
            exitBtn.Click += exitBtn_Click;
            // 
            // checkBalanceSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 609);
            Controls.Add(exitBtn);
            Controls.Add(lblChequebalance);
            Controls.Add(lblSavingsbalance);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "checkBalanceSection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "checkBalanceSection";
            Load += checkBalanceSection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblSavingsbalance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChequebalance;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
    }
}