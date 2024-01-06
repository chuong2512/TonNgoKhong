using Game;
using UnityEngine;

public class CoinItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagConstants.Player))
        {
            /*if(Green == true)
            {
                /*
                UIManager.GetComponent<ManagerMecanique>().GemsInt += 1;
                PlayerPrefs.SetInt("gems", UIManager.GetComponent<ManagerMecanique>().GemsInt);
            #1#
            }*/
            Destroy(this.gameObject);
        }
    }
}