namespace Dopamine.Tabs
{
    partial class InjectorTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            InjectingPanel = new Guna.UI2.WinForms.Guna2Panel();
            StatusLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            DllPathLabel = new Label();
            label1 = new Label();
            SelectDllBtn = new Guna.UI2.WinForms.Guna2Button();
            ClientLabel = new Label();
            InjectBtn = new Guna.UI2.WinForms.Guna2Button();
            ClientList = new Guna.UI2.WinForms.Guna2ComboBox();
            SettingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            UseCustomDllBox = new Guna.UI2.WinForms.Guna2CheckBox();
            InjectingPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // InjectingPanel
            // 
            InjectingPanel.BackColor = Color.Transparent;
            InjectingPanel.BorderColor = Color.FromArgb(25, 25, 25);
            InjectingPanel.BorderRadius = 6;
            InjectingPanel.BorderThickness = 1;
            InjectingPanel.Controls.Add(StatusLabel);
            InjectingPanel.Controls.Add(DllPathLabel);
            InjectingPanel.Controls.Add(label1);
            InjectingPanel.Controls.Add(SelectDllBtn);
            InjectingPanel.Controls.Add(ClientLabel);
            InjectingPanel.Controls.Add(InjectBtn);
            InjectingPanel.Controls.Add(ClientList);
            InjectingPanel.CustomizableEdges = customizableEdges7;
            InjectingPanel.FillColor = Color.FromArgb(15, 15, 15);
            InjectingPanel.Location = new Point(112, 56);
            InjectingPanel.Name = "InjectingPanel";
            InjectingPanel.ShadowDecoration.Color = Color.MediumPurple;
            InjectingPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            InjectingPanel.Size = new Size(449, 174);
            InjectingPanel.TabIndex = 0;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = false;
            StatusLabel.BackColor = Color.Transparent;
            StatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.DimGray;
            StatusLabel.Location = new Point(3, 154);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(443, 17);
            StatusLabel.TabIndex = 6;
            StatusLabel.Text = "<b>Status:</b> Waiting...";
            StatusLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // DllPathLabel
            // 
            DllPathLabel.AutoSize = true;
            DllPathLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DllPathLabel.ForeColor = Color.Silver;
            DllPathLabel.Location = new Point(219, 114);
            DllPathLabel.Name = "DllPathLabel";
            DllPathLabel.Size = new Size(92, 17);
            DllPathLabel.TabIndex = 5;
            DllPathLabel.Text = "No file chosen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(113, 84);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 4;
            label1.Text = "Custom DLL";
            // 
            // SelectDllBtn
            // 
            SelectDllBtn.Animated = true;
            SelectDllBtn.BorderColor = Color.FromArgb(20, 20, 20);
            SelectDllBtn.BorderRadius = 6;
            SelectDllBtn.BorderThickness = 1;
            SelectDllBtn.CustomizableEdges = customizableEdges1;
            SelectDllBtn.DisabledState.BorderColor = Color.DarkGray;
            SelectDllBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SelectDllBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SelectDllBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SelectDllBtn.FillColor = Color.FromArgb(25, 25, 25);
            SelectDllBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectDllBtn.ForeColor = Color.WhiteSmoke;
            SelectDllBtn.Image = Properties.Resources.folder_48px;
            SelectDllBtn.Location = new Point(113, 104);
            SelectDllBtn.Name = "SelectDllBtn";
            SelectDllBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SelectDllBtn.Size = new Size(100, 36);
            SelectDllBtn.TabIndex = 3;
            SelectDllBtn.Text = "Select DLL";
            SelectDllBtn.Click += SelectDllBtn_Click;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ClientLabel.ForeColor = Color.Gray;
            ClientLabel.Location = new Point(113, 11);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(44, 17);
            ClientLabel.TabIndex = 2;
            ClientLabel.Text = "Client";
            // 
            // InjectBtn
            // 
            InjectBtn.Animated = true;
            InjectBtn.BorderColor = Color.FromArgb(20, 20, 20);
            InjectBtn.BorderRadius = 6;
            InjectBtn.BorderThickness = 1;
            InjectBtn.CustomizableEdges = customizableEdges3;
            InjectBtn.DisabledState.BorderColor = Color.DarkGray;
            InjectBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            InjectBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            InjectBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            InjectBtn.FillColor = Color.FromArgb(25, 25, 25);
            InjectBtn.Font = new Font("Segoe UI", 9F);
            InjectBtn.ForeColor = Color.White;
            InjectBtn.Image = Properties.Resources.syringe_48px;
            InjectBtn.Location = new Point(259, 31);
            InjectBtn.Name = "InjectBtn";
            InjectBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            InjectBtn.Size = new Size(76, 36);
            InjectBtn.TabIndex = 1;
            InjectBtn.Text = "Inject";
            InjectBtn.Click += InjectBtn_Click;
            // 
            // ClientList
            // 
            ClientList.BackColor = Color.Transparent;
            ClientList.BorderColor = Color.FromArgb(20, 20, 20);
            ClientList.BorderRadius = 6;
            ClientList.CustomizableEdges = customizableEdges5;
            ClientList.DrawMode = DrawMode.OwnerDrawFixed;
            ClientList.DropDownStyle = ComboBoxStyle.DropDownList;
            ClientList.FillColor = Color.FromArgb(25, 25, 25);
            ClientList.FocusedColor = Color.FromArgb(20, 20, 20);
            ClientList.FocusedState.BorderColor = Color.FromArgb(20, 20, 20);
            ClientList.Font = new Font("Segoe UI", 10F);
            ClientList.ForeColor = Color.WhiteSmoke;
            ClientList.ItemHeight = 30;
            ClientList.ItemsAppearance.BackColor = Color.FromArgb(20, 20, 20);
            ClientList.ItemsAppearance.ForeColor = Color.WhiteSmoke;
            ClientList.ItemsAppearance.SelectedBackColor = Color.FromArgb(25, 25, 25);
            ClientList.ItemsAppearance.SelectedForeColor = Color.White;
            ClientList.Location = new Point(113, 31);
            ClientList.Name = "ClientList";
            ClientList.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ClientList.Size = new Size(140, 36);
            ClientList.TabIndex = 0;
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.Transparent;
            SettingsPanel.BorderColor = Color.FromArgb(25, 25, 25);
            SettingsPanel.BorderRadius = 6;
            SettingsPanel.BorderThickness = 1;
            SettingsPanel.Controls.Add(UseCustomDllBox);
            SettingsPanel.CustomizableEdges = customizableEdges9;
            SettingsPanel.FillColor = Color.FromArgb(15, 15, 15);
            SettingsPanel.Location = new Point(123, 281);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.ShadowDecoration.Color = Color.MediumPurple;
            SettingsPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            SettingsPanel.Size = new Size(438, 80);
            SettingsPanel.TabIndex = 1;
            // 
            // UseCustomDllBox
            // 
            UseCustomDllBox.Animated = true;
            UseCustomDllBox.AutoSize = true;
            UseCustomDllBox.CheckedState.BorderColor = Color.MediumPurple;
            UseCustomDllBox.CheckedState.BorderRadius = 4;
            UseCustomDllBox.CheckedState.BorderThickness = 0;
            UseCustomDllBox.CheckedState.FillColor = Color.MediumPurple;
            UseCustomDllBox.Location = new Point(10, 10);
            UseCustomDllBox.Name = "UseCustomDllBox";
            UseCustomDllBox.Size = new Size(113, 19);
            UseCustomDllBox.TabIndex = 0;
            UseCustomDllBox.Text = "Use Custom DLL";
            UseCustomDllBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            UseCustomDllBox.UncheckedState.BorderRadius = 4;
            UseCustomDllBox.UncheckedState.BorderThickness = 0;
            UseCustomDllBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // InjectorTab
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(SettingsPanel);
            Controls.Add(InjectingPanel);
            ForeColor = Color.WhiteSmoke;
            Name = "InjectorTab";
            Size = new Size(672, 450);
            InjectingPanel.ResumeLayout(false);
            InjectingPanel.PerformLayout();
            SettingsPanel.ResumeLayout(false);
            SettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel InjectingPanel;
        private Guna.UI2.WinForms.Guna2Panel SettingsPanel;
        private Guna.UI2.WinForms.Guna2ComboBox ClientList;
        private Guna.UI2.WinForms.Guna2Button InjectBtn;
        private Label DllPathLabel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button SelectDllBtn;
        private Label ClientLabel;
        private Guna.UI2.WinForms.Guna2CheckBox UseCustomDllBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel StatusLabel;
    }
}
