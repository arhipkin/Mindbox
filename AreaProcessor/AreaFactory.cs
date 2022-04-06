using AreaProcessor.Constants;
using AreaProcessor.Processors;
using System;

namespace AreaProcessor
{
    public static class AreaFactory
    {
        public static BaseProcessor CreateProcessor(FigureTypes type)
        {
            switch (type) {
                case FigureTypes.Circle:
                    return new CircleProcessor();
                case FigureTypes.Triangle:
                    return new TriangleProcessor();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
