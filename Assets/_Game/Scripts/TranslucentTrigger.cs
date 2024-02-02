using System;
using UnityEngine;

namespace _Game.Scripts
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class TranslucentTrigger : MonoBehaviour
    {
        [Range(0,1f)] [SerializeField] private float transparent = 0.5f;
        private SpriteRenderer _sprite;
        private float _defaultTransparent;

        private void Awake()
        {
            _sprite = GetComponent<SpriteRenderer>();
            _defaultTransparent = _sprite.color.a;
        }

        private void SetTransparent(float trans)
        {
            var spriteColor = _sprite.color;
            spriteColor.a = trans;
            _sprite.color = spriteColor;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.CompareTag("Player"))
            {
                return;
            }
            SetTransparent(transparent);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }
            SetTransparent(_defaultTransparent);
        }
    }
}