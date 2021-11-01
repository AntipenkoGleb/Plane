namespace Base.Events.Base
{
    public interface ISubscriber
    {
        void OnPublish();
    }

    public interface ISubscriber<T>
    {
        void OnPublish(T data);
    }
}