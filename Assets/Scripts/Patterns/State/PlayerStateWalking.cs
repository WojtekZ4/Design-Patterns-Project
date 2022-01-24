using UnityEngine;

class PlayerStateWalking : PlayerState
{
    public override void JumpHandle()
    {
        _context.Jump(_context.rb, _context.jumpForce);
    }

    public override void StateChangeHandle()
    {
        bool isOnGrounde = Physics2D.OverlapCircle(_context.groundChek.position, _context.checkRadius, _context.whatIsGround);
        if (!isOnGrounde)
            _context.TransitionTo(new PlayerStateJumping());
    }
}
