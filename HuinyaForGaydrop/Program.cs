// See https://aka.ms/new-console-template for more information

using HuinyaForGaydrop.Services;

ScreenshotService service = new ScreenshotService();
ImageTextDetector textDetector = new ImageTextDetector();

int x1 = 0, y1 = 0, x2 = 0, y2 = 0;





Console.SetWindowSize(100,20);

Console.WriteLine("Choose language(rus/eng)");
string language = Console.ReadLine();

try
{
    if (language == "rus")
    {
        Console.WriteLine("Введи x1 (координата левой верхней точки области скриншотов)");
        x1 = Convert.ToInt32(Console.ReadLine()); 
    
        Console.WriteLine("Введи y1 (координата левой верхней точки области скриншотов)");
        y1 = Convert.ToInt32(Console.ReadLine()); 
    
        Console.WriteLine("Введи x2 (координата правой нижней точки области скриншотов)");
        x2 = Convert.ToInt32(Console.ReadLine()); 
    
        Console.WriteLine("Введи y2 (координата правой нижней точки области скриншотов)");
        y2 = Convert.ToInt32(Console.ReadLine()); 
    
    } else if (language == "eng")
    
    {
        Console.WriteLine("иди нахуй");
        Console.ReadLine();
        return 0;
    }
    else
    {
        Console.WriteLine("ты чё даун ? Уже не можешь нормально ввести rus или eng");
        Console.ReadLine();
        return 0;
    }
}
catch (Exception e)
{
    Console.WriteLine("Ты ебалом споймал какую-то ошибку, если ты в душе не ебёшь чё за ошибка то скинь мне этот текст");
    Console.WriteLine(e.Message);
    Console.ReadLine();
    throw;
}






while (true)
{
    Console.WriteLine(textDetector.DetectText(service.GetScreenshot(x1,y1,x2, y2)));
    //Thread.Sleep(100);
}
    


