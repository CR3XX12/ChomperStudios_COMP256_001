using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesPerWave = 3;
    public float timeBetweenWaves = 5f;
    public Transform[] spawnPoints;

    private int waveNumber = 1;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            Debug.Log($"[Spawner] Wave {waveNumber} incoming...");

            for (int i = 0; i < enemiesPerWave; i++)
            {
                Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            }

            enemiesPerWave += 1; // Optional: increase difficulty each wave
            waveNumber++;

            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
}
