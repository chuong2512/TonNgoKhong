using Game;
using UnityEngine;

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

        InGameAction.OnPlayerDie += OnPlayerDie;
    }

    private void OnPlayerDie()
    {
        Death.SetActive(true);
    }

    private void OnDestroy()
    {
        InGameAction.OnPlayerDie -= OnPlayerDie;
    }

    void Update()
    {
        UI.transform.position = Vector3.SmoothDamp(transform.position, transform.position + Offest, ref rb, 0);
        SpawenShoot.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        HitBolts();
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
        if (other.CompareTag(TagConstants.Enemy))
        {
            AudioHeat.Play();
            PlayerCombat.Instance.TakeDamage(0.5f - (0.5f * supplies.Protect) / 100);
        }
    }
}