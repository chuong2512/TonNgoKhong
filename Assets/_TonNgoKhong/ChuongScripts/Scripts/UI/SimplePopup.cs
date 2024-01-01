using BabySound.Scripts;
using UnityEngine;

namespace SinhTon
{
    public class SimplePopup : AppPopup
    {
        [SerializeField] private ScreenType _type;

        public override ScreenType GetID() => _type;
    }
}