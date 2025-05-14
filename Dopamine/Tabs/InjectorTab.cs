using Dopamine.Handlers;

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
            ClientList.Items.Add("Orphan");
        }

        private async void InjectBtn_Click(object sender, EventArgs e)
        {
            if (!UseCustomDllBox.Checked)
            {
                var (success, response) = await Injection.GetAndInjectClient(ClientList.SelectedItem.ToString());
            } else
            {
                if (!string.IsNullOrEmpty(pathToCustomDll))
                {
                    var (err, dllMsg) = await Injection.InjectDLL(pathToCustomDll);
                    MessageBox.Show(dllMsg); 
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
                pathToCustomDll = FileIn.FileName ;
            }
        }
    }
}
