using UnityEngine;

public class WaitCommand : Command
{
    public float timeToHold;
    float timer;
    public override bool ComandComplete => timer < 0;
    public override void Execute()
    {
        timer = timeToHold;
        enabled = true;
    }
    public override void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;
        if (ComandComplete)
            enabled = false;
    }
}
