using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 spawnReferencePosition;
    public int amountToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < amountToSpawn; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-spawnReferencePosition.x, spawnReferencePosition.x),
                spawnReferencePosition.y, spawnReferencePosition.z);

            SpawnEnemy(spawnReferencePosition);
        }
    }

    public void SpawnEnemy(Vector3 enemyPosition)
    {
        Instantiate(enemyPrefab, enemyPosition, Quaternion.identity);
    }
}
