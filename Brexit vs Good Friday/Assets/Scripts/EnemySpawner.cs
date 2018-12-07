using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy1;
    public GameObject enemy2;
    public int hazardCount = 15;
    public float spawnWait = 2f;
    public float startWait = 1f;
    public float waveWait = 10f;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        // wait, execute, loop, spawn enemy in location, and do waves for this proess.
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(0, 35), Random.Range(0, 30), -2);
                Quaternion spawnRotation = Quaternion.identity;
                if(i % 2 == 0)
                    Instantiate(enemy1, spawnPosition, spawnRotation);
                else
                    Instantiate(enemy2, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
