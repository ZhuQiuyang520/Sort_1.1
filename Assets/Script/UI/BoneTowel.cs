using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using DG.Tweening;
using static RealmCare;
using Lofelt.NiceVibrations;

/// <summary>
/// GamePanelView - 自动生成的UI视图脚本
/// </summary>
public class BoneTowel : RoarUILight
{
    public static BoneTowel instance;
[UnityEngine.Serialization.FormerlySerializedAs("CaseEnter")]   
#region 
    //UI组件
    public GameObject TeemAvail;
[UnityEngine.Serialization.FormerlySerializedAs("TopArray")]    public GameObject NetMaser;
[UnityEngine.Serialization.FormerlySerializedAs("BtnArray")]    public GameObject OffMaser;
[UnityEngine.Serialization.FormerlySerializedAs("AddAfresh")]    //public Button ShopBtn;
    public Button KeyAppear;
[UnityEngine.Serialization.FormerlySerializedAs("AddVase")]    public Button KeyDarn;
[UnityEngine.Serialization.FormerlySerializedAs("AddRemind")]    public Button KeyInfect;
[UnityEngine.Serialization.FormerlySerializedAs("AddRollBack")]    public Button KeyForeHunt;
[UnityEngine.Serialization.FormerlySerializedAs("SettingBtn")]    public Button HabitatOff;
[UnityEngine.Serialization.FormerlySerializedAs("FinishBtn")]    public Button BranchOff;
[UnityEngine.Serialization.FormerlySerializedAs("FailBtn")]    public Button SilkOff;
[UnityEngine.Serialization.FormerlySerializedAs("TurnBtn")]    public Button PlowOff;
[UnityEngine.Serialization.FormerlySerializedAs("InputField")]    public InputField DustyLater;
[UnityEngine.Serialization.FormerlySerializedAs("Hand")]    public GameObject Duck;
[UnityEngine.Serialization.FormerlySerializedAs("GuideTip")]    public Text OfferTip;
[UnityEngine.Serialization.FormerlySerializedAs("UseRollBackBtn")]
    public Button RimForeHuntOff;
[UnityEngine.Serialization.FormerlySerializedAs("UseRemindBtn")]    public Button RimInfectOff;
[UnityEngine.Serialization.FormerlySerializedAs("UseVaseBtn")]    public Button RimDarnOff;
[UnityEngine.Serialization.FormerlySerializedAs("LevelDesc")]
    public Text ValidShop;
[UnityEngine.Serialization.FormerlySerializedAs("VaseTip")]
    public GameObject DarnKey;
[UnityEngine.Serialization.FormerlySerializedAs("VaseTipDesc")]    public Text DarnKeyShop;
[UnityEngine.Serialization.FormerlySerializedAs("RemindTip")]    public GameObject InfectKey;
[UnityEngine.Serialization.FormerlySerializedAs("RemindDesc")]    public Text InfectShop;
[UnityEngine.Serialization.FormerlySerializedAs("RollBackTip")]    public GameObject ForeHuntKey;
[UnityEngine.Serialization.FormerlySerializedAs("RollBackDesc")]    public Text ForeHuntShop;
[UnityEngine.Serialization.FormerlySerializedAs("PropMask")]    public GameObject OralFire;
[UnityEngine.Serialization.FormerlySerializedAs("Layout")]
    public GridUnfoldBenchEx Unfold;
[UnityEngine.Serialization.FormerlySerializedAs("ScrollViewObj")]    public GameObject PrisonFuseHim;
[UnityEngine.Serialization.FormerlySerializedAs("Content")]    public Transform Migrant;
[UnityEngine.Serialization.FormerlySerializedAs("ItemCell")]    public GameObject GoodLast;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_Sceen")]    public ParticleSystem Up_Amuse;
[UnityEngine.Serialization.FormerlySerializedAs("CoinIcon")]
    public GameObject GenePull;
[UnityEngine.Serialization.FormerlySerializedAs("EndPos")]    public Transform FlyLeg;
[UnityEngine.Serialization.FormerlySerializedAs("TurnIcon")]
    public Image PlowPull;
[UnityEngine.Serialization.FormerlySerializedAs("RewardContent")]
    public Transform ModuleMigrant;
[UnityEngine.Serialization.FormerlySerializedAs("Mask")]
    public Image Fire;
[UnityEngine.Serialization.FormerlySerializedAs("FX_Turn")]
    public GameObject FX_Plow;

    private Vector3 IndirectCrossLeg;//动画用

    private float SadPlowHotelGrand;

    private string ValidSquirrel;

    private Dictionary<string, int> VenomGap= new Dictionary<string, int>();
    
    private Dictionary<int, Stack<string>> DarnGap= new Dictionary<int, Stack<string>>();
    private List<LevelConfig> ValidHard= new List<LevelConfig>();
    private LevelConfig SadValidHeal;
    private int SadValidID;
    private int BranchStress;

    private int WitBranchStress;
    private bool ValidBranch;

    private int DarnOralStress;
    private int InfectOralStress;
    private int StockingOralStress;
    private string AideClauseBelow= "";
    private int DarnWitAttire= 0;
    private LevelGuideInfo.LevelGuideData SadOfferVole= new LevelGuideInfo.LevelGuideData();
    private int SadOfferFind= 0;
    private bool NoOffer= true;
    private bool NoBandOffer= false;
    private bool NoFactFire= false;
    private int BandIndigo;

    private List<string> ModuleDarn;

    //埋点数据
    private int RoarFlyRimResponse;
    private int RoarFlyRimLily;
    private int RoarFlyRimKey;
    private float RoarFlyShow;
    private int RoarFlyFind;
    private bool PanelFlyShow;

