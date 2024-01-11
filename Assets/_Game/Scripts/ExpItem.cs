using Game;
using UnityEngine;

public class ExpItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(TagConstants.Player))
            return;
        
        InGameManager.Instance.AddExp();
        MasterAudioManager.Play2DSfx(AudioConst.Exp);
        PoolContainer.DeSpawnItem(this.gameObject);
    }
}