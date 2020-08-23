using System.Collections;
using UnityEngine;

public class DeployEnnemySpawners : MonoBehaviour
{
    public GameObject bombSpawnerPrefab;

    public float minRespawnTime = 5.0f;
    public float maxRespawnTime = 10.0f;
    void Start()
    {
        StartCoroutine(SpawnerWave());
    }
    private void SpawnBombSpawner()
    {
        GameObject bombSpawner = Instantiate(bombSpawnerPrefab) as GameObject;
        // bomb.transform.parent = this.transform;
        bombSpawner.transform.position = this.transform.position;
    }

    IEnumerator SpawnerWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minRespawnTime, maxRespawnTime));
            SpawnBombSpawner();
        }
    }
}
