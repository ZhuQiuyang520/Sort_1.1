using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using sf_database;
using Lofelt.NiceVibrations;

/// <summary>
/// AddPropPopupView - 自动生成的UI视图脚本
/// </summary>
public class KeyOralSully : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("BackGround")]    
#region
 //UI组件
    public GameObject HuntPlover;
[UnityEngine.Serialization.FormerlySerializedAs("TitleDesc")]    public Text SheepShop;
[UnityEngine.Serialization.FormerlySerializedAs("CenterDesc")]    public Text UnloadShop;
[UnityEngine.Serialization.FormerlySerializedAs("CoinDesc")]    public Text GeneShop;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button BoardOff;
[UnityEngine.Serialization.FormerlySerializedAs("FreeBtn")]    public Button HuskOff;
[UnityEngine.Serialization.FormerlySerializedAs("CoinBtn")]    public Button GeneOff;
[UnityEngine.Serialization.FormerlySerializedAs("PopupNumber")]    public Text SullyStress;
[UnityEngine.Serialization.FormerlySerializedAs("BuyNumber")]    public Text LipStress;
[UnityEngine.Serialization.FormerlySerializedAs("FreeDesc")]    public Text HuskShop;
[UnityEngine.Serialization.FormerlySerializedAs("PopupIcon")]    public Image SullyPull;
    private PopupType Care;
    private int SadGeneStress;
    private int SadCoerce;
    private int SullyTie;
