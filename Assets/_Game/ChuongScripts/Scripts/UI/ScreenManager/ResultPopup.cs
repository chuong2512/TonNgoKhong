using SinhTon.Scripts.UI;
using UnityEngine;

namespace _TonNgoKhong
{
    public class ResultPopup : BaseScreenWithModel<ResultModel>
    {
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