using System;
using System.Collections;
using com.adjust.sdk;
using LitJson;
using UnityEngine;
using Random = UnityEngine.Random;

public class CommonJadeBenefit : MonoBehaviour
{
    public static CommonJadeBenefit Instance;
[UnityEngine.Serialization.FormerlySerializedAs("adjustID")]
    public string TraderID;     // 由遇总的打包工具统一修改，无需手动配置

    //用户adjust 状态KEY
    private string sv_ADRearJadeCare= "sv_ADJustInitType";

    //adjust 时间戳
    private string Dy_ADRearShow= "sv_ADJustTime";

    //adjust行为计数器
    public int _HexagonCreep{ get; private set; }

    public double _HexagonVibrant{ get; private set; }

    double TraderJadeMeVibrant= 0;


    private void Awake()
    {
        Instance = this;
        TownVoleBenefit.YamSyntax(Dy_ADRearShow, CureRend.Defense().ToString());

#if UNITY_IOS
        TownVoleBenefit.YamSyntax(sv_ADRearJadeCare, AdjustStatus.OpenAsAct.ToString());
        CommonJade();
#endif
    }

    private void Start()
    {
        _HexagonCreep = 0;
    }


    void CommonJade()
    {
#if UNITY_EDITOR
        return;
#endif
        AdjustConfig adjustConfig = new AdjustConfig(TraderID, AdjustEnvironment.Production, false);
        adjustConfig.setLogLevel(AdjustLogLevel.Verbose);
        adjustConfig.setSendInBackground(false);
        adjustConfig.setEventBufferingEnabled(false);
        adjustConfig.setLaunchDeferredDeeplink(true);
        Adjust.start(adjustConfig);

        StartCoroutine(TownCommonFlat());
    }

    private IEnumerator TownCommonFlat()
    {
        while (true)
        {
            string adjustAdid = Adjust.getAdid();
            if (string.IsNullOrEmpty(adjustAdid))
            {
                yield return new WaitForSeconds(5);
            }
            else
            {
                TownVoleBenefit.YamSyntax(CRamble.Dy_CommonFlat, adjustAdid);
                FluHealWar.instance.MoatCommonFlat();
                yield break;
            }
        }
    }

    public string RimCommonFlat()
    {
        return TownVoleBenefit.RimSyntax(CRamble.Dy_CommonFlat);
    }

    /// <summary>
    /// 获取adjust初始化状态
    /// </summary>
    /// <returns></returns>
    public string RimCommonAbrupt()
    {
        return TownVoleBenefit.RimSyntax(sv_ADRearJadeCare);
    }

    /*
     *  API
     *  Adjust 初始化
     */
    public void JadeCommonVole(bool isOldUser = false)
    {
        #if UNITY_IOS
            return;
        #endif
        // 如果后台配置的adjust_init_act_position <= 0，直接初始化
        if (string.IsNullOrEmpty(FluHealWar.instance.RambleVole.adjust_init_act_position) || int.Parse(FluHealWar.instance.RambleVole.adjust_init_act_position) <= 0)
        {
            TownVoleBenefit.YamSyntax(sv_ADRearJadeCare, AdjustStatus.OpenAsAct.ToString());
        }
        print(" user init adjust by status :" + TownVoleBenefit.RimSyntax(sv_ADRearJadeCare));
        //用户二次登录 根据标签初始化
        if (TownVoleBenefit.RimSyntax(sv_ADRearJadeCare) == AdjustStatus.OldUser.ToString() || TownVoleBenefit.RimSyntax(sv_ADRearJadeCare) == AdjustStatus.OpenAsAct.ToString())
        {
            print("second login  and  init adjust");
            CommonJade();
        }
    }



