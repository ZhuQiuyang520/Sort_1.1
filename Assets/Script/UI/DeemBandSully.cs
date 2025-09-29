using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Lofelt.NiceVibrations;

/// <summary>
/// DontShopPopupView - 自动生成的UI视图脚本
/// </summary>
public class DeemBandSully : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    
#region 
//UI组件
    public Button BoardOff;
[UnityEngine.Serialization.FormerlySerializedAs("GotoBtn")]    public Button TearOff;
[UnityEngine.Serialization.FormerlySerializedAs("TitleDesc")]    public Text SheepShop;
[UnityEngine.Serialization.FormerlySerializedAs("BackGround")]
    public GameObject HuntPlover;
    #endregion

    #region 生命周期函数

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
    }

    private void Start()
    {
        BoardOff.onClick.AddListener(Board);
        TearOff.onClick.AddListener(Tear);
        BoneBenefit.RimIndicate().StifleTranslation(HuntPlover.GetComponent<RectTransform>());
    }

    #endregion

    #region 事件绑定
    public void Board()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoardUIFend(nameof(DeemBandSully));
    }
    public void Tear()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        var UISta = UIBenefit.RimIndicate().RimWritingRamble(true);
        foreach (var item in UISta)
        {
            GameObject go = item.gameObject;
            BoardUIFend(nameof(DeemBandSully));
        }
        UIBenefit.RimIndicate().WrapUILight(nameof(BoneTowel));
    }
    #endregion

}
