namespace Dopamine.Tabs
{
    public partial class InjectorTab : UserControl
    {
        private static string pathToCustomDll = string.Empty;
        public InjectorTab()
        {
            InitializeComponent();
        }

        private async void InjectBtn_Click(object sender, EventArgs e)
        {
            if (!UseCustomDllBox.Checked)
            {

            } else
            {
                if (!string.IsNullOrEmpty(pathToCustomDll))
                {
                    var (err, dllMsg) = await Handlers.Injection.InjectDLL(pathToCustomDll);
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
