using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supplies : MonoBehaviour
{
    public int hp=0;
    public int Magnet=1;
    public float speedShoot=0;
    public float Protect =0;
    public float restoreHP =0;
    public float playerSpeed =0 ;

    public void ResetS()
    {
        hp = 0;
        Magnet = 1;
        speedShoot = 0;
        Protect = 0;
        restoreHP = 0;
        playerSpeed = 0;
    }
}
