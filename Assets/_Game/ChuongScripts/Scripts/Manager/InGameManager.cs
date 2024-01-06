using System;
using Unity.VisualScripting;

namespace SinhTon
{
    using System.Collections;
    using UnityEngine;

    public class InGameManager : Singleton<InGameManager>
    {
        public TimerManager timer;

        [Header("Componenet Player")] public GameObject Player;
        public GameObject HelthUI;
        public GameObject CurrentLevel;

        [Header("Strings Manager")] internal string CheckEvolve;
        internal string Checking;

        [Header("Boolaen Manager")] internal bool FinishScreenB = false;
        internal bool DestroyEnemys = false;
        private bool StopAllAudios = false;

        internal bool MapReady = false;

        AudioCheckerPlayer audioCheckerPlayer;

        void Start()
        {
            Checking = PlayerPrefs.GetString("CheckEvolve");

            StartCoroutine(GameStart());
        }

        void Update()
        {
            CheckEvolve = PlayerPrefs.GetString("CheckEvolve");

            if (GameManager.Instance.PlayerDeath && FinishScreenB == false)
            {
                DestroyEnemys = true;
                StopAllAudios = true;
                timer.StopTime();

                GameManager.Instance.PlayerDeath = false;
                FinishScreenB = true;
            }
            else
            {
                StopAllAudios = false;
            }
        }

        public void BackBtn()
        {
            MapReady = false;
            DestroyEnemys = true;
            Destroy(CurrentLevel);
            StartCoroutine(StartBacking());
        }

        public void BackFinish()
        {
            MapReady = false;
            DestroyEnemys = true;
            Destroy(CurrentLevel);
            StartCoroutine(StartBacking());
        }

        IEnumerator StartBacking()
        {
            yield return new WaitForSeconds(0.8f);
            Player.gameObject.GetComponent<Rigidbody2D>().simulated = true;
            DestroyEnemys = false;
            GameManager.Instance.CurrentReload = 0;
            GameManager.Instance.CurrentCurrency = 0;
            GameManager.Instance.CurrentKilled = 0;
            timer.timeRemaining = 0;
            FinishScreenB = false;
            
            Player.transform.position = new Vector3(0, 0, 0);
            HelthUI.SetActive(false);
        }
        

        IEnumerator GameStart()
        {
            yield return new WaitForSeconds(0.7f);
            if (Checking == "")
            {
                Checking = "work";
            }

            if (CheckEvolve == "")
            {
                PlayerPrefs.SetString("CheckEvolve", Checking);
            }

            Debug.Log("GameStart");

            MapReady = true;
            Player.GetComponent<PlayerManager>().enabled = true;
            GameManager.Instance.AvailabelWeapon = true;
            HelthUI.SetActive(true);
            timer.StartTime();
            if (GameManager.Instance?.EnemyAvailable == true)
            {
                GameManager.Instance.startmove = false;
                foreach (GameObject joint in GameManager.Instance.Enemys)
                {
                    joint.GetComponent<EnemyManager>().enabled = true;
                    joint.GetComponent<Rigidbody2D>().simulated = true;
                }
            }
        }

        public void Pause()
        {
            GameManager.Instance?.BtnPause();
        }

        public void Resume()
        {
            GameManager.Instance?.ResumeBtn();
        }

        bool myaudio = true;

        public void ChangeAudio()
        {
            audioCheckerPlayer = FindObjectOfType<AudioCheckerPlayer>();
            if (myaudio == true)
            {
                myaudio = false;
                audioCheckerPlayer.AudioManager(false);
            }
            else
            {
                myaudio = true;
                audioCheckerPlayer.AudioManager(true);
            }
        }
    }
}