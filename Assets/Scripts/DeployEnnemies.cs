using System.Collections;
using UnityEngine;

public class DeployEnnemies : MonoBehaviour
{
    public GameObject bombPrefab;
    public float minRespawnTime = 1.0f;
    public float maxRespawnTime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BombWave());
    }

    private void SpawnBomb()
    {
        GameObject bomb = Instantiate(bombPrefab) as GameObject;
        // bomb.transform.parent = this.transform;
        bomb.transform.position = this.transform.position;
    }

    IEnumerator BombWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minRespawnTime, maxRespawnTime));
            SpawnBomb();
        }
    }
}
