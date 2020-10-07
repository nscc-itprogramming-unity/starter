using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{

    [Range(0, 128)]
    public byte spawnDelay;

    public float spawnX;

    public float spawnY;

    public GameObject enemyPrefab;

    private float nextSpawn;

    void Start()
    {
    
    }

    void Update()
    {
        nextSpawn -= Time.deltaTime;

        if (nextSpawn <= 0)
        {
            nextSpawn = spawnDelay;

            GameObject enemy = Instantiate(enemyPrefab);

            enemy.transform.position = new Vector2(spawnX, spawnY);
        }
    }
}
