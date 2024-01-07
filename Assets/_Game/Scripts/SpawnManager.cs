using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public static int EnemiesCount = 0;

    [FormerlySerializedAs("ZombieLevel")] public GameObject[] Enemies;

    [Header("Spawents Poins")] public GameObject Spawen1;
    public GameObject Spawen2;
    public GameObject Spawen3;
    public GameObject Spawen4;

    private Transform _playerTrans;

    [SerializeField] private TimerManager _timer;

    private bool _isSpawning;

    private void Awake()
    {
        InGameAction.OnGameStateChange += OnGameStateChange;
    }

    private void Start()
    {
        _isSpawning = true;
        _playerTrans = PlayerManager.Instance.PlayerTransform;
    }

    private void OnGameStateChange()
    {
        _isSpawning = (InGameManager.Instance.IsPlaying);
    }

    private void OnDestroy()
    {
        InGameAction.OnGameStateChange -= OnGameStateChange;
    }

    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (!_isSpawning)
            return;

        if (EnemiesCount < 100)
        {
            EnemiesCount++;
            SpawnRandom();
            SpawnRandom();
        }
    }

    private void SpawnRandom()
    {
        PoolContainer.SpawnEnemy(Enemies[Random.Range(0, Enemies.Length)], GetRandomSpawnPoint());
    }

    public void SpawnEnemiesSameType(int amount, int type)
    {
        for (int i = 0; i < amount; i++)
        {
            PoolContainer.SpawnEnemy(Enemies[type], GetRandomSpawnPointOneDir());
        }
    }

    public void SpawnEnemiesSameType(int amount)
    {
        if (!_isSpawning)
            return;

        SpawnEnemiesSameType(amount, Random.Range(0, Enemies.Length));
    }

    private Vector3 GetRandomSpawnPoint()
    {
        var pos = _playerTrans.position;

        return pos + (Vector3) (Random.insideUnitCircle.normalized * Random.Range(6f, 9f));
    }

    private Vector3 GetRandomSpawnPointOneDir()
    {
        var pos = _playerTrans.position;

        return pos + (Vector3) (Random.insideUnitCircle.normalized * Random.Range(6f, 9f));
    }
}