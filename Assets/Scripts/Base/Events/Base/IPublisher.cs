namespace Base.Events.Base
{
    public interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);

        void Unsubscribe(ISubscriber subscriber);

        void NotifySubscribers();
    }

    public interface IPublisher<T>
    {
        void Subscribe(ISubscriber<T> subscriber);

        void Unsubscribe(ISubscriber<T> subscriber);

        void NotifySubscribers(T data);
    }
}