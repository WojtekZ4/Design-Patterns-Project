using UnityEngine;

public class SimplePlatformController : MovableObject
{
    public float speed = 0.2f;

    public SimplePlatformController()
    {
        m_Implementation = new SimpleMovementImplementation();
    }

    void FixedUpdate()
    {
        MoveForward(this.transform, speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("PlatformDestroyer"))
            Destroy(this.gameObject);

        if (other.gameObject.tag.Equals("Player"))
            other.gameObject.transform.SetParent(this.gameObject.transform);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.transform.parent != null && other.gameObject.transform.parent.Equals(this.gameObject.transform))
            other.gameObject.transform.SetParent(null);
    }
}
