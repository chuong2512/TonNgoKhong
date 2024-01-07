using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public float time = 0.3f;
    void OnEnable()
    {
        StartCoroutine(destroy());
    }
    IEnumerator destroy()
    {
        yield return new WaitForSeconds(time);
        PoolContainer.DeSpawnFX(this.gameObject);
    }
}