    private BaseStartGame CrossBone;
    private BaseEndGame FlyBone;
    private BaseUseProp RimOral;

    private string[] BongoHeal;
    private string[] ValidHabitat;
    private string[] ValidBelow;

    private Sequence EncounterMedicine;

    //道具 和失败 产生的瓶子数量。
    private int OralStress= 0;
    #endregion

    #region 生命周期函数

    protected override void Awake()
    {
        base.Awake();
        instance = this;
        BlanketBenefit.RimIndicate().AddListener<PopupType>(MessageCode.KeySully, FacialSullyStress);
        BlanketBenefit.RimIndicate().AddListener(MessageCode.ReelectDesigner, ReelectDesigner);
        BlanketBenefit.RimIndicate().AddListener(MessageCode.SilkProwlDodge, SilkReelectDarn);
        BandIndigo = FluHealWar.instance.BoneVole.initgamedata.unclock_shop_lv;
        ValidHard = FluHealWar.instance.ValidRambleVole;
    }

    private void Start()
    {
        FX_Plow.SetActive(false);
        IndirectCrossLeg = PlowPull.transform.position;
        //ShopBtn.onClick.AddListener(OpenShop);
        KeyAppear.onClick.AddListener(FacialElegant);
        KeyDarn.onClick.AddListener(FacialKeyDarn);
        KeyInfect.onClick.AddListener(FacialKeyInfect);
        KeyForeHunt.onClick.AddListener(FacialKeyForeHunt);
        HabitatOff.onClick.AddListener(FactHabitat);

        RimForeHuntOff.onClick.AddListener(()=> {
            BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
            BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
            FacialRimForeHunt();
        });
        RimInfectOff.onClick.AddListener(() => {
            BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
            BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
            FacialRimInfect();
        });
        RimDarnOff.onClick.AddListener(()=> {
            BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
            BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
            FacialRimDarn();
        });

        BranchOff.onClick.AddListener(RoleBranch);
        SilkOff.onClick.AddListener(RoleSilk);
        PlowOff.onClick.AddListener(GullPlow);

        SadPlowHotelGrand = 0;

        BoneBenefit.RimIndicate().StifleTranslation(OffMaser.GetComponent<RectTransform>());
        BoneBenefit.RimIndicate().StifleTranslation(NetMaser.GetComponent<RectTransform>());
        BoneBenefit.RimIndicate().StifleTranslation(Duck.GetComponent<RectTransform>());
        BoneBenefit.RimIndicate().StifleTranslation(Migrant.GetComponent<RectTransform>());

        if (!VerbalRend.NoSquat())
        {
            TeemAvail.SetActive(true);
            PlowPull.gameObject.SetActive(true);
        }
    }

    private void OnDestroy()
    {
        BlanketBenefit.RimIndicate().HamperShoshone<PopupType>(MessageCode.KeySully, FacialSullyStress);
        BlanketBenefit.RimIndicate().HamperShoshone(MessageCode.ReelectDesigner, ReelectDesigner);
        BlanketBenefit.RimIndicate().HamperShoshone(MessageCode.SilkProwlDodge, SilkReelectDarn);
        //BlanketBenefit.GetInstance().HamperShoshone(MessageCode.CreatePingziFinish, SettingLayout);
    }
    //购买道具后刷新道具数量
    public void FacialSullyStress(PopupType type)
    {
        switch (type)
        {
            case PopupType.Vase:
                DarnOralStress = PlayerPrefs.GetInt(VoleBenefit.TownDarnOral);
                DarnKey.SetActive(true);
                DarnKeyShop.text = DarnOralStress.ToString();
                FacialRimDarn();
                break;
            case PopupType.Remind:
                InfectOralStress = PlayerPrefs.GetInt(VoleBenefit.TownInfectOral);
                InfectKey.SetActive(true);
                InfectShop.text = InfectOralStress.ToString();
                FacialRimInfect();
                break;
            case PopupType.RollBack:
                StockingOralStress = PlayerPrefs.GetInt(VoleBenefit.TownStockingOral);
                ForeHuntKey.SetActive(true);
                ForeHuntShop.text = StockingOralStress.ToString();
                FacialRimForeHunt();
                break;
            default:
                break;
        }
    }

    private void CarcassOral(bool IsDisable)
    {
        OralFire.SetActive(IsDisable);
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);

        ValidBranch = false;
        PanelFlyShow = true;
        RoarFlyShow = 0;
        RoarFlyFind = 0;
        CrossBone = new BaseStartGame();
        FlyBone = new BaseEndGame();
        RimOral = new BaseUseProp();

        NoFactFire = false;
        Unfold.enabled = true;
        DarnOralStress = PlayerPrefs.GetInt(VoleBenefit.TownDarnOral);
        InfectOralStress = PlayerPrefs.GetInt(VoleBenefit.TownInfectOral);
        StockingOralStress = PlayerPrefs.GetInt(VoleBenefit.TownStockingOral);


        if (DarnOralStress > 0)
        {
            DarnKey.SetActive(true);
            DarnKeyShop.text = DarnOralStress.ToString();
        }
        else
        {
            DarnKey.SetActive(false);
        }

        if (InfectOralStress > 0)
        {
            InfectKey.SetActive(true);
            InfectShop.text = InfectOralStress.ToString();
        }
        else
        {
            InfectKey.SetActive(false);
        }

        if (StockingOralStress > 0)
        {
            ForeHuntKey.SetActive(true);
            ForeHuntShop.text = StockingOralStress.ToString();
        }
        else
        {
            ForeHuntKey.SetActive(false);
        }
        

