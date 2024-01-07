using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody2D;

        public void SetSimulated(bool b)
        {
            _rigidbody2D.simulated = b;
        }
    }

    public class PlayerTransform
    {
        private Transform _transform;
        public Transform Value => _transform;

        public void SetValue(Transform trans)
        {
            _transform = trans;
        }

        public PlayerTransform(Transform playerTransform)
        {
            _transform = playerTransform;
        }

        public Vector3 GetPosition()
        {
            return _transform.position;
        }
    }
}