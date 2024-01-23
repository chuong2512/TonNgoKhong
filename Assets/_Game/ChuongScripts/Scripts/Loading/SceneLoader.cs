﻿using SinhTon;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class SceneLoader : PersistentSingleton<SceneLoader>
    {
        [HideInInspector] public string sceneName;

        public void LoadScene(string nameScene)
        {
            sceneName = nameScene;
            SceneManager.LoadScene("FakeLoading");
        }

        public void LoadMap(int mapID)
        {
            LoadScene($"Map_{mapID + 1}");
        }
        
        public void LoadHome()
        {
            LoadScene("GamePlay");
        }
    }
}