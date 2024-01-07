using System;
using Game;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : BaseEnemy
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Collider2D _collision2D;
    [SerializeField] private Transform _playerTrans;

    private bool _followPlayer = true;

    protected override void OnValidate()
    {
        base.OnValidate();

        _audio = GetComponent<AudioSource>();
        _rigidbody = GetComponentInChildren<Rigidbody2D>();
        _collision2D = GetComponentInChildren<Collider2D>();
    }

    void Start()
    {
        _playerTrans = PlayerManager.Instance.PlayerTransform;

        InGameAction.OnGameStateChange += OnGameStateChange;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        _playerTrans = PlayerManager.Instance.PlayerTransform;
        _collision2D.isTrigger = false;
        _followPlayer = true;
    }

    private void OnGameStateChange()
    {
        enabled = InGameManager.Instance.IsPlaying;
        _rigidbody.simulated = InGameManager.Instance.IsPlaying;
    }

    private void OnDestroy()
    {
        InGameAction.OnGameStateChange -= OnGameStateChange;
    }

    void Update()
    {
        if (!_followPlayer) return;

        transform.position = Vector2.MoveTowards(transform.position, _playerTrans.position,
            attribute.Speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.up * (_playerTrans.position.x > transform.position.x ? 0 : 180));
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag(TagConstants.Player))
        {
            _audio.Play();
            _followPlayer = false;

            PlayerManager.Instance.Combat.TakeDamage(attribute.Damage);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.transform.CompareTag(TagConstants.Player))
        {
            _audio.Stop();
            _followPlayer = true;
        }
    }

    public override void Die()
    {
        base.Die();

        _followPlayer = false;
        _collision2D.isTrigger = true;

        switch (attribute.ExpValue)
        {
            case 1:
                PoolContainer.SpawnItem(PoolConstant.BlueDiamond, transform.position, transform.rotation);
                break;
            case 2:
                PoolContainer.SpawnItem(PoolConstant.RedDiamond, transform.position, transform.rotation);
                break;
            case 3:
                PoolContainer.SpawnItem(PoolConstant.GreenDiamond, transform.position, transform.rotation);
                break;
        }

        if (_animator == null)
        {
            this.gameObject.GetComponent<Animator>().Play("ZombieDeath");
            PoolContainer.DeSpawnEnemy(gameObject);
        }

        PoolContainer.SpawnFX(PoolConstant.Blood, transform.position, transform.rotation);
    }
}