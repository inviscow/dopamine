namespace Dopamine
{
    partial class Panel
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ModifyForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            CategoryPanel = new Guna.UI2.WinForms.Guna2Panel();
            TabsPanel = new Guna.UI2.WinForms.Guna2Panel();
            OpenMcDirectoryBtn = new Guna.UI2.WinForms.Guna2Button();
            OpenAppDirectoryBtn = new Guna.UI2.WinForms.Guna2Button();
            SpooferBtn = new Guna.UI2.WinForms.Guna2Button();
            InjectorBtn = new Guna.UI2.WinForms.Guna2Button();
            Separator = new Guna.UI2.WinForms.Guna2Separator();
            Watermark = new Label();
            Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            MinimizeBtn = new Guna.UI2.WinForms.Guna2Button();
            ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            DragCatBar = new Guna.UI2.WinForms.Guna2DragControl(components);
            UserControlHolder = new System.Windows.Forms.Panel();
            DragLogo = new Guna.UI2.WinForms.Guna2DragControl(components);
            DragWatermark = new Guna.UI2.WinForms.Guna2DragControl(components);
            DragTabsPanel = new Guna.UI2.WinForms.Guna2DragControl(components);
            CategoryPanel.SuspendLayout();
            TabsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // ModifyForm
            // 
            ModifyForm.AnimateWindow = true;
            ModifyForm.BorderRadius = 6;
            ModifyForm.ContainerControl = this;
            ModifyForm.DockIndicatorTransparencyValue = 0.6D;
            ModifyForm.ResizeForm = false;
            ModifyForm.TransparentWhileDrag = true;
            // 
            // CategoryPanel
            // 
            CategoryPanel.BackColor = Color.Transparent;
            CategoryPanel.BorderRadius = 6;
            CategoryPanel.BorderThickness = 1;
            CategoryPanel.Controls.Add(TabsPanel);
            CategoryPanel.Controls.Add(Separator);
            CategoryPanel.Controls.Add(Watermark);
            CategoryPanel.Controls.Add(Logo);
            CategoryPanel.Controls.Add(MinimizeBtn);
            CategoryPanel.Controls.Add(ExitBtn);
            CategoryPanel.CustomBorderColor = Color.BlueViolet;
            CategoryPanel.CustomBorderThickness = new Padding(0, 0, 2, 0);
            CategoryPanel.CustomizableEdges = customizableEdges17;
            CategoryPanel.Dock = DockStyle.Left;
            CategoryPanel.FillColor = Color.FromArgb(15, 15, 15);
            CategoryPanel.Location = new Point(0, 0);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.ShadowDecoration.CustomizableEdges = customizableEdges18;
            CategoryPanel.Size = new Size(128, 450);
            CategoryPanel.TabIndex = 0;
            // 
            // TabsPanel
            // 
            TabsPanel.Controls.Add(OpenMcDirectoryBtn);
            TabsPanel.Controls.Add(OpenAppDirectoryBtn);
            TabsPanel.Controls.Add(SpooferBtn);
            TabsPanel.Controls.Add(InjectorBtn);
            TabsPanel.CustomizableEdges = customizableEdges9;
            TabsPanel.FillColor = Color.Transparent;
            TabsPanel.Location = new Point(3, 123);
            TabsPanel.Name = "TabsPanel";
            TabsPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            TabsPanel.Size = new Size(122, 315);
            TabsPanel.TabIndex = 6;
            // 
            // OpenMcDirectoryBtn
            // 
            OpenMcDirectoryBtn.Animated = true;
            OpenMcDirectoryBtn.BorderColor = Color.FromArgb(20, 20, 20);
            OpenMcDirectoryBtn.BorderRadius = 6;
            OpenMcDirectoryBtn.CustomizableEdges = customizableEdges1;
            OpenMcDirectoryBtn.DisabledState.BorderColor = Color.DarkGray;
            OpenMcDirectoryBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            OpenMcDirectoryBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OpenMcDirectoryBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OpenMcDirectoryBtn.FillColor = Color.Transparent;
            OpenMcDirectoryBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenMcDirectoryBtn.ForeColor = Color.WhiteSmoke;
            OpenMcDirectoryBtn.Image = Properties.Resources.mc_48x_dark;
            OpenMcDirectoryBtn.Location = new Point(64, 286);
            OpenMcDirectoryBtn.Name = "OpenMcDirectoryBtn";
            OpenMcDirectoryBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            OpenMcDirectoryBtn.Size = new Size(26, 26);
            OpenMcDirectoryBtn.TabIndex = 5;
            OpenMcDirectoryBtn.Click += OpenMcDirectoryBtn_Click;
            // 
            // OpenAppDirectoryBtn
            // 
            OpenAppDirectoryBtn.Animated = true;
            OpenAppDirectoryBtn.BorderColor = Color.FromArgb(20, 20, 20);
            OpenAppDirectoryBtn.BorderRadius = 6;
            OpenAppDirectoryBtn.CustomizableEdges = customizableEdges3;
            OpenAppDirectoryBtn.DisabledState.BorderColor = Color.DarkGray;
            OpenAppDirectoryBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            OpenAppDirectoryBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OpenAppDirectoryBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OpenAppDirectoryBtn.FillColor = Color.Transparent;
            OpenAppDirectoryBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenAppDirectoryBtn.ForeColor = Color.WhiteSmoke;
            OpenAppDirectoryBtn.Image = Properties.Resources.folder_48px_dark;
            OpenAppDirectoryBtn.Location = new Point(32, 286);
            OpenAppDirectoryBtn.Name = "OpenAppDirectoryBtn";
            OpenAppDirectoryBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            OpenAppDirectoryBtn.Size = new Size(26, 26);
            OpenAppDirectoryBtn.TabIndex = 4;
            OpenAppDirectoryBtn.Click += OpenAppDirectoryBtn_Click;
            // 
            // SpooferBtn
            // 
            SpooferBtn.Animated = true;
            SpooferBtn.BorderColor = Color.Transparent;
            SpooferBtn.BorderRadius = 2;
            SpooferBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            SpooferBtn.CheckedState.FillColor = Color.Transparent;
            SpooferBtn.CheckedState.ForeColor = Color.BlueViolet;
            SpooferBtn.CustomizableEdges = customizableEdges5;
            SpooferBtn.DisabledState.BorderColor = Color.DarkGray;
            SpooferBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SpooferBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SpooferBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SpooferBtn.Dock = DockStyle.Top;
            SpooferBtn.FillColor = Color.Transparent;
            SpooferBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SpooferBtn.ForeColor = Color.Gainsboro;
            SpooferBtn.Image = Properties.Resources.anonymous_mask_48px;
            SpooferBtn.Location = new Point(0, 36);
            SpooferBtn.Name = "SpooferBtn";
            SpooferBtn.PressedColor = Color.FromArgb(20, 20, 20);
            SpooferBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SpooferBtn.Size = new Size(122, 36);
            SpooferBtn.TabIndex = 1;
            SpooferBtn.Text = "Spoofing";
            SpooferBtn.UseTransparentBackground = true;
            SpooferBtn.Click += SpooferBtn_Click;
            // 
            // InjectorBtn
            // 
            InjectorBtn.Animated = true;
            InjectorBtn.BorderColor = Color.Transparent;
            InjectorBtn.BorderRadius = 2;
            InjectorBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            InjectorBtn.CheckedState.FillColor = Color.Transparent;
            InjectorBtn.CheckedState.ForeColor = Color.BlueViolet;
            InjectorBtn.CustomizableEdges = customizableEdges7;
            InjectorBtn.DisabledState.BorderColor = Color.DarkGray;
            InjectorBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            InjectorBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            InjectorBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            InjectorBtn.Dock = DockStyle.Top;
            InjectorBtn.FillColor = Color.Transparent;
            InjectorBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InjectorBtn.ForeColor = Color.Gainsboro;
            InjectorBtn.Image = Properties.Resources.syringe_48px;
            InjectorBtn.Location = new Point(0, 0);
            InjectorBtn.Name = "InjectorBtn";
            InjectorBtn.PressedColor = Color.FromArgb(20, 20, 20);
            InjectorBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            InjectorBtn.Size = new Size(122, 36);
            InjectorBtn.TabIndex = 0;
            InjectorBtn.Text = "Injector";
            InjectorBtn.UseTransparentBackground = true;
            InjectorBtn.Click += InjectorBtn_Click;
            // 
            // Separator
            // 
            Separator.FillColor = Color.FromArgb(40, 40, 40);
            Separator.Location = new Point(4, 107);
            Separator.Name = "Separator";
            Separator.Size = new Size(120, 10);
            Separator.TabIndex = 5;
            // 
            // Watermark
            // 
            Watermark.AutoSize = true;
            Watermark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Watermark.Location = new Point(22, 75);
            Watermark.Name = "Watermark";
            Watermark.Size = new Size(85, 21);
            Watermark.TabIndex = 4;
            Watermark.Text = "Dopamine";
            // 
            // Logo
            // 
            Logo.CustomizableEdges = customizableEdges11;
            Logo.FillColor = Color.Transparent;
            Logo.Image = Properties.Resources.DopamineNoBG;
            Logo.ImageRotate = 0F;
            Logo.Location = new Point(44, 40);
            Logo.Name = "Logo";
            Logo.ShadowDecoration.Color = Color.FromArgb(16, 16, 16);
            Logo.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Logo.ShadowDecoration.Shadow = new Padding(1);
            Logo.Size = new Size(40, 40);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 3;
            Logo.TabStop = false;
            Logo.UseTransparentBackground = true;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.CustomizableEdges = customizableEdges13;
            MinimizeBtn.DisabledState.BorderColor = Color.DarkGray;
            MinimizeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            MinimizeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            MinimizeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            MinimizeBtn.FillColor = Color.Transparent;
            MinimizeBtn.FocusedColor = Color.Transparent;
            MinimizeBtn.Font = new Font("Segoe UI", 9F);
            MinimizeBtn.ForeColor = Color.White;
            MinimizeBtn.Image = Properties.Resources.mc_yellw;
            MinimizeBtn.ImageSize = new Size(12, 12);
            MinimizeBtn.Location = new Point(32, 12);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            MinimizeBtn.Size = new Size(14, 14);
            MinimizeBtn.TabIndex = 1;
            MinimizeBtn.UseTransparentBackground = true;
            // 
            // ExitBtn
            // 
            ExitBtn.CustomizableEdges = customizableEdges15;
            ExitBtn.DisabledState.BorderColor = Color.DarkGray;
            ExitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitBtn.FillColor = Color.Transparent;
            ExitBtn.FocusedColor = Color.Transparent;
            ExitBtn.Font = new Font("Segoe UI", 9F);
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Image = Properties.Resources.mc_red;
            ExitBtn.ImageSize = new Size(12, 12);
            ExitBtn.Location = new Point(12, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            ExitBtn.Size = new Size(14, 14);
            ExitBtn.TabIndex = 0;
            ExitBtn.UseTransparentBackground = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // DragCatBar
            // 
            DragCatBar.DockIndicatorTransparencyValue = 0.6D;
            DragCatBar.TargetControl = CategoryPanel;
            DragCatBar.UseTransparentDrag = true;
            // 
            // UserControlHolder
            // 
            UserControlHolder.BackColor = Color.Transparent;
            UserControlHolder.Dock = DockStyle.Fill;
            UserControlHolder.Location = new Point(128, 0);
            UserControlHolder.Name = "UserControlHolder";
            UserControlHolder.Size = new Size(672, 450);
            UserControlHolder.TabIndex = 1;
            // 
            // DragLogo
            // 
            DragLogo.DockIndicatorTransparencyValue = 0.6D;
            DragLogo.TargetControl = Logo;
            DragLogo.UseTransparentDrag = true;
            // 
            // DragWatermark
            // 
            DragWatermark.DockIndicatorTransparencyValue = 0.6D;
            DragWatermark.TargetControl = Watermark;
            DragWatermark.UseTransparentDrag = true;
            // 
            // DragTabsPanel
            // 
            DragTabsPanel.DockIndicatorTransparencyValue = 0.6D;
            DragTabsPanel.TargetControl = TabsPanel;
            DragTabsPanel.UseTransparentDrag = true;
            // 
            // Panel
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(800, 450);
            Controls.Add(UserControlHolder);
            Controls.Add(CategoryPanel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Panel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dopamine";
            CategoryPanel.ResumeLayout(false);
            CategoryPanel.PerformLayout();
            TabsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ModifyForm;
        private Guna.UI2.WinForms.Guna2Panel CategoryPanel;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Button MinimizeBtn;
        private Label Watermark;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Separator Separator;
        private Guna.UI2.WinForms.Guna2DragControl DragCatBar;
        private Guna.UI2.WinForms.Guna2Panel TabsPanel;
        private Guna.UI2.WinForms.Guna2Button InjectorBtn;
        private Guna.UI2.WinForms.Guna2Button SpooferBtn;
        private System.Windows.Forms.Panel UserControlHolder;
        private Guna.UI2.WinForms.Guna2DragControl DragLogo;
        private Guna.UI2.WinForms.Guna2DragControl DragWatermark;
        private Guna.UI2.WinForms.Guna2DragControl DragTabsPanel;
        private Guna.UI2.WinForms.Guna2Button OpenMcDirectoryBtn;
        private Guna.UI2.WinForms.Guna2Button OpenAppDirectoryBtn;
    }
}
