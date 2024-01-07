using Game;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : BaseEnemy
{
    private AudioSource _audio;
    private Rigidbody2D _rigidbody;
    private Transform _playerTrans;
    private SpriteRenderer _spriteRenderer;

    private bool _followPlayer = true;

    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _rigidbody = GetComponentInChildren<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _playerTrans = PlayerManager.Instance.PlayerTransform;

        InGameAction.OnGameStateChange += OnGameStateChange;
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
        if (_followPlayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, _playerTrans.position,
                attribute.Speed * Time.deltaTime);
            _spriteRenderer.flipX = _playerTrans.position.x < transform.position.x;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Player))
        {
            _audio.Play();
            _followPlayer = false;
            
            PlayerManager.Instance.Combat.TakeDamage(attribute.Damage);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Player))
        {
            _audio.Stop();
            _followPlayer = true;
        }
    }

    public override void Die()
    {
        base.Die();

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

        this.gameObject.GetComponent<Animator>().Play("ZombieDeath");

        PoolContainer.SpawnFX(PoolConstant.Blood, transform.position, transform.rotation);


        Destroy(this.gameObject);
    }
}