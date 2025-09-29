using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using com.adjust.sdk;
using LitJson;

public class ADBenefit : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("MAX_SDK_KEY")]    public string MAX_SDK_KEY= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_REWARD_ID")]    public string MAX_REWARD_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_INTER_ID")]    public string MAX_INTER_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("isTest")]
    public bool ByRole= false;
    public static ADBenefit Indicate{ get; private set; }

    private int AlienWorkday;   // 广告加载失败后，重新加载广告次数
    private bool ByCouncilMe;     // 是否正在播放广告，用于判断切换前后台时是否增加计数

    public int HaleBodeShowBooklet{ get; private set; }   // 距离上次广告的时间间隔
    public int Fanwise101{ get; private set; }     // 定时插屏(101)计数器
    public int Fanwise102{ get; private set; }     // NoThanks插屏(102)计数器
    public int Fanwise103{ get; private set; }     // 后台回前台插屏(103)计数器

    private string SpinetUnknownTale;
    private Action<bool> SpinetGermHuntFiring;    // 激励视频回调
    private bool SpinetNouveau;     // 激励视频是否成功收到奖励
    private string SpinetFresh;     // 激励视频的打点

    private string TessellationUnknownTale;
    private int TessellationCare;      // 当前播放的插屏类型，101/102/103
    private string TessellationFresh;     // 插屏广告的的打点
    public bool SweetShowImprisonment{ get; private set; } // 定时插屏暂停播放

    private List<Action<ADType>> OfGinghamGibraltar;    // 广告播放完成回调列表，用于其他系统广告计数（例如商店看广告任务）

    private long SubtractivePanelViewpoint;     // 切后台时的时间戳
    private Ad_CustomData ModuleMeOliverVole; //激励视频自定义数据
    private Ad_CustomData ImprisonmentMeOliverVole; //插屏自定义数据

    private void Awake()
    {
        Indicate = this;
    }

    private void OnEnable()
    {
        SweetShowImprisonment = false;
        ByCouncilMe = false;
        HaleBodeShowBooklet = 999;  // 初始时设置一个较大的值，不阻塞插屏广告
        SpinetNouveau = false;

        // Android平台将Adjust的adid传给Max；iOS将randomKey传给Max
#if UNITY_ANDROID
        MaxSdk.SetSdkKey(RimSystemVole.DecryptDES(MAX_SDK_KEY));
        // 将adjust id 传给Max
        string adjustId = TownVoleBenefit.GetString(CRamble.sv_AdjustAdid);
        if (string.IsNullOrEmpty(adjustId))
        {
            adjustId = Adjust.getAdid();
        }
        if (!string.IsNullOrEmpty(adjustId))
        {
            MaxSdk.SetUserId(adjustId);
            MaxSdk.InitializeSdk();
            TownVoleBenefit.SetString(CRamble.sv_AdjustAdid, adjustId);
        }
        else
        {
            StartCoroutine(setAdjustAdid());
        }
#else
        MaxSdk.SetSdkKey(RimSystemVole.SomedayDES(MAX_SDK_KEY));
        MaxSdk.SetUserId(TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyTentId));
        MaxSdk.InitializeSdk();
