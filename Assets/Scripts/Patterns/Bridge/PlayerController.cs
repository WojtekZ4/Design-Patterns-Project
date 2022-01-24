using UnityEngine;

public class PlayerController : MovableObject
{

    private PlayerState playerState = null;
    public float speed;
    public float jumpForce = 10;
    public Rigidbody2D rb;
    public Sprite walkingSprite;
    public Sprite jumpingSprite;
    SpriteRenderer sr;
    public Transform groundChek;
    public float checkRadius;
    public LayerMask whatIsGround;

    public void TransitionTo(PlayerState state)
    {
        if (state is PlayerStateJumping)
            sr.sprite = jumpingSprite;
        if (state is PlayerStateWalking)
            sr.sprite = walkingSprite;

        this.playerState = state;
        this.playerState.SetContext(this);
    }

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        m_Implementation = new SimpleMovementImplementation();
        this.TransitionTo(new PlayerStateWalking());
    }

    void FixedUpdate()
    {
        StateChange();

        if (Input.GetKey(KeyCode.Space))
            playerState.JumpHandle();

        if ((!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)))
            HoryzontalStop(rb);
        else if (Input.GetKey(KeyCode.A))
            MoveLeft(this.transform, speed);
        else if (Input.GetKey(KeyCode.D))
            MoveRight(this.transform, speed);
    }

    public void StateChange()
    {
        this.playerState.StateChangeHandle();
    }
}
