using System;
using System.Collections;
using System.Collections.Generic;
using _TonNgoKhong.Shop;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [InlineEditor()] public ShopCoinBtn[] CoinBtns;
    [InlineEditor()] public ShopGemBtn[] GemBtns;

    private void OnValidate()
    {
        CoinBtns = GetComponentsInChildren<ShopCoinBtn>();
        GemBtns = GetComponentsInChildren<ShopGemBtn>();
    }
}