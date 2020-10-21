using UnityEngine;
/**
 * This class is responsible for spawning and despawning enemy entities.
 * 
 * @author Jason MacKeigan
 */
public class EnemyManager : MonoBehaviour
{

    [Range(0, 128)]
    public byte spawnDelay;

    public float spawnX;

    public float spawnY;

    public GameObject enemyPrefab;

    private float nextSpawn;

    public FloatValue inspiration;

    void Start()
    {

    }

    void Update()
    {
        if (inspiration.value <= 0)
        {
            return;
        }
        nextSpawn -= Time.deltaTime;


        if (nextSpawn <= 0)
        {
            nextSpawn = spawnDelay;

            GameObject enemy = Instantiate(enemyPrefab);

            enemy.transform.position = new Vector2(spawnX, spawnY);
        }
    }

    void OnDisable()
    {
        print("Disabling enemy controller.");

        Enemy[] enemies = FindObjectsOfType<Enemy>();

        print("Length of enemies: " + enemies.Length);

        foreach (Enemy enemy in enemies)
        {
            Destroy(enemy.gameObject);
        }
    }
    
}
