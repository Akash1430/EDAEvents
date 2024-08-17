using System;

namespace EDA_Events.Consumer
{
    public class EventConsumer2 :EventConsumer
    {

        protected override void HandleDataReceived(object sender, string data)
        {
            Console.WriteLine($"Data received EventConsumer2: {data}");
        }
    }
}
