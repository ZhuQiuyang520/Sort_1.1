using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using static RealmCare;
using System.Runtime.InteropServices;
using Lofelt.NiceVibrations;

/// <summary>
/// SettingPanelView - 自动生成的UI视图脚本
/// </summary>
public class HabitatTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("Version")]    
#region
//UI组件
    public Text Primacy;
[UnityEngine.Serialization.FormerlySerializedAs("Sound")]
    public Toggle Organ;
[UnityEngine.Serialization.FormerlySerializedAs("Music")]    public Toggle Realm;
[UnityEngine.Serialization.FormerlySerializedAs("VibraBtn")]    public Toggle TitleOff;
[UnityEngine.Serialization.FormerlySerializedAs("LanguageBtn")]    public Button DesignerOff;
[UnityEngine.Serialization.FormerlySerializedAs("ShopBtn")]    public Button BandOff;
[UnityEngine.Serialization.FormerlySerializedAs("GoHomeBtn")]    public Button GoBuckOff;
[UnityEngine.Serialization.FormerlySerializedAs("RateBtn")]    public Button LoadOff;
[UnityEngine.Serialization.FormerlySerializedAs("Privacy")]    public Button Printer;
[UnityEngine.Serialization.FormerlySerializedAs("QuitBtn")]    public Button SafeOff;
[UnityEngine.Serialization.FormerlySerializedAs("UnSubBtn")]    public Button ToGelOff;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    
    public Button BoardOff;
[UnityEngine.Serialization.FormerlySerializedAs("Setting")]
    public Button Habitat;
    private int RoostStress= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ListBtn")]
    public GameObject[] HardOff;
[UnityEngine.Serialization.FormerlySerializedAs("Content")]    public GameObject Migrant;

    private int BandIndigo;
    private string PrinterURL;
    private PopupType Care;

#if UNITY_IOS
    [DllImport("__Internal")] // 打开外部链接
    internal extern static void openUrl(string url);
#endif

    #endregion

    #region 生命周期函数

    protected override void OnMessageReceived(object message)
    {
        base.OnMessageReceived(message);
        Care = (PopupType)message;
        if (Care == PopupType.Game)
        {
            GoBuckOff.gameObject.SetActive(true);
        }
        else if (Care == PopupType.Home)
        {
            GoBuckOff.gameObject.SetActive(false);
        }
    }

    protected override void Awake()
    {
        base.Awake();
        BandIndigo = FluHealWar.instance.BoneVole.initgamedata.unclock_shop_lv;
    }

    private void Start()
    {
        Organ.onValueChanged.AddListener(FacialOrgan);
        Realm.onValueChanged.AddListener(FacialRealm);
        TitleOff.onValueChanged.AddListener(FacialTitle);
        DesignerOff.onClick.AddListener(FacialDesigner);

        BandOff.onClick.AddListener(FacialBand);
        GoBuckOff.onClick.AddListener(FacialBuck);
        LoadOff.onClick.AddListener(FacialLoad);
        Printer.onClick.AddListener(FacialPrinter);
        SafeOff.onClick.AddListener(FacialFist);

        ToGelOff.onClick.AddListener(FacialToGel);
        BoardOff.onClick.AddListener(Board);

        Habitat.onClick.AddListener(HabitatRoost);

        Primacy.text = string.Format("Ver 0.{0}({1})", Application.version, 1);

        PrinterURL = FluHealWar.instance.BoneVole.initgamedata.Privacy_Policy;
        BoneBenefit.RimIndicate().StifleTranslation(Migrant.GetComponent<RectTransform>());
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        //if (PlayerPrefs.GetInt(VoleBenefit.SaveLevel) >= ShopUnlock)
        //{
        //    ShopBtn.gameObject.SetActive(true);
        //}

        if (PlayerPrefs.GetInt(VoleBenefit.TownRealm) == 1)
        {
            FacialRealm(true);
        }
        else
        {
            FacialRealm(false);
        }

        if (PlayerPrefs.GetInt(VoleBenefit.TownOrgan) == 1)
        {
            FacialOrgan(true);
        }
        else
        {
            FacialOrgan(false);
        }

        if (PlayerPrefs.GetInt(VoleBenefit.TownDiffusely) == 1)
        {
            FacialTitle(true);
        }
        else
        {
            FacialTitle(false);
        }
    }

