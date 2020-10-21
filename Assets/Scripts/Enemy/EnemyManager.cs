using UnityEngine;
using System.Collections.Generic;

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

    private int spawned;

    public floatValue inspirtation;

    void Start()
    {
    
    }

    void Update()
    {
        if (inspirtation.value <= 0)
        {
            return;
        }
        nextSpawn -= Time.deltaTime;


        if (nextSpawn <= 0)
        {
            nextSpawn = spawnDelay;

            GameObject enemy = Instantiate(enemyPrefab);

            enemy.transform.position = new Vector2(spawnX, spawnY);

            spawned++;
        }
    }
}
