using UnityEngine;

namespace Game
{
    public abstract class BaseSkillController<T> : MonoBehaviour where T : IAttribute
    {
        public T attribute { get; set; }

        public abstract void Refresh();
    }
}