#endregion

#region 事件绑定
    public void FacialRealm(bool open)
    {
        RoostStress = 0;
        
        Realm.isOn = open;
        BoneBenefit.RimIndicate().NoRealm = open;
        if (open)
        {
            //继续播放，如果没有BGM就从头播放
            RealmWar.RimIndicate().IllFewExploitLagShow();
            PlayerPrefs.SetInt(VoleBenefit.TownRealm, 1);
        }
        else
        {
            //暂停
            RealmWar.RimIndicate().IllFewBoardLagShow();
            PlayerPrefs.SetInt(VoleBenefit.TownRealm, 0);
        }
    }
    public void FacialOrgan(bool open)
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        Organ.isOn = open;
        BoneBenefit.RimIndicate().NoOrgan = open;
        if (open)
        {
            PlayerPrefs.SetInt(VoleBenefit.TownOrgan, 1);
        }
        else
        {
            //AudioManager.Instance.StopAllSFX();
            PlayerPrefs.SetInt(VoleBenefit.TownOrgan, 0);
        }
    }
    public void FacialTitle(bool open)
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        TitleOff.isOn = open;
        BoneBenefit.RimIndicate().NoTitle = open;
        if (open)
        {
            PlayerPrefs.SetInt(VoleBenefit.TownDiffusely, 1);
        }
        else
        {
            PlayerPrefs.SetInt(VoleBenefit.TownDiffusely, 0);
        }
    }
    public void FacialDesigner()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        //UIBenefit.GetInstance().ShowUIForms(nameof(LanguagePanel));
    }

    public void FacialBand()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        //UIBenefit.GetInstance().CloseUI();
        BoardUIFend(GetType().Name);
        UIBenefit.RimIndicate().WrapUILight(nameof(BandTowel));
    }
    public void FacialBuck()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        UIBenefit.RimIndicate().GuardLopUI();
        UIBenefit.RimIndicate().WrapUILight(nameof(BuckTowel));
    }
    public void FacialLoad()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        string toMail = FluHealWar.instance.BoneVole.initgamedata.Contact_Us;
        string subject = "[USERFEED]wordfarmers v1.1.0";
        Uri uri = new Uri(string.Format("mailto:{0}?subject={1}&body={2}", toMail, subject,"你好"));
        Application.OpenURL(uri.AbsoluteUri);
    }
    public void FacialPrinter()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        if (!string.IsNullOrEmpty(PrinterURL))
        {
            string url = PrinterURL;
#if UNITY_ANDROID || UNITY_EDITOR
            Application.OpenURL(url);
#elif UNITY_IOS
       openUrl(url);
#endif
        }
    }
    public void FacialFist()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void FacialToGel()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        UIBenefit.RimIndicate().WrapUILight(nameof(MonoidTowel));
    }

    public void Board()
    {
        RoostStress = 0;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        //UIBenefit.GetInstance().CloseUI();
        BoardUIFend(GetType().Name);
        BlanketBenefit.RimIndicate().Dimension(MessageCode.BoardBuckHandle);
    }

    public void HabitatRoost()
    {
        RoostStress++;
        if (RoostStress >= 5)
        {
            RoostStress = 0;
            BoardUIFend(GetType().Name);
            //UIBenefit.GetInstance().ShowUIForms(nameof(DebugInfoPanel));
        }
    }

#endregion

//#if UNITY_EDITOR

//    [MenuItem("Tools/Update Version Number")]
//    public static void UpdateVersion()
//    {
//        int version =int.Parse(PlayerSettings.bundleVersion);
//        version++;
//        PlayerSettings.bundleVersion = version.ToString();
//    }
//#endif
}
