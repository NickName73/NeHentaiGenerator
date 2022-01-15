using NekosSharp;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;

namespace NeHentaiGenerator
{
    public partial class neHentaiForm : Form
    {
        private static NekoClient client;
        private static Image originalImage;
        public neHentaiForm()
        {
            InitializeComponent();
            client = new NekoClient("neHentaiGenerator");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string hentaiUrl = GetUrlFromTag(tagBox.Text);
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(hentaiUrl);
                using (MemoryStream mem = new MemoryStream(data))
                {
                    Image image = Image.FromStream(mem);
                    hentaiPictureBox.Image = ResizeImage(image, 400, 400);
                }

            }
        }
        public Bitmap NormalizeImage(Image image)
        {
            return ResizeImage(image, (int)numX.Value, (int)numY.Value);
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        /*
        Hentai
        Femdom
        Feet
        Neko
        BOObs
        Pussy
        Cum
        Spank
        Blowjob
        Yuri
        Lewd
        Lewd Yuri
        Lewd Fox
        Avatar
         */
        private string GetUrlFromTag(string tag)
        {
            switch (tag)
            {
                case "Hentai":
                    {
                        return client.Nsfw.Hentai().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Femdom":
                    {
                        return client.Nsfw.Femdom().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Feet":
                    {
                        return client.Nsfw.Feet().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Neko":
                    {
                        return client.Nsfw.Neko().GetAwaiter().GetResult().ImageUrl;
                    }
                case "BOObs":
                    {
                        return client.Nsfw.Boobs().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Pussy":
                    {
                        return client.Nsfw.Pussy().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Cum":
                    {
                        return client.Nsfw.Cum().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Spank":
                    {
                        return client.Nsfw.Spank().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Blowjob":
                    {
                        return client.Nsfw.Blowjob().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Yuri":
                    {
                        return client.Nsfw.Yuri().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Lewd":
                    {
                        return client.Nsfw.Lewd().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Lewd Yuri":
                    {
                        return client.Nsfw.LewdYuri().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Lewd Fox":
                    {
                        return client.Nsfw.LewdFox().GetAwaiter().GetResult().ImageUrl;
                    }
                case "Avatar":
                    {
                        return client.Nsfw.Avatar().GetAwaiter().GetResult().ImageUrl;
                    }
            }
            return client.Nsfw.Avatar().GetAwaiter().GetResult().ImageUrl;
        }
        private void saveImage(object sender, EventArgs e)
        {
            if (hentaiPictureBox.Image != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPeg Image|*.jpg|PNG Image|*.png|Gif Image|*.gif";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {

                    FileStream fs = (FileStream)saveFileDialog1.OpenFile();

                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            hentaiPictureBox.Image.Save(fs,
                              System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            hentaiPictureBox.Image.Save(fs,
                              System.Drawing.Imaging.ImageFormat.Png);
                            break;

                        case 3:
                            hentaiPictureBox.Image.Save(fs,
                              System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }

                    fs.Close();
                }
                else
                {
                    System.Media.SystemSounds.Hand.Play();
                }
            }
        }
    }
}