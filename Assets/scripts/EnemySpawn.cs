using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //public GameObject[] EnemyPrefabs;
    public ArrayList Enemy = new ArrayList();


    private float spawnLimitXLeft = 3;
    private float spawnLimitXRight = 3;
    private float spawnPosX = 1;

    private float startDelay = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomEnemy", startDelay);
    }

    // Spawn random enemies at random x position at top of play area
    void SpawnRandomEnemy()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosX, 1);

        // instantiate ball at random spawn location
        int prefabIndex = UnityEngine.Random.Range(0, 3);
        Instantiate(Enemy[prefabIndex], spawnPos, Enemy[prefabIndex].transform.rotation);
        Invoke("SpawnRandomEnemy", Random.Range(0, 3));
    }
}

