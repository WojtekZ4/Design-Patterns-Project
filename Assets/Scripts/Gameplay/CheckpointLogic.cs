using UnityEngine;

public class CheckpointLogic : MonoBehaviour
{
    bool active = false;
    private readonly LevelManager menager = LevelManager.Instance;
    public Sprite activeChceckpoint;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player") && !active)
        {
            Activate();
        }
    }
    void Activate()
    {
        active = true;
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = activeChceckpoint;
        //renderer.color = Color.green;
        menager.UnlockChekpoint(gameObject);
    }
}
