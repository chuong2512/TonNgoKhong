using System;

namespace Game
{
    public class InGameAction
    {
        public static Action<int> OnUpgradeSkill;

        public static Action OnGameStateChange;

        public static Action OnHealthChange;
        public static Action<int> OnKillChange;
        public static Action<int> OnCoinChange;
        public static Action<int> OnExpChange;
        public static Action OnLevelUp;
        public static Action<float> OnTimeChange;
        public static Action OnPlayerDie;
    }
}