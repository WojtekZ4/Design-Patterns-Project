using UnityEngine;

public class EnemyHeadLogic : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
