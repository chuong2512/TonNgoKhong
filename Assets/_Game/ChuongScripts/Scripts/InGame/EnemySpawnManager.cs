using Game;
using SinhTon;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : Singleton<EnemySpawnManager>
{
    public static int EnemiesCount = 0;

    private GameObject[] Enemies;
    public Transform[] SpawnPoints;

    private Transform _playerTrans;

    private bool _isSpawning;

    float _timeCounter = 0;
    float _timeCounter1 = 0;
    float _timeCounter2 = 0;
    float _timeSpawn = 0.8f;
    float _timeAddAttribute = 0;

    private LevelSO _levelSo;
    private DataMap _dataMap;

    private void Awake()
    {
        InGameAction.OnGameStateChange += OnGameStateChange;
    }

    private void Start()
    {
        _isSpawning = true;
        _playerTrans = PlayerManager.Instance.PlayerTransform;

        _dataMap = GameDataManager.Instance.GetCurrentDataMap();

        Enemies = _dataMap.Enemies;
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
        _timeCounter1 += Time.deltaTime;
        _timeCounter1 += Time.deltaTime;

        _timeAddAttribute += Time.deltaTime;

        if (_timeCounter >= _timeSpawn)
        {
            _timeCounter = 0;

            Spawn();
        }

        if (_timeCounter1 >= _dataMap.ZoneSpawnTime)
        {
            _timeCounter1 = 0;

            Spawn();
        }

        if (_timeCounter2 >= _dataMap.TimeSpawnBoss)
        {
            _timeCounter2 = 0;

            Spawn();
        }
    }

    private void Spawn()
    {
        if (EnemiesCount < _dataMap.MaxEnemies)
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

        var baseAttribute = _dataMap.EnemyAttribute;

        return new EnemyAttribute()
        {
            MaxHealth = baseAttribute.MaxHealth + HP * _dataMap.AddHPPerTime,
            Defense = baseAttribute.Defense,
            Health = baseAttribute.Health,
            ExpValue = baseAttribute.ExpValue,
            Piority = baseAttribute.Piority,
            CoinValue = baseAttribute.CoinValue,
            Speed = baseAttribute.Speed,
            Damage = baseAttribute.Damage + DMG * _dataMap.AddDMGPerTime
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