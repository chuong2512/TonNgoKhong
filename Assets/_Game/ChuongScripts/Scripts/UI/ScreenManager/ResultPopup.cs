using System;
using Game;
using SinhTon.Scripts.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _TonNgoKhong
{
    public class ResultPopup : BaseScreenWithModel<ResultModel>
    {
        [SerializeField] private Button _restartBtn, _homeBtn;

        public Text KilledTMP;
        public Text CoinTMP;
        public Text TimeTMP;
        public Text ExpTMP;
        public Text MaxTimeTMP;
        
        public Text ChapterTMP;

        private PlayerData _player;
        private InGameManager _game;

        private void Start()
        {
            _restartBtn.onClick.AddListener(ClickRestart);
            _homeBtn.onClick.AddListener(ClickHome);
        }

        public override void OnOpen()
        {
            base.OnOpen();

            _player = GameDataManager.Instance.playerData;
            _game = InGameManager.Instance;

            AddData();

            CoinTMP.text = (_game.CoinValue.ToString());
            KilledTMP.text = (_game.KilledValue.ToString());
            ExpTMP.text = ("+10");

            var time = TimerManager.Instance.PlayTime;

            TimeTMP.text = ($"{time.TotalMinutes:00}:{time.Seconds:00}");

            var maxTime = TimeSpan.FromSeconds(_player.GetMapWithID(_player.choosingMap).time);

            MaxTimeTMP.text = ($"{maxTime.TotalMinutes:00}:{maxTime.Seconds:00}");

            ChapterTMP.text = $"Chương {_player.choosingMap + 1}";
        }

        private void AddData()
        {
            _player.Exp += 10;
            _player.Coin += _game.CoinValue;

            var time = TimerManager.Instance.TimeToDisplay;

            _player.SetMaxTime(time, _player.choosingMap);
        }

        private void ClickHome()
        {
            SceneLoader.Instance.LoadHome();
        }

        private void ClickRestart()
        {
            SceneLoader.Instance.LoadMap(GameDataManager.Instance.playerData.choosingMap);
        }

        public override void BindData(ResultModel model)
        {
            InGameManager.Instance.GameState = GameState.Pause;
        }

        public override ScreenType GetID()
        {
            return ScreenType.Result;
        }
    }

    public class ResultModel
    {
        public bool isWin;

        public ResultModel(bool b)
        {
            isWin = b;
        }
    }
}