using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class SpinerManager : MonoBehaviour
{
    [SerializeField] private float Damage = 4;

    void Update()
    {
        transform.Rotate(0, 0, -5f);
    }

    private void Start()
    {
        StartCoroutine(CheckingSize());
    }

    IEnumerator CheckingSize()
    {
        yield return new WaitForSeconds(5f);
        this.gameObject.GetComponent<Animator>().Play("FadeOut");
        this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(1.1f);
        this.gameObject.GetComponent<Animator>().Play("FadeIn");
        this.gameObject.GetComponent<CircleCollider2D>().enabled = true;
        StartCoroutine(CheckingSize());
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        var combat = other.GetComponentInParent<BaseEnemy>();
        if (combat != null && !combat.IsDestroyed())
        {
            var damageInfo = new DamageInfo(Damage, 0);

            combat.TakeDamage(damageInfo);
        }
    }
}