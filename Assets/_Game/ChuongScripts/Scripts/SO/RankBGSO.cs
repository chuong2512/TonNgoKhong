using UnityEngine;

namespace Game
{
    [CreateAssetMenu(fileName = "RankBGSO", menuName = "ScriptableObjects/RankBGSO", order = 1)]
    public class RankBGSO : ScriptableObject
    {
        public int MaxRank => RankColors.Length;
        public Color32[] RankColors;
        public Sprite InnerBG, OuterBG;
    }
}