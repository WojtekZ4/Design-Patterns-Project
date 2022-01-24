using UnityEngine;

public class BulletController : MovableObject
{
    public float speed = 1.0f;
    readonly LevelManager menager = LevelManager.Instance;

    BulletController()
    {
        m_Implementation = new SimpleMovementImplementation();
    }

    void FixedUpdate()
    {
        MoveForward(this.transform, speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            menager.TakeDamage();
        }
        Destroy(this.gameObject);
    }
}
