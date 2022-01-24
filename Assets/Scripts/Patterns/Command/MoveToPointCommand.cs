using UnityEngine;

public class MoveToPointCommand : Command
{
    public Transform target;
    public float spead;
    public Transform subject;
    IMovementImplementation movement;

    private void Start()
    {
        movement = new SimpleMovementImplementation();
    }

    public override bool ComandComplete => Vector2.Distance(subject.position, target.position) < 0.001f;
    public override void Execute()
    {
        enabled = true;
    }

    public override void FixedUpdate()
    {
        movement.MovetoPoint(target, subject, spead);
        if (ComandComplete)
            enabled = false;
    }
}
