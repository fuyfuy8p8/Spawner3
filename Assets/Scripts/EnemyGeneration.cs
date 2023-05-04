using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private EnemyMovement _enemyPrefab;

    private IEnumerator SpawnEnemiesCoroutine()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(2f);
        while (true)
        {
            int _randomInt = Random.Range(0, _spawnPoints.Length );
            SpawnEnemy(_randomInt);

            yield return waitForSeconds;
        }
    }

    private void SpawnEnemy(int spawnIndex)
    {
        Instantiate(_enemyPrefab, _spawnPoints[spawnIndex].position, Quaternion.identity);
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemiesCoroutine());
    }
}

