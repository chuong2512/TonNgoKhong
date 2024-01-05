using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    [Header("Manaegr")] public GameObject Level1;

    internal bool M1 = true;
    internal bool M2 = true;
    internal bool M3 = true;
    internal bool M4 = true;
    internal bool M5 = true;
    internal bool M6 = true;

    [Header("ListedLevels")] public GameObject[] Levels;
}