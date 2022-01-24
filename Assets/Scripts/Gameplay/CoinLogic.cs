using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    public int value = 1;
    private readonly LevelManager menager = LevelManager.Instance;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            menager.UpdateScore(value);
            Destroy(gameObject);
        }
    }
}
