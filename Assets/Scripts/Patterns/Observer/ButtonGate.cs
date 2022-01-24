public class ButtonGate : Observer
{
    public override void ObserverUpdate(ISubject subject)
    {
        FlipState();
    }

    void FlipState()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
