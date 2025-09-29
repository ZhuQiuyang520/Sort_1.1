using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Lofelt.NiceVibrations;

/// <summary>
/// FailPanelView - 自动生成的UI视图脚本
/// </summary>
public class SilkTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("FreeBtn")]   
#region 
    //UI组件
    public Button HuskOff;
[UnityEngine.Serialization.FormerlySerializedAs("SkipBtn")]    public Button DireOff;
[UnityEngine.Serialization.FormerlySerializedAs("ListArray")]
    public GameObject[] HardMaser;
    #endregion

    #region 生命周期函数

    private void Start()
    {
        HuskOff.onClick.AddListener(FactHusk);
        DireOff.onClick.AddListener(Silk);
        for (int i = 0; i < HardMaser.Length; i++)
        {
            BoneBenefit.RimIndicate().StifleTranslation(HardMaser[i].GetComponent<RectTransform>());
        }
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.fail);
    }

    #endregion

    #region 事件绑定
    /// <summary>
    /// 初始化UI事件
    /// </summary>
    private void PolynesianEvents()
    {
        HuskOff.onClick.AddListener(FactHusk);
        DireOff.onClick.AddListener(Silk);
    }

    //打开激励视频
    public void FactHusk()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        ADBenefit.Indicate.PineModuleProwl((success) =>
        {
            if (success)
            {
                // 播放成功逻辑处理
                //UIBenefit.GetInstance().CloseUI();
                BoardUIFend(GetType().Name);
                BlanketBenefit.RimIndicate().Dimension(MessageCode.SilkProwlDodge);
            }
            else
            {
                TruthBenefit.RimIndicate().WrapTruth("No ads right now, please try it later.");
            }
        }, "");

    }
    //失败
    public void Silk()
    {
        ADBenefit.Indicate.AxFreelyKeyCreep();
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        
        // 播放成功逻辑处理
        UIBenefit.RimIndicate().GuardLopUI();
        UIBenefit.RimIndicate().WrapUILight(nameof(BuckTowel));
    }
    #endregion

}
