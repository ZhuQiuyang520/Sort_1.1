using UnityEngine;
using UnityEngine.UI;

/// <summary> 屏蔽界面 阻止玩家操作 退出游戏 </summary>
public class StiltTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("InfoText")]    public Text HealCart;
[UnityEngine.Serialization.FormerlySerializedAs("QuitBtn")]    public Button SafeOff;

    private void Start()
    {
        SafeOff.onClick.AddListener(Application.Quit);
    }

    public void WrapHeal(string info)
    {
        HealCart.text = info;
    }
}
