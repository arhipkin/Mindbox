using AreaProcessor;
using AreaProcessor.Processors;
using AreaProcessor_v2;
using AreaProcessor_v2.Interfaces;
using AreaProcessor_v2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class TriangleProcessorTest
    {
        [TestMethod]
        public void Process()
        {
            double a = 5;
            double b = 3;
            double c = 4;

            BaseProcessor _processorTriangle = AreaFactory.CreateProcessor(AreaProcessor.Constants.FigureTypes.Triangle);
            var result = _processorTriangle.ProcessArea(a, b, c);
            var isRectangular = _processorTriangle.IsRectangular(a, b, c);

            Assert.AreEqual(result, 77.768888380894325);
            Assert.IsTrue(isRectangular);
        }

        [TestMethod]
        public void Process_v2()
        {
            double a = 5;
            double b = 3;
            double c = 4;

            IBaseProcessor<TriangleResult> _processorTriangle_v2 = AreaFactory<TriangleResult>.CreateProcessor(AreaProcessor_v2.Constants.FigureTypes.Triangle);
            var result = _processorTriangle_v2.Process(a, b, c);

            Assert.AreEqual(result.area, 77.768888380894325);
            Assert.IsTrue(result.isRectangular);
        }
    }
}
