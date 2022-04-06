using System;
using System.Linq;

namespace AreaProcessor.Processors
{
    public class TriangleProcessor : BaseProcessor
    {
        public override double ProcessArea(params double[] data)
        {
            var p = data.Sum();
            return Math.Sqrt(p * (p - data[0]) * (p - data[1]) * (p - data[2]));
        }

        public override bool IsRectangular(params double[] data)
        {
            Array.Sort(data);
            return Math.Pow(data[2], 2) == Math.Pow(data[1], 2) + Math.Pow(data[0], 2);
        }
    }
}
