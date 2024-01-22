using SinhTon;
using Game;
using UnityEngine;

public class AddSkillPanel : BasePopup
{
    [SerializeField] private SkillButton[] _skillButtons;
    
    public override ScreenType GetID() => ScreenType.AddSkill;
    
    
    public override void OnOpen()
    {
#if UNITY_EDITOR
        InGameManager.Instance.GameState = GameState.Pause;
#endif
        var listSkill = SkillSelector.Instance.GetListSkillUpgrade();
        var buttonIndex = 0;
        for (; buttonIndex < listSkill.Count; buttonIndex++)
        {
            _skillButtons[buttonIndex].gameObject.SetActive(true);
            _skillButtons[buttonIndex].Setup(listSkill[buttonIndex]);
        }

        for (; buttonIndex < _skillButtons.Length; buttonIndex++)
        {
            _skillButtons[buttonIndex].Setup(-1);
        }
        
    }
}
