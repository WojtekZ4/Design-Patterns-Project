using UnityEngine;

public class SimpleMovementImplementation : IMovementImplementation
{
    bool facingRight = true;
    public void Jump(Rigidbody2D rb, float jumpForce)
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    public void Flip(Transform tr)
    {
        facingRight = !facingRight;
        SpriteRenderer sr = tr.GetComponent<SpriteRenderer>();
        sr.flipX = !sr.flipX;
    }
    public void HoryzontalStop(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
    public void MoveForward(Transform tf, float speed)
    {
        if (facingRight)
            MoveRight(tf, speed);
        else
            MoveLeft(tf, speed);
    }
    public void MoveLeft(Transform tf, float speed)
    {
        if (facingRight)
            Flip(tf);
        tf.position = new Vector2(tf.position.x + (-1) * speed * Time.fixedDeltaTime, tf.position.y);
    }

    public void MoveRight(Transform tf, float speed)
    {
        if (!facingRight)
            Flip(tf);
        tf.position = new Vector2(tf.position.x + (1) * speed * Time.fixedDeltaTime, tf.position.y);
    }

    public void MovetoPoint(Transform target, Transform subject, float speed)
    {
        subject.position = (Vector2.MoveTowards(subject.position, target.position, speed * Time.fixedDeltaTime));
    }
}
