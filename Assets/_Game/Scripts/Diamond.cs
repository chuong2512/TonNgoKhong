using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public int Value = 1;

    public GameObject Player;
    private AudioSource Audio;

    internal bool FollowPlayer = false;
    internal bool StartMove = true;
    internal bool AddOnce = true;

    void Start()
    {
        Player = PlayerManager.Instance.gameObject;
        Audio = GetComponent<AudioSource>();
        Audio.volume = 0.5f;
    }

    void FixedUpdate()
    {
        if (FollowPlayer == true)
        {
            if (StartMove == true)
            {
                if (AddOnce == true)
                {
                    this.gameObject.AddComponent<Rigidbody2D>();
                    this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
                    AddOnce = false;
                }

                this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 15);
                StartCoroutine(BackPoint());
            }
        }
    }

    void Update()
    {
        gameObject.GetComponent<BoxCollider2D>().size = Vector2.one * PlayerManager.Instance.CurrentStatus.Magnet;

        if (StartMove == false)
        {
            transform.position =
                Vector2.MoveTowards(this.transform.position, Player.transform.position, 15f * Time.deltaTime);
        }
    }

    IEnumerator BackPoint()
    {
        yield return new WaitForSeconds(0.4f);
        StartMove = false;
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Player))
        {
            InGameManager.Instance.AddExp(Value);
            
            PoolContainer.SpawnFX(PoolConstant.Flash, transform.position, transform.rotation);
            Audio.Play();
            StartCoroutine(Destroy());
        }

        if (other.CompareTag("RoadDetections"))
        {
            FollowPlayer = true;
        }
    }
}