[UnityEngine.Serialization.FormerlySerializedAs("PorpIcon")]    public Sprite[] LurePull;
    #endregion

    #region 生命周期函数

    private void Start()
    {
        BoardOff.onClick.AddListener(FacialBoard);
        HuskOff.onClick.AddListener(FacialHusk);
        GeneOff.onClick.AddListener(LipSully);
        BoneBenefit.RimIndicate().StifleTranslation(HuntPlover.GetComponent<RectTransform>());

        if (VerbalRend.NoSquat())
        {
            GeneOff.gameObject.SetActive(true);
        }
        else
        {
            HuskOff.transform.localPosition = Vector3.zero;
        }
    }


    protected override void OnMessageReceived(object message)
    {
        base.OnMessageReceived(message);
        Care = (PopupType)message;
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        SadGeneStress = PlayerPrefs.GetInt(CRamble.Dy_GoldGene);
        GeneShop.text = SadGeneStress.ToString();
        switch (Care)
        {
            case PopupType.Vase:
                SheepShop.text = "Add Bottle";
                UnloadShop.text = "More Bottles";
                SullyPull.sprite = LurePull[0];
                LipStress.text = FluHealWar.instance.BoneVole.initgamedata.bottles_price.ToString();
                SullyStress.text = "×" + FluHealWar.instance.BoneVole.initgamedata.bottles_ad_nums.ToString();
                SullyTie = FluHealWar.instance.BoneVole.initgamedata.bottles_ad_nums;
                SadCoerce = FluHealWar.instance.BoneVole.initgamedata.bottles_price;
                break;
            case PopupType.Remind:
                SheepShop.text = "Hint";
                UnloadShop.text = "More Hint";
                SullyPull.sprite = LurePull[1];
                LipStress.text = FluHealWar.instance.BoneVole.initgamedata.Hint_price.ToString();
                SullyStress.text = "×" + FluHealWar.instance.BoneVole.initgamedata.Hint_ad_nums;
                SullyTie = FluHealWar.instance.BoneVole.initgamedata.Hint_ad_nums;;
                SadCoerce = FluHealWar.instance.BoneVole.initgamedata.Hint_price;
                break;
            case PopupType.RollBack:
                SheepShop.text = "Withdrawn";
                UnloadShop.text = "More Withdrawn";
                SullyPull.sprite = LurePull[2];
                LipStress.text = FluHealWar.instance.BoneVole.initgamedata.withdrawn_price.ToString();
                SullyStress.text = "×" + FluHealWar.instance.BoneVole.initgamedata.withdrawn_ad_nums;;
                SullyTie = FluHealWar.instance.BoneVole.initgamedata.withdrawn_ad_nums; ;
                SadCoerce = FluHealWar.instance.BoneVole.initgamedata.withdrawn_price;
                break;
            default:
                break;
        }
        if (SadGeneStress < SadCoerce)
        {
            GeneOff.interactable = false;
        }
        else
        {
            GeneOff.interactable = true;
        }
    }


    #endregion

    #region 事件绑定

    public void FacialBoard()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        //UIBenefit.GetInstance().CloseUI();
        BoardUIFend(GetType().Name);
    }

    public void FacialHusk()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        string PropType = "";
        switch (Care)
        {
            case PopupType.Vase:
                MillXenonSister.RimIndicate().MoatXenon("9001", "6");
                break;
            case PopupType.Remind:
                MillXenonSister.RimIndicate().MoatXenon("9001", "5");
                break;
            case PopupType.RollBack:
                MillXenonSister.RimIndicate().MoatXenon("9001", "4");
                break;
            default:
                break;
        }
        
        BaseGetProp GetProp = new BaseGetProp();
        GetProp.Arouse = SullyTie;
        GetProp.Inn = "rv";
        // 播放成功逻辑处理
        ADBenefit.Indicate.PineModuleProwl((success) =>
        {
            if (success)
            {
                switch (Care)
                {
                    case PopupType.Vase:
                        PropType = "6";
                        MillXenonSister.RimIndicate().MoatXenon("1015","2");
                        MillXenonSister.RimIndicate().MoatXenon("9003", "6");
                        PlayerPrefs.SetInt(VoleBenefit.TownDarnOral, SullyTie);
                        GetProp.type = "add";
                        break;
                    case PopupType.Remind:
                        PropType = "5";
                        MillXenonSister.RimIndicate().MoatXenon("1014", "2");
                        MillXenonSister.RimIndicate().MoatXenon("9003", "5");
                        PlayerPrefs.SetInt(VoleBenefit.TownInfectOral, SullyTie);
                        GetProp.type = "hint";
                        break;
                    case PopupType.RollBack:
                        PropType = "4";
                        MillXenonSister.RimIndicate().MoatXenon("1013", "2");
                        MillXenonSister.RimIndicate().MoatXenon("9003", "4");
                        PlayerPrefs.SetInt(VoleBenefit.TownStockingOral, SullyTie);
                        GetProp.type = "withdraw";
                        break;
                    default:
                        break;
                }
                BlanketBenefit.RimIndicate().Dimension(MessageCode.KeySully, Care);
                BoardUIFend(GetType().Name);
            }
            else
            {
                TruthBenefit.RimIndicate().WrapTruth("No ads right now, please try it later.");
            }
        }, PropType);
    }

    public void LipSully()
    {
        ADBenefit.Indicate.AxFreelyKeyCreep();
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        SadGeneStress -= SadCoerce;

        BaseUseCoin useCoin = new BaseUseCoin();
        useCoin.Plank = SadCoerce;
        useCoin.Bongo_id = PlayerPrefs.GetInt(VoleBenefit.TownValid);

        BaseGetProp GetProp = new BaseGetProp();
        GetProp.Arouse = SullyTie;
        GetProp.Inn = "buy";

        PlayerPrefs.SetInt(CRamble.Dy_GoldGene, SadGeneStress);
        switch (Care)
        {
            case PopupType.Vase:
                useCoin.Index = "add";
                GetProp.type = "add";
                MillXenonSister.RimIndicate().MoatXenon("1015","1");
                PlayerPrefs.SetInt(VoleBenefit.TownDarnOral,SullyTie);
                break;
            case PopupType.Remind:
                useCoin.Index = "hint";
                GetProp.type = "hint";
                MillXenonSister.RimIndicate().MoatXenon("1014","1");
                PlayerPrefs.SetInt(VoleBenefit.TownInfectOral, SullyTie);
                break;
            case PopupType.RollBack:
                useCoin.Index = "withdraw";
                GetProp.type = "withdraw";
                MillXenonSister.RimIndicate().MoatXenon("1013","1");
                PlayerPrefs.SetInt(VoleBenefit.TownStockingOral, SullyTie);
                break;
            default:
                break;
        }
        BlanketBenefit.RimIndicate().Dimension(MessageCode.KeySully, Care);
        //UIBenefit.GetInstance().CloseUI();
        BoardUIFend(GetType().Name);
    }
    #endregion

}
