using AreaProcessor;
using AreaProcessor.Processors;
using AreaProcessor_v2;
using AreaProcessor_v2.Interfaces;
using AreaProcessor_v2.Models;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter circle radius, must be positive value more than 0");

            if (double.TryParse(Console.ReadLine(), out radius))
            {
                BaseProcessor _processorCircle = AreaFactory.CreateProcessor(AreaProcessor.Constants.FigureTypes.Circle);
                Console.WriteLine(_processorCircle.ProcessArea(radius));

                IBaseProcessor<double> _processorCircle_v2 = AreaFactory<double>.CreateProcessor(AreaProcessor_v2.Constants.FigureTypes.Circle);
                Console.WriteLine(_processorCircle_v2.Process(radius));
            }
            else
            {
                Console.WriteLine("Error - invalid radius");
            }

            double a, b, c;
            Console.WriteLine("Enter triangle 3 sides, must be positive values more than 0");

            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
            {
                BaseProcessor _processorTriangle = AreaFactory.CreateProcessor(AreaProcessor.Constants.FigureTypes.Triangle);
                Console.WriteLine(_processorTriangle.ProcessArea(a, b, c));
                Console.WriteLine(_processorTriangle.IsRectangular(a, b, c));

                IBaseProcessor<TriangleResult> _processorTriangle_v2 = AreaFactory<TriangleResult>.CreateProcessor(AreaProcessor_v2.Constants.FigureTypes.Triangle);
                var _result = _processorTriangle_v2.Process(a, b, c);
                Console.WriteLine(_result.area);
                Console.WriteLine(_result.isRectangular);
            }
            else
            {
                Console.WriteLine("Error - invalid sides");
            }

            Console.ReadLine();
        }
    }
}
