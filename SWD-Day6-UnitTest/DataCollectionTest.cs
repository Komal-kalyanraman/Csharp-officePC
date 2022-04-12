using NUnit.Framework;
using SWD_Day6;
using Moq;
using System.Threading.Tasks;
using System;

namespace SWD_Day6_UnitTest
{
    public class DataCollectionTest
    {
        private DataCollection _sensorData { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _sensorData = new DataCollection();
        }

        [TestCase("16")]
        public void CurrentTime_EqualTest(string input)
        {
            // Assist

            // Act
            string result = _sensorData.CurrentTime();

            // Assert
            Assert.AreEqual(result, input);
        }

        [TestCase("100")]
        [TestCase("25")]
        public void CurrentTime_NotEqualTest(string input)
        {
            // Assist

            // Act
            string result = _sensorData.CurrentTime();

            // Assert
            Assert.AreNotEqual(result, input);
        }

        [TestCase("1 watt")]
        public void SocketEnergy_EqualTest(string input)
        {
            // Assist
            Mock<DataCollection> _sensorData = new Mock<DataCollection>();

            // Act
            _sensorData.Setup(x => x.SocketEnergy()).Returns("1 watt");

            // Assert
            Assert.AreEqual(input, _sensorData.Object.SocketEnergy());
        }

    }
}
