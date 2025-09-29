using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static RealmCare;
using Lofelt.NiceVibrations;

/// <summary>
/// LogoutPanelView - 自动生成的UI视图脚本
/// </summary>
public class MonoidTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("Title")]   
#region
    //UI组件
    public Text Sheep;
[UnityEngine.Serialization.FormerlySerializedAs("Desc")]    public Text Shop;
[UnityEngine.Serialization.FormerlySerializedAs("Yes")]    public Button Ago;
[UnityEngine.Serialization.FormerlySerializedAs("No")]    public Button Ax;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button BoardOff;
[UnityEngine.Serialization.FormerlySerializedAs("BackGround")]
    public GameObject HuntPlover;

    private bool Caliber= true;
    #endregion

    #region 生命周期函数

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        BoneBenefit.RimIndicate().StifleTranslation(HuntPlover.GetComponent<RectTransform>());
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        Caliber = true;
        Shop.text = "Do you want to delete all the data?";
    }
    private void Start()
    {
        BoardOff.onClick.AddListener(FacialBoard);
        Ax.onClick.AddListener(FacialBoard);
        Ago.onClick.AddListener(FacialAgo);
    }

    #endregion

    #region 事件绑定

    public void FacialBoard()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        //UIBenefit.GetInstance().CloseUI();
        BoardUIFend(GetType().Name);
    }
    public void FacialAgo()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        if (Caliber)
        {
            Caliber = false;
            Shop.text = "All your information will be cleared!";
        }
        else
        {
#if UNITY_EDITOR

            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
            PlayerPrefs.DeleteAll();
        }

    }
    #endregion

}
