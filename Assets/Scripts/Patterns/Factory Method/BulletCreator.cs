using UnityEngine;

public class BulletCreator : Creator
{
    public override MovableObject FactoryMethod(Transform location, float spead, bool facingRight)
    {
        GameObject gameObject = new GameObject("Bullet");

        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        spriteRenderer.sprite = Resources.Load<Sprite>("Bullet");

        Rigidbody2D rigidbody2D = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;

        BoxCollider2D boxCollider2D = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
        boxCollider2D.isTrigger = true;

        BulletController bulletController = gameObject.AddComponent<BulletController>() as BulletController;
        bulletController.speed = spead;

        if (!facingRight)
            bulletController.Flip(gameObject.transform);

        return bulletController;
    }
}
