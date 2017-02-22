﻿//( ͡° ͜ʖ ͡°)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : EnemyDatabase {

    [SerializeField]private List<GameObject> _enemyTypes = new List<GameObject>();
    [SerializeField]private Transform _enemyParentObject;
    private List<Transform> _spawnpoints = new List<Transform>();

    private int _enemyTypeCount;

    void Awake()
    {
        foreach (Transform child in transform)
        {
            _spawnpoints.Add(child);
        }
    }

    public void SpawnEnemy()
    {
        int randomEnemy = Random.Range(0, _enemyTypeCount);
        GameObject spawnedEnemy = Instantiate(_enemyTypes[0]);
        spawnedEnemy.transform.position = _spawnpoints[Random.Range(0, _spawnpoints.Count)].position;
        spawnedEnemy.transform.SetParent(_enemyParentObject);
    }
}
