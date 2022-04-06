using System;

namespace AreaProcessor.Processors
{
    public abstract class BaseProcessor
    {
        public virtual double ProcessArea(params double[] data)
        {
            throw new NotImplementedException();
        } 
        public virtual bool IsRectangular(params double[] data)
        {
            throw new NotImplementedException();
        }
    }
}
