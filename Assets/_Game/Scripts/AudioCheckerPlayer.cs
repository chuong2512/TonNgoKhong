using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCheckerPlayer : MonoBehaviour
{
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
