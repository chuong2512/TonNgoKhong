using UnityEngine;
using UnityEngine.UI;

public class OpenPopupButton : MonoBehaviour
{
    private Button _button;

    [SerializeField] private ScreenType _screenType;

    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        AudioManager.Instance.ClickSound();
        if (_screenType == ScreenType.Back)
        {
            ScreenManager.Instance.Back();
        }
        else
        {
            ScreenManager.Instance.OpenScreen(_screenType);
        }
    }
}