using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Lofelt.NiceVibrations;

/// <summary>
/// HomePanelView - 自动生成的UI视图脚本
/// </summary>
public class BuckTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("CoinDesc")]    
#region
    //UI组件
    public Text GeneShop;
[UnityEngine.Serialization.FormerlySerializedAs("LevelDesc")]    public Text ValidShop;
[UnityEngine.Serialization.FormerlySerializedAs("StartBtn")]    public Button CrossOff;
[UnityEngine.Serialization.FormerlySerializedAs("SettingBtn")]    public Button HabitatOff;
[UnityEngine.Serialization.FormerlySerializedAs("Effect")]    public GameObject Handle;
[UnityEngine.Serialization.FormerlySerializedAs("CoinObj")]    public GameObject GeneHim;
[UnityEngine.Serialization.FormerlySerializedAs("AdaptiveObj")]
    public GameObject[] RadiatorHim;
    #endregion

    #region 生命周期函数

    protected override void Awake()
    {
        base.Awake();
        BlanketBenefit.RimIndicate().AddListener(MessageCode.ReelectDesigner, ReelectDesigner);
        BlanketBenefit.RimIndicate().AddListener(MessageCode.BoardBuckHandle, FactHandle);
    }

    private void Start()
    {
        if (VerbalRend.NoSquat())
        {
            GeneHim.SetActive(true);
        }
        CrossOff.onClick.AddListener(CrossBone);
        HabitatOff.onClick.AddListener(FactHabitat);
        for (int i = 0; i < RadiatorHim.Length; i++)
        {
            BoneBenefit.RimIndicate().StifleTranslation(RadiatorHim[i].GetComponent<RectTransform>());
        }
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        GeneShop.text = PlayerPrefs.GetInt(CRamble.Dy_GoldGene).ToString();
        ReelectDesigner();
    }

    private void OnDestroy()
    {
        BlanketBenefit.RimIndicate().HamperShoshone(MessageCode.ReelectDesigner, ReelectDesigner);
        BlanketBenefit.RimIndicate().HamperShoshone(MessageCode.BoardBuckHandle, FactHandle);
    }

    protected override void OnMessageReceived(object message)
    {
        base.OnMessageReceived(message);
        Handle.SetActive(false);
        ReelectDesigner();
    }

    #endregion

    #region 事件绑定
    /// <summary>
    /// 初始化UI事件
    /// </summary>
    private void PolynesianEvents()
    {
        CrossOff.onClick.AddListener(CrossBone);
        HabitatOff.onClick.AddListener(FactHabitat);
    }
    #endregion

    public void CrossBone()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        //UIBenefit.GetInstance().CloseUI();
        BoardUIFend(GetType().Name);
        UIBenefit.RimIndicate().WrapUILight(nameof(BoneTowel));
    }
    public void FactHabitat()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        Handle.SetActive(false);
        //UIBenefit.GetInstance().CacheUIMessage(UINames.HabitatTowel, PopupType.Home);
        UIBenefit.RimIndicate().WrapUILight(nameof(HabitatTowel), PopupType.Home);
    }

    private void ReelectDesigner()
    {
        //LevelDesc.text = string.Format(I18NManager.Instance.GetText("Level_Limit{0}"), PlayerPrefs.GetInt(VoleBenefit.SaveLevel));
        ValidShop.text = "Level " + PlayerPrefs.GetInt(VoleBenefit.TownValid);
    }

    private void FactHandle()
    {
        Handle.SetActive(true);
    }
}
