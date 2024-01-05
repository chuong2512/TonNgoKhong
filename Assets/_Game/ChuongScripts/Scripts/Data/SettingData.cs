using UnityEngine;

namespace SinhTon
{
    public class SettingData: BaseData
    {
        public bool Music = true;
        public bool Sound = true;
        public bool Vibration = true;
        
        public override void Init()
        {
            prefString = Constant.DataKey_SettingData;
            if (PlayerPrefs.GetString(prefString).Equals(""))
            {
                ResetData();
            }

            base.Init();
        }

        public void ClickSound(out bool isOn)
        {
            Sound = !Sound;
            isOn = Sound;
        }

        public void ClickMusic(out bool isOn)
        {
            Music = !Music;
            isOn = Music;
        }

        public void ClickVibration(out bool isOn)
        {
            Vibration = !Vibration;
            isOn = Vibration;
        }
    }
}