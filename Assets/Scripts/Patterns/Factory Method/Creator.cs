using UnityEngine;

public abstract class Creator
{
    public abstract MovableObject FactoryMethod(Transform location, float spead, bool facingRight);
}
