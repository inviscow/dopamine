namespace Dopamine
{
    public partial class Panel : Form
    {
        private UserControl? currentTab;

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
            }

            currentTab = tab;
            currentTab.Dock = DockStyle.Fill;
            UserControlHolder.Controls.Add(currentTab);
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

        }
    }
}
