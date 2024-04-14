using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class EvolveData : BaseData
    {
        public int evolveLevel;

        public override void Init()
        {
            prefString = Constant.DataKey_EvolveData;

            if (PlayerPrefs.GetString(prefString).Equals(""))
            {
                ResetData();
            }

            base.Init();
        }

        public void Upgrade()
        {
            evolveLevel++;
            OutGameAction.UpgradeEvolve?.Invoke();
        }
        
        public override void ResetData()
        {
            evolveLevel = 0;

            Save();
        }

        public override void ValidateData()
        {
        }

        public void SaveData()
        {
            Save();
        }
    }
}