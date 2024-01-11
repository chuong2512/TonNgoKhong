using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public int Value = 1;

    private GameObject _player;

    internal bool StartMove = true;
    internal bool AddOnce = true;

    void Start()
    {
        _player = PlayerManager.Instance.gameObject;
    }

    void Update()
    {
        if (StartMove == false)
        {
            transform.position =
                Vector2.MoveTowards(this.transform.position, _player.transform.position, 15f * Time.deltaTime);
        }
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.4f);
        StartMove = false;
        yield return new WaitForSeconds(0.8f);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(TagConstants.Player))
            return;

        InGameManager.Instance.AddExp(Value);

        PoolContainer.SpawnFX(PoolConstant.Flash, transform.position, transform.rotation);
        MasterAudioManager.Play2DSfx(AudioConst.Exp);

        if (AddOnce == true)
        {
            this.gameObject.AddComponent<Rigidbody2D>();
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            AddOnce = false;
        }

        this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 15);
        StartCoroutine(Destroy());
    }
}