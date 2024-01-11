using Game;
using SinhTon;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class ItemSpawnManager : MonoBehaviour
{
    public GameObject[] Item;

    private Transform _playerTrans;

    private bool _isSpawning;

    float _timeCounter = 0;
    [SerializeField] float _timeSpawn = 10f;
    [SerializeField] float minRange = 9f;
    [SerializeField] float maxRange = 20;
    [SerializeField] int numberSpawn = 60;

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

        if (_timeCounter >= _timeSpawn)
        {
            _timeCounter = 0;

            Spawn();
        }
    }

    private void Spawn()
    {
        for (int i = 0; i < numberSpawn; i++)
        {
            PoolContainer.SpawnItem(Item[Random.Range(0, Item.Length)], GetRandomSpawnPoint(),
                Quaternion.identity);
        }
    }

    private Vector3 GetRandomSpawnPoint()
    {
        var pos = _playerTrans.position;

        return pos + (Vector3) (Random.insideUnitCircle.normalized * Random.Range(minRange, maxRange));
    }
}