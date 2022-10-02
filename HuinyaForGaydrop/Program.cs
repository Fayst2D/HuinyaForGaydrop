// See https://aka.ms/new-console-template for more information

using HuinyaForGaydrop.Services;

ScreenshotService service = new ScreenshotService();
ImageTextDetector textDetector = new ImageTextDetector();

int x1 = 0, y1 = 0, width = 0, height = 0;




Console.WriteLine("Choose language(rus/eng)");
string language = Console.ReadLine();

if (language == "rus")
{
    Console.WriteLine("Введи x1 (координата левой верхней точки области скриншотов)");
    x1 = Convert.ToInt32(Console.ReadLine()); 
    
    Console.WriteLine("Введи y1 (координата левой верхней точки области скриншотов)");
    y1 = Convert.ToInt32(Console.ReadLine()); 
    
    Console.WriteLine("Введи ширину (если IQ больше 3 то понятно)");
    width = Convert.ToInt32(Console.ReadLine()); 
    
    Console.WriteLine("Введи высоту (если IQ больше 4 то понятно)");
    height = Convert.ToInt32(Console.ReadLine()); 
    
} else if (language == "eng")
    
{
    Console.WriteLine("иди нахуй");
}
else
{
    Console.WriteLine("ты чё даун ? Уже не можешь нормально ввести rus или eng");
}





while (true)
{
    Console.WriteLine(textDetector.DetectText(service.GetScreenshot(x1,y1,width,height)));
    //Thread.Sleep(100);
}
    


