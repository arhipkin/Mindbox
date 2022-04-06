using AreaProcessor;
using AreaProcessor.Processors;
using AreaProcessor_v2;
using AreaProcessor_v2.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CircleProcessorTest
    {
        [TestMethod]
        public void Process()
        {
            double radius = 12.3;

            BaseProcessor _processorCircle = AreaFactory.CreateProcessor(AreaProcessor.Constants.FigureTypes.Circle);
            var result = _processorCircle.ProcessArea(radius);

            Assert.AreEqual(result, 475.29115110000004);
        }

        [TestMethod]
        public void Process_v2()
        {
            double radius = 12.3;

            IBaseProcessor<double> _processorCircle_v2 = AreaFactory<double>.CreateProcessor(AreaProcessor_v2.Constants.FigureTypes.Circle);
            var result = _processorCircle_v2.Process(radius);

            Assert.AreEqual(result, 475.29115110000004);
        }
    }
}
