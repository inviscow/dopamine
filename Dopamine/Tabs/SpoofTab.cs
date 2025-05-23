using Dopamine.Utils;
using DotNetConfig;

namespace Dopamine.Tabs
{
    public partial class SpoofTab : UserControl
    {
        public SpoofTab()
        {
            InitializeComponent();
        }

        private void SetLabel(Guna.UI2.WinForms.Guna2HtmlLabel label, string text) =>
            label.Text = text;

        private async void SpoofTab_Load(object sender, EventArgs e)
        {
            CustomDidBox.Text = Data.GetConfig().GetString("Spoofer", "DID", "CustomDid");
            SetLabel(DidLabel, $"Original DID: <b>{await Minecraft.GetDIDFromFile()}</b>");
            SetLabel(McidLabel, $"MCID: <b>N/A</b>");
            SetLabel(CidLabel, $"CID: <b>{await Minecraft.GetCIDFromFile()}</b>");
            var (err, mpUser) = await Minecraft.GetDataFromOptionsFile("mp_username");
            SetLabel(MpUsernameLabel, $"MP_Username: <b>{(err ? mpUser : "N/A")}</b>");
            SetLabel(McVersionLabel, $"MC Version: <b>{Minecraft.GetMCVersion()}</b>");
        }

        private async void InjectBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CustomDidBox.Text))
                Data.GetConfig().SetString("Spoofer", "DID", "CustomDid", CustomDidBox.Text);
            else
                Data.GetConfig().RemoveSection("Spoofer", "DID");
            StatusLabel.Text = "Status: <b>Randomizing data...</b>";
            var (err, resp) = await Handlers.Spoof.RandomizeData();
            StatusLabel.Text = $"Status: <b>{(err ? "Spoofing DID..." : "An error has occurred. " + resp)}</b>";
            var (err2, didSpoofResp) = await Handlers.Spoof.SpoofDID(CustomDidBox.Text);
            StatusLabel.Text = $"Status: <b>{(err2 ? "Complete! Waiting..." : "An error has occurred. " + didSpoofResp)}</b>";
            SetLabel(DidLabel, $"Spoofed DID: <b>{didSpoofResp}</b>");
        }
    }
}
