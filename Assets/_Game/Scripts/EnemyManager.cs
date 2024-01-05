using System.Collections;
using System.Collections.Generic;
using SinhTon;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using static UnityEngine.GraphicsBuffer;

public class EnemyManager : MonoBehaviour
{
    [Header("Manager Enemy")]
    public GameObject HitEffect;
    public GameObject BloodLocalisation;
    public GameObject UImanager;
    private AudioSource Audio;

    public GameObject Bolt;
    private Transform Player;
    internal bool FollowPlayer = true;
    internal int ValueAdd;
    internal int Diamond;

    [Header("Diamond")]
    public GameObject BlueDiamond;
    public GameObject RedDiamond;
    public GameObject GreenDiamond;

    void Start()
    {
        UImanager = GameObject.Find("UI");
        BloodLocalisation = GameObject.Find("BloodManager");
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        ValueAdd = Random.Range(1, 100);
        Diamond = Random.Range(1, 3);
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(FollowPlayer == true)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.position, GameManager.Instance.SpeedEnemy * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = Player.transform.position.x < this.transform.position.x;
        }
        if(InGameManager.Instance.DestroyEnemys == true)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator AnimationController()
    {
        yield return new WaitForSeconds(0.5f);
        if(Diamond == 1)
        {
            (Instantiate(BlueDiamond, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
        }
        if (Diamond == 2)
        {
            (Instantiate(RedDiamond, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
        }
        if (Diamond == 3)
        {
            (Instantiate(GreenDiamond, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
        }
        Destroy(this.gameObject);
    }
    IEnumerator BallController()
    {
        yield return new WaitForSeconds(0.5f);
        if (Diamond == 1)
        {
            (Instantiate(BlueDiamond, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
        }
        if (Diamond == 2)
        {
            (Instantiate(RedDiamond, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
        }
        if (Diamond == 3)
        {
            (Instantiate(GreenDiamond, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
        }
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bolt"))
        {
            Audio.Play();
            Bolt.SetActive(true);
            Bolt.GetComponent<TextMeshProUGUI>().color = Color.red;
            Bolt.GetComponent<TextMeshProUGUI>().text = "" + ValueAdd;
            this.gameObject.GetComponent<Animator>().Play("ZombieDeath");
            (Instantiate(HitEffect, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
            GameManager.Instance.CurrentKilled += 1;
            StartCoroutine(AnimationController());
        }
        if (other.CompareTag("ball"))
        {
            Audio.Play();
            Bolt.SetActive(true);
            Bolt.GetComponent<TextMeshProUGUI>().text = "" + ValueAdd;
            this.gameObject.GetComponent<Animator>().Play("ZombieDeath");
            (Instantiate(HitEffect, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
            GameManager.Instance.CurrentKilled += 1;
            StartCoroutine(BallController());
        }        
        if (other.CompareTag("Fire"))
        {
            Audio.Play();
            Bolt.SetActive(true);
            Bolt.GetComponent<TextMeshProUGUI>().text = "" + ValueAdd;
            this.gameObject.GetComponent<Animator>().Play("ZombieDeath");
            (Instantiate(HitEffect, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
            GameManager.Instance.CurrentKilled += 1;
            StartCoroutine(BallController());
        }
        if (other.CompareTag("Spiner"))
        {
            Audio.Play();
            Bolt.SetActive(true);
            Bolt.GetComponent<TextMeshProUGUI>().text = "" + ValueAdd;
            this.gameObject.GetComponent<Animator>().Play("ZombieDeath");
            (Instantiate(HitEffect, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
            GameManager.Instance.CurrentKilled += 1;
            StartCoroutine(AnimationController());
        }
        if (other.CompareTag("Player"))
        {
            Audio.Play();
            FollowPlayer = false;
        }

        if (other.CompareTag("Pet"))
        {
            Audio.Play();
            Bolt.SetActive(true);
            Bolt.GetComponent<TextMeshProUGUI>().text = "" + ValueAdd;
            this.gameObject.GetComponent<Animator>().Play("ZombieDeath");
            (Instantiate(HitEffect, transform.position, transform.rotation) as GameObject).transform.SetParent(BloodLocalisation.transform);
            GameManager.Instance.CurrentKilled += 1;
            StartCoroutine(BallController());
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FollowPlayer = true;

        }
    }
}
