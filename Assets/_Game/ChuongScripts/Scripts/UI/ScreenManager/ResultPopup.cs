using SinhTon.Scripts.UI;
using UnityEngine;
using UnityEngine.UI;

namespace _TonNgoKhong
{
    public class ResultPopup : BaseScreenWithModel<ResultModel>
    {
        [SerializeField] private Button _restartBtn, _homeBtn;

        private void Start()
        {
            _restartBtn.onClick.AddListener(ClickRestart);
            _homeBtn.onClick.AddListener(ClickHome);
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