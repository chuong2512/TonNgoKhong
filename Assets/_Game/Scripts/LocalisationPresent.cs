using System.Collections;
using System.Collections.Generic;
using SinhTon;
using UnityEngine;

public class LocalisationPresent : MonoBehaviour
{
    private void Update()
    {
        ControllerSpawening.Instance.SpawenOne.GetComponent<SpawenManager>()
            .SpawenLocalisation = this.gameObject;
        ControllerSpawening.Instance.SpawenTwo.GetComponent<SpawenManager>()
            .SpawenLocalisation = this.gameObject;
    }
}