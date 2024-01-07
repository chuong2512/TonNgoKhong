using System.Collections;
using System.Collections.Generic;
using Game;
using SinhTon;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using static UnityEngine.GraphicsBuffer;

public class Enemy : BaseEnemy
{
    public GameObject BloodLocalisation;
    private AudioSource Audio;

    public GameObject Bolt;
    internal bool FollowPlayer = true;

    public Rigidbody2D rigidbody;

    public Transform _playerTrans;

    void Start()
    {
        BloodLocalisation = GameObject.Find("BloodManager");
        
        Audio = GetComponent<AudioSource>();

        rigidbody = GetComponentInChildren<Rigidbody2D>();

        _playerTrans = PlayerManager.Instance.Transform;

        InGameAction.OnGameStateChange += OnGameStateChange;
    }

    private void OnGameStateChange()
    {
        enabled = InGameManager.Instance.IsPlaying;
        rigidbody.simulated = InGameManager.Instance.IsPlaying;
    }

    private void OnDestroy()
    {
        InGameAction.OnGameStateChange -= OnGameStateChange;
    }
    
    void Update()
    {
        if (FollowPlayer == true)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, _playerTrans.position,
                InGameManager.Instance.SpeedEnemy * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = _playerTrans.position.x < transform.position.x;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bolt"))
        {
            Audio.Play();
            Bolt.SetActive(true);
            Bolt.GetComponent<TextMeshProUGUI>().color = Color.red;
            
            TakeDamage(999);
        }

        if (other.CompareTag("ball"))
        {
            Audio.Play();
            Bolt.SetActive(true);
            TakeDamage(999);
        }

        if (other.CompareTag("Fire"))
        {
            Audio.Play();
            Bolt.SetActive(true);

            TakeDamage(999);
        }

        if (other.CompareTag("Spiner"))
        {
            Audio.Play();
            Bolt.SetActive(true);

            TakeDamage(999);
        }

        if (other.CompareTag("Player"))
        {
            Audio.Play();
            FollowPlayer = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FollowPlayer = true;
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

        PoolContainer.SpawnItem(PoolConstant.Blood, transform.position, transform.rotation);

        
        Destroy(this.gameObject);
    }
}