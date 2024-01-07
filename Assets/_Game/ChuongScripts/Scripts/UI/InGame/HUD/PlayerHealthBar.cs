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
        public Vector3 Offest;

        private Vector3 _rb;

        private PlayerCombat PlayerCombat;

        private void Start()
        {
            HealthBar.color = Color.green;
            InGameAction.OnHealthChange += OnHealthChange;

            PlayerCombat = PlayerManager.Instance.Combat;
        }

        private void OnHealthChange()
        {
            HealthBar.fillAmount = PlayerCombat.Health / PlayerCombat.MaxHealth;
            if (HealthBar.fillAmount <= 0.5f)
            {
                HealthBar.color = Color.yellow;
            }

            if (HealthBar.fillAmount <= 0.3f)
            {
                HealthBar.color = Color.red;
            }
        }

        /*void ReloadingWapeons()
{
    Valeur += 1f * Time.deltaTime;
    if (ReloadWeapon.fillAmount < 1 && RightFill == true)
    {
        SpawnObject = false;
        ReloadWeapon.fillAmount = Valeur;
        LeftFill = true;
    }

    if (ReloadWeapon.fillAmount == 1 && LeftFill == true)
    {
        SpawnObject = true;
        ReloadWeapon.fillAmount = 0;
        Valeur = 0;
        LeftFill = false;
    }
}*/

        private void OnDestroy()
        {
            InGameAction.OnHealthChange -= OnHealthChange;
        }
    }
}