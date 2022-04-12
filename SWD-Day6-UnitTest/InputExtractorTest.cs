using NUnit.Framework;
using SWD_Day6;

namespace SWD_Day6_UnitTest
{
    public class InputExtractorTest
    {
        private InputExtractor _Finder { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _Finder = new InputExtractor();
            _Finder.ReadFile();
        }

        [TestCase("TimeBasedMonitoring")]
        public void UseCase_EqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.UseCase();

            // Assert
            Assert.AreEqual(result, input);
        }

        [TestCase("SocketEnergyMonitoring")]
        [TestCase("GrannySleepMonitoring")]
        [TestCase("BoschConference")]
        public void UseCase_NotEqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.UseCase();

            // Assert
            Assert.AreNotEqual(result, input);
        }

        [TestCase("0")]
        public void SocketEnergyThreshold_EqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.SocketEnergyThreshold();

            // Assert
            Assert.AreEqual(result, input);
        }

        [TestCase("1")]
        [TestCase("10")]
        [TestCase("100")]
        public void SocketEnergyThreshold_NotEqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.SocketEnergyThreshold();

            // Assert
            Assert.AreNotEqual(result, input);
        }

        [TestCase("1")]
        public void StartTime_EqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.StartTime();

            // Assert
            Assert.AreEqual(result, input);
        }

        [TestCase("5")]
        [TestCase("10")]
        [TestCase("20")]
        public void StartTime_NotEqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.StartTime();

            // Assert
            Assert.AreNotEqual(result, input);
        }

        [TestCase("20")]
        public void EndTime_EqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.EndTime();

            // Assert
            Assert.AreEqual(result, input);
        }

        [TestCase("1")]
        [TestCase("10")]
        [TestCase("22")]
        public void EndTime_NotEqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.EndTime();

            // Assert
            Assert.AreNotEqual(result, input);
        }

        [TestCase("0")]
        public void Timer_EqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.Timer();

            // Assert
            Assert.AreEqual(result, input);
        }

        [TestCase("1")]
        [TestCase("7")]
        [TestCase("14")]
        public void Timer_NotEqualTest(string input)
        {
            // Assist

            // Act
            string result = _Finder.Timer();

            // Assert
            Assert.AreNotEqual(result, input);
        }
    }
}
