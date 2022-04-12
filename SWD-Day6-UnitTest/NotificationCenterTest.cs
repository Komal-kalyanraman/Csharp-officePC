using NUnit.Framework;
using SWD_Day6;

namespace SWD_Day6_UnitTest
{
    public class NotificationCenterTest
    {
        private NotificationCenter _Alert { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _Alert = new NotificationCenter();
        }

        [TestCase("Granny sleep time is over. She is out of bed")]
        public void Notification_EqualTest(string input)
        {   
            _Alert.Notification(input);
            
            // Assert
            Assert.AreEqual("Granny sleep time is over. She is out of bed", input);
        }

        [TestCase("Granny is not on bed")]
        public void Notification_NotEqualTest(string input)
        {
            _Alert.Notification(input);

            // Assert
            Assert.AreNotEqual("Granny sleep time is over. She is out of bed", input);
        }
    }
}