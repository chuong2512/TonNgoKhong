using System.Collections;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;

public class ControllerSpawening : Singleton<ControllerSpawening>
{
    public GameObject Spawner;

    public GameObject SpawenOne;
    public GameObject SpawenTwo;
    internal bool CheckWork = true;

    void Update()
    {
        Spawner.SetActive(true);
        if (CheckWork == true)
        {
            StartCoroutine(SpawenOne.GetComponent<SpawenManager>().SpaweningManager());
            StartCoroutine(SpawenTwo.GetComponent<SpawenManager>().SpaweningManager());
            StartCoroutine(SpawenOne.GetComponent<SpawenManager>().stopSpawning());
            StartCoroutine(SpawenTwo.GetComponent<SpawenManager>().stopSpawning());
            CheckWork = false;
        }
    }
}