namespace updatedATM
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            chbShow = new Guna.UI2.WinForms.Guna2CheckBox();
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            registerBtn = new Guna.UI2.WinForms.Guna2Button();
            txtCardNum = new Guna.UI2.WinForms.Guna2TextBox();
            txtPIN = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.BorderColor = Color.DarkSlateGray;
            loginBtn.BorderRadius = 10;
            loginBtn.BorderThickness = 2;
            loginBtn.CustomizableEdges = customizableEdges1;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.Teal;
            loginBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.SeaShell;
            loginBtn.Location = new Point(259, 511);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loginBtn.Size = new Size(127, 57);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "LOG IN";
            loginBtn.Click += loginBtn_Click;
            // 
            // chbShow
            // 
            chbShow.AutoSize = true;
            chbShow.BackColor = Color.Transparent;
            chbShow.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chbShow.CheckedState.BorderRadius = 0;
            chbShow.CheckedState.BorderThickness = 0;
            chbShow.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chbShow.CheckMarkColor = Color.DarkSlateGray;
            chbShow.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbShow.Location = new Point(275, 445);
            chbShow.Margin = new Padding(3, 4, 3, 4);
            chbShow.Name = "chbShow";
            chbShow.Size = new Size(97, 24);
            chbShow.TabIndex = 6;
            chbShow.Text = "Show PIN";
            chbShow.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chbShow.UncheckedState.BorderRadius = 0;
            chbShow.UncheckedState.BorderThickness = 0;
            chbShow.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chbShow.UseVisualStyleBackColor = false;
            chbShow.CheckedChanged += chbShow_CheckedChanged;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BorderColor = Color.DarkSlateGray;
            exitBtn.BorderRadius = 5;
            exitBtn.CustomizableEdges = customizableEdges3;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.FillColor = Color.DarkRed;
            exitBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(763, 3);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            exitBtn.Size = new Size(34, 35);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "X";
            exitBtn.Click += exitBtn_Click;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.BackgroundImage = (Image)resources.GetObject("registerBtn.BackgroundImage");
            registerBtn.BorderColor = Color.DarkSlateGray;
            registerBtn.BorderRadius = 10;
            registerBtn.BorderThickness = 2;
            registerBtn.CustomizableEdges = customizableEdges5;
            registerBtn.DisabledState.BorderColor = Color.DarkGray;
            registerBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            registerBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            registerBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            registerBtn.FillColor = Color.Teal;
            registerBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.SeaShell;
            registerBtn.Location = new Point(411, 511);
            registerBtn.Margin = new Padding(3, 4, 3, 4);
            registerBtn.Name = "registerBtn";
            registerBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            registerBtn.Size = new Size(127, 57);
            registerBtn.TabIndex = 13;
            registerBtn.Text = "REGISTER";
            registerBtn.Click += registerBtn_Click;
            // 
            // txtCardNum
            // 
            txtCardNum.BackColor = Color.Transparent;
            txtCardNum.BorderColor = Color.DarkSlateGray;
            txtCardNum.BorderRadius = 10;
            txtCardNum.BorderThickness = 2;
            txtCardNum.CustomizableEdges = customizableEdges7;
            txtCardNum.DefaultText = "";
            txtCardNum.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCardNum.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCardNum.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCardNum.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCardNum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCardNum.Font = new Font("Segoe UI", 9F);
            txtCardNum.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCardNum.Location = new Point(259, 303);
            txtCardNum.Margin = new Padding(3, 5, 3, 5);
            txtCardNum.Name = "txtCardNum";
            txtCardNum.PasswordChar = '\0';
            txtCardNum.PlaceholderText = "Card Number";
            txtCardNum.SelectedText = "";
            txtCardNum.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCardNum.Size = new Size(279, 56);
            txtCardNum.TabIndex = 28;
            // 
            // txtPIN
            // 
            txtPIN.BackColor = Color.Transparent;
            txtPIN.BorderColor = Color.DarkSlateGray;
            txtPIN.BorderRadius = 10;
            txtPIN.BorderThickness = 2;
            txtPIN.CustomizableEdges = customizableEdges9;
            txtPIN.DefaultText = "";
            txtPIN.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPIN.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPIN.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPIN.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPIN.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPIN.Font = new Font("Segoe UI", 9F);
            txtPIN.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPIN.Location = new Point(259, 375);
            txtPIN.Margin = new Padding(3, 5, 3, 5);
            txtPIN.Name = "txtPIN";
            txtPIN.PasswordChar = '\0';
            txtPIN.PlaceholderText = "PIN";
            txtPIN.SelectedText = "";
            txtPIN.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPIN.Size = new Size(279, 56);
            txtPIN.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 629);
            Controls.Add(txtCardNum);
            Controls.Add(txtPIN);
            Controls.Add(registerBtn);
            Controls.Add(exitBtn);
            Controls.Add(chbShow);
            Controls.Add(loginBtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2CheckBox chbShow;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button registerBtn;
        private Guna.UI2.WinForms.Guna2TextBox txtCardNum;
        private Guna.UI2.WinForms.Guna2TextBox txtPIN;
    }
}
