using AreaProcessor_v2.Interfaces;
using System;

namespace AreaProcessor_v2.Processors
{
    public class CircleProcessor : IBaseProcessor<double>
    {
        public double Process(params double[] data)
        {
            return Constants.Variables.pi * Math.Pow(data[0], 2);
        }
    }
}