#endif

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
        {
            // 打开调试模式
            //MaxSdk.ShowMediationDebugger();

            PolynesianSaturateJob();
            MaxSdk.SetCreativeDebuggerEnabled(true);

            // 每秒执行一次计数
            InvokeRepeating(nameof(MarvelNorway), 1, 1);
        };
    }

    IEnumerator IllCommonFlat()
    {
        int i = 0;
        while (i < 5)
        {
            yield return new WaitForSeconds(1);
            if (VerbalRend.NoWarren())
            {
                MaxSdk.SetUserId(TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyTentId));
                MaxSdk.InitializeSdk();
                yield break;
            }
            else
            {
                string adjustId = Adjust.getAdid();
                if (!string.IsNullOrEmpty(adjustId))
                {
                    MaxSdk.SetUserId(adjustId);
                    MaxSdk.InitializeSdk();
                    TownVoleBenefit.YamSyntax(CRamble.Dy_CommonFlat, adjustId);
                    yield break;
                }
            }
            i++;
        }
        if (i == 5)
        {
            MaxSdk.SetUserId(TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyTentId));
            MaxSdk.InitializeSdk();
        }
    }

    public void PolynesianSaturateJob()
    {
        // Attach callback
        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
        MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
        MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnInterstitialRevenuePaidEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

        // Load the first rewarded ad
        PikeSaturateMe();

        // Load the first interstitial
        PikeImprisonment();
    }

    private void PikeSaturateMe()
    {
        MaxSdk.LoadRewardedAd(MAX_REWARD_ID);
    }

    private void PikeImprisonment()
    {
        MaxSdk.LoadInterstitial(MAX_INTER_ID);
    }

    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is ready for you to show. MaxSdk.IsRewardedAdReady(adUnitId) now returns 'true'.

        // Reset retry attempt
        AlienWorkday = 0;
        SpinetUnknownTale = adInfo.NetworkName;

        ModuleMeOliverVole = new Ad_CustomData();
        ModuleMeOliverVole.user_id = CashOutManager.RimIndicate().Data.UserID;
        ModuleMeOliverVole.version = Application.version;
        ModuleMeOliverVole.request_id = CashOutManager.RimIndicate().EcpmRequestID();
        ModuleMeOliverVole.vendor = adInfo.NetworkName;
    }

    private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Rewarded ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

        AlienWorkday++;
        double retryDelay = Math.Pow(2, Math.Min(6, AlienWorkday));

        Invoke(nameof(PikeSaturateMe), (float)retryDelay);
    }

    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        RealmWar.RimIndicate().ItRealmEndure = !RealmWar.RimIndicate().ItRealmEndure;
        Time.timeScale = 0;
#endif
    }

    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
        PikeSaturateMe();
        ByCouncilMe = false;
    }

    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {

    }

    private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is hidden. Pre-load the next ad
#if UNITY_IOS
        Time.timeScale = 1;
        RealmWar.RimIndicate().ItRealmEndure = !RealmWar.RimIndicate().ItRealmEndure;
