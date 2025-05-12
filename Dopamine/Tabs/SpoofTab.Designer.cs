namespace Dopamine.Tabs
{
    partial class SpoofTab
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SpoofPanel = new Guna.UI2.WinForms.Guna2Panel();
            StatusLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SeparatorBottom = new Guna.UI2.WinForms.Guna2Separator();
            McVersionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SeparatorTop = new Guna.UI2.WinForms.Guna2Separator();
            MpUsernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            CidLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            McidLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            DidLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            InjectBtn = new Guna.UI2.WinForms.Guna2Button();
            CustomDidBox = new Guna.UI2.WinForms.Guna2TextBox();
            SpoofPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SpoofPanel
            // 
            SpoofPanel.BackColor = Color.Transparent;
            SpoofPanel.BorderColor = Color.FromArgb(25, 25, 25);
            SpoofPanel.BorderRadius = 6;
            SpoofPanel.BorderThickness = 1;
            SpoofPanel.Controls.Add(StatusLabel);
            SpoofPanel.Controls.Add(SeparatorBottom);
            SpoofPanel.Controls.Add(McVersionLabel);
            SpoofPanel.Controls.Add(SeparatorTop);
            SpoofPanel.Controls.Add(MpUsernameLabel);
            SpoofPanel.Controls.Add(CidLabel);
            SpoofPanel.Controls.Add(McidLabel);
            SpoofPanel.Controls.Add(DidLabel);
            SpoofPanel.Controls.Add(InjectBtn);
            SpoofPanel.Controls.Add(CustomDidBox);
            SpoofPanel.CustomizableEdges = customizableEdges5;
            SpoofPanel.FillColor = Color.FromArgb(15, 15, 15);
            SpoofPanel.Location = new Point(116, 103);
            SpoofPanel.Name = "SpoofPanel";
            SpoofPanel.ShadowDecoration.Color = Color.MediumPurple;
            SpoofPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SpoofPanel.Size = new Size(440, 244);
            SpoofPanel.TabIndex = 2;
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = Color.Transparent;
            StatusLabel.ForeColor = Color.WhiteSmoke;
            StatusLabel.Location = new Point(20, 209);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(93, 17);
            StatusLabel.TabIndex = 10;
            StatusLabel.Text = "Status: <b>Waiting...</b>";
            // 
            // SeparatorBottom
            // 
            SeparatorBottom.FillColor = Color.FromArgb(40, 40, 40);
            SeparatorBottom.Location = new Point(20, 193);
            SeparatorBottom.Name = "SeparatorBottom";
            SeparatorBottom.Size = new Size(400, 10);
            SeparatorBottom.TabIndex = 9;
            // 
            // McVersionLabel
            // 
            McVersionLabel.BackColor = Color.Transparent;
            McVersionLabel.ForeColor = Color.WhiteSmoke;
            McVersionLabel.Location = new Point(20, 170);
            McVersionLabel.Name = "McVersionLabel";
            McVersionLabel.Size = new Size(122, 17);
            McVersionLabel.TabIndex = 8;
            McVersionLabel.Text = "MC Version: <b>Loading...</b>";
            // 
            // SeparatorTop
            // 
            SeparatorTop.FillColor = Color.FromArgb(40, 40, 40);
            SeparatorTop.Location = new Point(20, 62);
            SeparatorTop.Name = "SeparatorTop";
            SeparatorTop.Size = new Size(400, 10);
            SeparatorTop.TabIndex = 7;
            // 
            // MpUsernameLabel
            // 
            MpUsernameLabel.BackColor = Color.Transparent;
            MpUsernameLabel.ForeColor = Color.WhiteSmoke;
            MpUsernameLabel.Location = new Point(20, 147);
            MpUsernameLabel.Name = "MpUsernameLabel";
            MpUsernameLabel.Size = new Size(137, 17);
            MpUsernameLabel.TabIndex = 6;
            MpUsernameLabel.Text = "MP_Username: <b>Loading...</b>";
            // 
            // CidLabel
            // 
            CidLabel.BackColor = Color.Transparent;
            CidLabel.ForeColor = Color.WhiteSmoke;
            CidLabel.Location = new Point(20, 124);
            CidLabel.Name = "CidLabel";
            CidLabel.Size = new Size(80, 17);
            CidLabel.TabIndex = 5;
            CidLabel.Text = "CID: <b>Loading...</b>";
            // 
            // McidLabel
            // 
            McidLabel.BackColor = Color.Transparent;
            McidLabel.ForeColor = Color.WhiteSmoke;
            McidLabel.Location = new Point(20, 101);
            McidLabel.Name = "McidLabel";
            McidLabel.Size = new Size(91, 17);
            McidLabel.TabIndex = 4;
            McidLabel.Text = "MCID: <b>Loading...</b>";
            // 
            // DidLabel
            // 
            DidLabel.BackColor = Color.Transparent;
            DidLabel.ForeColor = Color.WhiteSmoke;
            DidLabel.Location = new Point(20, 78);
            DidLabel.Name = "DidLabel";
            DidLabel.Size = new Size(125, 17);
            DidLabel.TabIndex = 3;
            DidLabel.Text = "Original DID: <b>Loading...</b>";
            // 
            // InjectBtn
            // 
            InjectBtn.Animated = true;
            InjectBtn.BorderColor = Color.FromArgb(20, 20, 20);
            InjectBtn.BorderRadius = 6;
            InjectBtn.BorderThickness = 1;
            InjectBtn.CustomizableEdges = customizableEdges1;
            InjectBtn.DisabledState.BorderColor = Color.DarkGray;
            InjectBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            InjectBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            InjectBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            InjectBtn.FillColor = Color.FromArgb(25, 25, 25);
            InjectBtn.Font = new Font("Segoe UI", 9F);
            InjectBtn.ForeColor = Color.White;
            InjectBtn.Image = Properties.Resources.shuffle_48px;
            InjectBtn.Location = new Point(344, 20);
            InjectBtn.Name = "InjectBtn";
            InjectBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            InjectBtn.Size = new Size(76, 36);
            InjectBtn.TabIndex = 2;
            InjectBtn.Text = "Spoof";
            InjectBtn.Click += InjectBtn_Click;
            // 
            // CustomDidBox
            // 
            CustomDidBox.Animated = true;
            CustomDidBox.BorderColor = Color.FromArgb(20, 20, 20);
            CustomDidBox.BorderRadius = 6;
            CustomDidBox.CustomizableEdges = customizableEdges3;
            CustomDidBox.DefaultText = "";
            CustomDidBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CustomDidBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CustomDidBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CustomDidBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CustomDidBox.FillColor = Color.FromArgb(25, 25, 25);
            CustomDidBox.FocusedState.BorderColor = Color.FromArgb(20, 20, 20);
            CustomDidBox.Font = new Font("Segoe UI", 9F);
            CustomDidBox.ForeColor = Color.WhiteSmoke;
            CustomDidBox.HoverState.BorderColor = Color.FromArgb(20, 20, 20);
            CustomDidBox.Location = new Point(20, 20);
            CustomDidBox.Name = "CustomDidBox";
            CustomDidBox.PlaceholderText = "Custom DID (Leave blank for random)";
            CustomDidBox.SelectedText = "";
            CustomDidBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CustomDidBox.Size = new Size(318, 36);
            CustomDidBox.TabIndex = 0;
            // 
            // SpoofTab
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(SpoofPanel);
            ForeColor = Color.WhiteSmoke;
            Name = "SpoofTab";
            Size = new Size(672, 450);
            Load += SpoofTab_Load;
            SpoofPanel.ResumeLayout(false);
            SpoofPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel SpoofPanel;
        private Guna.UI2.WinForms.Guna2TextBox CustomDidBox;
        private Guna.UI2.WinForms.Guna2Button InjectBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel DidLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel MpUsernameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel CidLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel McidLabel;
        private Guna.UI2.WinForms.Guna2Separator SeparatorTop;
        private Guna.UI2.WinForms.Guna2HtmlLabel McVersionLabel;
        private Guna.UI2.WinForms.Guna2Separator SeparatorBottom;
        private Guna.UI2.WinForms.Guna2HtmlLabel StatusLabel;
    }
}
