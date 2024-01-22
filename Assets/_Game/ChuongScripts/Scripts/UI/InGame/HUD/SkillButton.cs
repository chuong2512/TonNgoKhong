using Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SkillButton : MonoBehaviour
{
    [SerializeField] private Image skillIcon;
    [SerializeField] private TextMeshProUGUI tDescription;
    [SerializeField] private Text tNameSkill;
    [SerializeField] private GameObject[] stars;
    private Button _upgradeBut;
    private int _hashID = -1;


    [SerializeField] private Sprite _coin;

    private void Start()
    {
        _upgradeBut = GetComponent<Button>();
        _upgradeBut.onClick.AddListener(OnUpgrade);
    }

    public void Setup(int hashID)
    {
        _hashID = hashID;
        if (hashID < 0)
        {
            ShowCoinBtn();
        }

        SetInfo();
    }

    private void ShowCoinBtn()
    {
        skillIcon.sprite = _coin;
        tDescription.text = "+10 Ngân lượng";
        tNameSkill.text = "Ngân lượng";
        SetStar(6);
    }

    private void SetInfo()
    {
        var data = GameDataManager.Instance.SkillSo[_hashID];
        skillIcon.sprite = data.icon;
        tDescription.text = data.contentSkill;
        tNameSkill.text = data.nameSkill;
        var level = SkillSelector.Instance.GetSkillLevel(_hashID);

        SetStar(level);
    }

    private void SetStar(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            stars[i].SetActive(true);
        }

        for (int i = amount; i < stars.Length; i++)
        {
            stars[i].SetActive(false);
        }
    }

    private void OnUpgrade()
    {
        if (_hashID >= 0)
        {
            SkillSelector.Instance.UpgradeSkill(_hashID);
        }

        ClosePopUp();
    }

    private void OnDisable()
    {
        _hashID = -1;
    }

    private void ClosePopUp()
    {
        InGameManager.Instance.GameState = GameState.Playing;
        ScreenManager.Instance.Back();
    }
}