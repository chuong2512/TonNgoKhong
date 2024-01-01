using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetManager : MonoBehaviour
{
    public GameObject[] Enemys;

    public Image HealthBar;

    //public float hh;
    public float Health = 100;
    [Header("Manager Pet")] public GameObject Manager;
    public GameObject HitEffect;
    public GameObject BloodLocalisation;
    public float petSpeed;
    bool isattacking;
    public GameObject enemy;
    public bool PlayerDeath = false;
    private Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        BloodLocalisation = GameObject.Find("BloodManager");
        Manager = GameObject.Find("GameManager");
        this.gameObject.GetComponent<Animator>().Play("petidle");
    }


    // Update is called once per frame
    private void LateUpdate()
    {
    }

    void Update()
    {
        float dist = Vector3.Distance(Player.position, transform.position);

        if (PlayerDeath == false)
        {
            if (dist > 4)
            {
                transform.position =
                    Vector2.MoveTowards(this.transform.position, Player.position, petSpeed * Time.deltaTime);
                this.gameObject.GetComponent<SpriteRenderer>().flipX =
                    Player.transform.position.x < this.transform.position.x;
                this.gameObject.GetComponent<Animator>().Play("petwalk");
            }
            else if (dist <= 3.5)
            {
                Debug.Log("check enemy is null1");
                if (enemy == null)
                {
                    Enemys = GameObject.FindGameObjectsWithTag("Enemy");
                    Debug.Log("petidle");
                    this.gameObject.GetComponent<Animator>().Play("petidle");

                    for (int xx = 0; xx < Enemys.Length; xx++)
                    {
                        if (Enemys[xx] != null)
                        {
                            float enemydist = Vector3.Distance(Player.position, Enemys[xx].transform.position);
                            if (enemydist <= 3)
                            {
                                enemy = Enemys[xx];
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (enemy != null)
                    {
                        Debug.Log("attack enemy");

                        transform.position = Vector2.MoveTowards(this.transform.position, enemy.transform.position,
                            petSpeed * Time.deltaTime);
                        this.gameObject.GetComponent<SpriteRenderer>().flipX =
                            enemy.transform.position.x < this.transform.position.x;
                        this.gameObject.GetComponent<Animator>().Play("petwalk");
                    }
                }
            }
        }


        HealthBar.fillAmount = (Health / 100);
        if (HealthBar.fillAmount == 0.5f)
        {
            HealthBar.color = Color.yellow;
        }

        if (HealthBar.fillAmount == 0.3f)
        {
            HealthBar.color = Color.red;
        }

        if (HealthBar.fillAmount == 0 && PlayerDeath == false)
        {
            Debug.Log("You are Death");
            this.gameObject.GetComponent<Animator>().Play("petDeath");
            PlayerDeath = true;
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }


    public void InitPet()
    {
        this.gameObject.GetComponent<Animator>().Play("petidle");
        Health = 100;
        PlayerDeath = false;
        this.GetComponent<BoxCollider2D>().enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Health -= 1f;
        }
    }
}