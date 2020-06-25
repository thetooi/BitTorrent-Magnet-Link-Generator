using System.Windows.Forms;

namespace BitTorrent_Magnet_Link_Generator
{
    public partial class DonateForm : Form
    {
        public DonateForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            _ = System.Diagnostics.Process.Start("bitcoin:33Z8Gmnur9Je4DzEKMnRG75sXdPb5ZTTby??label=Donate to BitTorrent Magnet Link Generator");
        }
    }
}
