using Dopamine.Handlers;
using DotNetConfig;
using System.Diagnostics;

namespace Dopamine.Tabs
{
    public partial class InjectorTab : UserControl
    {
        private static string pathToCustomDll = string.Empty;
        public InjectorTab()
        {
            InitializeComponent();
            ClientList.Items.Add("Horion");
            ClientList.Items.Add("Latite");
            ClientList.Items.Add("Flarial");
            ClientList.Items.Add("Onix");
            ClientList.SelectedIndex = 0;
            try
            {
                string savedDllPath = Utils.Data.GetConfig().GetString("Injector", "Dll", "CustomDllPath");
                string savedDllName = Utils.Data.GetConfig().GetString("Injector", "Dll", "CustomDllName");
                if (!string.IsNullOrEmpty(savedDllPath))
                    pathToCustomDll = savedDllPath;
                if (!string.IsNullOrEmpty(savedDllName))
                    DllPathLabel.Text = savedDllName;

                UseCustomDllBox.Checked = (bool)Utils.Data.GetConfig().GetBoolean("Injector", "Dll", "UseCustomDll");
            }
            catch (Exception) { }
        }

        private async void InjectBtn_Click(object sender, EventArgs e)
        {
            if (ClientList.SelectedIndex < 0) return;

            if (!UseCustomDllBox.Checked)
            {
                var (success, response) = await Injection.GetAndInjectClient(ClientList.SelectedItem.ToString());
                StatusLabel.Text = $"<b>Status:</b> {response}";
            }
            else
            {
                if (!string.IsNullOrEmpty(pathToCustomDll))
                {
                    var (err, dllMsg) = await Injection.InjectDLL(pathToCustomDll);
                    StatusLabel.Text = $"<b>Status:</b> {dllMsg}";
                }
            }
        }

        private void SelectDllBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileIn = new OpenFileDialog();
            FileIn.Filter = "Dll |*.dll";
            if (FileIn.ShowDialog() == DialogResult.OK)
            {
                DllPathLabel.Text = FileIn.SafeFileName;
                pathToCustomDll = FileIn.FileName;
                try
                {
                    Utils.Data.GetConfig().SetString("Injector", "Dll", "CustomDllPath", FileIn.FileName);
                    Utils.Data.GetConfig().SetString("Injector", "Dll", "CustomDllName", FileIn.SafeFileName);
                }
                catch (Exception) { }
            }
        }

        private void UseCustomDllBox_CheckedChanged(object sender, EventArgs e)
        {
            Utils.Data.GetConfig().SetBoolean("Injector", "Dll", "UseCustomDll", UseCustomDllBox.Checked);
        }

        private void KillMcBtn_Click(object sender, EventArgs e)
        {
            Process[] targetProcessIndex = Process.GetProcessesByName("Minecraft.Windows");
            foreach (Process process in targetProcessIndex)
                process.Kill();
        }
    }
}
