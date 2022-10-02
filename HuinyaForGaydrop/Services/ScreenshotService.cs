using System.Drawing;
using System.Drawing.Imaging;

namespace HuinyaForGaydrop.Services;

public class ScreenshotService : IScreenshotService
{
    public string GetScreenshot(int x1, int y1, int width, int height)
    {
        Bitmap screenshot = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        Graphics graphics = Graphics.FromImage(screenshot);
        
        graphics.CopyFromScreen(x1,y1,0,0,screenshot.Size,CopyPixelOperation.SourceCopy);

        string path = $"D:/hui{x1}.jpeg";
        
        screenshot.Save(path, ImageFormat.Jpeg);

        return path;

    }
}