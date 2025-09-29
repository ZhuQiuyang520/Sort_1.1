using DG.Tweening;
using LitJson;
using Lofelt.NiceVibrations;
using Newtonsoft.Json;
using sf_database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class BoneBenefit : DeedSingleton<BoneBenefit>
{
    private List<LanguageconfigDB> DesignerHard= new List<LanguageconfigDB>();
    private Dictionary<int, colorconfigDB> TossGap= new Dictionary<int, colorconfigDB>();
    private List<colorconfigDB> TossHard= new List<colorconfigDB>();

    private Stack<Action<int, string>> KeyPique= new Stack<Action<int, string>>();
    private Stack<Action<int>> SilurianPique= new Stack<Action<int>>();
    private Stack<int> PiqueLikeStress= new Stack<int>();
    private Stack<string> PiqueBelowStress= new Stack<string>();

    public bool NoTitle{ get; set; }
    public bool NoRealm{ get; set; }
    public bool NoOrgan{ get; set; }

    private void Start()
    {
        PikeDesignerRamble(JsonName.Evidence);
        PikeTossRamble(JsonName.Toss);
    }


    //判断是登陆进入还是从后台切换
    private bool NoFist= false;
    private bool NoObedient= false;
    private GameObject ObedientHim;
    private int ObedientDarnFresh;
    private string ObedientLowerBelow;
    private colorconfigDB ObedientBelowVole;
    private int ObedientToughStress;
    private int ObedientSadAttire;
    private Vector3 ObedientJadeAppetite;
    private Action<int> ObedientBranch;
    private Action ObedientToBranch;
    private Image[] ObedientTwiceMaser;
    private Image[] ObedientMusicianMaser;
    private GameObject[] ObedientHolmNeed;
    private GameObject ObedientNet;
    private Action<int, string> ObedientFiringForeHuntKey;
    private Action<int> ObedientSlanderNetBelow;
    private Action ObedientGuardBelowAttire;

    //true 第一个瓶为空  false 第一个瓶不为空
    private bool NoTruly= true;

    private GameObject TrulyHim;
    private int TrulyDarnFresh;
    private string TrulyLowerBelow;
    private colorconfigDB TrulyBelowVole;
    private int TrulyToughStress;
    private int TrulySadAttire;
    private Vector3 TrulyJadeAppetite;
    private Action<int> TrulyBranch;
    private Action TrulyToBranch;
    private float Badge;
    private Image[] TrulyTwiceMaser;
    private Image[] TrulyOrderlyMaser;
    private GameObject[] TrulyHolmNeed;
    private GameObject TrulyNet;
    private Action<int, string> TrulyFiringForeHuntKey;
    private Action<int> TrulySlanderNetBelow;
    private Action TrulyGuardBelowAttire;
    //private Action FirstActionReClick;

    private GameObject FranceNetHandle;

    private int TrulyApeDigestStress;


    /// <summary>
    /// 瓶子倒水方法
    /// </summary>
    /// <param name="VaseIndex">瓶子序号</param>
    /// <param name="SelectObj">瓶子对象</param>
    /// <param name="ColorData">颜色数值</param>
    /// <param name="CurColor">颜色</param>
    /// <param name="ReadyNumber">预倒水值</param>
    /// <param name="CurVolume">被倒水瓶子当前容量</param>
    /// <param name="MaxVolume">瓶子最大容量</param>
    /// <param name="InitPosition">倒水瓶子位置</param>
    /// <param name="ImageArray">水图片数据</param>
    /// <param name="FanguangArray">水反光图片数组</param>
    /// <param name="QuesMark">障碍色问号数组</param>
    /// <param name="Top">水面</param>
    /// <param name="WaterLineEffect">水面特效</param>
    /// <param name="ClearColorVolume">清空颜色值回调</param>
    /// <param name="FinishDaoshui">倒水完成回调</param>
    /// <param name="FinishBeidaoshui">被倒水完成回调</param>
    /// <param name="Unfinish">未完成倒水回调</param>
    /// <param name="ReClick">动画期间不能执行其他点击操作</param>
    /// <param name="RollBackAdd">撤回倒水回调</param>
    /// <param name="RollBackSubtract">撤回被倒水回调</param>
    /// <param name="DisableProp">禁用道具回调</param>
    /// <param name="DaoshuiTopColor">倒水水面颜色值</param>
    public void SlanderNorway(int VaseIndex, GameObject SelectObj, colorconfigDB ColorData, string CurColor, int ReadyNumber, int CurVolume, int MaxVolume, Vector3 InitPosition, Image[] ImageArray, Image[] FanguangArray, GameObject[] QuesMark, GameObject Top, GameObject WaterLineEffect, Action ClearColorVolume, Action<int> FinishDaoshui, Action<int, string> FinishBeidaoshui, Action Unfinish, Action ReClick, Action<int, string> RollBackAdd, Action<int> RollBackSubtract, Action<bool> DisableProp, Action<int> DaoshuiTopColor)
    {
        if (NoObedient)
        {
            if (CurColor != null)
            {
                HabitatOrgan(RealmCare.UIMusic.click_2);
                //瓶子抬起
                GroundingBench.JoinerMeBus(SelectObj, InitPosition, () =>
                {
                    ReClick();
                });
                if (ObedientHim != null)
                {
                    ObedientToBranch();
                }
                ObedientHim = SelectObj;
                ObedientDarnFresh = VaseIndex;
                ObedientLowerBelow = CurColor;
                ObedientBelowVole = ColorData;
                ObedientJadeAppetite = InitPosition;
                ObedientToughStress = ReadyNumber;
                ObedientBranch = FinishDaoshui;
                ObedientToBranch = Unfinish;
                ObedientSadAttire = CurVolume;
                ObedientTwiceMaser = ImageArray;
                ObedientMusicianMaser = FanguangArray;
                ObedientHolmNeed = QuesMark;
                ObedientNet = Top;
                ObedientFiringForeHuntKey = RollBackAdd;
                ObedientSlanderNetBelow = DaoshuiTopColor;
                ObedientGuardBelowAttire = ClearColorVolume;
            }
        }
        else
        {
            TrulyApeDigestStress = 0;
            if (NoTruly)
            {
                //点击的第一个瓶子为空瓶 跳过操作
                if (CurColor != null)
                {
                    NoTruly = false;
                    TrulyBelowVole = ColorData;
                    TrulyHim = SelectObj;
                    TrulyDarnFresh = VaseIndex;
                    TrulyLowerBelow = CurColor;
                    TrulyJadeAppetite = InitPosition;
                    TrulyToughStress = ReadyNumber;
                    TrulyBranch = FinishDaoshui;
                    TrulyToBranch = Unfinish;
                    TrulySadAttire = CurVolume;
                    TrulyTwiceMaser = ImageArray;
                    TrulyOrderlyMaser = FanguangArray;
                    TrulyHolmNeed = QuesMark;
                    TrulyNet = Top;
                    TrulyFiringForeHuntKey = RollBackAdd;
                    TrulySlanderNetBelow = DaoshuiTopColor;
                    TrulyGuardBelowAttire = ClearColorVolume;

                    HabitatOrgan(RealmCare.UIMusic.click_2);
                    //第一个瓶子抬起
                    GroundingBench.JoinerMeBus(TrulyHim, TrulyJadeAppetite, () =>
                    {
                        ReClick();
                    }); ;
                }
            }
            else
            {
                if (TrulyDarnFresh == VaseIndex)
                {
                    LeapTiffany();
                    //第一个瓶子落下
                    TrulyToBranch();
                }
                else
                {
                    //第一个瓶子预倒水量 + 第二个瓶子当前已有容量 > 最大容量
                    //第二个瓶子当前容量 = 最大容量
                    if (CurVolume == MaxVolume)
                    {
                        //第一个瓶子落下
                        TrulyToBranch();
                        HabitatOrgan(RealmCare.UIMusic.click_2);
                        //第二个瓶子抬起
                        GroundingBench.JoinerMeBus(SelectObj, InitPosition, () =>
                        {
                            ReClick();
                        }); ;

                        //将第二个瓶子的数据赋值到第一个瓶子，并当做第一个瓶子处理
                        TrulyHim = SelectObj;
                        NoTruly = false;
                        TrulyDarnFresh = VaseIndex;
                        TrulyBelowVole = ColorData;
                        TrulyLowerBelow = CurColor;
                        TrulyToughStress = ReadyNumber;
                        TrulyJadeAppetite = InitPosition;
                        TrulyBranch = FinishDaoshui;
                        TrulyToBranch = Unfinish;
                        TrulySadAttire = CurVolume;
                        TrulyTwiceMaser = ImageArray;
                        TrulyOrderlyMaser = FanguangArray;
                        TrulyHolmNeed = QuesMark;
                        TrulyNet = Top;
                        TrulyFiringForeHuntKey = RollBackAdd;
                        TrulySlanderNetBelow = DaoshuiTopColor;
                        TrulyGuardBelowAttire = ClearColorVolume;
                    }
                    else
                    {
                        //当前倒水颜色 和被倒水颜色不一致 并且被倒水颜色不为空
                        if (TrulyLowerBelow != CurColor && CurColor != null)
                        {
                            //第一个瓶子落下
                            TrulyToBranch();
                            HabitatOrgan(RealmCare.UIMusic.click_2);
                            //第二个瓶子抬起
                            GroundingBench.JoinerMeBus(SelectObj, InitPosition, () =>
                            {
                                ReClick();
                            }); ;

                            TrulyHim = SelectObj;
                            NoTruly = false;
                            TrulyDarnFresh = VaseIndex;
                            TrulyBelowVole = ColorData;
                            TrulyLowerBelow = CurColor;
                            TrulyJadeAppetite = InitPosition;
                            TrulyToughStress = ReadyNumber;
                            TrulyBranch = FinishDaoshui;
                            TrulyToBranch = Unfinish;
                            TrulySadAttire = CurVolume;
                            TrulyTwiceMaser = ImageArray;
                            TrulyOrderlyMaser = FanguangArray;
                            TrulyHolmNeed = QuesMark;
                            TrulyNet = Top;
                            TrulyFiringForeHuntKey = RollBackAdd;
                            TrulySlanderNetBelow = DaoshuiTopColor;
                            TrulyGuardBelowAttire = ClearColorVolume;
                        }
                        else
                        {
                            FranceNetHandle = WaterLineEffect;
                            TrulyHim.transform.SetAsLastSibling();
                            //倒水过程中道具禁用
                            DisableProp(true);
                            NoObedient = true;
                            //如果预倒水量 + 第二个瓶子已有容量 > 瓶子的总量
                            //则预倒水量改为 第二个瓶子还能倒进去的量
                            if (TrulyToughStress + CurVolume > MaxVolume)
                            {
                                //第一个瓶子未倒出去的水量
                                TrulyApeDigestStress = TrulyToughStress - (MaxVolume - CurVolume);
                                //实际倒水值
                                TrulyToughStress = MaxVolume - CurVolume;
                            }
                            //倾斜值 根据瓶子剩余容量 - 实际倒水值
                            int SlantNum = TrulySadAttire - TrulyToughStress;
                            switch (SlantNum)
                            {
                                case 3:
                                    Badge = 70;
                                    break;
                                case 2:
                                    Badge = 80;
                                    break;
                                case 1:
                                    Badge = 90;
                                    break;
                                case 0:
                                    Badge = 100;
                                    break;
                                default:
                                    break;
                            }
                            KeyPique.Push(TrulyFiringForeHuntKey);
                            SilurianPique.Push(RollBackSubtract);
                            PiqueLikeStress.Push(TrulyToughStress);
                            PiqueBelowStress.Push(TrulyLowerBelow);

                            ClauseLast item = TrulyHim.GetComponent<ClauseLast>();
                            item.GroundingAbrupt();
                            //Vector3 StartFirstPos = item.InitPosition;

                            for (int i = 0; i < TrulyHolmNeed.Length; i++)
                            {
                                TrulyHolmNeed[i].SetActive(false);
                            }
                            //开始倒水清空倒水瓶子的预倒水值
                            TrulyGuardBelowAttire();
                            //判断瓶子的相对位置，区分被倒水瓶子和倒水瓶子的位置，区分方向
                            if (TrulyHim.transform.position.x < SelectObj.transform.position.x)
                            {
                                item.Snippet.GetComponent<RectTransform>().pivot = new Vector2(1, 1);
                                for (int i = 0; i < item.LikeBelow1.Length; i++)
                                {
                                    RectTransform Coloritem = item.LikeBelow1[i].GetComponent<RectTransform>();
                                    Coloritem.pivot = new Vector2(1, 1);
                                }
                                SearLowerBus(-Badge, TrulyApeDigestStress, TrulyBelowVole, TrulyTwiceMaser, ImageArray, TrulyOrderlyMaser, TrulyNet, Top, TrulyJadeAppetite, SelectObj, TrulySadAttire, CurVolume, TrulyToughStress, () =>
                                {
                                    // 倒水动画执行后 , 调用第一个瓶子的倒水完成和第二个瓶子被倒水完成
                                    TrulyBranch(TrulyApeDigestStress);
                                    FinishBeidaoshui(TrulyToughStress, TrulyLowerBelow);

                                    LeapTiffany();
                                    NoObedient = false;
                                    if (ObedientHim != null)
                                    {
                                        TrulyBelowVole = ObedientBelowVole;
                                        TrulyDarnFresh = ObedientDarnFresh;
                                        TrulyHim = ObedientHim;
                                        NoTruly = false;
                                        TrulyLowerBelow = ObedientLowerBelow;
                                        TrulyJadeAppetite = ObedientJadeAppetite;
                                        TrulyToughStress = ObedientToughStress;
                                        TrulyBranch = ObedientBranch;
                                        TrulyToBranch = ObedientToBranch;
                                        TrulySadAttire = ObedientSadAttire;
                                        TrulyTwiceMaser = ObedientTwiceMaser;
                                        TrulyOrderlyMaser = ObedientMusicianMaser;
                                        TrulyHolmNeed = ObedientHolmNeed;
                                        TrulyNet = ObedientNet;
                                        TrulyFiringForeHuntKey = ObedientFiringForeHuntKey;
                                        TrulySlanderNetBelow = ObedientSlanderNetBelow;
                                        TrulyGuardBelowAttire = ObedientGuardBelowAttire;
                                        ObedientHim = null;
                                    }

                                });
                            }
                            else
                            {
                                item.Snippet.GetComponent<RectTransform>().pivot = new Vector2(0, 1);
                                for (int i = 0; i < item.LikeBelow1.Length; i++)
                                {
                                    RectTransform Coloritem = item.LikeBelow1[i].GetComponent<RectTransform>();
                                    Coloritem.pivot = new Vector2(0, 1);
                                }

                                SearLowerBus(Badge, TrulyApeDigestStress, TrulyBelowVole, TrulyTwiceMaser, ImageArray, TrulyOrderlyMaser, TrulyNet, Top, TrulyJadeAppetite, SelectObj, TrulySadAttire, CurVolume, TrulyToughStress, () =>
                                {
                                    // 倒水动画执行后 , 调用第一个瓶子的倒水完成和第二个瓶子被倒水完成
                                    TrulyBranch(TrulyApeDigestStress);
                                    FinishBeidaoshui(TrulyToughStress, TrulyLowerBelow);

                                    LeapTiffany();
                                    NoObedient = false;
                                    if (ObedientHim != null)
                                    {
                                        TrulyBelowVole = ObedientBelowVole;
                                        TrulyDarnFresh = ObedientDarnFresh;
                                        TrulyHim = ObedientHim;
                                        NoTruly = false;
                                        TrulyLowerBelow = ObedientLowerBelow;
                                        TrulyJadeAppetite = ObedientJadeAppetite;
                                        TrulyToughStress = ObedientToughStress;
                                        TrulyBranch = ObedientBranch;
                                        TrulyToBranch = ObedientToBranch;
                                        TrulySadAttire = ObedientSadAttire;
                                        TrulyTwiceMaser = ObedientTwiceMaser;
                                        TrulyOrderlyMaser = ObedientMusicianMaser;
                                        TrulyHolmNeed = ObedientHolmNeed;
                                        TrulyNet = ObedientNet;
                                        TrulyFiringForeHuntKey = ObedientFiringForeHuntKey;
                                        TrulySlanderNetBelow = ObedientSlanderNetBelow;
                                        TrulyGuardBelowAttire = ObedientGuardBelowAttire;
                                        ObedientHim = null;
                                    }
                                });
                            }
                        }
                    }
                }
            }
        }
    }

    //点击撤回后取出需要撤回的数据
    public void ForeHuntPaper()
    {
        if (PiqueLikeStress.Count > 0)
        {
            if (TrulyHim != null)
            {
                TrulyToBranch();
                LeapTiffany();
            }
            if (FranceNetHandle.activeSelf && FranceNetHandle!= null)
            {
                FranceNetHandle.SetActive(false);
            }
            int ReadyNumber = PiqueLikeStress.Pop();
            string WaterColor = PiqueBelowStress.Pop();
            Action<int, string> AcAdd = KeyPique.Pop();
            Action<int> AcSubtract = SilurianPique.Pop();
            AcAdd(ReadyNumber, WaterColor);
            AcSubtract(ReadyNumber);
            BlanketBenefit.RimIndicate().Dimension(MessageCode.ReelectInfect);
        }
    }
    //根据当前数据数量判断是否可以继续撤回
    public int ForeHuntTie()
    {
        return PiqueLikeStress.Count;
    }

    //当瓶子完成后，数据不能撤回
    public void CompanyForeHunt()
    {
        PiqueLikeStress.Clear();
        PiqueBelowStress.Clear();
        KeyPique.Clear();
        SilurianPique.Clear();
    }

    //倒水后重置状态  
    //第二次点击相同的对象，重置状态
    public void LeapTiffany()
    {
        NoTruly = true;
    }

    public void RimOralJade()
    {
        if (!NoTruly)
        {
            TrulyToBranch();
            LeapTiffany();
        }
    }

    //用来判断当前有没有点击起来的瓶子
    public bool FiringTrulyHim()
    {
        return NoTruly;
    }

    //回调当前抬起的瓶子的索引
    public int FiringTrulyFresh()
    {
        return TrulyDarnFresh;
    }

    /// <summary>
    /// UI的世界坐标转为屏幕坐标
    /// </summary>
    /// <param name="tf"></param>
    /// <returns></returns>
    public static Vector2 EnjoyHeavy2StifleHeavy(RectTransform tf)
    {
        if (tf == null)
        {
            return Vector2.zero;
        }

        Vector2 fromPivotDerivedOffset = new Vector2(tf.rect.width * 0.5f + tf.rect.xMin, tf.rect.height * 0.5f + tf.rect.yMin);
        Vector2 screenP = RectTransformUtility.WorldToScreenPoint(null, tf.position);
        screenP += fromPivotDerivedOffset;
        return screenP;
    }


    /// <summary>
    /// UI的屏幕坐标，转为世界坐标
    /// </summary>
    /// <param name="tf"></param>
    /// <param name="startPos"></param>
    /// <returns></returns>
    public static Vector2 StifleHeavy2EnjoyHeavy(RectTransform tf, Vector2 startPos)
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(tf, startPos, null, out localPoint);
        Vector2 pivotDerivedOffset = new Vector2(tf.rect.width * 0.5f + tf.rect.xMin, tf.rect.height * 0.5f + tf.rect.yMin);
        return tf.anchoredPosition + localPoint - pivotDerivedOffset;
    }

    public void PikeDesignerRamble(string JsonName)
    {
        string json = Resources.Load<TextAsset>("LocationJson/" + JsonName).text;
        DesignerHard = JsonConvert.DeserializeObject<List<LanguageconfigDB>>(json);
    }

    public List<LanguageconfigDB> RimDesignerVole()
    {
        return DesignerHard;
    }

    //获取皮肤
    public void  PikeTossRamble(string JsonName)
    {
        string json = Resources.Load<TextAsset>("LocationJson/" + JsonName).text;

        TossHard = JsonConvert.DeserializeObject<List<colorconfigDB>>(json);
    }

    //刷新当前皮肤下水的色值
    public void PikeSadToss()
    {
        TossGap.Clear();
        int CurSkin = PlayerPrefs.GetInt(VoleBenefit.TownSadToss);
        int BelowBench= 0;
        foreach (var item in FluHealWar.instance.BoneVole.shop)
        {
            if (CurSkin == item.id && item.type == 2)
            {
                BelowBench = item.colorgroup;
                break;
            }
        }
        foreach (var item in TossHard)
        {
            if (item.group == BelowBench)
            {
                TossGap.Add(item.id, item);
            }
        }
    }
    public Dictionary<int , colorconfigDB> RimTossVole()
    {
        return TossGap;
    }
    /// <summary>
    /// 倒水动画打包
    /// </summary>
    /// <param name="A">角度</param>
    /// <param name="WaterColor">水颜色</param>
    /// <param name="DaoshuiImageArray">倒水数组</param>
    /// <param name="BeidaoshuiImageArray">被倒水数组</param>
    /// <param name="ImageFanguangArray">反光数组</param>
    /// <param name="DaohuiTop">倒水水面</param>
    /// <param name="BeidaoshuiTop">被倒水水面</param>
    /// <param name="StartFirstPos">位置起始值</param>
    /// <param name="SelectObj">选中</param>
    /// <param name="FristCurVolme">首次剩余</param>
    /// <param name="CurVolme">剩余</param>
    /// <param name="FirstReadyNumber">首次预倒水</param>
    /// <param name="finish">回调</param>
    public void SearLowerBus(float A,int NotVolume, colorconfigDB WaterColor,Image[] DaoshuiImageArray, Image[] BeidaoshuiImageArray, Image[] ImageFanguangArray, GameObject DaohuiTop, GameObject BeidaoshuiTop, Vector3 StartFirstPos, GameObject SelectObj, int FristCurVolme, int CurVolme, int FirstReadyNumber, Action finish)
    {
        HabitatTitle(HapticPatterns.PresetType.LightImpact);
        //倒水准备
        GroundingBench.ObviouslyPourLowerBus(TrulyHim, A, SelectObj.transform.position, DaoshuiImageArray, DaohuiTop, () =>
        {
            HabitatOrgan(RealmCare.UIMusic.PourWater);
            //被倒水
            GroundingBench.TheAwakeQuotationSearLower(NotVolume,BeidaoshuiImageArray, SelectObj, WaterColor, BeidaoshuiTop, CurVolme, A, FristCurVolme, FirstReadyNumber, TrulySlanderNetBelow);
            //正在倒水
            GroundingBench.SearLowerBusInSpecimen(TrulyHim, A, DaoshuiImageArray, DaohuiTop, FristCurVolme, () =>
            {
                HabitatTineOrgan(RealmCare.UIMusic.PourWater);
                //倒水完成
                GroundingBench.SearLowerBusOver(TrulyHim, StartFirstPos, FristCurVolme, FirstReadyNumber, A, DaoshuiImageArray, ImageFanguangArray, DaohuiTop, () =>
                {
                    finish?.Invoke();
                });
            });
        });
    }

    

    public void HabitatTitle(HapticPatterns.PresetType type)
    {
        if (NoTitle)
        {
            HapticPatterns.PlayPreset(type);
        }
    }
    public void HabitatOrgan(RealmCare.UIMusic sfx)
    { 
        if (NoOrgan)
        {
            //AudioManager.Instance.PlaySFX(sfx);
            RealmWar.RimIndicate().BodeHandle(sfx);
        }
    }
    //暂定指定的音效
    public void HabitatTineOrgan(RealmCare.UIMusic sfx)
    {
        if (NoOrgan)
        {

            //AudioManager.Instance.StopSFX(sfx);
            //RealmWar.GetInstance().StopEffect(sfx);
        }
    }

    private LevelGuideInfo.LevelGuideData SadGuiVole;
    public LevelGuideInfo.LevelGuideData ValidOffer(int CurStep)
    {
        if (LevelGuideInfo.OfferGap.ContainsKey(CurStep))
        {
            SadGuiVole = LevelGuideInfo.OfferGap[CurStep];
        }
        else
        {
            SadGuiVole = null;
        }
        return SadGuiVole;
    }

    public void StifleTranslation(RectTransform ObjRect)
    {
        //ObjRect.localScale = new Vector2((float)Screen.width / 1080, (float)Screen.width / 1080);
    }

    public List<string> TariffTie(int wantNum, int dataCount)
    {
        System.Random random = new System.Random();
        HashSet<int> values = new HashSet<int>();
        List<string> list = new List<string>();
        int n;
        while (values.Count < wantNum)
        {
            n = random.Next(0, dataCount);

            if (values.Add(n))
            {
                list.Add(n.ToString());
            }
        }
        return list;
    }
}

public class RewardPanelData
{
    /// <summary>
    /// 小游戏类型
    /// </summary>
    public string AcidCare;
    public Dictionary<RewardType, double> Gap_Module;

    public RewardPanelData()
    {
        Gap_Module = new();
    }
}






