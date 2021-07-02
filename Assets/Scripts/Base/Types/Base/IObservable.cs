namespace Base.Types.Base
{
    public interface IObservable<out TObserver>
    {
        public void NotifyValueChanged();

        public void AddObserver(IObserver<TObserver> observer);

        public void RemoveObserver(IObserver<TObserver> observer);
    }
}