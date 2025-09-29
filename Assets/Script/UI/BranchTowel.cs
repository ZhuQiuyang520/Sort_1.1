using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Spine.Unity;
using DG.Tweening;
using sf_database;
using Lofelt.NiceVibrations;

/// <summary>
/// FinishPanelView - 自动生成的UI视图脚本
/// </summary>
public class BranchTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("Fx_Fireworks")]    
#region
    //UI组件
    //烟花特效
    public ParticleSystem Up_Prototype; 
[UnityEngine.Serialization.FormerlySerializedAs("Fx_Ribbon")]    //彩带特效
    public ParticleSystem Up_Teacup;
[UnityEngine.Serialization.FormerlySerializedAs("CatSpineAni")]    // 猫的spine动画
    public SkeletonGraphic PayPanicBus;
[UnityEngine.Serialization.FormerlySerializedAs("WelldoneSpineAni")]    // welldone的spine动画
    public SkeletonGraphic OccasionPanicBus;
[UnityEngine.Serialization.FormerlySerializedAs("ShowList")]    // 显示列表
    public List<GameObject> WrapHard;
[UnityEngine.Serialization.FormerlySerializedAs("CoinDesc")]    //金币显示
    public Text GeneShop;
[UnityEngine.Serialization.FormerlySerializedAs("CoinAward")]    //金币奖励数量
    public Text GeneDodge;
[UnityEngine.Serialization.FormerlySerializedAs("DiamondAward")]    public Text ProposeDodge;
[UnityEngine.Serialization.FormerlySerializedAs("FreeBtn")]    public Button HuskOff;
[UnityEngine.Serialization.FormerlySerializedAs("ClaimBtn")]    public Button AdultOff;
[UnityEngine.Serialization.FormerlySerializedAs("CoinLight")]
    //public GameObject DiamondLight;
    public GameObject GeneTrunk;
[UnityEngine.Serialization.FormerlySerializedAs("MaskIcon")]
    public GameObject FirePull;
[UnityEngine.Serialization.FormerlySerializedAs("CoinIcon")]
    public GameObject GenePull;
[UnityEngine.Serialization.FormerlySerializedAs("EndPos")]    public Transform FlyLeg;
[UnityEngine.Serialization.FormerlySerializedAs("DiamondReward")]
    public GameObject ProposeModule;
[UnityEngine.Serialization.FormerlySerializedAs("CoinReward")]    public GameObject GeneModule;
[UnityEngine.Serialization.FormerlySerializedAs("CoinObj")]    public GameObject GeneHim;

    [Header("转盘组")]
[UnityEngine.Serialization.FormerlySerializedAs("SlotBG")]    public WarpBench WarpBG;

    private bool NoSodium= true;

    //当前金币数
    private int SadGeneStress;
    //奖励数量
    private double ModuleStress;
    private double GeneModuleStress;
    private int SadBranchValid;

    private List<LevelConfig> ValidHard= new List<LevelConfig>();

    private int Ever;