    /*
     * API
     *  记录行为累计次数
     *  @param2 打点参数
     */
    public void KeyLeoCreep(string param2 = "")
    {
#if UNITY_IOS
            return;
#endif
        if (TownVoleBenefit.RimSyntax(sv_ADRearJadeCare) != "") return;
        _HexagonCreep++;
        print(" add up to :" + _HexagonCreep);
        if (string.IsNullOrEmpty(FluHealWar.instance.RambleVole.adjust_init_act_position) || _HexagonCreep == int.Parse(FluHealWar.instance.RambleVole.adjust_init_act_position))
        {
            PikeCommonSoLeo(param2);
        }
    }

    /// <summary>
    /// 记录广告行为累计次数，带广告收入
    /// </summary>
    /// <param name="countryCode"></param>
    /// <param name="revenue"></param>
    public void KeyMeCreep(string countryCode, double revenue)
    {
#if UNITY_IOS
            return;
#endif
        //if (TownVoleBenefit.GetString(sv_ADJustInitType) != "") return;

        _HexagonCreep++;
        _HexagonVibrant += revenue;
        print(" Ads count: " + _HexagonCreep + ", Revenue sum: " + _HexagonVibrant);

        //如果后台有adjust_init_adrevenue数据 且 能找到匹配的countryCode，初始化adjustInitAdRevenue
        if (!string.IsNullOrEmpty(FluHealWar.instance.RambleVole.adjust_init_adrevenue))
        {
            JsonData jd = JsonMapper.ToObject(FluHealWar.instance.RambleVole.adjust_init_adrevenue);
            if (jd.ContainsKey(countryCode))
            {
                TraderJadeMeVibrant = double.Parse(jd[countryCode].ToString(), new System.Globalization.CultureInfo("en-US"));
            }
        }

        if (
            string.IsNullOrEmpty(FluHealWar.instance.RambleVole.adjust_init_act_position)                   //后台没有配置限制条件，直接走LoadAdjust
            || (_HexagonCreep == int.Parse(FluHealWar.instance.RambleVole.adjust_init_act_position)         //累计广告次数满足adjust_init_act_position条件，且累计广告收入满足adjust_init_adrevenue条件，走LoadAdjust
                && _HexagonVibrant >= TraderJadeMeVibrant)
        )
        {
            PikeCommonSoLeo();
        }
    }

    /*
     * API
     * 根据行为 初始化 adjust
     *  @param2 打点参数 
     */
    public void PikeCommonSoLeo(string param2 = "")
    {
        if (TownVoleBenefit.RimSyntax(sv_ADRearJadeCare) != "") return;

        // 根据比例分流   adjust_init_rate_act  行为比例
        if (string.IsNullOrEmpty(FluHealWar.instance.RambleVole.adjust_init_rate_act) || int.Parse(FluHealWar.instance.RambleVole.adjust_init_rate_act) > Random.Range(0, 100))
        {
            print("user finish  act  and  init adjust");
            TownVoleBenefit.YamSyntax(sv_ADRearJadeCare, AdjustStatus.OpenAsAct.ToString());
            CommonJade();

            // 上报点位 新用户达成 且 初始化
            MillXenonSister.RimIndicate().MoatXenon("1091", RimCommonShow(), param2);
        }
        else
        {
            print("user finish  act  and  not init adjust");
            TownVoleBenefit.YamSyntax(sv_ADRearJadeCare, AdjustStatus.CloseAsAct.ToString());
            // 上报点位 新用户达成 且  不初始化
            MillXenonSister.RimIndicate().MoatXenon("1092", RimCommonShow(), param2);
        }
    }

    
    /*
     * API
     *  重置当前次数
     */
    public void WasteLeoCreep()
    {
        print("clear current ");
        _HexagonCreep = 0;
    }


    // 获取启动时间
    private string RimCommonShow()
    {
        return CureRend.Defense() - long.Parse(TownVoleBenefit.RimSyntax(Dy_ADRearShow)) + "";
    }
}


/*
 *@param
 *  OldUser     老用户
 *  OpenAsAct   行为触发且初始化
 *  CloseAsAct  行为触发不初始化
 */
public enum AdjustStatus
{
    OldUser,
    OpenAsAct,
    CloseAsAct
}