using UnityEngine;

public class EnemyLogic : MovableObject
{
    public float spead = 1.0f;
    Vector3 previousPosition;
    readonly float flipInterval = 1;
    float timer;
    private void Start()
    {
        m_Implementation = new SimpleMovementImplementation();
    }
    void FixedUpdate()
    {
        if (timer > 0)
            timer -= Time.fixedDeltaTime;

        MoveForward(this.transform, spead);

        if (previousPosition != null && Vector3.Distance(this.transform.position, previousPosition) < 0.001f && timer <= 0)
        {
            Flip(this.transform);
            timer = flipInterval;
        }

        previousPosition = this.transform.position;
    }
}
