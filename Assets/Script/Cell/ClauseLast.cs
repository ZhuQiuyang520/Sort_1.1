using DG.Tweening;
using Lofelt.NiceVibrations;
using sf_database;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClauseLast : MonoBehaviour
{
    //防止重复点击
    private bool OxPaper;

    private bool NoBranchSlander;
[UnityEngine.Serialization.FormerlySerializedAs("SceenEffect")]
    public ParticleSystem AmuseHandle;
[UnityEngine.Serialization.FormerlySerializedAs("RibbonEffect")]    public ParticleSystem TeacupHandle;
[UnityEngine.Serialization.FormerlySerializedAs("WaterEffect")]    public ParticleSystem LowerHandle;
[UnityEngine.Serialization.FormerlySerializedAs("PingziCellBtn")]
    public Button ClauseLastOff;
[UnityEngine.Serialization.FormerlySerializedAs("ShuiColor1")]    public Image[] LikeBelow1;
[UnityEngine.Serialization.FormerlySerializedAs("ShuifanguangColor")]    public Image[] UndiscoveredBelow;
[UnityEngine.Serialization.FormerlySerializedAs("ObstacleColor")]    //障碍颜色 0：最上层障碍图片 1：中间障碍层图片 2：最下层障碍图片
    public GameObject[] SquirrelBelow;
[UnityEngine.Serialization.FormerlySerializedAs("ObstacleQuesMaek")]    public GameObject[] SquirrelHolmWide;
[UnityEngine.Serialization.FormerlySerializedAs("ObstacleEffect")]    public ParticleSystem[] SquirrelHandle;
[UnityEngine.Serialization.FormerlySerializedAs("Plug")]    public GameObject Clue;
[UnityEngine.Serialization.FormerlySerializedAs("WaterLine")]    public GameObject LowerWife;
[UnityEngine.Serialization.FormerlySerializedAs("Shuitop")]
    public Image Snippet;
[UnityEngine.Serialization.FormerlySerializedAs("ShuitopFanguang")]    public Image SnippetMusician;
[UnityEngine.Serialization.FormerlySerializedAs("ShuitopMaterial")]    public Material SnippetColonize;
    private Material MusicianColonize;
    //最大容量
    private int WitAttire;
    //当前容量
    private int SadAttire= 0;
    //取到当前颜色
    private string SadBelow;
    //取到颜色个数
    private int BelowStress;
[UnityEngine.Serialization.FormerlySerializedAs("InitPosition")]    public Vector3 JadeAppetite;
    private bool NoSod;
    private Dictionary<int, colorconfigDB> BelowGap= new Dictionary<int, colorconfigDB>();
    private Color TwiceHabitat= new Color();
    private colorconfigDB StarkVole;

    private string[] BelowMaser;
    //将颜色存到栈里
    private Stack<string> BelowPique= new Stack<string>();
    private bool NoBranch;
    private Action<int> BranchFiring;
    private Action<bool> NoCarcassOral;
    private int DarnComedy;
    private LevelGuideInfo.LevelGuideData OfferVole;
    private Action<Vector3> OfferFiring;

    private Action<int, Stack<string>, ShuiState , Transform> FiringInfectDarn;

    private Action FiringFind;

    //从上往下第一层障碍
    private bool Squirrel1= false;
    //从上往下第二层障碍
    private bool Squirrel2= false;
    //从上往下第三层障碍
    private bool Squirrel3= false;

    private int SquirrelStress;
[UnityEngine.Serialization.FormerlySerializedAs("RewardPos")]
    public GameObject ModuleLeg;
[UnityEngine.Serialization.FormerlySerializedAs("RewardObj")]    public GameObject ModuleHim;
    private GameObject ModuleCompel;
    private double SpinetStress;
    private bool NoModule;

   

    //瓶子水的颜色  ， 瓶子容量
    public void Jade(int VaseIndex,bool isReward, string curColor, int Volume, string LevelObstacle, LevelGuideInfo.LevelGuideData guideData,  Action<int> Finish , Action<bool> DisableProp , Action<int,Stack<string>, ShuiState,Transform> ActionRemind , Action<Vector3> GuidePos , Action step )
    {
        BoneBenefit.RimIndicate().StifleTranslation(gameObject.GetComponent<RectTransform>());
        NoModule = isReward;
        

        OfferVole = guideData;
        OfferFiring = GuidePos;
        //回调步数
        FiringFind = step;
        //道具基础信息回调
        FiringInfectDarn = ActionRemind;
        //瓶子索引
        DarnComedy = VaseIndex;
        BranchFiring = Finish;
        //禁用道具回调
        NoCarcassOral = DisableProp;
        NoBranch = false;
        BelowGap = BoneBenefit.RimIndicate().RimTossVole();
        MusicianColonize = Instantiate<Material>(SnippetColonize);
        SnippetMusician.material = MusicianColonize;
        WitAttire = Volume;
        TwiceHabitat.a = 0;
        ClauseLastOff.onClick.AddListener(PaperVole);
        SquirrelStress = int.Parse(LevelObstacle);
        //当前颜色值长度为0时 透明度调为0
        if (curColor.Length == 0)
        {
            HabitatTwiceCover(TwiceHabitat);
        }
        else
        {
            if (SquirrelStress == PlayerPrefs.GetInt(VoleBenefit.TownSquirrelValid))
            {
                Squirrel1 = true;
                Squirrel2 = true;
                Squirrel3 = true;
                for (int i = 0; i < SquirrelBelow.Length; i++)
                {
                    SquirrelBelow[i].SetActive(true);
                }
            }
            
            BelowMaser = curColor.Split("_");
            Color ShuiColor = new Color();
            Color TopColor = new Color();
            for (int i = 0; i < WitAttire; i++)
            {
                if (BelowMaser[i] == " " || BelowMaser[i] == string.Empty)
                {
                    ShuiColor.a = 0;
                    LikeBelow1[i].color = ShuiColor;
                    UndiscoveredBelow[i].color = ShuiColor;
                }
                else
                {
                    SadAttire++;
                    BelowPique.Push(BelowMaser[i]);
                    colorconfigDB data = BelowGap[int.Parse(BelowMaser[i])];
                    if (ColorUtility.TryParseHtmlString(data.color, out ShuiColor))
                    {
                        ShuiColor.a = 1;
                        LikeBelow1[i].color = ShuiColor;
                        UndiscoveredBelow[i].color = ShuiColor;
                    }

                    if (ColorUtility.TryParseHtmlString(data.topcolor, out TopColor))
                    {
                        TopColor.a = 1;
                        //Shuitop.color = TopColor;
                        HabitatNetTwice(LikeBelow1[i].transform.position, TopColor);
                    }
                }
            }
        }
        
        //回调瓶子的索引和颜色集合
        ActionRemind(VaseIndex, BelowPique,ShuiState.None, transform);
        NoSod = false;
        OxPaper = false;
        NoBranchSlander = false;
        Invoke(nameof(NephewOfferFiring),0.05f);
    }

    public void PaperVole()
    {
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        if (PlayerPrefs.GetInt(VoleBenefit.TownValid) == 1)
        {
            //判断当前点击的瓶子是否是引导的瓶子
            //如果是回调，并且执行点击。
            //如果不是没反应
            if (DarnComedy == OfferVole.OfferDarnID)
            {
                OfferFiring(gameObject.transform.position);
            }
            else
            {
                return;
            }
        }
        //保证瓶子在动画运动过程中不能点击
        if (!OxPaper)
        {
            OxPaper = true;

            //Isput true为抬起  false未抬起
            if (!NoSod)
            {
                BelowStress = 0;
                //Debug.Log("当前颜色：" + CurColor + "当前倒水值：" + ColorNumber + "当前已有容量：" + CurVolume + "瓶子最大容量：" + MaxVolume);
                if (BelowPique.Count == 0)
                {
                    OxPaperJade();
                    
                    StarkVole = new colorconfigDB();
                    BoneBenefit.RimIndicate().SlanderNorway(DarnComedy,gameObject, StarkVole, null, BelowStress, SadAttire, WitAttire, JadeAppetite, LikeBelow1, UndiscoveredBelow, SquirrelHolmWide, Snippet.gameObject, LowerHandle.gameObject, GuardSlanderAttire, BranchSlanderAbrupt, BranchEmigrationAbrupt, ToBranchAbrupt, OxPaperJade , ForeHuntKey , ForeHuntSilurian,NoCarcassOral, SlanderNetBelow);
                }
                else
                {
                    JadeAppetite = gameObject.transform.position;
                    NoSod = true;

                    SadBelow = BelowPique.Peek();
                    StarkVole = BelowGap[int.Parse(SadBelow)];

                    //判断当前关卡是否是障碍关卡
                    if (SquirrelStress == PlayerPrefs.GetInt(VoleBenefit.TownSquirrelValid))
                    {
                        int Number = BelowPique.Count;
                        for (int i = 0; i < Number; i++)
                        {
                            if (SadBelow == BelowPique.Peek())
                            {
                                if (Squirrel1)
                                {
                                    BelowPique.Pop();
                                    BelowStress++;
                                    break;
                                }
                                else
                                {
                                    if (Squirrel2)
                                    {
                                        if (BelowPique.Count > 2)
                                        {
                                            BelowPique.Pop();
                                            BelowStress++;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (Squirrel3)
                                        {
                                            if (BelowPique.Count > 1)
                                            {
                                                BelowPique.Pop();
                                                BelowStress++;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            BelowPique.Pop();
                                            BelowStress++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in BelowPique)
                        {
                            if (item == SadBelow)
                            {
                                BelowStress++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        for (int i = 0; i < BelowStress; i++)
                        {
                            BelowPique.Pop();
                        }
                    }
                    Debug.Log("当前颜色：" + SadBelow + "当前倒水值：" + BelowStress + "当前已有容量：" + SadAttire + "瓶子最大容量：" + WitAttire);
                    BoneBenefit.RimIndicate().SlanderNorway(DarnComedy, gameObject, StarkVole, SadBelow, BelowStress, SadAttire, WitAttire, JadeAppetite, LikeBelow1, UndiscoveredBelow, SquirrelHolmWide, Snippet.gameObject, LowerHandle.gameObject, GuardSlanderAttire, BranchSlanderAbrupt, BranchEmigrationAbrupt, ToBranchAbrupt, OxPaperJade, ForeHuntKey, ForeHuntSilurian , NoCarcassOral , SlanderNetBelow);
                }
            }
            else
            {
                if (!NoBranchSlander)
                {
                    NoSod = false;
                    for (int i = 0; i < BelowStress; i++)
                    {
                        BelowPique.Push(SadBelow);
                    }
                    BoneBenefit.RimIndicate().LeapTiffany();
                    GroundingBench.JoinerLeapBus(OxPaper, gameObject, JadeAppetite, OxPaperJade);
                }
            }
        }
    }
    public void OxPaperJade()
    {
        //恢复点击
        OxPaper = false;
    }

    public void GroundingAbrupt()
    {
        NoBranchSlander = true;
    }

    public void ReelectInfect()
    {
        if (NoRimInfect)
        {
            NoRimInfect = false;
        }
    }

    //倒水动画执行时，清空倒水瓶子的预倒水值
    //防止快速点击又将数值加回到倒水瓶子中
    public void GuardSlanderAttire()
    {
        BelowStress = 0;
    }

    //倒水完成回调
    public void BranchSlanderAbrupt(int UnDaoshuiNumbber)
    {
        gameObject.transform.SetSiblingIndex(transform.parent.childCount - 1 - DarnComedy);
        NoBranchSlander = false;
        //未成功倒水的数量
        if (UnDaoshuiNumbber != 0)
        {
            for (int i = 0; i < UnDaoshuiNumbber; i++)
            {
                BelowPique.Push(SadBelow);
            }
        }

        FiringInfectDarn(DarnComedy, BelowPique,ShuiState.Daoshui, transform);
        //刷新当前瓶子颜色
        ReelectBelow();
        BoneBenefit.RimIndicate().LeapTiffany();
        SadAttire = BelowPique.Count;
        NoSod = false;
        OxPaperJade();

        //没有使用道具正常倒水完成清除障碍色。一次清除一个
        if (!NoRimInfect)
        {
            FiringFind();

            if (BelowPique.Count == 3)
            {
                if (Squirrel1)
                {
                    Squirrel1 = false;
                    SquirrelHolmWide[1].SetActive(true);
                    SquirrelHolmWide[2].SetActive(true);
                    GroundingBench.GuardSquirrelBelow(SquirrelBelow[0], SquirrelHandle[0], GuardSquirrel);
                }
                else if (Squirrel2)
                {
                    SquirrelHolmWide[1].SetActive(true);
                    SquirrelHolmWide[2].SetActive(true);
                }
                else if (Squirrel3)
                {
                    SquirrelHolmWide[2].SetActive(true);
                }
            }
            else if (BelowPique.Count == 2)
            {
                if (Squirrel2)
                {
                    Squirrel2 = false;
                    SquirrelHolmWide[2].SetActive(true);
                    GroundingBench.GuardSquirrelBelow(SquirrelBelow[1], SquirrelHandle[1], GuardSquirrel);
                }
                else if (Squirrel3)
                {
                    SquirrelHolmWide[2].SetActive(true);
                }
            }
            else if (BelowPique.Count == 1)
            {
                if (Squirrel3)
                {
                    Squirrel3 = false;
                    GroundingBench.GuardSquirrelBelow(SquirrelBelow[2], SquirrelHandle[2], GuardSquirrel);
                }
            }
        }
        else
        {
            if (Squirrel1)
            {
                SquirrelHolmWide[0].SetActive(true);
                SquirrelHolmWide[1].SetActive(true);
                SquirrelHolmWide[2].SetActive(true);
            }
            else if (Squirrel2)
            {
                SquirrelHolmWide[1].SetActive(true);
                SquirrelHolmWide[2].SetActive(true);
            }
            else if (Squirrel3)
            {
                SquirrelHolmWide[2].SetActive(true);
            }
        }
    }

    //被倒水完成回调
    public void BranchEmigrationAbrupt(int ReadyNumber, string WaterColor)
    {
        NoSod = false;
        for (int i = 0; i < ReadyNumber + BelowStress; i++)
        {
            BelowPique.Push(WaterColor);
        }
        SadAttire = BelowPique.Count;
       
        ReelectBelow();
        if (NoRimInfect)
        {
            OxPaperJade();
            NoRimInfect = false;
            Invoke(nameof(NephewForeHunt), 0.1f);
        }
        else
        {
            FiringInfectDarn(DarnComedy, BelowPique, ShuiState.Beidaoshui, transform);
            if (BelowPique.Count == WitAttire)
            {
                BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.MediumImpact);
                string colorStr = BelowPique.Peek();
                foreach (var item in BelowPique)
                {
                    if (colorStr != item)
                    {
                        NoBranch = false;
                        break;
                    }
                    else
                    {
                        NoCarcassOral(true);
                        NoBranch = true;
                    }
                }

                if (NoBranch && !Squirrel1 && !Squirrel2 && !Squirrel3)
                {
                    BoneBenefit.RimIndicate().CompanyForeHunt();
                    OxPaper = true;
                    Clue.SetActive(true);
                    BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.waterfull);
                    
                    GroundingBench.ElusiveBranchBus(gameObject.transform.GetChild(0).gameObject, Clue, AmuseHandle, TeacupHandle, () => {
                        //BoneBenefit.GetInstance().SettingVibra();
                        BranchFiring(DarnComedy);
                        if (NoModule && !VerbalRend.NoSquat())
                        {
                            BoneTowel.instance.SpyGene(ModuleCompel.transform, SpinetStress);
                            Destroy(ModuleCompel);
                            //RewardObject.SetActive(false);
                        }
                    });
                }
                else
                {
                    NoCarcassOral(false);
                    OxPaperJade();
                }
            }
            else
            {
                NoCarcassOral(false);
                OxPaperJade();
            }
        }
    }

    //未完成回调 瓶子落下并将数据存回到栈中
    public void ToBranchAbrupt()
    {
        NoSod = false;
        NoBranchSlander = false;
        //倒水完成，如果使用了提示道具，则更新状态
        if (NoRimInfect)
        {
            NoRimInfect = false;
        }
        for (int i = 0; i < BelowStress; i++)
        {
            BelowPique.Push(SadBelow);
        }
        GroundingBench.JoinerLeapBus(OxPaper, gameObject, JadeAppetite, OxPaperJade);
    }

    //调整图片透明度
    public void HabitatTwiceCover(Color imageColor)
    {
        for (int i = 0; i < LikeBelow1.Length; i++)
        {
            LikeBelow1[i].color = imageColor;
        }
        for (int i = 0; i < UndiscoveredBelow.Length; i++)
        {
            UndiscoveredBelow[i].color = imageColor;
        }
        Snippet.color = imageColor;
        SnippetMusician.color = imageColor;
    }

    //设置水面的位置和颜色
    public void HabitatNetTwice(Vector3 CurPos, Color Topcolor)
    {
        Snippet.transform.position = CurPos;
        Snippet.GetComponent<RectTransform>().anchoredPosition = new Vector2(Snippet.GetComponent<RectTransform>().anchoredPosition.x, Snippet.GetComponent<RectTransform>().anchoredPosition.y + Snippet.GetComponent<RectTransform>().rect.height * 0.5f);

        Snippet.color = Topcolor;
        MusicianColonize.color = Topcolor;
    }

    //刷新水面位置以及水的颜色
    public void ReelectBelow()
    {
        HabitatTwiceCover(TwiceHabitat);
        Color ShuiColor = new Color();
        Color TopColor = new Color();
        if (BelowPique.Count == 0)
        {
            TopColor.a = 0;
            HabitatNetTwice(LikeBelow1[0].transform.position, TopColor);
        }
        else
        {
            if (Snippet.gameObject.activeSelf == false)
            {
                Snippet.gameObject.SetActive(true);
            }
            ShuiColor.a = 1;
            TopColor.a = 1;
            int Residue = BelowPique.Count;
            colorconfigDB data = BelowGap[int.Parse(BelowPique.Peek())];
            if (ColorUtility.TryParseHtmlString(data.topcolor, out TopColor))
            {
                HabitatNetTwice(LikeBelow1[Residue - 1].transform.position, TopColor);
            }

            int Reset = 0;
            foreach (var item in BelowPique)
            {
                data = BelowGap[int.Parse(item)];
                if (ColorUtility.TryParseHtmlString(data.color, out ShuiColor))
                {
                    if (Reset <= Residue)
                    {
                        Residue--;
                        LikeBelow1[Residue].color = ShuiColor;
                        //ShuifanguangColor[Residue].color = ShuiColor;
                    }
                }
            }
        }
    }
    public void ForeHuntKey(int ReadyNumber , string WaterColor)
    {
        for (int i = 0; i < ReadyNumber; i++)
        {
            BelowPique.Push(WaterColor);
        }
        SadAttire = BelowPique.Count;
        ReelectBelow();
    }

    public void ForeHuntSilurian(int ReadyNumber)
    {
        for (int i = 0; i < ReadyNumber; i++)
        {
            BelowPique.Pop();
        }
        SadAttire = BelowPique.Count;
        ReelectBelow();
    }

    //单独处理倒水瓶子水面颜色
    //如果NotVolume为0 ，则用数组中的颜色
    //如果Norvolume不为0，则用
    private void SlanderNetBelow(int NotVolume)
    {
        Color TopColor = new Color();
        TopColor.a = 1;
        if (BelowPique.Count != 0)
        {
            if (NotVolume == 0)
            {
                colorconfigDB data = BelowGap[int.Parse(BelowPique.Peek())];
                if (ColorUtility.TryParseHtmlString(data.topcolor, out TopColor))
                {
                    Snippet.color = TopColor;
                }
            }
            else
            {
                if (ColorUtility.TryParseHtmlString(StarkVole.topcolor, out TopColor))
                {
                    Snippet.color = TopColor;
                }
            }
        }
    }

    private void Start()
    {
         //SceenEffect = (UIBenefit.GetInstance().GetCurrentUI() as BoneTowel).Fx_Sceen;
        AmuseHandle = UIBenefit.RimIndicate().RimTowelWeTale(nameof(BoneTowel)).GetComponent<BoneTowel>().Up_Amuse;
        Vector2 SceenScale = AmuseHandle.GetComponent<RectTransform>().localScale;
        //当屏幕尺寸
        if (Screen.width < 1080)
        {
            AmuseHandle.GetComponent<RectTransform>().localScale = new Vector2(SceenScale.x * 1080 / (float)Screen.width, SceenScale.y * 1080 / (float)Screen.width);
        }
        else
        {
            AmuseHandle.GetComponent<RectTransform>().localScale = new Vector2(SceenScale.x * (float)Screen.width / 1080, SceenScale.y * (float)Screen.width / 1080);
        }
    }
    private void Awake()
    {
        BlanketBenefit.RimIndicate().AddListener(MessageCode.ReelectClauseBelow, ReelectBelow);
        BlanketBenefit.RimIndicate().AddListener<int>(MessageCode.RimInfectOral, RimInfect);
        BlanketBenefit.RimIndicate().AddListener(MessageCode.ReelectInfect, ReelectInfect);
        BlanketBenefit.RimIndicate().AddListener<LevelGuideInfo.LevelGuideData>(MessageCode.ValidOffer, BlanketOfferVole);
        BlanketBenefit.RimIndicate().AddListener<Transform>(MessageCode.StitchModule, StitchDarnModule);
        BlanketBenefit.RimIndicate().AddListener(MessageCode.ReelectModuleLeg, ReelectModuleLeg);
    }

    private void OnDestroy()
    {
        BlanketBenefit.RimIndicate().HamperShoshone(MessageCode.ReelectClauseBelow, ReelectBelow);
        BlanketBenefit.RimIndicate().HamperShoshone<int>(MessageCode.RimInfectOral, RimInfect);
        BlanketBenefit.RimIndicate().HamperShoshone(MessageCode.ReelectInfect, ReelectInfect);
        BlanketBenefit.RimIndicate().HamperShoshone<LevelGuideInfo.LevelGuideData>(MessageCode.ValidOffer, BlanketOfferVole);
        BlanketBenefit.RimIndicate().HamperShoshone<Transform>(MessageCode.StitchModule, StitchDarnModule);
        BlanketBenefit.RimIndicate().HamperShoshone(MessageCode.ReelectModuleLeg, ReelectModuleLeg);
    }

    private void StitchDarnModule(Transform obj)
    {
        if (NoModule && !VerbalRend.NoSquat())
        {
            ModuleCompel = Instantiate(ModuleHim, obj);
            ModuleCompel.transform.position = ModuleLeg.transform.position;
            SpinetStress = FluHealWar.instance.BoneVole.rewardvaseData.reward_num + GameUtil.GetCashMulti();
            ModuleCompel.GetComponent<ModuleLast>().Jade(SpinetStress);
        }
    }
    private void ReelectModuleLeg()
    {
        if (NoModule && !VerbalRend.NoSquat())
        {
            ModuleCompel.transform.position = ModuleLeg.transform.position;
        }
    }

    private bool NoRimInfect= false;
    //使用提示 如果瓶子序号相等，执行点击操作
    public void RimInfect(int VaseIndex)
    {
        NoRimInfect = true;
        if (VaseIndex == DarnComedy)
        {
            PaperVole();
        }
    }

    public void NephewForeHunt()
    {
        NoCarcassOral(false);
        BoneBenefit.RimIndicate().ForeHuntPaper();
    }

    public void BlanketOfferVole(LevelGuideInfo.LevelGuideData guide)
    {
        OfferVole = guide;
        if (OfferVole.OfferDarnID == DarnComedy)
        {
            OfferFiring(gameObject.transform.position);
        }
    }

    private void NephewOfferFiring()
    {
        if (PlayerPrefs.GetInt(VoleBenefit.TownValid) == 1)
        {
            if (DarnComedy == OfferVole.OfferDarnID)
            {
                OfferFiring(gameObject.transform.position);
            }
        }
    }

    public void GuardSquirrel()
    {
    }
}

