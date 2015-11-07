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
                try
                {
                    Console.WriteLine(_XPixel);
                    _xpixels = int.Parse(Console.ReadLine());
                    Console.WriteLine(_YPixels);
                    _ypixels = int.Parse(Console.ReadLine());
                    Console.WriteLine(_screensize);
                    _inches = double.Parse(Console.ReadLine());
                    Console.WriteLine("Your screen has a PPI of " + CalculateDpi());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                if (args.Length == 3)
                {
                    try
                    {
                        _xpixels = int.Parse(args[0]);
                        _xpixels = int.Parse(args[1]);
                        _inches = double.Parse(args[2]);
                        Console.WriteLine("Your screen has a PPI of " + CalculateDpi());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            
            Console.ReadKey();
        }

        static double CalculateDpi()
        {
            return Math.Sqrt((_xpixels*_xpixels) + (_ypixels*_ypixels))/_inches;
        }
    }
}
