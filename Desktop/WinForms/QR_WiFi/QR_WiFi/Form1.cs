using QRCoder;
using System.Drawing.Imaging;

namespace QR_WiFi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string ssid = tbSsid.Text;
            string pass = tbPass.Text;

            var wifi = $"WIFI:T:WPA;S:{ssid};P:{pass};;";
            var qrGenerator = new QRCodeGenerator();
            var qrData = qrGenerator.CreateQrCode(wifi, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new BitmapByteQRCode(qrData);
            var qrBytes = qrCode.GetGraphic(20);
            var bitmap = new Bitmap(new MemoryStream(qrBytes));
            
            if (!string.IsNullOrWhiteSpace(ssid) || !string.IsNullOrWhiteSpace(pass)) {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Success!";

                pbQrCode.Image = new Bitmap(bitmap, pbQrCode.Size);

                bitmap.Save($"../../../{ssid}_qr.png", ImageFormat.Png);
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "SSID or pass empty!";
            }

            
        }
    }
}
