using System;

namespace AreaProcessor.Processors
{
    public class CircleProcessor : BaseProcessor
    {
        public override double ProcessArea(params double[] data)
        {
            return Constants.Variables.pi * Math.Pow(data[0], 2);
        }
    }
}