[UnityEngine.Serialization.FormerlySerializedAs("ListArray")]
    public GameObject[] HardMaser;
    #endregion

    #region 生命周期函数
    private void Start()
    {
        HuskOff.onClick.AddListener(BodeResemblance);
        AdultOff.onClick.AddListener(AxResemblance);
        for (int i = 0; i < HardMaser.Length; i++)
        {
            BoneBenefit.RimIndicate().StifleTranslation(HardMaser[i].GetComponent<RectTransform>());
        }
        if (VerbalRend.NoSquat())
        {
            GeneHim.SetActive(true);
            GeneModule.SetActive(true);
        }
        else
        {
            ProposeModule.SetActive(true);
        }
    }
    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        WarpBG.PaneMouth();
        BoneBenefit.RimIndicate().StifleTranslation(HuskOff.GetComponent<RectTransform>());
        Ever = PlayerPrefs.GetInt(VoleBenefit.TownValidEver);
        FirePull.SetActive(false);
        NoSodium = true;
        ModuleStress = FluHealWar.instance.BoneVole.initgamedata.level_complete_cash_num;
        GeneModuleStress = FluHealWar.instance.BoneVole.initgamedata.win_coins;
        GeneDodge.text = GeneModuleStress.ToString();
        ProposeDodge.text = ModuleStress.ToString("f2");
        SadGeneStress = PlayerPrefs.GetInt(CRamble.Dy_GoldGene);
        GeneShop.text = SadGeneStress.ToString();

        int CurLevelNumber = PlayerPrefs.GetInt(VoleBenefit.TownValid);
        TownVoleBenefit.YamDot(CRamble.Dy_SoloistPumpMental, CurLevelNumber);
        if (CurLevelNumber == 2)
        {
            MillXenonSister.RimIndicate().MoatXenon("1002");
        }
        MillXenonSister.RimIndicate().MoatXenon("1003", CurLevelNumber.ToString());
        //AdCtrl.Instance.AddPassLevel(CurLevelNumber);
        SadBranchValid = CurLevelNumber;
        CurLevelNumber++;
        if (Ever > 1)
        {
            if (CurLevelNumber > ValidHard.Count + ((ValidHard.Count - 30) * Ever))
            {
                Ever++;
                PlayerPrefs.SetInt(VoleBenefit.TownValidEver, Ever);
                if (Ever % 2 == 1)
                {
                    PlayerPrefs.SetInt(VoleBenefit.TownSquirrelValid, 1);
                }
                else
                {
                    PlayerPrefs.SetInt(VoleBenefit.TownSquirrelValid, 0);
                }
            }
        }
        else
        {
            if (CurLevelNumber > ValidHard.Count * Ever)
            {
                Ever++;
                PlayerPrefs.SetInt(VoleBenefit.TownValidEver, Ever);
                PlayerPrefs.SetInt(VoleBenefit.TownSquirrelValid, 0);
            }
        }
        
        PlayerPrefs.SetInt(VoleBenefit.TownValid, CurLevelNumber);
        WrapBranchTowel();
    }

    protected override void Awake()
    {
        base.Awake();

        //RewardMuilte = BoneBenefit.GetInstance().GetGameConfig().win_ad_coins;
        ValidHard = FluHealWar.instance.ValidRambleVole;
        
    }

    #endregion

    /// <summary>
    /// 初始化动画
    /// </summary>
    /// <param name="finish"></param>
    public void JadeWrapHard(System.Action finish)
    {
        for (int i = 0; i < WrapHard.Count; i++)
        {
            WrapHard[i].transform.localScale = new Vector3(0, 0, 0);
        }
        CanadaPanic(PayPanicBus);
        CanadaPanic(OccasionPanicBus);
        PayPanicBus.gameObject.SetActive(false);
        OccasionPanicBus.gameObject.SetActive(false);
        finish?.Invoke();
    }

    /// <summary>
    /// 过关成功动画
    /// </summary>
    public void WrapBranchTowel()
    {
        JadeWrapHard(() =>
        {
            StartCoroutine(GroundingBench.ValidBranchBus(PayPanicBus, OccasionPanicBus, Up_Prototype, Up_Teacup, WrapHard, () =>
            {
                Debug.Log("动画结束");
                PayPanicBus.gameObject.SetActive(false);
                if (VerbalRend.NoSquat())
                {
                    GeneHim.SetActive(true);
                    GeneModule.SetActive(true);
                    ProposeModule.SetActive(false);
                }
                else
                {
                    ProposeModule.SetActive(true);
                }
            }));
        });
    }
    /// <summary>
    /// 重置Spine动画
    /// </summary>
    /// <param name="skeletonGraphic"></param>
    public void CanadaPanic(SkeletonGraphic skeletonGraphic)
    {
        skeletonGraphic.Skeleton.SetToSetupPose();
        skeletonGraphic.AnimationState.ClearTracks();
        // 强制立即更新骨骼状态（关键步骤！）
        skeletonGraphic.Update(0);
    }

    public void BodeResemblance()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        FirePull.SetActive(true);
        MillXenonSister.RimIndicate().MoatXenon("1007");
        MillXenonSister.RimIndicate().MoatXenon("9001", "3");
        if (ByMapTent())
        {
            PineWarp();
        }
        else
        {
            ADBenefit.Indicate.PineModuleProwl((success) =>
            {
                MillXenonSister.RimIndicate().MoatXenon("9003", "3");
                if (success)
                {
                    PineWarp();
                }
                else
                {
                    FirePull.SetActive(false);
                    TruthBenefit.RimIndicate().WrapTruth("No ads right now, please try it later.");
                }
            }, "3");
        }
    }
    
    public void AxResemblance()
    {
        ADBenefit.Indicate. AxFreelyKeyCreep();
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        FirePull.SetActive(true);
        if (NoSodium)
        {
            BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.win_3);
            NoSodium = false;
            if (VerbalRend.NoSquat())
            {
                SpyGene(GeneDodge.transform, GeneModuleStress);
            }
            else
            {
                BoneTowel.instance.BranchSpyGene(ProposeDodge.transform, ModuleStress);
                UIBenefit.RimIndicate().GuardLopUI();
                //弹出好评页面
                if (SadBranchValid == FluHealWar.instance.BoneVole.initgamedata.rateconfig)
                {
                    UIBenefit.RimIndicate().WrapUILight(nameof(BuckTowel), SadBranchValid);
                    UIBenefit.RimIndicate().WrapUILight(nameof(LoadAtTowel));
                }
                else
                {
                    UIBenefit.RimIndicate().WrapUILight(nameof(BoneTowel));
                }
            }
        }
    }


    private void PineWarp()
    {
        int index = WedWarpMouthFresh();
        WarpBG.Weak(index, (multi) =>
        {
            if (VerbalRend.NoSquat())
            {
                GroundingSpacecraft.FacialStress(GeneModuleStress, GeneModuleStress * multi, 0.1f, GeneDodge, () =>
                {
                    GeneModuleStress = GeneModuleStress * multi;
                    SpyGene(GeneDodge.transform, GeneModuleStress);
                });
            }
            else
            {
                // slot结束后的回调
                GroundingSpacecraft.FacialStress(ModuleStress, ModuleStress * multi, 0.1f, ProposeDodge, "+", () =>
                {
                    ModuleStress = ModuleStress * multi;
                    BoneTowel.instance.BranchSpyGene(ProposeDodge.transform, ModuleStress);
                    UIBenefit.RimIndicate().GuardLopUI();
                    //弹出好评页面
                    if (SadBranchValid == FluHealWar.instance.BoneVole.initgamedata.rateconfig)
                    {
                        UIBenefit.RimIndicate().WrapUILight(nameof(BuckTowel), SadBranchValid);
                        UIBenefit.RimIndicate().WrapUILight(nameof(LoadAtTowel));
                    }
                    else
                    {
                        UIBenefit.RimIndicate().WrapUILight(nameof(BoneTowel));
                    }
                });
            }
        });

        TownVoleBenefit.YamHeed(CRamble.Dy_TrulyWarp, false);
    }

    private int WedWarpMouthFresh()
    {
        // 新用户，第一次固定翻5倍
        if (ByMapTent())
        {
            int index = 0;
            foreach (SlotItem wg in FluHealWar.instance.JadeVole.slot_group)
            {
                if (wg.multi == 7)
                {
                    return index;
                }
                index++;
            }
        }
        else
        {
            int sumWeight = 0;
            foreach (SlotItem wg in FluHealWar.instance.JadeVole.slot_group)
            {
                sumWeight += wg.weight;
            }
            int r = UnityEngine.Random.Range(0, sumWeight);
            int nowWeight = 0;
            int index = 0;
            foreach (SlotItem wg in FluHealWar.instance.JadeVole.slot_group)
            {
                nowWeight += wg.weight;
                if (nowWeight > r)
                {
                    return index;
                }
                index++;
            }

        }
        return 0;
    }
    private bool ByMapTent()
    {
        return !PlayerPrefs.HasKey(CRamble.Dy_TrulyWarp + "Bool") || TownVoleBenefit.RimHeed(CRamble.Dy_TrulyWarp);
    }

    public void SpyGene(Transform StartPostion, double AwardNum)
    {
        int GeneStress= (int)AwardNum / FluHealWar.instance.BoneVole.coin_fly_count;
        if (AwardNum % FluHealWar.instance.BoneVole.coin_fly_count > 0)
        {
            GeneStress += 1;
        }
        GroundingSpacecraft.CareMuchVeil(GenePull, GeneStress, StartPostion, FlyLeg, () =>
        {
            
            int oldGold = TownVoleBenefit.RimDot(CRamble.Dy_GoldGene);
            BoneVoleBenefit.RimIndicate().RibCare(AwardNum);

            GroundingSpacecraft.FacialStress(oldGold, oldGold + AwardNum, 0.1f, GeneShop, () => {
                UIBenefit.RimIndicate().GuardLopUI();
                //弹出好评页面
                if (SadBranchValid == FluHealWar.instance.BoneVole.initgamedata.rateconfig)
                {
                    UIBenefit.RimIndicate().WrapUILight(nameof(BuckTowel), SadBranchValid);
                    UIBenefit.RimIndicate().WrapUILight(nameof(LoadAtTowel));
                }
                else
                {
                    UIBenefit.RimIndicate().WrapUILight(nameof(BoneTowel));
                }
            });  
        });
    }

    private void Update()
    {
        //DiamondLight.transform.Rotate(0, 0, -1);
        GeneTrunk.transform.Rotate(0, 0, -1);
    }
}