#endif

        ByCouncilMe = false;
        PikeSaturateMe();
        if (SpinetNouveau)
        {
            SpinetNouveau = false;
            SpinetGermHuntFiring?.Invoke(true);

            SlothMeBodeNouveau(ADType.Rewarded);
            MillXenonSister.RimIndicate().MoatXenon("9007", SpinetFresh);
        }
        else
        {
            SpinetGermHuntFiring?.Invoke(false);
        }

        // 上报ecpm
        CashOutManager.RimIndicate().ReportEcpm(adInfo, ModuleMeOliverVole.request_id, "REWARD");
    }

    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        // The rewarded ad displayed and the user should receive the reward.
        SpinetNouveau = true;
    }

    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        // Ad revenue paid. Use this callback to track user revenue.
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        MillXenonSister.RimIndicate().MoatXenon("9008", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
        //CommonJadeBenefit.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        string adjustAdid = CommonJadeBenefit.Instance.RimCommonFlat();
        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(adjustAdid))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (rewarded), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Rewarded revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is ready for you to show. MaxSdk.IsInterstitialReady(adUnitId) now returns 'true'

        // Reset retry attempt
        AlienWorkday = 0;
        TessellationUnknownTale = adInfo.NetworkName;

        ImprisonmentMeOliverVole = new Ad_CustomData();
        ImprisonmentMeOliverVole.user_id = CashOutManager.RimIndicate().Data.UserID;
        ImprisonmentMeOliverVole.version = Application.version;
        ImprisonmentMeOliverVole.request_id = CashOutManager.RimIndicate().EcpmRequestID();
        ImprisonmentMeOliverVole.vendor = adInfo.NetworkName;
    }

    private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Interstitial ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds)

        AlienWorkday++;
        double retryDelay = Math.Pow(2, Math.Min(6, AlienWorkday));

        Invoke(nameof(PikeImprisonment), (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        RealmWar.RimIndicate().ItRealmEndure = !RealmWar.RimIndicate().ItRealmEndure;
        Time.timeScale = 0;
#endif
    }

    private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad failed to display. AppLovin recommends that you load the next ad.
        PikeImprisonment();
        ByCouncilMe = false;
    }

    private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        MillXenonSister.RimIndicate().MoatXenon("9108", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
        //CommonJadeBenefit.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(CommonJadeBenefit.Instance.RimCommonFlat()))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (interstitial), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        string adjustAdid = CommonJadeBenefit.Instance.RimCommonFlat();
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Interstitial revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is hidden. Pre-load the next ad.
#if UNITY_IOS
        Time.timeScale = 1;
        RealmWar.RimIndicate().ItRealmEndure = !RealmWar.RimIndicate().ItRealmEndure;
#endif
        PikeImprisonment();

        SlothMeBodeNouveau(ADType.Interstitial);
        MillXenonSister.RimIndicate().MoatXenon("9107", TessellationFresh);
        // 上报ecpm
        CashOutManager.RimIndicate().ReportEcpm(adInfo, ImprisonmentMeOliverVole.request_id, "INTER");
    }


    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    /// <param name="callBack"></param>
    /// <param name="index"></param>
    public void PineModuleProwl(Action<bool> callBack, string index)
    {
        if (ByRole)
        {
            callBack(true);
            SlothMeBodeNouveau(ADType.Rewarded);
            return;
        }

        bool rewardVideoReady = MaxSdk.IsRewardedAdReady(MAX_REWARD_ID);
        SpinetGermHuntFiring = callBack;
        if (rewardVideoReady)
        {
            // 打点
            SpinetFresh = index;
            MillXenonSister.RimIndicate().MoatXenon("9002", index);
            ByCouncilMe = true;
            SpinetNouveau = false;
            string placement = index + "_" + SpinetUnknownTale;
            ModuleMeOliverVole.placement_id = placement;
            MaxSdk.ShowRewardedAd(MAX_REWARD_ID, placement, JsonMapper.ToJson(ModuleMeOliverVole));
        }
        else
        {
            TruthBenefit.RimIndicate().WrapTruth("No ads right now, please try it later.");
            SpinetGermHuntFiring(false);
        }
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index"></param>
    public void PineImprisonmentMe(int index)
    {
        if (index == 101 || index == 102 || index == 103)
        {
            UnityEngine.Debug.LogError("广告点位不允许为101、102、103");
            return;
        }

        PineImprisonment(index);
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index">101/102/103</param>
    /// <param name="customIndex">用户自定义点位</param>
    private void PineImprisonment(int index, int customIndex = 0)
    {
        MillXenonSister.RimIndicate().MoatXenon("9101", index.ToString());
        TessellationCare = index;
        if (ByCouncilMe)
        {
            return;
        }

        //这个参数很少有游戏会用 需要的时候自己再打开
        // 当用户过关数 < trial_MaxNum时，不弹插屏广告
        // int sv_trialNum = TownVoleBenefit.GetInt(CRamble.sv_ad_trial_num);
        // int trial_MaxNum = int.Parse(FluHealWar.instance.ConfigData.trial_MaxNum);
        // if (sv_trialNum < trial_MaxNum)
        // {
        //     return;
        // }
        // 时间间隔低于阈值，不播放广告
        if (HaleBodeShowBooklet < int.Parse(FluHealWar.instance.RambleVole.inter_freq))
        {
            return;
        }
        

        if (ByRole)
        {
            SlothMeBodeNouveau(ADType.Interstitial);
            return;
        }
        bool interstitialVideoReady = MaxSdk.IsInterstitialReady(MAX_INTER_ID);
        if (interstitialVideoReady)
        {
            ByCouncilMe = true;
            // 打点
            string point = index.ToString();
            if (customIndex > 0)
            {
                point += customIndex.ToString().PadLeft(2, '0');
            }
            TessellationFresh = point;
            MillXenonSister.RimIndicate().MoatXenon("9102", point);
            string placement = point + "_" + TessellationUnknownTale;
            ImprisonmentMeOliverVole.placement_id = placement;
            MaxSdk.ShowInterstitial(MAX_INTER_ID, placement, JsonMapper.ToJson(ImprisonmentMeOliverVole));
        }
    }

    /// <summary>
    /// 每秒更新一次计数器 - 101计数器 和 时间间隔计数器
    /// </summary>
    private void MarvelNorway()
    {
        HaleBodeShowBooklet++;

        int relax_interval = int.Parse(FluHealWar.instance.RambleVole.relax_interval);
        // 计时器阈值设置为0或负数时，关闭广告101；
        // 播放广告期间不计数；
        if (relax_interval <= 0 || ByCouncilMe)
        {
            return;
        }
        else
        {
            Fanwise101++;
            if (Fanwise101 >= relax_interval && !SweetShowImprisonment)
            {
                PineImprisonment(101);
            }
        }
    }

    /// <summary>
    /// NoThanks插屏 - 102
    /// </summary>
    public void AxFreelyKeyCreep(int customIndex = 0)
    {
        // 用户行为累计次数计数器阈值设置为0或负数时，关闭广告102
        int nextlevel_interval = int.Parse(FluHealWar.instance.RambleVole.nextlevel_interval);
        if (nextlevel_interval <= 0)
        {
            return;
        }
        else
        {
            Fanwise102 = TownVoleBenefit.RimDot("NoThanksCount") + 1;
            TownVoleBenefit.YamDot("NoThanksCount", Fanwise102);
            if (Fanwise102 >= nextlevel_interval)
            {
                PineImprisonment(102, customIndex);
            }
        }
    }

    /// <summary>
    /// 前后台切换计数器 - 103
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            // 切回前台
            if (!ByCouncilMe)
            {
                // 前后台切换时，播放间隔计数器需要累加切到后台的时间
                if (SubtractivePanelViewpoint > 0)
                {
                    HaleBodeShowBooklet += (int)(CureRend.Defense() - SubtractivePanelViewpoint);
                    SubtractivePanelViewpoint = 0;
                }
                // 后台切回前台累计次数，后台配置为0或负数，关闭该广告
                int inter_b2f_count = int.Parse(FluHealWar.instance.RambleVole.inter_b2f_count);
                if (inter_b2f_count <= 0)
                {
                    return;
                }
                else
                {
                    Fanwise103++;
                    if (Fanwise103 >= inter_b2f_count)
                    {
                        PineImprisonment(103);
                    }
                }
            }
        }
        else
        {
            // 切到后台
            SubtractivePanelViewpoint = CureRend.Defense();
        }
    }

    /// <summary>
    /// 暂停定时插屏播放 - 101
    /// </summary>
    public void PanelShowImprisonment()
    {
        SweetShowImprisonment = true;
    }

    /// <summary>
    /// 恢复定时插屏播放 - 101
    /// </summary>
    public void NarrowShowImprisonment()
    {
        SweetShowImprisonment = false;
    }

    /// <summary>
    /// 更新游戏的TrialNum
    /// </summary>
    /// <param name="num"></param>
    public void CanadaTaintTie(int num)
    {
        TownVoleBenefit.YamDot(CRamble.Dy_Of_Crane_Mob, num);
    }

    /// <summary>
    /// 注册看广告的回调事件
    /// </summary>
    /// <param name="callback"></param>
    public void HatcheryBodePretense(Action<ADType> callback)
    {
        if (OfGinghamGibraltar == null)
        {
            OfGinghamGibraltar = new List<Action<ADType>>();
        }

        if (!OfGinghamGibraltar.Contains(callback))
        {
            OfGinghamGibraltar.Add(callback);
        }
    }

    /// <summary>
    /// 广告播放成功后，执行看广告回调事件
    /// </summary>
    private void SlothMeBodeNouveau(ADType adType)
    {
        ByCouncilMe = false;
        // 播放间隔计数器清零
        HaleBodeShowBooklet = 0;
        // 插屏计数器清零
        if (adType == ADType.Interstitial)
        {
            // 计数器清零
            if (TessellationCare == 101)
            {
                Fanwise101 = 0;
            }
            else if (TessellationCare == 102)
            {
                Fanwise102 = 0;
                TownVoleBenefit.YamDot("NoThanksCount", 0);
            }
            else if (TessellationCare == 103)
            {
                Fanwise103 = 0;
            }
        }

        // 看广告总数+1
        TownVoleBenefit.YamDot(CRamble.Dy_Roman_Of_Mob + adType.ToString(), TownVoleBenefit.RimDot(CRamble.Dy_Roman_Of_Mob + adType.ToString()) + 1);
        // 真提现任务 
        if (adType == ADType.Rewarded)
            CashOutManager.RimIndicate().AddTaskValue("Ad",1);

        // 回调
        if (OfGinghamGibraltar != null && OfGinghamGibraltar.Count > 0)
        {
            foreach (Action<ADType> callback in OfGinghamGibraltar)
            {
                callback?.Invoke(adType);
            }
        }
    }

    /// <summary>
    /// 获取总的看广告次数
    /// </summary>
    /// <returns></returns>
    public int RimSplitMeTie(ADType adType)
    {
        return TownVoleBenefit.RimDot(CRamble.Dy_Roman_Of_Mob + adType.ToString());
    }
}

public enum ADType { Interstitial, Rewarded }

[System.Serializable]
public class Ad_CustomData //广告自定义数据
{
    public string user_id; //用户id
    public string version; //版本号
    public string request_id; //请求id
    public string vendor; //渠道
    public string placement_id; //广告位id
}