using AreaProcessor_v2.Interfaces;
using AreaProcessor_v2.Models;
using System;
using System.Linq;

namespace AreaProcessor_v2.Processors
{
    public class TriangleProcessor : IBaseProcessor<TriangleResult>
    {
        public TriangleResult Process(params double[] data)
        {
            var p = data.Sum();
            var _area = Math.Sqrt(p * (p - data[0]) * (p - data[1]) * (p - data[2]));

            Array.Sort(data);
            var _isRectangular = Math.Pow(data[2], 2) == Math.Pow(data[1], 2) + Math.Pow(data[0], 2);

            return new TriangleResult
            {
                area = _area,
                isRectangular = _isRectangular
            };
        }
    }
}
