using System;

namespace EDA_Events
{
    public class EventProducer
    {
        // Define an event based on the EventHandler delegate
        public event EventHandler<string> OnDataReceived;

        public void GenerateEvent(string data)
        {
            // Raise the event
            OnDataReceived?.Invoke(this, data);
        }
    }
}
