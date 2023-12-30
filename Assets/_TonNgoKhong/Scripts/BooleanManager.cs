using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanManager : MonoBehaviour
{
    public bool GameStart = false;
    public bool Music = true;
    internal bool Sound = true;
    internal bool Vibration = true;
    private void Update()
    {
        if(GameStart == true)
        {
          
        }
    }
    public void SoundM()
    {
        if (Music == false)
        {
           
            Music = true;
            Sound = true;
        }
        else
        {
            Music = false;
            Sound = false;
        }
    }
}
