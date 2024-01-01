using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.VFX;

public class JoystickManager : MonoBehaviour
{
    Supplies supplies;
    public float shoesSpeed;
    public AudioManager Sounds;

    [Header("ManagerPlayer")] public movementJoystick joystickMovement;
    public float playerSpeed;
    private Rigidbody2D rb;
    public GameObject Gun;

    internal bool rigidManager = true;

    [Header("Animations")] public Animator anim;

    void Start()
    {
        supplies = FindObjectOfType<Supplies>();
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("shoes") == 10)
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
        }

        if (rigidManager)
        {
            rb = GetComponent<Rigidbody2D>();
            rigidManager = false;
        }


        if (rb.velocity.magnitude > 0)
        {
            anim.Play("CharacterBody");
        }
        else
        {
            anim.Play("0");
        }

        AnimatorController();
        if (joystickMovement.joystickVec.y != 0)
        {
            float ps = playerSpeed + (playerSpeed * supplies.playerSpeed) / 100 +
                       PlayerPrefs.GetFloat("Spead") / 10;
            Debug.Log("player speed" + ps);

            rb.velocity = new Vector2(
                joystickMovement.joystickVec.x *
                (shoesSpeed + playerSpeed + (playerSpeed * supplies.playerSpeed) / 100),
                joystickMovement.joystickVec.y *
                (shoesSpeed + playerSpeed + (playerSpeed * supplies.playerSpeed) / 100));
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