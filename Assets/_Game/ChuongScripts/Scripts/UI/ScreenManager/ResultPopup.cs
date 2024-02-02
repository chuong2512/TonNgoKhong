using System;
using Game;
using SinhTon.Scripts.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
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

        private bool _result;

        [Header("Visual")] [SerializeField] private Image resultSprite;
        [SerializeField] private Sprite loseImg, winImg;
        [SerializeField] private Text resultTxt;
        [SerializeField] private Text buttonTxt;

        private void Start()
        {
            _restartBtn.onClick.AddListener(ClickRestart);
            _homeBtn.onClick.AddListener(ClickHome);
        }

        private void AddData()
        {
            _player.Exp += 10;
            _player.Coin += _game.CoinValue;

            if (_result)
            {
                _player.Gem += 10;
            }

var time = TimerManager.Instance.TimeToDisplay;

            _player.SetMaxTime(time, _player.choosingMap);
        }

        private void ClickHome()
        {
            SceneLoader.Instance.LoadHome();
        }

        private void ClickRestart()
        {
            var choosingMap = GameDataManager.Instance.playerData.choosingMap;

            if (_result && !GameDataManager.Instance.IsMaxLevel())
                SceneLoader.Instance.LoadMap(choosingMap + 1);
            else
            {
                SceneLoader.Instance.LoadMap(choosingMap);
            }
        }

        public override void BindData(ResultModel model)
        {
            InGameManager.Instance.GameState = GameState.Pause;

            _result = model.isWin;

            _player = GameDataManager.Instance.playerData;
            _game = InGameManager.Instance;

            
            if (model.isWin)
            {
                GameDataManager.Instance.playerData.UnlockMap(_player.choosingMap + 1);
            }
            
            AddData();

            resultSprite.sprite = _result ? winImg : loseImg;

            if (_result)
            {
                ExpTMP.text = ("+50");
                resultTxt.text = "Chiến thắng";
                buttonTxt.text = "Tiếp tục";
            }
            else
            {
                ExpTMP.text = ("+10");
                resultTxt.text = "Thất bại";
                buttonTxt.text = "Chơi lại";
            }

            CoinTMP.text = (_game.CoinValue.ToString());
            KilledTMP.text = (_game.KilledValue.ToString());


            var time = TimerManager.Instance.PlayTime;

            TimeTMP.text = ($"{time.TotalMinutes:00}:{time.Seconds:00}");

            var maxTime = TimeSpan.FromSeconds(_player.GetMapWithID(_player.choosingMap).time);

            MaxTimeTMP.text = ($"{maxTime.TotalMinutes:00}:{maxTime.Seconds:00}");

            ChapterTMP.text = $"Chương {_player.choosingMap + 1}";
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