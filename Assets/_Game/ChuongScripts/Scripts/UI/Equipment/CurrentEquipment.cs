using UnityEngine;

namespace Game
{
    public class CurrentEquipment : MonoBehaviour
    {
        public GameDataManager GameDataManager;

        private void Start()
        {
            GameDataManager = GameDataManager.Instance;
        }

        public void BindData()
        {
        }
    }
}