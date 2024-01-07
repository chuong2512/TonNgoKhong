using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemys : MonoBehaviour
{
    public SpawenManager ManagerSpawn;
    public SpawenManager Monsters;
    public GameObject Blooding;

    internal bool Stop = false;
    
    IEnumerator Spawning()
    {
        yield return new WaitForEndOfFrame();
        ManagerSpawn.enabled = true;
        yield return new WaitForSeconds(.005f);
        ManagerSpawn.enabled = false;
    }
    IEnumerator SpawningM()
    {
        yield return new WaitForEndOfFrame();
        Monsters.enabled = true;
        yield return new WaitForSeconds(.005f);
        Monsters.enabled = false;
    }
    IEnumerator AddScore()
    {
        yield return new WaitForEndOfFrame();
        Stop = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Diamond"))
        {
            Stop = true;
            StartCoroutine(AddScore());
        }
        if (other.CompareTag("Enemy"))
        {
            (Instantiate(Blooding, transform.position, transform.rotation) as GameObject).transform.SetParent(transform);
        }
        if (other.CompareTag("ZoneZombie"))
        {
            StartCoroutine(Spawning());
        }
        if (other.CompareTag("ZoneMonsters"))
        {
            StartCoroutine(SpawningM());
        }
        if (other.CompareTag("Coins"))
        {
            //Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("ZoneZombie"))
        {
            StartCoroutine(Spawning());
        }
        if (other.CompareTag("ZoneMonsters"))
        {
            StartCoroutine(SpawningM());
        }
    }
}
