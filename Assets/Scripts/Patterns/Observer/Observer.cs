using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    public abstract void ObserverUpdate(ISubject subject);
}
