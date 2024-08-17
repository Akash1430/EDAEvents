namespace EDA_Events.Consumer
{
    public abstract class EventConsumer
    {
        public void Subscribe(EventProducer producer)
        {
            // Subscribe to the event
            producer.OnDataReceived += HandleDataReceived;
        }

        protected abstract void HandleDataReceived(object sender, string data);
    }
}
