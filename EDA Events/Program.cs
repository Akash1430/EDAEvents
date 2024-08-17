using EDA_Events.Consumer;
using System;

namespace EDA_Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var producer = new EventProducer();
            var consumer1 = new EventConsumer1();
            var consumer2 = new EventConsumer2();

            consumer1.Subscribe(producer);
            consumer2.Subscribe(producer);
            producer.GenerateEvent("Hello, World!");

            Console.ReadKey();
        }
    }
}
