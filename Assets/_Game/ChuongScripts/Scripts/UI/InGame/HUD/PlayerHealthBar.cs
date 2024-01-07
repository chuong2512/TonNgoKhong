using System;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    //TODO:Chuong
    public class PlayerHealthBar : MonoBehaviour
    {
        [Header("UI Manager")] public Image HealthBar;
        public Image ReloadWeapon;
        public Color[] myColors;

        internal int len;
        public float Health;
        public float hh;

        public Vector3 Offest;
        private Vector3 rb;
        
        private void Start()
        {
            len = myColors.Length;

            HealthBar.color = Color.green;

            InGameAction.OnHealthChange += OnHealthChange;
        }

        private void FixedUpdate()
        {
            transform.position = Vector3.SmoothDamp(transform.position, transform.position + Offest, ref rb, 0);
        }

        private void OnHealthChange()
        {
            //HealthBar.fillAmount = Health / (100f + hh + ((Health * supplies.hp) / 100));
            if (HealthBar.fillAmount <= 0.5f)
            {
                HealthBar.color = Color.yellow;
            }

            if (HealthBar.fillAmount <= 0.3f)
            {
                HealthBar.color = Color.red;
            }
        }

        private void OnDestroy()
        {
            InGameAction.OnHealthChange -= OnHealthChange;
        }
    }
}