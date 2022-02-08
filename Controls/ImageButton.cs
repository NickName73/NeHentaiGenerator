using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeHentaiGenerator.Controls;

public class ImageButton : Button
{
    public Size ImageSize { get; set; } = new Size(32, 32);

    private Lazy<Bitmap> resizedImage;
    public ImageButton() : base()
    {
        resizedImage = new Lazy<Bitmap>( () => new Bitmap(Image, ImageSize));
    }
    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        if(Image != null)
        {
            Image = resizedImage.Value;
        }
    }
}