using DiscordRPC;
using NeHentaiGenerator.Properties;
using NekosSharp;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Media;
using System.Net;

namespace NeHentaiGenerator;
public partial class MainForm : Form
{
    private DiscordRpcClient rpcClient;
    private NekoClient nekoClient;
    private static readonly DateTime startTime = DateTime.Now;
    private static readonly DateTime startUTCTime = DateTime.UtcNow;

    private Image sourceImage;
    private Image scaledImage;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainFormLoad(object sender, EventArgs e)
    {
        optionScreen.Hide();
        menuScreen.Show();
        backButton.Hide();
        downloadButton.BringToFront();
        nextButton.BringToFront();
        menuScreen.Dock = DockStyle.Fill;
        optionScreen.Dock = DockStyle.Fill;
        UpdateDiscordRPC("Example", false);
    }

    private void OptionsOpen(object sender, EventArgs e)
    {
        optionScreen.Show();
        menuScreen.Hide();
        backButton.Show();
        UpdateDiscordRPC("Example", true);
    }

    private void OptionsClose(object sender, EventArgs e)
    {
        optionScreen.Hide();
        menuScreen.Show();
        backButton.Hide();
        UpdateDiscordRPC("Example", false);
    }
    private bool isDownload = false;
    private async void DownloadClick(object sender, EventArgs e)
    {
        if (sourceImage is null)
        {
            SystemSounds.Hand.Play();
            return;
        }
        if (isDownload)
            return;

        isDownload = true;
        using (FileStream fs = (FileStream)imageSaveDialog.OpenFile())
        {
            imageSaveDialog.ShowDialog();
            switch (imageSaveDialog.FilterIndex)
            {
                case 1:
                    sourceImage.Save(fs, ImageFormat.Jpeg);
                    break;

                case 2:
                    sourceImage.Save(fs, ImageFormat.Png);
                    break;

                case 3:
                    sourceImage.Save(fs, ImageFormat.Gif);
                    break;
            }
            imageSaveDialog.Dispose();
        }
        isDownload = false;
    }
    private bool isNextClickStarted = false;
    private async void NextClick(object sender, EventArgs e)
    {
        if (isNextClickStarted)
            return;
        try
        {
            nekoClient ??= new NekoClient("neHentaiGenerator");
            Request request = await nekoClient.Nsfw.Hentai();
            if (!request.Success)
            {
                MessageBox.Show($"Request error ocured\nCode: {request.Code}\nError: {request.Error}", "neHentaiGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (WebClient client = new WebClient())
                {
                    string pathToDownload = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) ?? Directory.GetCurrentDirectory();
                    if (pathToDownload is null)
                        MessageBox.Show("Cache folder not found", "Error", MessageBoxButtons.OK);
                    pathToDownload += Path.GetFileNameWithoutExtension(request.ImageUrl);
                    client.DownloadFileTaskAsync(request.ImageUrl, pathToDownload);
                    client.DownloadFileCompleted += (s, o) =>
                    {
                        sourceImage = Image.FromFile(pathToDownload);
                        imageSaveDialog.FileName = Path.GetFileNameWithoutExtension(request.ImageUrl);
                        scaledImage = ResizeImageByHight(sourceImage, picture.Height - 20);
                        picture.Image = scaledImage;
                        //TODO: generated images ++
                    };
                }
            }
        }
        catch (Exception) { }
        isNextClickStarted = false;
    }
    private void UpdateDiscordRPC(string name, bool inOptions = false)
    {
        int count = Settings.Default.count;
        bool enableRPC = Settings.Default.discord_rpc;

        if (!enableRPC)
            return;

        if (rpcClient is null)
        {
            rpcClient = new DiscordRpcClient("940607688155471882");
            rpcClient.Initialize();
            rpcClient.Invoke();
        }
        rpcClient.SetPresence(new RichPresence()
        {
            State = inOptions ? "In Options" : $"Generate images: {count}",
            Details = "Tags: tag1 | tag2 | tag3",
            Timestamps = new Timestamps(startUTCTime, null)
        });
    }

    private void discordRPCCheckedChanged(object sender, EventArgs e)
    {
        Settings.Default.discord_rpc = !Settings.Default.discord_rpc;
    }
    public Image ResizeImageByHight(Image image, int requiredHiegth)
    {
        int height = image.Height;

        float ratio = (float)requiredHiegth / height;
        return ResizeImage(image, (int)(height * ratio), (int)(image.Width * ratio));
    }
    public Image ResizeImage(Image image, int height, int width)
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

    private void OnSizeChanged(object sender, EventArgs e)
    {
        if (sourceImage is null)
            return;

        scaledImage = ResizeImageByHight(sourceImage, base.Height);
        picture.Image = scaledImage;
    }

    private void Press(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Next:
                {
                    this.NextClick(this, null);
                    break;
                }
            case Keys.D:
                {
                    this.DownloadClick(this, null);
                    break;
                }
        }
    }
}