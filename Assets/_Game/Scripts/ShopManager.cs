using Game;
using Sirenix.OdinInspector;
using UnityEngine;

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