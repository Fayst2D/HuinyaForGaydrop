using System.Drawing;
using System.Drawing.Imaging;

namespace HuinyaForGaydrop.Services;

public class ScreenshotService : IScreenshotService
{
    public string GetScreenshot(int x1, int y1, int x2, int y2)
    {
        Bitmap screenshot = new Bitmap(x2-x1, y2-y1, PixelFormat.Format32bppArgb);
        Graphics graphics = Graphics.FromImage(screenshot);
        
        graphics.CopyFromScreen(x1,y1,0,0,screenshot.Size,CopyPixelOperation.SourceCopy);

        string path = $"D:/hui.jpeg";
        
        screenshot.Save(path, ImageFormat.Jpeg);

        return path;
    }
}