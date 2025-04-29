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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            DllPathLabel = new Label();
            label1 = new Label();
            SelectDllBtn = new Guna.UI2.WinForms.Guna2Button();
            ClientLabel = new Label();
            InjectBtn = new Guna.UI2.WinForms.Guna2Button();
            ClientList = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            UseCustomDllBox = new Guna.UI2.WinForms.Guna2CheckBox();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.FromArgb(25, 25, 25);
            guna2Panel1.BorderRadius = 6;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(DllPathLabel);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(SelectDllBtn);
            guna2Panel1.Controls.Add(ClientLabel);
            guna2Panel1.Controls.Add(InjectBtn);
            guna2Panel1.Controls.Add(ClientList);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.FillColor = Color.FromArgb(15, 15, 15);
            guna2Panel1.Location = new Point(112, 56);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.Color = Color.MediumPurple;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(449, 169);
            guna2Panel1.TabIndex = 0;
            // 
            // DllPathLabel
            // 
            DllPathLabel.AutoSize = true;
            DllPathLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DllPathLabel.ForeColor = Color.Silver;
            DllPathLabel.Location = new Point(219, 120);
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
            label1.Location = new Point(113, 90);
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
            SelectDllBtn.Location = new Point(113, 110);
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
            ClientLabel.Location = new Point(113, 17);
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
            InjectBtn.Location = new Point(259, 37);
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
            ClientList.Location = new Point(113, 37);
            ClientList.Name = "ClientList";
            ClientList.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ClientList.Size = new Size(140, 36);
            ClientList.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.FromArgb(25, 25, 25);
            guna2Panel2.BorderRadius = 6;
            guna2Panel2.BorderThickness = 1;
            guna2Panel2.Controls.Add(UseCustomDllBox);
            guna2Panel2.CustomizableEdges = customizableEdges9;
            guna2Panel2.FillColor = Color.FromArgb(15, 15, 15);
            guna2Panel2.Location = new Point(123, 281);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.Color = Color.MediumPurple;
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel2.Size = new Size(438, 80);
            guna2Panel2.TabIndex = 1;
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
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            ForeColor = Color.WhiteSmoke;
            Name = "InjectorTab";
            Size = new Size(672, 450);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox ClientList;
        private Guna.UI2.WinForms.Guna2Button InjectBtn;
        private Label DllPathLabel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button SelectDllBtn;
        private Label ClientLabel;
        private Guna.UI2.WinForms.Guna2CheckBox UseCustomDllBox;
    }
}
