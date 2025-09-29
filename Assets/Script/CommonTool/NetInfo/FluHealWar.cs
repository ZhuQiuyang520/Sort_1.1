/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
using com.adjust.sdk;
//using MoreMountains.NiceVibrations;

public class FluHealWar : MonoBehaviour
{

    public static FluHealWar instance;
    //请求超时时间
    private static float TIMEOUT= 3f;
[UnityEngine.Serialization.FormerlySerializedAs("BaseUrl")]    //base
    public string RoarMar;
[UnityEngine.Serialization.FormerlySerializedAs("BaseLoginUrl")]    //登录url
    public string RoarAdaptMar;
[UnityEngine.Serialization.FormerlySerializedAs("BaseConfigUrl")]    //配置url
    public string RoarRambleMar;
[UnityEngine.Serialization.FormerlySerializedAs("BaseTimeUrl")]    //时间戳url
    public string RoarShowMar;
[UnityEngine.Serialization.FormerlySerializedAs("BaseAdjustUrl")]    //更新AdjustId url
    public string RoarCommonMar;
[UnityEngine.Serialization.FormerlySerializedAs("GameCode")]    //后台gamecode
    public string BoneLuce= "21277";
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]
    //channel渠道平台
#if UNITY_IOS
    public string Subsidy= "iOS";
#elif UNITY_ANDROID
    public string Channel = "Android";
#else
    public string Channel = "Other";
#endif
    //工程包名
    private string SecrecyTale{ get { return Application.identifier; } }
    //登录url
    private string AdaptMar= "";
    //配置url
    private string RambleMar= "";
    //更新AdjustId url
    private string CommonMar= "";
[UnityEngine.Serialization.FormerlySerializedAs("country")]    //国家
    public string Kingdom= "";
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]    //服务器Config数据
    public ServerData RambleVole;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    //游戏内数据
    public Init JadeVole;
[UnityEngine.Serialization.FormerlySerializedAs("GameData")]    public Game_Data BoneVole;
[UnityEngine.Serialization.FormerlySerializedAs("LevelConfigData")]    //public Task_Data TaskData;
    public List<LevelConfig> ValidRambleVole;
[UnityEngine.Serialization.FormerlySerializedAs("LevelList")]    public List<LevelInfo> ValidHard;
[UnityEngine.Serialization.FormerlySerializedAs("adManager")]    //ADBenefit
    public GameObject OfBenefit;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("gaid")]    public string Afar;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("aid")]    public string Mar;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("idfa")]    public string Head;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("DataFrom")]public string VoleLift; //数据来源 打点用
    int Prone_Plank= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ready")]    public bool Prone= false;
[UnityEngine.Serialization.FormerlySerializedAs("BlockRule")]    public BlockRuleData StiltPutt;
[UnityEngine.Serialization.FormerlySerializedAs("CashOut_Data")]    //提现相关后台数据
    public CashOutData WoadHow_Vole;
    //ios 获取idfa函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void getIDFA();
#endif

    void Awake()
    {
        instance = this;
        AdaptMar = RoarAdaptMar + BoneLuce + "&channel=" + Subsidy + "&version=" + Application.version;
        RambleMar = RoarRambleMar + BoneLuce + "&channel=" + Subsidy + "&version=" + Application.version;
        CommonMar = RoarCommonMar + BoneLuce;
        Application.targetFrameRate = 60; // 锁定300帧 
    }
    private void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            p.Call("getGaid");
            p.Call("getAid");

        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS
            //Login();
            getIDFA();
            string idfv = UnityEngine.iOS.Device.vendorIdentifier;
            TownVoleBenefit.YamSyntax("idfv", idfv);
