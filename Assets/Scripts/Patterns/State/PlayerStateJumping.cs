using UnityEngine;

class PlayerStateJumping : PlayerState
{
    public override void JumpHandle()
    {

    }

    public override void StateChangeHandle()
    {
        bool isOnGrounde = Physics2D.OverlapCircle(_context.groundChek.position, _context.checkRadius, _context.whatIsGround);
        if (isOnGrounde)
            _context.TransitionTo(new PlayerStateWalking());
    }
}
