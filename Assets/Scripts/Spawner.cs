using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemiesTemplate;
    [SerializeField] private GameObject[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawn;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeBetweenSpawn)
        {
            _elapsedTime = 0;

            int enemyTemplateNumber = Random.Range(0, _enemiesTemplate.Length);

            Spawn(_enemiesTemplate[enemyTemplateNumber]);
        }
    }

    private void Spawn(GameObject enemyTemplate)
    {
        int spawnpointNumber = Random.Range(0, _spawnPoints.Length);

        Instantiate(enemyTemplate, _spawnPoints[spawnpointNumber].transform);
    }
}
