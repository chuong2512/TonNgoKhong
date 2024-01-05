using UnityEngine;

namespace Skill
{
    public class BaseSkillController<T> : MonoBehaviour where T : IAttribute
    {
        public T attribute { get; set; }
    }
}