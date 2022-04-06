using AreaProcessor_v2.Constants;
using AreaProcessor_v2.Interfaces;
using AreaProcessor_v2.Processors;
using System;

namespace AreaProcessor_v2
{
    public static class AreaFactory<TResult>
    {
        public static IBaseProcessor<TResult> CreateProcessor(FigureTypes type)
        {
            switch (type) {
                case FigureTypes.Circle:
                    return (IBaseProcessor<TResult>) new CircleProcessor();
                case FigureTypes.Triangle:
                    return (IBaseProcessor<TResult>) new TriangleProcessor();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
