using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCheckerPlayer : MonoBehaviour
{
    public GameObject UIManager;
    BooleanManager booleanManager;
    // [Header("Manager")]

    private void Start()
    {
        booleanManager = FindObjectOfType<BooleanManager>();
       
    }
    private void Update()
    {
     /*   if(UIManager.GetComponent<UIManager>().StopAllAudios == true)
        {
            Destroy(this.gameObject);
        }*/
    }
    public void AudioManager(bool audio)
    {
        if (audio)
        {
            this.GetComponent<AudioSource>().Play();
        }
        else
        {
            this.GetComponent<AudioSource>().Stop();
        }
    }
    

    
}
