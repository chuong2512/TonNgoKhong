using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSoundSwipe : MonoBehaviour
{
    public AudioSource Swiping;
    public SelectMapManager Manager;

    public void Swipe()
    {
        Swiping.Play();
    }
}
