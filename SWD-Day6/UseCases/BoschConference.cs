using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class BoschConference
    {
        DataCollection sensorData = new DataCollection();
        InputExtractor inputJson = new InputExtractor();

        private string result;
        private string response;

        public string CheckUseCase()
        {
            inputJson.ReadFile();

            string Timer;
            inputJson.InputData.TryGetValue("Timer", out Timer);
            
            ///
            Console.WriteLine("Timer value is " + Timer);
            
            int TimerInt = 0;
            Int32.TryParse(Timer, out TimerInt);

            for(int i=0; i<5; i++)
            {
                response = sensorData.TurnOnSocket();
                
                ///
                Console.WriteLine(response);
                Task.Delay(TimerInt*100).Wait();

                response = sensorData.TurnOffSocket();
                
                ///
                Console.WriteLine(response);
                Task.Delay(TimerInt*100).Wait();
            }

            result = "Thanks for Watching";

            return result;
        }
    }
}