using UnityEngine;

public enum Spawnable
{
    Bullet,
    Platform
}
public class SpawnerLogic : MonoBehaviour
{
    public Spawnable whatToSpawn;
    public bool spawnedFacingRight;
    Creator factory;
    public float timeInterval = 30.0f;
    public float spawnedObjectSpeed;
    float timer;
    private void Start()
    {
        switch (whatToSpawn)
        {
            case Spawnable.Bullet:
                factory = new BulletCreator();
                break;
            case Spawnable.Platform:
                factory = new SimplePlatformCreator();
                break;
        }
        timer = timeInterval;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SpawnThing();
            timer = timeInterval;
        }
    }
    void SpawnThing()
    {
        var spawned = factory.FactoryMethod(this.transform, spawnedObjectSpeed, spawnedFacingRight);
        spawned.transform.position = this.transform.position;
        spawned.transform.rotation = this.transform.rotation;
    }
}
