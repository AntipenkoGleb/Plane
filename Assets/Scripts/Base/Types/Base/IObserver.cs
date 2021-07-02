namespace Base.Types.Base
{
    public interface IObserver<in T>
    {
        void OnValueChanged(T value);
    }
}