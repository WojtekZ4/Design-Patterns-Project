using UnityEngine;

public interface IMovementImplementation
{
    void HoryzontalStop(Rigidbody2D rb);
    void MoveLeft(Transform tf, float speed);
    void MoveForward(Transform tf, float speed);
    void Flip(Transform tf);
    void MoveRight(Transform tf, float speed);
    void Jump(Rigidbody2D rb, float jumpForce);
    void MovetoPoint(Transform target, Transform subject, float speed);
}
