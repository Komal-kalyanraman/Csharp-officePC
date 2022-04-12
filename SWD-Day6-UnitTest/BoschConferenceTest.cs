using NUnit.Framework;
using SWD_Day6;
using Moq;

namespace SWD_Day6_UnitTest
{
    public class BoschConferenceTest
    {
        private BoschConference _BOCSE { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _BOCSE = new BoschConference();
        }

        [TestCase("Thanks for Watching")]
        public void CurrentUseCase_EqualTest(string input)
        {
            string result = _BOCSE.CheckUseCase();
            
            // Assert
            Assert.AreEqual(input, result);
        }
    }
}