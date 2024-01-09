using Game;
using UnityEngine;

public class CoinItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(TagConstants.Player))
            return;
        
        InGameManager.Instance.AddCoin();
        Destroy(this.gameObject);
    }
}