public interface ISubject
{
    public abstract void Attach(Observer observer);
    public abstract void Detach(Observer observer);
    public abstract void Notify();
}
