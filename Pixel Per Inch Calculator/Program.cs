using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Per_Inch_Calculator
{
    class Program
    {
        private static string _XPixel = "Number of horizontal pixels:",_YPixels="Number of vertical pixels:",_screensize="Size of screen in inches:";
        private static int _xpixels = 0, _ypixels = 0;
        static double _inches = 0;
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(_XPixel);
                int.TryParse(Console.ReadLine(),out _xpixels);
                Console.WriteLine(_YPixels);
                int.TryParse(Console.ReadLine(), out _ypixels);
                Console.WriteLine(_screensize);
                double.TryParse(Console.ReadLine(), out _inches);
                Console.WriteLine("Your screen has a PPI of "+Math.Sqrt((_xpixels*_xpixels)+(_ypixels*_ypixels))/_inches);
            }
            else
            {
                if (args.Length == 3)
                {
                    int.TryParse(args[0], out _xpixels);
                    int.TryParse(args[1], out _ypixels);
                    double.TryParse(args[2], out _inches);
                    Console.WriteLine("Your screen has a PPI of " + Math.Sqrt((_xpixels * _xpixels) + (_ypixels * _ypixels)) / _inches);
                }
            }
            Console.ReadKey();
        }
    }
}