        //处理新手玩家
        if (PlayerPrefs.GetInt(VoleBenefit.TownValid) == 0)
        {
            PlayerPrefs.SetInt(VoleBenefit.TownValid, 1);
            SadValidID = 1;
        }
        else
        {
            SadValidID = PlayerPrefs.GetInt(VoleBenefit.TownValid);
        }
        //关卡进入埋点数据
        CrossBone.Bongo_id = SadValidID;
        CrossBone.Solitude_nums = StockingOralStress;
        CrossBone.Berg_Heal = InfectOralStress;
        CrossBone.Rib_Heal = DarnOralStress;

        FlyBone.Bongo_id = SadValidID;

        HabitatOff.gameObject.SetActive(true);
        KeyAppear.gameObject.SetActive(true);
        RimForeHuntOff.gameObject.SetActive(true);
        RimInfectOff.gameObject.SetActive(true);
        RimDarnOff.gameObject.SetActive(true);
        OfferTip.gameObject.SetActive(false);
        Duck.SetActive(false);
        //第一关的新手引导
        if (SadValidID == 1)
        {
            HabitatOff.gameObject.SetActive(false);
            KeyAppear.gameObject.SetActive(false);
            RimForeHuntOff.gameObject.SetActive(false);
            RimInfectOff.gameObject.SetActive(false);
            RimDarnOff.gameObject.SetActive(false);
            OfferTip.gameObject.SetActive(true);
            Duck.SetActive(true);
            OfferTip.text = "Click to pour water";

            SadOfferVole = BoneBenefit.RimIndicate().ValidOffer(SadOfferFind);
            
        }
        else if (SadValidID == 2)
        {
            HabitatOff.gameObject.SetActive(false);
            KeyAppear.gameObject.SetActive(false);
            RimForeHuntOff.gameObject.SetActive(false);
            RimInfectOff.gameObject.SetActive(false);
            RimDarnOff.gameObject.SetActive(false);
            OfferTip.gameObject.SetActive(true);
            OfferTip.text = "Only water of the same color can be poured on top of each other";
        }
        else if (SadValidID == 3 && PlayerPrefs.GetString(VoleBenefit.ValidOffer) == "0")
        {
            if (!VerbalRend.NoSquat())
            {
                Fire.gameObject.SetActive(true);
                Color MaskColir = new Color();
                MaskColir.a = 0.85f;
                Fire.color = MaskColir;
                EncounterMedicine = DOTween.Sequence();
                EncounterMedicine.Append(TeemAvail.transform.DOScale(new Vector3(0.9f, 0.9f, 0.9f), 0.3f).SetLoops(10, LoopType.Yoyo))
                    .SetDelay(2)
                    .SetLoops(-1);
            }
        }
        //else if (CurLevelID == ShopUnlock)
        //{
        //    ShopBtn.gameObject.SetActive(true);
        //    if (PlayerPrefs.GetInt(VoleBenefit.SaveUnLockShop) == 0)
        //    {
        //        IsShopGuide = true;
        //        Hand.SetActive(true);
        //        Hand.transform.position = ShopBtn.transform.position;
        //        GroundingBench.HandAni(Hand, ShopBtn.transform.position, true);
        //    }
        //}
        //else if (CurLevelID > ShopUnlock)
        //{
        //    ShopBtn.gameObject.SetActive(true);
        //}
        


        //根据轮数选择关卡
        //当轮数>=3的时候 加载权重字典 加载剩余关卡
        //if (PlayerPrefs.GetInt(VoleBenefit.SaveLevelBout) >= 3)
        //{
        //    int RandomWeight = UnityEngine.Random.Range(1, BoneBenefit.GetInstance().AllWeight);
        //    foreach (var item in BoneBenefit.GetInstance().GetLevelWeight())
        //    {
        //        RandomWeight -= item.Value;
        //        if (RandomWeight <= 0)
        //        {
        //            CurLevelID = item.Key;
        //        }
        //    }
        //}
        if (PlayerPrefs.GetInt(VoleBenefit.TownValidEver) >= 2)
        {
            if (ValidHard.Count < SadValidID)
            {
                SadValidID = SadValidID - ValidHard.Count - ((ValidHard.Count - 30) * ((PlayerPrefs.GetInt(VoleBenefit.TownValidEver) - 2))) + 29;
            }
        }
        SadValidHeal = new LevelConfig();
        SadValidHeal = ValidHard.Find(x => x.ID == SadValidID);

        //0关卡设置  1颜色设置  2关卡轮回
        BongoHeal = SadValidHeal.Layout.Split("|");
        ValidHabitat = BongoHeal[0].Split("_");
        ValidBelow = BongoHeal[1].Split(",");
        ModuleDarn = new List<string>();
        if (SadValidID > 2)
        {
            ModuleDarn = BoneBenefit.RimIndicate().TariffTie(2, int.Parse(ValidHabitat[1]));
        }
        
