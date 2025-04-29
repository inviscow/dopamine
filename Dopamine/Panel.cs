using Dopamine.Utils;
using System.Diagnostics;

namespace Dopamine
{
    public partial class Panel : Form
    {
        private UserControl? currentTab;
        private Guna.UI2.WinForms.Guna2DragControl tempDragControl;

        public Panel()
        {
            InitializeComponent();
        }

        private void OpenTab(UserControl tab)
        {
            if (currentTab != null)
            {
                UserControlHolder.Controls.Remove(currentTab);
                currentTab.Dispose();
                tempDragControl.Dispose();
            }

            currentTab = tab;
            currentTab.Dock = DockStyle.Fill;
            UserControlHolder.Controls.Add(currentTab);
            tempDragControl = new Guna.UI2.WinForms.Guna2DragControl(this);
            tempDragControl.TargetControl = tab;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void InjectorBtn_Click(object sender, EventArgs e)
        {
            OpenTab(new Tabs.InjectorTab());
        }

        private void SpooferBtn_Click(object sender, EventArgs e)
        {
            OpenTab(new Tabs.SpoofTab());
        }

        private void OpenAppDirectoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void OpenMcDirectoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = $"\"{Minecraft.McpeDirectory}\"",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
    }
}
