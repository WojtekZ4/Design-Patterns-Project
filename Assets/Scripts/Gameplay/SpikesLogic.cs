using UnityEngine;

public class SpikesLogic : MonoBehaviour
{
    readonly LevelManager menager = LevelManager.Instance;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            menager.TakeDamage();
    }
}