        //CurLevelID = FluHealWar.instance.LevelList.Find(x => x.LevelID == CurLevelID).LevelData;
        AppearCross();
        if (ModuleMigrant.childCount > 0)
        {
            for (int i = 0; i < ModuleMigrant.childCount; i++)
            {
                Destroy(ModuleMigrant.GetChild(i).gameObject);
            }
        }
        Sequence seq = DOTween.Sequence();
        seq.AppendCallback(() =>
        {
            BlanketBenefit.RimIndicate().Dimension(MessageCode.StitchModule, ModuleMigrant);
        })
        .SetDelay(0.15f)
        .SetLoops(0);
    }
    
    public void BoardEncounterFire()
    {
        if (Fire.gameObject.activeSelf)
        {
            Fire.gameObject.SetActive(false);
            EncounterMedicine.Kill();
            TeemAvail.transform.localScale = Vector3.one;
        }
    }

    private void ReelectDesigner()
    {
        ValidShop.text = "Level " + PlayerPrefs.GetInt(VoleBenefit.TownValid);
    }

    public void AppearCross()
    {
        VenomGap = new Dictionary<string, int>();
        ReelectDesigner();
        if (DarnGap.Count > 0)
        {
            DarnGap.Clear();
        }
        OralStress = 0;
        //游戏开始或者关卡更新时，重置数据
        BoneBenefit.RimIndicate().CompanyForeHunt();
        BoneBenefit.RimIndicate().LeapTiffany();
        OralFire.SetActive(true);
        BranchStress = 0;
        if (Migrant.childCount > 0)
        {
            for (int i = 0; i < Migrant.childCount; i++)
            {
                Destroy(Migrant.GetChild(i).gameObject);
            }
        }
        
       
        ValidSquirrel = SadValidHeal.Mask.ToString();
       
        DarnWitAttire = int.Parse(ValidHabitat[0]);
        WitBranchStress = int.Parse(ValidHabitat[2]);

        //创建瓶子
        for (int i = int.Parse(ValidHabitat[1]) - 1; i >= 0; i--)
        {
            if (ModuleDarn.Contains(i.ToString()))
            {
                Last().Jade(i, true, ValidBelow[i], int.Parse(ValidHabitat[0]), ValidSquirrel, SadOfferVole, BranchFiring, CarcassOral, ClauseBelowPique, FiringOffer, FiringFind);
            }
            else
            {
                Last().Jade(i, false, ValidBelow[i], int.Parse(ValidHabitat[0]), ValidSquirrel, SadOfferVole, BranchFiring, CarcassOral, ClauseBelowPique, FiringOffer, FiringFind);
            }

            string[] colorArray = ValidBelow[i].Split('_');
            string curColor = colorArray[0];
            int SadAttire= 1;
            if (curColor == string.Empty)
            {
                continue;
            }
            if (!VenomGap.ContainsKey(curColor))
            {
                VenomGap.Add(curColor, SadAttire);
            }
            for (int j = 1; j < colorArray.Length; j++)
            {
                if (curColor == colorArray[j])
                {
                    SadAttire++;
                    VenomGap[curColor] = SadAttire;
                }
                else
                {
                    curColor = colorArray[j];
                    SadAttire = 1;
                    if (!VenomGap.ContainsKey(curColor))
                    {
                        VenomGap.Add(curColor, SadAttire);
                    }
                }
            }
        }
        //根据关卡瓶子总数设置排列规则
        ClauseStress(int.Parse(ValidHabitat[1]));
    }

    /// <summary>
    /// 根据瓶子总数动态设置排列方式
    /// </summary>
    /// <param name="LevelPingziNumber">关卡默认瓶子数量</param>
    public void ClauseStress(int LevelPingziNumber)
    {
        Unfold.enabled = true;
        int number = LevelPingziNumber;
        //设置瓶子大小和位置 第一排个数不到三个按照三个处理
        int FirstNumber = number / 2 + number % 2;
        if (FirstNumber < 4)
        {
            Unfold.spacing = new Vector2((1080 - 3 * Unfold.cellSize.x) / 3, Unfold.spacing.y);
        }
        else
        {
            Unfold.spacing = new Vector2((1080 - FirstNumber * Unfold.cellSize.x) / FirstNumber, Unfold.spacing.y);
        }
        //动态排列瓶子
        if (number > 3 && number <= 14)
        {
            Unfold.constraintCount = number / 2 + number % 2;
        }
        else if (number <= 3)
        {
            Unfold.constraintCount = 3;
        }
        else if (number > 14)
        {
            //弹提示
        }
        Sequence seq = DOTween.Sequence();
        seq.AppendCallback(() =>
        {
            NoFactFire = true;
            Unfold.enabled = false;
            BlanketBenefit.RimIndicate().Dimension(MessageCode.ReelectModuleLeg);
        })
        .SetDelay(0.1f)
        .SetLoops(0);
        
    }

    private bool NoSilk= false;
    private bool NoAideDarn= false;
    public void ClauseBelowPique(int VaseIndex , Stack<string> color,ShuiState state , Transform pos)
    {
        if (state == ShuiState.Beidaoshui && !VerbalRend.NoSquat())
        {
            int colorNumber = 0;
            string curColor = color.Peek();
            foreach (var item in color)
            {
                if (item == curColor)
                {
                    colorNumber++;
                }
                else
                {
                    break;
                }
            }

            double SpinetStress= FluHealWar.instance.BoneVole.vaildData.reward_num + GameUtil.GetCashMulti();
            VenomSpyGene(pos, SpinetStress);
            VenomGap[curColor] = colorNumber;
            float StartNumber = SadPlowHotelGrand / FluHealWar.instance.BoneVole.initgamedata.TurntableValue;
            float EndNumber = (SadPlowHotelGrand + 1) / FluHealWar.instance.BoneVole.initgamedata.TurntableValue;
            GameObject turnitem = Resources.Load<GameObject>("Prefab/PlowGood");
            BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
            GroundingSpacecraft.ExtremePlowBus(turnitem, PlowPull.transform.position, pos.position, UIBenefit.RimIndicate().FlaxPillow.transform, () => 
            {
                GroundingSpacecraft.FacialPullStress(StartNumber, EndNumber, PlowPull, () => 
                {
                    SadPlowHotelGrand++;
                    if (SadPlowHotelGrand >= FluHealWar.instance.BoneVole.initgamedata.TurntableValue)
                    {
                        SadPlowHotelGrand = 0;
                        PlowPull.fillAmount = 0;
                        PlowBus(() => 
                        {
                            UIBenefit.RimIndicate().WrapUILight(nameof(TrunHotelTowel));
                        });
                    }
                });
            });

            //if (ValidDic[curColor] < colorNumber )
            //{
            //    double rewardNumber = FluHealWar.instance.GameData.vaildData.reward_num + GameUtil.GetCashMulti();
            //    ValidFlyCoin(pos, rewardNumber);
            //    ValidDic[curColor] = colorNumber;
            //    float StartNumber = CurTurnTableValue / FluHealWar.instance.GameData.initgamedata.TurntableValue;
            //    float EndNumber = (CurTurnTableValue + 1) / FluHealWar.instance.GameData.initgamedata.TurntableValue;
            //    GroundingSpacecraft.ChangeIconNumber(StartNumber, EndNumber, TurnIcon, () => {
            //        CurTurnTableValue++;
            //        if (CurTurnTableValue >= FluHealWar.instance.GameData.initgamedata.TurntableValue)
            //        {
            //            CurTurnTableValue = 0;
            //            UIBenefit.GetInstance().ShowUIForms(nameof(TrunHotelTowel));
            //        }
            //    });
            //}
        }
        
        if (DarnGap.ContainsKey(VaseIndex))
        {
            DarnGap[VaseIndex] = color;
        }
        else
        {
            DarnGap.Add(VaseIndex, color);
        }
        //排除当前还有空瓶
        foreach (var item in DarnGap)
        {
            if (item.Value.Count == 0)
            {
                NoAideDarn = true;
                break;
            }
            else
            {
                NoAideDarn = false;
            }
        }
        //如果没有空瓶，则开始判断是否能倒水
        if (!NoAideDarn)
        {
            for (int i = 0; i < DarnGap.Count; i++)
            {
                string FirstColor = DarnGap.ElementAt(i).Value.Peek();
                for (int j = i+1; j < DarnGap.Count; j++)
                {
                    
                    if (FirstColor == DarnGap.ElementAt(j).Value.Peek() && (DarnGap.ElementAt(i).Value.Count != 4 || DarnGap.ElementAt(j).Value.Count != 4))
                    {
                        //可以动
                        NoSilk = false;
                        return;
                    }
                    else
                    {
                       
                        if (OralStress<2)
                        {
                            //不可以动，添加失败界面
                            NoSilk = true;
                        }
                        else
                        {
                            NoSilk = false;
                        }
                    }
                }
            }
            if (NoSilk)
            {
                FlyBone.Bongo_Danger = "fail";
                FlyBone.Fee_Solitude_Heal = RoarFlyRimResponse;
                FlyBone.Fee_Berg_Heal = RoarFlyRimLily;
                FlyBone.Fee_Rib_Heal = RoarFlyRimKey;
                FlyBone.Lush = (int)RoarFlyShow;
                FlyBone.Mate = RoarFlyFind;
                PanelFlyShow = false;

                UIBenefit.RimIndicate().WrapUILight(nameof(SilkTowel));
            }
        }
    }

    public void BranchFiring(int FinishVaseIndex)
    {
        //清除掉已完成的瓶子
        DarnGap.Remove(FinishVaseIndex);

        BranchStress++;
        if (BranchStress == WitBranchStress)
        {
            ValidBranch = true;
            OralFire.SetActive(true);

            FlyBone.Bongo_Danger = "success";
            FlyBone.Fee_Solitude_Heal = RoarFlyRimResponse;
            FlyBone.Fee_Berg_Heal = RoarFlyRimLily;
            FlyBone.Fee_Rib_Heal = RoarFlyRimKey;
            FlyBone.Lush = (int)RoarFlyShow;
            FlyBone.Mate = RoarFlyFind;
            BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.win_1);
            BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.Success);
            UIBenefit.RimIndicate().WrapUILight(nameof(BranchTowel));
        }
        else
        {
            OralFire.SetActive(false);
        }
    }

    private void FacialKeyDarn()
    {
        //打开页面之前传参数
        //UIBenefit.GetInstance().CacheUIMessage(UINames.KeyOralSully, PopupType.Vase);
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        UIBenefit.RimIndicate().WrapUILight(nameof( KeyOralSully), PopupType.Vase);
    }
    private void FacialKeyInfect()
    {
        //UIBenefit.GetInstance().CacheUIMessage(UINames.KeyOralSully, PopupType.Remind);
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        UIBenefit.RimIndicate().WrapUILight(nameof( KeyOralSully), PopupType.Remind);
    }
    private void FacialKeyForeHunt()
    {
        //UIBenefit.GetInstance().CacheUIMessage(UINames.KeyOralSully, PopupType.RollBack);
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        UIBenefit.RimIndicate().WrapUILight(nameof( KeyOralSully), PopupType.RollBack);
    }

    private void FacialRimDarn()
    {
        OralFire.SetActive(true);
        if (DarnOralStress > 0)
        {
            if (OralStress < 2)
            {
                MillXenonSister.RimIndicate().MoatXenon("1010");
                RoarFlyRimKey++;
                RimOral.type = "add";
                RimOral.Arouse = 1;
                RimOral.Index = SadValidID;

                OralStress++;
                DarnKey.SetActive(true);
                DarnOralStress--;
                DarnKeyShop.text = DarnOralStress.ToString();
                PlayerPrefs.SetInt(VoleBenefit.TownDarnOral, DarnOralStress);
                if (DarnOralStress == 0)
                {
                    DarnKey.SetActive(false);
                }
                OralLast().Jade(Migrant.childCount - 1, false, AideClauseBelow, DarnWitAttire, ValidSquirrel, SadOfferVole, BranchFiring, CarcassOral, ClauseBelowPique, FiringOffer, FiringFind);
                ClauseStress(Migrant.childCount + 1);
            }
            else
            {
                if (!ValidBranch)
                {
                    TruthBenefit.RimIndicate().WrapTruth("The maximum limit has been reached");
                    //MgrTips.Instance.ShowTip("The maximum limit has been reached");
                    OralFire.SetActive(false);
                }
            }
        }
        else
        {
            if (!ValidBranch)
            {
                OralFire.SetActive(false);
            }
            
            //UIBenefit.GetInstance().CacheUIMessage(UINames.KeyOralSully, PopupType.Vase);
           UIBenefit.RimIndicate().WrapUILight(nameof( KeyOralSully), PopupType.Vase);
        }
    }

    //失败看广告获得道具瓶子
    private void SilkReelectDarn()
    {
        PanelFlyShow = true;
        BaseGetProp GetProp = new BaseGetProp();
        GetProp.Arouse = 1;
        GetProp.Inn = "retry";
        GetProp.type = "add";
        OralLast().Jade(Migrant.childCount - 1, false, AideClauseBelow, DarnWitAttire, ValidSquirrel, SadOfferVole, BranchFiring, CarcassOral, ClauseBelowPique, FiringOffer, FiringFind);
        ClauseStress(Migrant.childCount + 1);

    }

    private string InfectBelow;

    private void FacialRimInfect()
    {
        OralFire.SetActive(true);
        
        if (InfectOralStress > 0)
        {
            MillXenonSister.RimIndicate().MoatXenon("1009");
            RoarFlyRimLily++;

            RimOral.type = "hint";
            RimOral.Arouse = 1;
            RimOral.Index = SadValidID;

            InfectKey.SetActive(true);
            
            InfectOralStress--;
            PlayerPrefs.SetInt(VoleBenefit.TownInfectOral, InfectOralStress);
            
            InfectShop.text = InfectOralStress.ToString();

            if (InfectOralStress == 0)
            {
                InfectKey.SetActive(false);
            }
            //使用提示按钮
            BoneBenefit.RimIndicate().RimOralJade();
            for (int i = 0; i < DarnGap.Count - 1; i++)
            {
                for (int j = i + 1; j < DarnGap.Count; j++)
                {
                    //如果第一层为空瓶 第二层的瓶不为空  则第二层往第一层的空瓶中倒水
                    if (DarnGap.ElementAt(i).Value.Count == 0 && DarnGap.ElementAt(j).Value.Count != 0)
                    {
                        StartCoroutine(BlanketInfect(DarnGap.ElementAt(j).Key, DarnGap.ElementAt(i).Key));
                        return;
                    }
                    //如果第一层不为空瓶 ， 第二层为空瓶  第一层往第二层中倒水
                    else if (DarnGap.ElementAt(i).Value.Count != 0 && DarnGap.ElementAt(j).Value.Count == 0)
                    {
                        StartCoroutine(BlanketInfect(DarnGap.ElementAt(i).Key, DarnGap.ElementAt(j).Key));
                        return;
                    }
                    //如果都不为空瓶
                    else if (DarnGap.ElementAt(i).Value.Count != 0 && DarnGap.ElementAt(j).Value.Count != 0)
                    {
                        
                        InfectBelow = DarnGap.ElementAt(i).Value.Peek();
                        //第二层瓶中的颜色最上层颜色等于第一层的预倒水颜色
                        if (InfectBelow == DarnGap.ElementAt(j).Value.Peek())
                        {
                            //如果第一层瓶子为满水状态  第二层瓶子为不满水状态  则第一层往第二层倒水
                            if (DarnGap.ElementAt(i).Value.Count == 4 && DarnGap.ElementAt(j).Value.Count != 4)
                            {
                                StartCoroutine(BlanketInfect(DarnGap.ElementAt(i).Key, DarnGap.ElementAt(j).Key));
                                //BlanketBenefit.GetInstance().Broadcast(MessageCode.UseRemindProp, VaseDic.ElementAt(i).Key);
                                //BlanketBenefit.GetInstance().Broadcast(MessageCode.UseRemindProp, VaseDic.ElementAt(j).Key);
                                return;
                            }
                            //如果第一层为不满水状态 第二层瓶子为满水装填  则第二层往第一层倒水
                            else if (DarnGap.ElementAt(i).Value.Count != 4 && DarnGap.ElementAt(j).Value.Count == 4)
                            {
                                StartCoroutine(BlanketInfect(DarnGap.ElementAt(j).Key, DarnGap.ElementAt(i).Key));
                                //BlanketBenefit.GetInstance().Broadcast(MessageCode.UseRemindProp, VaseDic.ElementAt(j).Key);
                                //BlanketBenefit.GetInstance().Broadcast(MessageCode.UseRemindProp, VaseDic.ElementAt(i).Key);
                                return;
                            }
                            //如果两层都不为满水 则第一层往第二层倒水
                            else if (DarnGap.ElementAt(i).Value.Count != 4 && DarnGap.ElementAt(j).Value.Count != 4)
                            {
                                StartCoroutine(BlanketInfect(DarnGap.ElementAt(i).Key, DarnGap.ElementAt(j).Key));
                                //BlanketBenefit.GetInstance().Broadcast(MessageCode.UseRemindProp, VaseDic.ElementAt(i).Key);
                                //BlanketBenefit.GetInstance().Broadcast(MessageCode.UseRemindProp, VaseDic.ElementAt(j).Key);
                                return;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            if (!ValidBranch)
            {
                OralFire.SetActive(false);
            }
           
            //UIBenefit.GetInstance().CacheUIMessage(UINames.KeyOralSully, PopupType.Remind);
           UIBenefit.RimIndicate().WrapUILight(nameof( KeyOralSully), PopupType.Remind);
        }
    }

    private void FacialRimForeHunt()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        if (BoneBenefit.RimIndicate().ForeHuntTie() > 0)
        {
            if (StockingOralStress > 0)
            {
                MillXenonSister.RimIndicate().MoatXenon("1008");
                RoarFlyRimResponse++;

                RimOral.type = "withdraw";
                RimOral.Arouse = 1;
                RimOral.Index = SadValidID;

                ForeHuntKey.SetActive(true);
                StockingOralStress--;
                PlayerPrefs.SetInt(VoleBenefit.TownStockingOral, StockingOralStress);
                
                ForeHuntShop.text = StockingOralStress.ToString();

                if (StockingOralStress == 0)
                {
                    ForeHuntKey.SetActive(false);
                }
                //使用回退按钮
                BoneBenefit.RimIndicate().ForeHuntPaper();
            }
            else
            {
                //UIBenefit.GetInstance().CacheUIMessage(UINames.KeyOralSully, PopupType.RollBack);
               UIBenefit.RimIndicate().WrapUILight(nameof( KeyOralSully), PopupType.RollBack);
            }
        }
        else
        {
            if (StockingOralStress == 0)
            {
                //UIBenefit.GetInstance().CacheUIMessage(UINames.KeyOralSully, PopupType.RollBack);
               UIBenefit.RimIndicate().WrapUILight(nameof( KeyOralSully), PopupType.RollBack);
            }
            else
            {
                TruthBenefit.RimIndicate().WrapTruth("Irrevocable");
                //MgrTips.Instance.ShowTip("Irrevocable");
            }
        }
    }

    ClauseLast Last()
    {
        GameObject Go = Instantiate<GameObject>(GoodLast);
        Go.transform.SetParent(Migrant, false);
        ClauseLast cell = Go.GetComponent<ClauseLast>();
        return cell;
    }


    //由于动态排列组件是从右下角开始 所以新建的道具瓶子要将索引排在第一位
    ClauseLast OralLast()
    {
        GameObject Go = Instantiate<GameObject>(GoodLast);
        Go.transform.SetParent(Migrant, false);
        Go.transform.SetSiblingIndex(0);
        ClauseLast cell = Go.GetComponent<ClauseLast>();
        return cell;
    }

    #endregion

    #region 事件绑定

    public void RoleBranch()
    {
        UIBenefit.RimIndicate().WrapUILight(nameof(BranchTowel));
    }
    public void RoleSilk()
    {
        UIBenefit.RimIndicate().WrapUILight(nameof(SilkTowel));
    }

    public void GullPlow()
    {
        UIBenefit.RimIndicate().WrapUILight(nameof(TrunHotelTowel));
    }
    public void RoleFacialValid()
    {
        PlayerPrefs.SetInt(VoleBenefit.TownValid, int.Parse(DustyLater.text));
        UIBenefit.RimIndicate().GuardLopUI();
        UIBenefit.RimIndicate().WrapUILight(nameof(BoneTowel));
    }

    public void FacialElegant()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        UIBenefit.RimIndicate().WrapUILight(nameof(ElegantTowel));
    }

    public void FacialAppearCross()
    {
        AppearCross();
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        if (ModuleMigrant.childCount > 0)
        {
            for (int i = 0; i < ModuleMigrant.childCount; i++)
            {
                Destroy(ModuleMigrant.GetChild(i).gameObject);
            }
        }
        Sequence seq = DOTween.Sequence();
        seq.AppendCallback(() =>
        {
            BlanketBenefit.RimIndicate().Dimension(MessageCode.StitchModule, ModuleMigrant);
        })
        .SetDelay(0.15f)
        .SetLoops(0);
    }

    //打开商店
    public void FactBand()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        if (Duck.activeSelf)
        {
            DOTween.Kill("handanimation");
            Duck.SetActive(false);
        }
        UIBenefit.RimIndicate().WrapUILight(nameof(BandTowel));
    }

    public void FactHabitat()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        //UIBenefit.GetInstance().CacheUIMessage(UINames.HabitatTowel, PopupType.Game);
        UIBenefit.RimIndicate().WrapUILight(nameof(HabitatTowel), PopupType.Game);
    }

    IEnumerator BlanketInfect(int A , int B)
    {
        if (A != BoneBenefit.RimIndicate().FiringTrulyFresh())
        {
            BoneBenefit.RimIndicate().RimOralJade();
            yield return new WaitForSeconds(0.2f);
            BlanketBenefit.RimIndicate().Dimension(MessageCode.RimInfectOral, A);
        }
        else
        {
            yield return new WaitForSeconds(0.5f);
            BlanketBenefit.RimIndicate().Dimension(MessageCode.RimInfectOral, A);
        }
        yield return new WaitForSeconds(0.1f);

        BlanketBenefit.RimIndicate().Dimension(MessageCode.RimInfectOral, B);
        
        StopCoroutine(nameof(BlanketInfect));
    }

    public void FiringFind()
    {
        RoarFlyFind++;
    }

    public void FiringOffer(Vector3 HandPos)
    {
        if (SadValidID == 1)
        {
            if (NoOffer)
            {
                SadOfferFind++;
                NoOffer = false;
                Vector3 Pos = new Vector3(HandPos.x, HandPos.y - 1f, HandPos.z);
                Duck.transform.position = Pos;
                //Hand.SetActive(true);
                GroundingBench.DuckBus(Duck, Pos, true);
                SadOfferVole = BoneBenefit.RimIndicate().ValidOffer(SadOfferFind);
            }
            else
            {
                NoOffer = true;
                Duck.transform.position = new Vector3(HandPos.x, HandPos.y - 5f, HandPos.z);
                GroundingBench.DuckBus(Duck, HandPos, true);
                SadOfferVole = BoneBenefit.RimIndicate().ValidOffer(SadOfferFind);
                if (SadOfferVole != null)
                {
                    BlanketBenefit.RimIndicate().Dimension(MessageCode.ValidOffer, SadOfferVole);
                }
                else
                {
                    DOTween.Kill("handanimation");
                    Duck.SetActive(false);
                }
            }
        }
    }

    private void Update()
    {
        if (PanelFlyShow)
        {
            RoarFlyShow += Time.deltaTime;
        }
        
        if (Input.GetMouseButtonDown(0) && NoBandOffer)
        {
            if (PlayerPrefs.GetInt(VoleBenefit.TownToErieBand) == 0 && SadValidID == BandIndigo && UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != null)
            {
                if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name != "Shangdian")
                {
                    NoBandOffer = false;
                    DOTween.Kill("handanimation");
                    Duck.SetActive(false);
                    PlayerPrefs.SetInt(VoleBenefit.TownToErieBand, 1);
                }
            }
        }
        //只在初始化时瓶子创建完之后执行
        //避免重新开始时或游戏刚开始时瓶子未排列完成就使用道具造成，打断排列造成的瓶子位置错误
        if (NoFactFire && OralFire.activeSelf)
        {
            NoFactFire = false;
            OralFire.SetActive(false);
        }
    }

    public void SpyGene(Transform StartPostion, double AwardNum)
    {
        if (!VerbalRend.NoSquat())
        {
            int GeneStress= (int)AwardNum / FluHealWar.instance.BoneVole.diamond_fly_count;
            if (AwardNum % FluHealWar.instance.BoneVole.diamond_fly_count > 0)
            {
                GeneStress += 1;
            }
            GroundingSpacecraft.CareMuchVeil(GenePull, GeneStress, StartPostion, FlyLeg, () =>
            {
                BoneVoleBenefit.RimIndicate().KeyWoad(AwardNum);
            });
        }  
    }

    public void VenomSpyGene(Transform StartPostion, double AwardNum)
    {
        if (!VerbalRend.NoSquat())
        {
            GroundingSpacecraft.ExtremeBus(FlyLeg.position, StartPostion.position, UIBenefit.RimIndicate().FlaxPillow.transform, () =>
            {
                BoneVoleBenefit.RimIndicate().KeyWoad(AwardNum);
            });
            
            
            //GroundingSpacecraft.GoldMoveBest(CoinIcon, 5, StartPostion, EndPos, () =>
            //{
            //    BoneVoleBenefit.GetInstance().AddCash(AwardNum);
            //});
        }
    }
    public void PlowBus(Action finish) 
    {
        PlowPull.transform.DOScale(2, 0.2f);
        PlowPull.transform.DOMoveX(0, 0.5f);
        PlowPull.transform.DOMoveY(0, 0.5f).SetEase(Ease.OutExpo).OnComplete(()=> 
        {
            PlowPull.transform.DOScale(1, 0.3f).SetEase(Ease.InBack);
            PlowPull.transform.DOMoveX(0, 0.1f).OnComplete(()=> 
            {
                FX_Plow.SetActive(true);
                UIBenefit.RimIndicate().WrapUILight(nameof(FireTowel));
                FireTowel.instance.InflexiblyLeafy(() => 
                {
                    PlowPull.transform.position = IndirectCrossLeg;
                    finish();
                });
            });
        });
    }
    public void BranchSpyGene(Transform StartPostion, double AwardNum)
    {
        if (!VerbalRend.NoSquat())
        {
            PlayerPrefs.SetString(VoleBenefit.ValidOffer, "1");
            if (PlayerPrefs.GetInt(VoleBenefit.TownValid) == 3)
            {
                Fire.gameObject.SetActive(true);
            }
            int GeneStress= (int)AwardNum / FluHealWar.instance.BoneVole.diamond_fly_count;
            if (AwardNum % FluHealWar.instance.BoneVole.diamond_fly_count > 0)
            {
                GeneStress += 1;
            }
            GroundingSpacecraft.BranchCareMuchVeil(GenePull, GeneStress, StartPostion, FlyLeg, () =>
            {
                PlayerPrefs.SetString(VoleBenefit.ValidOffer, "0");
                if (PlayerPrefs.GetInt(VoleBenefit.TownValid) == 3)
                {
                    Color MaskColir = new Color();
                    MaskColir.a = 0.85f;
                    Fire.color = MaskColir;
                    EncounterMedicine = DOTween.Sequence();
                    EncounterMedicine.Append(TeemAvail.transform.DOScale(new Vector3(0.9f, 0.9f, 0.9f), 0.3f).SetLoops(10, LoopType.Yoyo))
                        .SetDelay(2)
                        .SetLoops(-1);
                }
                BoneVoleBenefit.RimIndicate().KeyWoad(AwardNum);
            });
        }
    }

    #endregion

}
