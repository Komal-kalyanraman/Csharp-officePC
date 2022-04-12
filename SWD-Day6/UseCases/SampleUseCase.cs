using System.Collections.Generic;

namespace SWD_Day6
{
    public class SampleUseCase
    {
        InputExtractor inputJson = new InputExtractor();
        DataCollection sensorData = new DataCollection();
        private string result;

        public string CheckUseCase()
        {
            Task.Delay(1).Wait();
            return result;
        }
    }
}