#endif
        }
        else
        {
            Adapt();           //编辑器登录
        }
        //获取config数据
        RimRambleVole();
        //提现登录
        CashOutManager.RimIndicate().Login();
    }

    /// <summary>
    /// 获取gaid回调
    /// </summary>
    /// <param name="gaid_str"></param>
    public void gaidAction(string gaid_str)
    {
        Debug.Log("unity收到gaid：" + gaid_str);
        Afar = gaid_str;
        if (Afar == null || Afar == "")
        {
            Afar = TownVoleBenefit.RimSyntax("gaid");
        }
        else
        {
            TownVoleBenefit.YamSyntax("gaid", Afar);
        }
        Prone_Plank++;
        if (Prone_Plank == 2)
        {
            Adapt();
        }
    }
    /// <summary>
    /// 获取aid回调
    /// </summary>
    /// <param name="aid_str"></param>
    public void aidAction(string aid_str)
    {
        Debug.Log("unity收到aid：" + aid_str);
        Mar = aid_str;
        if (Mar == null || Mar == "")
        {
            Mar = TownVoleBenefit.RimSyntax("aid");
        }
        else
        {
            TownVoleBenefit.YamSyntax("aid", Mar);
        }
        Prone_Plank++;
        if (Prone_Plank == 2)
        {
            Adapt();
        }
    }
    /// <summary>
    /// 获取idfa成功
    /// </summary>
    /// <param name="message"></param>
    public void idfaSuccess(string message)
    {
        Debug.Log("idfa success:" + message);
        Head = message;
        TownVoleBenefit.YamSyntax("idfa", Head);
        Adapt();
    }
    /// <summary>
    /// 获取idfa失败
    /// </summary>
    /// <param name="message"></param>
    public void idfaFail(string message)
    {
        Debug.Log("idfa fail");
        Head = TownVoleBenefit.RimSyntax("idfa");
        Adapt();
    }
    /// <summary>
    /// 登录
    /// </summary>
    public void Adapt()
    {
        //提现登录
        //CashOutManager.GetInstance().Login();
        //获取本地缓存的Local用户ID
        string localId = TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyTentId);

        //没有用户ID，视为新用户，生成用户ID
        if (localId == "" || localId.Length == 0)
        {
            //生成用户随机id
            TimeSpan st = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timeStr = Convert.ToInt64(st.TotalSeconds).ToString() + UnityEngine.Random.Range(0, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString();
            localId = timeStr;
            TownVoleBenefit.YamSyntax(CRamble.Dy_EnjoyTentId, localId);
        }

        //拼接登录接口参数
        string url = "";
        if (Application.platform == RuntimePlatform.IPhonePlayer)       //一个参数 - iOS
        {
            url = AdaptMar + "&" + "randomKey" + "=" + localId + "&idfa=" + Head + "&packageName=" + SecrecyTale;
        }
        else if (Application.platform == RuntimePlatform.Android)  //两个参数 - Android
        {
            url = AdaptMar + "&" + "randomKey" + "=" + localId + "&gaid=" + Afar + "&androidId=" + Mar + "&packageName=" + SecrecyTale;
        }
        else //编辑器
        {
            url = AdaptMar + "&" + "randomKey" + "=" + localId + "&packageName=" + SecrecyTale;
        }

        //获取国家信息
        WedPrecede(() => {
            url += "&country=" + Kingdom;
            //登录请求
            FluOntoBenefit.RimIndicate().DecoRim(url,
                (data) => {
                    Debug.Log("Login 成功" + data.downloadHandler.text);
                    TownVoleBenefit.YamSyntax("init_time", DateTime.Now.ToString());
                    ServerUserData serverUserData = JsonMapper.ToObject<ServerUserData>(data.downloadHandler.text);
                    TownVoleBenefit.YamSyntax(CRamble.Dy_EnjoyWanderNo, serverUserData.data.ToString());

                    MoatCommonFlat();
                    if (PlayerPrefs.GetInt("SendedEvent") != 1 && !String.IsNullOrEmpty(VerbalRend.FindLog))
                        VerbalRend.MoatXenon();
                },
                () => {
                    Debug.Log("Login 失败");
                });
        });
    }
    /// <summary>
    /// 获取国家
    /// </summary>
    /// <param name="cb"></param>
    private void WedPrecede(Action cb)
    {
        bool callBackReady = false;
        if (String.IsNullOrEmpty(Kingdom))
        {
            ////获取国家超时返回
            //StartCoroutine(NetWorkTimeOut(() =>
            //{
            //    if (!callBackReady)
            //    {
            //        country = "";
            //        callBackReady = true;
            //        cb?.Invoke();
            //    }
            //}));
            FluOntoBenefit.RimIndicate().DecoRim("https://a.mafiagameglobal.com/event/country/", (data) =>
            {
                Kingdom = JsonMapper.ToObject<Dictionary<string, string>>(data.downloadHandler.text)["country"];
                Debug.Log("获取国家 成功:" + Kingdom);
                if (!callBackReady)
                {
                    callBackReady = true;
                    cb?.Invoke();
                }
            },
            () => {
                Debug.Log("获取国家 失败");
                if (!callBackReady)
                {
                    Kingdom = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            });
        }
        else
        {
            if (!callBackReady)
            {
                callBackReady = true;
                cb?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取服务器Config数据
    /// </summary>
    private void RimRambleVole()
    {
        Debug.Log("GetConfigData:" + RambleMar);
        //StartCoroutine(NetWorkTimeOut(() =>
        //{
        //    GetLoactionData();
        //}));

        //获取并存入Config
        FluOntoBenefit.RimIndicate().DecoRim(RambleMar,
        (data) => {
            VoleLift = "OnlineData";
            Debug.Log("ConfigData 成功" + data.downloadHandler.text);
            TownVoleBenefit.YamSyntax("OnlineData", data.downloadHandler.text);
            YamRambleVole(data.downloadHandler.text);
        },
        () => {
            Debug.Log("ConfigData 失败");
            RimUnbrokenVole();
        });
    }

    /// <summary>
    /// 获取本地Config数据
    /// </summary>
    private void RimUnbrokenVole()
    {
        //是否有缓存
        if (TownVoleBenefit.RimSyntax("OnlineData") == "" || TownVoleBenefit.RimSyntax("OnlineData").Length == 0)
        {
            VoleLift = "LocalData_Updated"; //已联网更新过的数据

            Debug.Log("本地数据");
            TextAsset json = Resources.Load<TextAsset>("LocationJson/LocationData");
            YamRambleVole(json.text);
        }
        else
        {
            VoleLift = "LocalData_Original"; //原始数据
            Debug.Log("服务器缓存数据");
            YamRambleVole(TownVoleBenefit.RimSyntax("OnlineData"));
        }
    }


    /// <summary>
    /// 解析config数据
    /// </summary>
    /// <param name="configJson"></param>
    void YamRambleVole(string configJson)
    {
        //如果已经获得了数据则不再处理
        if (RambleVole == null)
        {
            RootData rootData = JsonMapper.ToObject<RootData>(configJson);
            RambleVole = rootData.data;
            switch (TownVoleBenefit.RimSyntax(CRamble.Her_Evidence))
            {
                case "Russian":
                    JadeVole = JsonMapper.ToObject<Init>(RambleVole.init_ru);
                    //TaskData = JsonMapper.ToObject<Task_Data>(ConfigData.task_data_ru);
                    break;
                case "Portuguese (Brazil)":
                    JadeVole = JsonMapper.ToObject<Init>(RambleVole.init_br);
                    //TaskData = JsonMapper.ToObject<Task_Data>(ConfigData.task_data_br);
                    break;
                case "Japanese":
                    JadeVole = JsonMapper.ToObject<Init>(RambleVole.init_jp);
                    //TaskData = JsonMapper.ToObject<Task_Data>(ConfigData.task_data_jp);
                    break;
                case "English":
                    JadeVole = JsonMapper.ToObject<Init>(RambleVole.init_us);
                    //TaskData = JsonMapper.ToObject<Task_Data>(ConfigData.task_data_us);
                    break;
                default:
                    JadeVole = JsonMapper.ToObject<Init>(RambleVole.init);
                    //TaskData = JsonMapper.ToObject<Task_Data>(ConfigData.task_data);
                    break;
            }
            BoneVole = JsonMapper.ToObject<Game_Data>(RambleVole.GameData);
            ValidRambleVole = JsonMapper.ToObject<List<LevelConfig>>(RambleVole.LevelData);
            ValidHard = JsonMapper.ToObject<List<LevelInfo>>(RambleVole.level_change);
            if (!string.IsNullOrEmpty(RambleVole.BlockRule))
                StiltPutt = JsonMapper.ToObject<BlockRuleData>(RambleVole.BlockRule);
            if (!string.IsNullOrEmpty(RambleVole.CashOut_Data))
                WoadHow_Vole = JsonMapper.ToObject<CashOutData>(RambleVole.CashOut_Data);
            RimTentHeal();
        }
    }
    /// <summary>
    /// 进入游戏
    /// </summary>
    void BoneTough()
    {
        //打开admanager
        OfBenefit.SetActive(true);
        //进度条可以继续
        Prone = true;
    }



    ///// <summary>
    ///// 超时处理
    ///// </summary>
    ///// <param name="finish"></param>
    ///// <returns></returns>
    //IEnumerator NetWorkTimeOut(Action finish)
    //{
    //    yield return new WaitForSeconds(TIMEOUT);
    //    finish();
    //}

    /// <summary>
    /// 向后台发送adjustId
    /// </summary>
    public void MoatCommonFlat()
    {
        string serverId = TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyWanderNo);
        string adjustId = CommonJadeBenefit.Instance.RimCommonFlat();
        if (string.IsNullOrEmpty(serverId) || string.IsNullOrEmpty(adjustId))
        {
            return;
        }

        string url = CommonMar + "&serverId=" + serverId + "&adid=" + adjustId;
        FluOntoBenefit.RimIndicate().DecoRim(url,
            (data) => {
                Debug.Log("服务器更新adjust adid 成功" + data.downloadHandler.text);
            },
            () => {
                Debug.Log("服务器更新adjust adid 失败");
            });
        CashOutManager.RimIndicate().ReportAdjustID();
    }
[UnityEngine.Serialization.FormerlySerializedAs("UserDataStr")]
    ////轮询检查Adjust归因信息
    //int CheckCount = 0;
    //[HideInInspector] public string Event_TrackerName; //打点用参数
    //bool _CheckOk = false;
    //[HideInInspector]
    //public bool AdjustTracker_Ready //是否成功获取到归因信息
    //{
    //    get
    //    {
    //        if (Application.isEditor) //编译器跳过检查
    //            return true;
    //        return _CheckOk;
    //    }
    //}
    //public void CheckAdjustNetwork() //检查Adjust归因信息
    //{
    //    if (Application.isEditor) //编译器跳过检查
    //        return;
    //    if (!string.IsNullOrEmpty(Event_TrackerName)) //已经拿到归因信息
    //        return;


    //    CancelInvoke(nameof(CheckAdjustNetwork));
    //    if (!string.IsNullOrEmpty(ConfigData.fall_down) && ConfigData.fall_down == "fall")
    //    {
    //        print("Adjust 无归因相关配置或未联网 跳过检查");
    //        _CheckOk = true;
    //    }
    //    try
    //    {
    //        AdjustAttribution Info = Adjust.getAttribution();
    //        print("Adjust 获取信息成功 归因渠道：" + Info.trackerName);
    //        Event_TrackerName = "TrackerName: " + Info.trackerName;
    //        VerbalRend.Adjust_TrackerName = Info.trackerName;
    //        _CheckOk = true;
    //    }
    //    catch (System.Exception e)
    //    {
    //        CheckCount++;
    //        Debug.Log("Adjust 获取信息失败：" + e.Message + " 重试次数：" + CheckCount);
    //        if (CheckCount >= 10)
    //            _CheckOk = true;
    //        Invoke(nameof(CheckAdjustNetwork), 1);
    //    }
    //}


    //获取用户信息
    public string TentVoleFan= "";
[UnityEngine.Serialization.FormerlySerializedAs("UserData")]    public UserInfoData TentVole;
    int RimTentHealCreep= 0;
    void RimTentHeal()
    {
        //还有进入正常模式的可能
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "YES")
            PlayerPrefs.DeleteKey("Save_AP");
        //已经记录过用户信息 跳过检查
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "NO")
        {
            BoneTough();
            return;
        }

        //检查归因渠道信息
        //CheckAdjustNetwork();
        //获取用户信息
        string CheckUrl = RoarMar + "/api/client/user/checkUser";
        FluOntoBenefit.RimIndicate().DecoRim(CheckUrl,
        (data) =>
        {
            TentVoleFan = data.downloadHandler.text;
            print("+++++ 获取用户数据 成功" + TentVoleFan);
            UserRootData rootData = JsonMapper.ToObject<UserRootData>(TentVoleFan);
            TentVole = JsonMapper.ToObject<UserInfoData>(rootData.data);
            if (TentVoleFan.Contains("apple")
            || TentVoleFan.Contains("Apple")
            || TentVoleFan.Contains("APPLE"))
                TentVole.IsHaveApple = true;
            BoneTough();
        }, () => { });
        Invoke(nameof(OxRimTentHeal), 1);
    }
    void OxRimTentHeal()
    {
        if (!Prone)
        {
            RimTentHealCreep++;
            if (RimTentHealCreep < 10)
            {
                print("+++++ 获取用户数据失败 重试： " + RimTentHealCreep);
                RimTentHeal();
            }
            else
            {
                print("+++++ 获取用户数据 失败次数过多，放弃");
                BoneTough();
            }
        }
    }
}
