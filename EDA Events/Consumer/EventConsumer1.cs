using EDA_Events.Consumer;
using System;

namespace EDA_Events
{
    public class EventConsumer1 : EventConsumer
    {

        protected override void HandleDataReceived(object sender, string data)
        {
            Console.WriteLine($"Data received EventConsumer1: {data}");
        }
    }
}
