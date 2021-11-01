namespace Base.Events.Base
{
    public interface IEventChannel
    {
        public void Subscribe(ISubscriber subscriber);

        public void Unsubscribe(ISubscriber subscriber);

        public void Publish();
    }

    public interface IEventChannel<T>
    {
        public void Subscribe(ISubscriber<T> subscriber);

        public void Unsubscribe(ISubscriber<T> subscriber);

        public void Publish(T data);
    }
}