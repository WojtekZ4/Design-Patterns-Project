public abstract class PlayerState
{
    protected PlayerController _context;
    public void SetContext(PlayerController context)
    {
        this._context = context;
    }
    public abstract void JumpHandle();

    public abstract void StateChangeHandle();
}
