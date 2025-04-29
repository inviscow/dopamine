using Dopamine.Utils;

namespace Dopamine.Tabs
{
    public partial class SpoofTab : UserControl
    {
        public SpoofTab()
        {
            InitializeComponent();
        }

        private void SetLabel(Guna.UI2.WinForms.Guna2HtmlLabel label, string text)
        {
            label.Text = text;
        }

        private async void SpoofTab_Load(object sender, EventArgs e)
        {
            SetLabel(DidLabel, $"DID: <b>{await Minecraft.GetDIDFromFile()}</b>");
            SetLabel(McidLabel, $"MCID: <b>N/A</b>");
            SetLabel(CidLabel, $"CID: <b>{await Minecraft.GetCIDFromFile()}</b>");
            var (err, mpUser) = await Minecraft.GetDataFromOptionsFile("mp_username");
            SetLabel(MpUsernameLabel, $"MP_Username: <b>{(err ? mpUser : "N/A")}</b>");
            SetLabel(McVersionLabel, $"MC Version: <b>{Minecraft.GetMCVersion()}</b>");
        }
    }
}
