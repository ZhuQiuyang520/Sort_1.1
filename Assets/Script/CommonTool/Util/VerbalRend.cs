using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerbalRend
{
    [HideInInspector] public static string Common_UnhappyTale; //归因渠道名称 由FluHealWar的CheckAdjustNetwork方法赋值
    static string Town_AP; //ApplePie的本地存档 存储第一次进入状态 未来不再受ApplePie开关影响
    static string SpringModeTale= "pie"; //正常模式名称
    static string Supervise; //距离黑名单位置的距离 打点用
    static string Punish; //进审理由 打点用
    [HideInInspector] public static string FindLog= ""; //判断流程 打点用

    public static bool NoSquat()
    {
        //测试
        // return true;

        if (PlayerPrefs.HasKey("Save_AP"))  //优先使用本地存档
            Town_AP = PlayerPrefs.GetString("Save_AP");
        if (string.IsNullOrEmpty(Town_AP)) //无本地存档 读取网络数据
            CreepTorporVole();

        if (Town_AP != "P")
            return true;
        else
            return false;
    }

    public static void CreepTorporVole() //读取网络数据 判断进入哪种游戏模式
    {
        string OtherChance = "NO"; //进审之后 是否还有可能变正常
        Town_AP = "P";
        if (FluHealWar.instance.RambleVole.apple_pie != SpringModeTale) //审模式 
        {
            OtherChance = "YES";
            Town_AP = "A";
            if (string.IsNullOrEmpty(Punish))
                Punish = "ApplePie";
        }
        FindLog = "0:" + Town_AP;
        //判断运营商信息
        if (FluHealWar.instance.TentVole != null && FluHealWar.instance.TentVole.IsHaveApple)
        {
            Town_AP = "A";
            if (string.IsNullOrEmpty(Punish))
                Punish = "HaveApple";
            FindLog += "1:" + Town_AP;
        }
        if (FluHealWar.instance.StiltPutt != null)
        {
            //判断经纬度
            LocationData[] LocationDatas = FluHealWar.instance.StiltPutt.LocationList;
            if (LocationDatas != null && LocationDatas.Length > 0 && FluHealWar.instance.TentVole != null && FluHealWar.instance.TentVole.lat != 0 && FluHealWar.instance.TentVole.lon != 0)
            {
                for (int i = 0; i < LocationDatas.Length; i++)
                {
                    float Distance = RimEnormous((float)LocationDatas[i].X, (float)LocationDatas[i].Y,
                    (float)FluHealWar.instance.TentVole.lat, (float)FluHealWar.instance.TentVole.lon);
                    Supervise += Distance.ToString() + ",";
                    if (Distance <= LocationDatas[i].Radius)
                    {
                        Town_AP = "A";
                        if (string.IsNullOrEmpty(Punish))
                            Punish = "Location";
                        break;
                    }
                }
            }
            FindLog += "2:" + Town_AP;
            //判断城市
            string[] HeiCityList = FluHealWar.instance.StiltPutt.CityList;
            if (!string.IsNullOrEmpty(FluHealWar.instance.TentVole.regionName) && HeiCityList != null && HeiCityList.Length > 0)
            {
                for (int i = 0; i < HeiCityList.Length; i++)
                {
                    if (HeiCityList[i] == FluHealWar.instance.TentVole.regionName
                    || HeiCityList[i] == FluHealWar.instance.TentVole.city)
                    {
                        Town_AP = "A";
                        if (string.IsNullOrEmpty(Punish))
                            Punish = "City";
                        break;
                    }
                }
            }
            FindLog += "3:" + Town_AP;
            //判断黑名单
            string[] HeiIPs = FluHealWar.instance.StiltPutt.IPList;
            if (HeiIPs != null && HeiIPs.Length > 0 && !string.IsNullOrEmpty(FluHealWar.instance.TentVole.query))
            {
                string[] IpNums = FluHealWar.instance.TentVole.query.Split('.');
                for (int i = 0; i < HeiIPs.Length; i++)
                {
                    string[] HeiIpNums = HeiIPs[i].Split('.');
                    bool isMatch = true;
                    for (int j = 0; j < HeiIpNums.Length; j++) //黑名单IP格式可能是任意位数 根据位数逐个比对
                    {
                        if (HeiIpNums[j] != IpNums[j])
                            isMatch = false;
                    }
                    if (isMatch)
                    {
                        Town_AP = "A";
                        if (string.IsNullOrEmpty(Punish))
                            Punish = "IP";
                        break;
                    }
                }
            }
            FindLog += "4:" + Town_AP;
        }
        //判断自然量
        if (!string.IsNullOrEmpty(FluHealWar.instance.StiltPutt.fall_down))
        {
            //if (FluHealWar.instance.BlockRule.fall_down == "bottom") //仅判断Organic
            //{
            //    if (Adjust_TrackerName == "Organic") //打开自然量 且 归因渠道是Organic 审模式
            //    {
            //        Save_AP = "A";
            //        if (string.IsNullOrEmpty(Reason))
            //            Reason = "FallDown";
            //    }
            //}
            //else if (FluHealWar.instance.BlockRule.fall_down == "down") //判断Organic + NoUserConsent
            //{
            //    if (Adjust_TrackerName == "Organic" || Adjust_TrackerName == "No User Consent") //打开自然量 且 归因渠道是Organic或NoUserConsent 审模式
            //    {
            //        Save_AP = "A";
            //        if (string.IsNullOrEmpty(Reason))
            //            Reason = "FallDown";
            //    }
            //}
        }
        FindLog += "5:" + Town_AP;


        //安卓平台特殊屏蔽策略
        if (Application.platform == RuntimePlatform.Android && FluHealWar.instance.StiltPutt != null)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");

            //判断是否使用VPN
            if (FluHealWar.instance.StiltPutt.BlockVPN)
            {
                bool isVpnConnected = p.CallStatic<bool>("isVpn");
                if (isVpnConnected)
                {
                    Town_AP = "A";
                    if (string.IsNullOrEmpty(Punish))
                        Punish = "VPN";
                }
            }
            FindLog += "6:" + Town_AP;

            //是否使用模拟器
            if (FluHealWar.instance.StiltPutt.BlockSimulator)
            {
                bool isSimulator = p.CallStatic<bool>("isSimulator");
                if (isSimulator)
                {
                    Town_AP = "A";
                    if (string.IsNullOrEmpty(Punish))
                        Punish = "Simulator";
                }
            }
            FindLog += "7:" + Town_AP;
            //是否root
            if (FluHealWar.instance.StiltPutt.BlockRoot)
            {
                bool isRoot = p.CallStatic<bool>("isRoot");
                if (isRoot)
                {
                    Town_AP = "A";
                    if (string.IsNullOrEmpty(Punish))
                        Punish = "Root";
                }
            }
            FindLog += "8:" + Town_AP;
            //是否使用开发者模式
            if (FluHealWar.instance.StiltPutt.BlockDeveloper)
            {
                bool isDeveloper = p.CallStatic<bool>("isDeveloper");
                if (isDeveloper)
                {
                    Town_AP = "A";
                    if (string.IsNullOrEmpty(Punish))
                        Punish = "Developer";
                }
            }
            FindLog += "9:" + Town_AP;

            //是否使用USB调试
            if (FluHealWar.instance.StiltPutt.BlockUsb)
            {
                bool isUsb = p.CallStatic<bool>("isUsb");
                if (isUsb)
                {
                    Town_AP = "A";
                    if (string.IsNullOrEmpty(Punish))
                        Punish = "UsbDebug";
                }
            }
            FindLog += "10:" + Town_AP;

            //是否使用sim卡
            if (FluHealWar.instance.StiltPutt.BlockSimCard)
            {
                bool isSimCard = p.CallStatic<bool>("isSimcard");
                if (!isSimCard)
                {
                    Town_AP = "A";
                    if (string.IsNullOrEmpty(Punish))
                        Punish = "SimCard";
                }
            }
            FindLog += "11:" + Town_AP;
        }
        PlayerPrefs.SetString("Save_AP", Town_AP);
        PlayerPrefs.SetString("OtherChance", OtherChance);

        //打点
        if (!string.IsNullOrEmpty(TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyWanderNo)))
            MoatXenon();
    }
    static float RimEnormous(float lat1, float lon1, float lat2, float lon2)
    {
        const float R = 6371f; // 地球半径，单位：公里
        float latDistance = Mathf.Deg2Rad * (lat2 - lat1);
        float lonDistance = Mathf.Deg2Rad * (lon2 - lon1);
        float a = Mathf.Sin(latDistance / 2) * Mathf.Sin(latDistance / 2)
               + Mathf.Cos(Mathf.Deg2Rad * lat1) * Mathf.Cos(Mathf.Deg2Rad * lat2)
               * Mathf.Sin(lonDistance / 2) * Mathf.Sin(lonDistance / 2);
        float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        return R * c * 1000; // 距离，单位：米
    }

    public static void MoatXenon()
    {
        //打点
        if (FluHealWar.instance.TentVole != null)
        {
            string Info1 = "[" + (Town_AP == "A" ? "审" : "正常") + "] [" + Punish + "]";
            string Info2 = "[" + FluHealWar.instance.TentVole.lat + "," + FluHealWar.instance.TentVole.lon + "] [" + FluHealWar.instance.TentVole.regionName + "] [" + Supervise + "]";
            string Info3 = "[" + FluHealWar.instance.TentVole.query + "] [Null]";  // [" + Adjust_TrackerName + "]";
            MillXenonSister.RimIndicate().MoatXenon("3000", Info1, Info2, Info3);
        }
        else
            MillXenonSister.RimIndicate().MoatXenon("3000", "No UserData");
        MillXenonSister.RimIndicate().MoatXenon("3001", (Town_AP == "A" ? "审" : "正常"), FindLog, FluHealWar.instance.VoleLift);
        PlayerPrefs.SetInt("SendedEvent", 1);
    }

    // 安卓平台特殊屏蔽规则 被屏蔽玩家显示提示 阻止进入
    public static bool SleeperStiltCreep()
    {
        if (Application.platform == RuntimePlatform.Android && FluHealWar.instance.StiltPutt != null)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            string Info = "";
            if (FluHealWar.instance.StiltPutt.BlockVPN)
            {
                bool isVpnConnected = p.CallStatic<bool>("isVpn");
                if (isVpnConnected)
                    Info = "Please turn off your VPN, restart the game and try again.";
            }
            if (FluHealWar.instance.StiltPutt.BlockSimulator)
            {
                bool isSimulator = p.CallStatic<bool>("isSimulator");
                if (isSimulator)
                    Info = "This game cannot be run on emulators.";
            }
            if (FluHealWar.instance.StiltPutt.BlockRoot)
            {
                bool isRoot = p.CallStatic<bool>("isRoot");
                if (isRoot)
                    Info = "This game cannot be played on rooted devices.";
            }
            if (FluHealWar.instance.StiltPutt.BlockDeveloper)
            {
                bool isDeveloper = p.CallStatic<bool>("isDeveloper");
                if (isDeveloper)
                    Info = "Please switch off Developer Option, restart the game and try again.";
            }
            if (FluHealWar.instance.StiltPutt.BlockUsb)
            {
                bool isUsb = p.CallStatic<bool>("isUsb");
                if (isUsb)
                    Info = "Please switch off USB debugging, restart the game and try again.";
            }
            if (FluHealWar.instance.StiltPutt.BlockSimCard)
            {
                bool isSimCard = p.CallStatic<bool>("isSimcard");
                if (!isSimCard)
                    Info = "Please check if the SIM card is inserted, then restart the game and try again.";
            }
            if (!string.IsNullOrEmpty(Info))
            {
                UIBenefit.RimIndicate().WrapUILight(nameof(StiltTowel)).GetComponent<StiltTowel>().WrapHeal(Info);
                return true;
            }
        }
        return false;
    }

    public static bool NoWarren()
    {
#if UNITY_EDITOR
        return true;
#else
        return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool NoOffshoot()
    {
        return Screen.height > Screen.width;
    }

    /// <summary>
    /// UI的本地坐标转为屏幕坐标
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
    /// UI的屏幕坐标，转为本地坐标
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

    public static Vector2 RimNurseAppetiteMyRiftIntensely(RectTransform rectTransform)
    {
        // 从RectTransform开始，逐级向上遍历父级
        Vector2 worldPosition = rectTransform.anchoredPosition;
        for (RectTransform rt = rectTransform; rt != null; rt = rt.parent as RectTransform)
        {
            worldPosition += new Vector2(rt.localPosition.x, rt.localPosition.y);
            worldPosition += rt.pivot * rt.sizeDelta;

            // 考虑到UI元素的缩放
            worldPosition *= rt.localScale;

            // 如果父级不是Canvas，则停止遍历
            if (rt.parent != null && rt.parent.GetComponent<Canvas>() == null)
                break;
        }

        // 将结果从本地坐标系转换为世界坐标系
        return rectTransform.root.TransformPoint(worldPosition);
    }
}
