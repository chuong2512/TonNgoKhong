using System;

namespace Game
{

    public class InGameAction
    {
        public static Action<int> OnUpgradeSkill;

        public static Action OnHealthChange;
        public static Action OnKillChange;
        public static Action OnCoinChange;
        public static Action OnExpChange;
        public static Action OnLevelUp;
        public static Action OnTimeChange;
        public static Action OnPlayerDie;
    }
}