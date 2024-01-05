using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerManager : MonoBehaviour
{
    Supplies supplies;

    [Header("Spawen Transformer")] public AudioSource EffectArrow;
    public AudioSource AudioHeat;
    public GameObject Death;
    public GameObject SpawenShoot;
    public GameObject ContainerWap;
    public Vector3 Offest;
    private Vector3 rb;

    [Header("Containers")] public GameObject Bolts;
    public GameObject UI;

    [Header("Boolean manager")] internal bool Deaths = true;


    void Start()
    {
        supplies = FindObjectOfType<Supplies>();
    }

    void Update()
    {
        UI.transform.position = Vector3.SmoothDamp(transform.position, transform.position + Offest, ref rb, 0);
        SpawenShoot.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        HitBolts();


        if (GameManager.Instance.HealthBar.fillAmount == 0)
        {
            Death.SetActive(true);
        }
        else
        {
            Death.SetActive(false);
        }
    }

    void HitBolts()
    {
        if (GameManager.Instance.AvailabelWeapon == true)
        {
            if (GameManager.Instance.SpawnObject == true)
            {
                (Instantiate(Bolts, SpawenShoot.transform.position, Quaternion.identity) as GameObject).transform
                    .SetParent(ContainerWap.transform);
                EffectArrow.Play();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            AudioHeat.Play();
            GameManager.Instance.Health -= (0.5f - (0.5f * supplies.Protect) / 100);
        }
    }
}