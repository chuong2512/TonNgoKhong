using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.VFX;

public class JoystickManager : MonoBehaviour
{
    [Header("ManagerPlayer")] public movementJoystick joystickMovement;
    private Rigidbody2D rb;
    public GameObject Gun;

    [Header("Animations")] public Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        /*if (PlayerPrefs.GetInt("shoes") == 10)
        {
            shoesSpeed = 0.1f * PlayerPrefs.GetInt("shoes1");
        }
        else if (PlayerPrefs.GetInt("shoes") == 11)
        {
            shoesSpeed = 0.1f * PlayerPrefs.GetInt("shoes2");
        }
        else if (PlayerPrefs.GetInt("shoes") == 12)
        {
            shoesSpeed = 0.1f * PlayerPrefs.GetInt("shoes3");
        }*/

        anim.Play(rb.velocity.magnitude > 0 ? "CharacterBody" : "0");

        AnimatorController();
        if (joystickMovement.joystickVec.y != 0)
        {
            var speed = PlayerManager.Instance.CurrentStatus.Speed;

            float ps = speed /*+ PlayerPrefs.GetFloat("Spead") / 10*/;
            Debug.Log("player speed" + ps);
            Debug.Log("player save" + PlayerPrefs.GetFloat("Spead"));

            rb.velocity = new Vector2(joystickMovement.joystickVec.x * speed,
                joystickMovement.joystickVec.y * speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    void AnimatorController()
    {
        if (joystickMovement.joystickVec.y < 0)
        {
            //Debug.Log("Going Down");
        }

        if (joystickMovement.joystickVec.y > 0)
        {
            //Debug.Log("Going Up");
        }

        if (joystickMovement.joystickVec.x < 0)
        {
            //Debug.Log(" Going Left");
            this.gameObject.transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
            if (Gun.activeSelf == true)
            {
                Gun.transform.localScale = new Vector3(-0.2446888f, 0.2446888f, 0.2446888f);
            }
        }

        if (joystickMovement.joystickVec.x > 0)
        {
            //Debug.Log("Going Right");
            this.gameObject.transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            if (Gun.activeSelf == true)
            {
                Gun.transform.localScale = new Vector3(0.2446888f, 0.2446888f, 0.2446888f);
            }
        }
    }
}