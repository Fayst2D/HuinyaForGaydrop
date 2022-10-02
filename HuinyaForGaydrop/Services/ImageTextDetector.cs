using System.Text.RegularExpressions;
using Tesseract;
using TextCopy;
using System.IO;

namespace HuinyaForGaydrop.Services;

public class ImageTextDetector : IImageTextDetector
{
    
    public string? DetectText(string path)
    {
        
        
        using (var engine = new TesseractEngine(Directory.GetCurrentDirectory(), "eng"))
        {
            Clipboard clipboard = new Clipboard();
            
            
            using (var img = Pix.LoadFromFile(path))
            {
                using (var page = engine.Process(img))
                {
                    var text = page.GetText();

                    if (Regex.IsMatch(text, "^BONUS_"))
                    {
                        clipboard.SetText(text);
                    }
                    
                    return text;
                }
            }
        }

        return null;
    }
}