using NUnit.Framework;
using SWD_Day6;
using Moq;
using System.Threading.Tasks;

namespace SWD_Day6_UnitTest
{
    public class GrannySleepMonitoringTest
    {
        private GrannySleepMonitoring _GSM { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _GSM = new GrannySleepMonitoring();
        }

    }
}
