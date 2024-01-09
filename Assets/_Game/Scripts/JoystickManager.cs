using UnityEngine;

public class JoystickManager : MonoBehaviour
{
    [Header("ManagerPlayer")] public movementJoystick joystickMovement;

    [Header("Animations")] public Animator anim;

    [SerializeField] private Rigidbody2D _rigidbody2D;
    private static readonly int Speed = Animator.StringToHash("Speed");

    public void SetSimulated(bool b)
    {
        _rigidbody2D.simulated = b;
    }

    void Update()
    {
        anim.SetFloat(Speed, _rigidbody2D.velocity.magnitude > 0 ? 1 : 0);

        AnimatorController();
        if (joystickMovement.joystickVec.y != 0)
        {
            var speed = PlayerManager.Instance.CurrentStatus.Speed;

            float ps = speed /*+ PlayerPrefs.GetFloat("Spead") / 10*/;
            Debug.Log("player speed" + ps);
            Debug.Log("player save" + PlayerPrefs.GetFloat("Spead"));

            _rigidbody2D.velocity = new Vector2(joystickMovement.joystickVec.x * speed,
                joystickMovement.joystickVec.y * speed);
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
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
            var localScale = anim.transform.localScale;
            localScale.x = Mathf.Abs(localScale.x);
            anim.transform.localScale = localScale;
        }

        if (joystickMovement.joystickVec.x > 0)
        {
            //Debug.Log("Going Right");
            var localScale = anim.transform.localScale;
            localScale.x = -Mathf.Abs(localScale.x);
            anim.transform.localScale = localScale;
        }
    }
}