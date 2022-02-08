using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NeHentaiGenerator.Controls;

public class RoundedButton : Button
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner-
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

    public bool RoundedCorners { get; set; } = true;
    public int EllipseRadius { get; set; } = 5;

    public RoundedButton() : base()
    {

    }
    protected virtual void DrawCorners()
    {
        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, EllipseRadius, EllipseRadius));
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if(RoundedCorners)
            DrawCorners();
    }
}