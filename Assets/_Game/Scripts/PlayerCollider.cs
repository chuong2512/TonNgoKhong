using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Enemy))
        {
            PoolContainer.SpawnFX(PoolConstant.BloodB, transform.position, transform.rotation);
        }

        if (other.CompareTag(TagConstants.ZoneZombie))
        {
            EnemySpawnManager.Instance.SpawnEnemiesSameType(Random.Range(15, 30));
        }
    }
}