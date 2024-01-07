using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public SpawnManager ManagerSpawn;
    public SpawnManager Monsters;

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
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Enemy))
        {
            PoolContainer.SpawnFX(PoolConstant.BloodB, transform.position, transform.rotation);
            
            //AudioManager.Instance.
        }

        if (other.CompareTag(TagConstants.ZoneZombie))
        {
            StartCoroutine(Spawning());
        }

        if (other.CompareTag(TagConstants.ZoneMonster))
        {
            StartCoroutine(SpawningM());
        }
    }
}