using Game;
using SinhTon;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : Singleton<EnemySpawnManager>
{
    public static int EnemiesCount = 0;

    public GameObject[] Enemies;
    public Transform[] SpawnPoints;

    private Transform _playerTrans;

    private bool _isSpawning;

    float _timeCounter = 0;
    float _timeSpawn = 0.8f;
    float _timeAddAttribute = 0;

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
        if (!_isSpawning)
            return;

        _timeCounter += Time.deltaTime;
        _timeAddAttribute += Time.deltaTime;

        if (_timeCounter >= _timeSpawn)
        {
            _timeCounter = 0;

            Spawn();
        }
    }

    private void Spawn()
    {
        if (EnemiesCount < 100)
        {
            SpawnRandom();
            SpawnRandom();
        }
    }

    private void SpawnRandom()
    {
        EnemiesCount++;
        var e = PoolContainer.SpawnEnemy(Enemies[Random.Range(0, Enemies.Length)], GetRandomSpawnPoint());
        e.Attribute = GetEnemyAttribute();
    }

    private void SpawnEnemiesSameType(int amount, int type)
    {
        var pointSpawn = SpawnPoints[Random.Range(0, SpawnPoints.Length)];

        EnemiesCount += amount;

        for (int i = 0; i < amount; i++)
        {
            var e = PoolContainer.SpawnEnemy(Enemies[type], GetRandomSpawnPointOneDir(pointSpawn));
            e.Attribute = GetEnemyAttribute();
        }
    }

    private EnemyAttribute GetEnemyAttribute()
    {
        var DMG = (int) _timeAddAttribute / 20;
        var HP = (int) _timeAddAttribute / 15;

        return new EnemyAttribute()
        {
            MaxHealth = 10 + HP * 1.8f,
            Defense = 0,
            Health = 10,
            ExpValue = 1,
            Piority = 1,
            CoinValue = 1,
            Speed = 1,
            Damage = 2 + DMG * 0.1f
        };
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

        return pos + (Vector3) (Random.insideUnitCircle.normalized * Random.Range(8f, 10f));
    }

    private Vector3 GetRandomSpawnPointOneDir(Transform point)
    {
        return point.position + (Vector3) (Random.insideUnitCircle.normalized * Random.Range(0f, 2f));
    }
}