using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class ProtectedGreen : MonoBehaviour
{
    public GameObject Rotatore;
    public GameObject Points;
    internal bool UpdateFixe = false;

    void Start()
    {
        StartCoroutine(Spawning());
    }

    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(0.4f);
        if (UpdateFixe == false)
        {
            PoolContainer.SpawnFX(Rotatore, transform.position, transform.rotation);
        }

        StartCoroutine(Spawning());
    }
}