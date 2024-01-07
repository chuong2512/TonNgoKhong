using Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDInGame : MonoBehaviour
{
    [Header("UI Text Manager")] public Text TimeTMP;
    public TextMeshProUGUI ExpTMP;
    public TextMeshProUGUI KilledTMP;
    public TextMeshProUGUI CoinTMP;

    public Image ExpImage;

    public Button pauseBtn;

    private void Start()
    {
        OnKillChange(0);
        OnCoinChange(0);
        OnExpChange(0);

        InGameAction.OnCoinChange += OnCoinChange;
        InGameAction.OnKillChange += OnKillChange;
        InGameAction.OnExpChange += OnExpChange;
        InGameAction.OnTimeChange += OnTimeChange;

        pauseBtn.onClick.AddListener(OnCickPauseBtn);
    }

    private void OnCickPauseBtn()
    {
        InGameManager.Instance.GameState = GameState.Pause;
        ScreenManager.Instance.OpenScreen(ScreenType.Pause);
    }

    private void OnDestroy()
    {
        InGameAction.OnCoinChange -= OnCoinChange;
        InGameAction.OnKillChange -= OnKillChange;
        InGameAction.OnExpChange -= OnExpChange;
        InGameAction.OnTimeChange -= OnTimeChange;

        pauseBtn.onClick.RemoveAllListeners();
    }

    private void OnTimeChange(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        TimeTMP.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void OnCoinChange(int amount)
    {
        CoinTMP.SetText(amount.ToString());
    }

    private void OnKillChange(int amount)
    {
        KilledTMP.SetText(amount.ToString());
    }

    private void OnExpChange(int amount)
    {
        ExpTMP.SetText(amount.ToString());
        ExpImage.fillAmount = InGameManager.Instance.PercentLevel;
    }
}