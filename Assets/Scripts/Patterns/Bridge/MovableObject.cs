using UnityEngine;

public abstract class MovableObject : MonoBehaviour
{
    public IMovementImplementation m_Implementation;
    public void Jump(Rigidbody2D rb, float jumpForce) { m_Implementation.Jump(rb, jumpForce); }
    public void MoveForward(Transform tf, float spead) { m_Implementation.MoveForward(tf, spead); }
    public void HoryzontalStop(Rigidbody2D rb) { m_Implementation.HoryzontalStop(rb); }
    public void Flip(Transform tr) { m_Implementation.Flip(tr); }
    public void MoveLeft(Transform tf, float spead) { m_Implementation.MoveLeft(tf, spead); }
    public void MoveRight(Transform tf, float spead) { m_Implementation.MoveRight(tf, spead); }
    public void MovetoPoint(Transform target, Transform subject, float spead) { m_Implementation.MovetoPoint(target, subject, spead); }
}
