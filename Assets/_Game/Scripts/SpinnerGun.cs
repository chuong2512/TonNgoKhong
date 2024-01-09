using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerGun : MonoBehaviour
{
    [SerializeField] private float speed = -5.2f;
    
    void FixedUpdate()
    {
        transform.Rotate(0, 0, speed);
    }
}
