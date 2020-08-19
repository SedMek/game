using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnnemies : MonoBehaviour
{
    public GameObject bombPrefab;
    public float respawnTime = 1.0f;
    // private GameObject spawner;
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
            yield return new WaitForSeconds(respawnTime);
            SpawnBomb();
        }
    }
}
