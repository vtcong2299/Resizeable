using System;

namespace BaiTapResizeable
{
    class Program
    {
        static void Main (string [] args)
        {
            Random random = new Random();
            double percent = 1.0;

            // Circle
            percent = random.Next(1,100);
            Circle circle =  new Circle(3.5);
            Console.WriteLine("Dien tich truoc khi tang la: "+ Math.Round(circle.GetArea(),2));
            circle.Resize(percent);
            Console.WriteLine("Tang ban kinh len {0} % ta duoc ban kinh moi la {1}", percent,circle.radius);
            Console.WriteLine("Dien tich sau khi tang la: "+ Math.Round(circle.GetArea(),2));
            Console.WriteLine(circle);

            // Rectangle
            percent = random.Next(1,100);
            Rectangle rectangle =  new Rectangle(3.5,5);
            Console.WriteLine("Dien tich truoc khi tang la: "+ Math.Round(rectangle.GetArea(),2));
            rectangle.Resize(percent);
            Console.WriteLine("Tang chieu dai va rong len {0} % ta duoc width va height moi la {1} va {2}", percent,rectangle.width,rectangle.height);
            Console.WriteLine("Dien tich sau khi tang la: "+ Math.Round(rectangle.GetArea(),2));
            Console.WriteLine(rectangle);

            // Square
            percent = random.Next(1,100);
            Square square =  new Square(5);
            Console.WriteLine("Dien tich truoc khi tang la: "+ Math.Round(square.GetArea(),2));
            square.Resize(percent);
            Console.WriteLine("Tang canh hinh vuong len {0} % ta duoc kich thuoc canh moi la {1}", percent,square.width);
            Console.WriteLine("Dien tich sau khi tang la: "+ Math.Round(square.GetArea(),2));
            Console.WriteLine(square);
        }
    }
}