using UnityEngine;

public class SimplePlatformCreator : Creator
{
    public override MovableObject FactoryMethod(Transform location, float spead, bool facingRight)
    {
        GameObject gameObject = new GameObject("SimplePlatform");
        gameObject.layer = 6;

        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
        spriteRenderer.sprite = Resources.Load<Sprite>("Platform");
        spriteRenderer.sortingOrder = -1;

        gameObject.transform.localScale = new Vector3(1.5f, 0.5f, 1);

        Rigidbody2D rigidbody2D = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;

        SimplePlatformController simplePlatformController = gameObject.AddComponent<SimplePlatformController>() as SimplePlatformController;
        simplePlatformController.speed = 0.5f;
        simplePlatformController.speed = spead;

        BoxCollider2D boxCollider2D_1 = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;

        BoxCollider2D boxCollider2D_2 = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
        boxCollider2D_2.isTrigger = true;

        if (!facingRight)
            simplePlatformController.Flip(gameObject.transform);

        return simplePlatformController;
    }
}
