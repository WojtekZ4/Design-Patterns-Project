using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public abstract bool ComandComplete { get; }
    public abstract void Execute();
    public abstract void FixedUpdate();
}
