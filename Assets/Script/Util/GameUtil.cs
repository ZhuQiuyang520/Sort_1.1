using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtil
{
    /// <summary>
    /// 获取现金系数 不随机
    /// </summary>
    /// <param name="cumulative"></param>
    /// <param name="multiGroup"></param>
    /// <returns></returns>
    private static double GetMultiWithOutRandom(double cumulative, MultiGroup[] multiGroup)
    {
        foreach (MultiGroup item in multiGroup)
        {
            if (item.max > cumulative)
            {
                return item.multi;
            }
        }

        return 1;

    }

    /// <summary>
    /// 获取multi系数
    /// </summary>
    /// <returns></returns>
    private static double GetMulti(RewardType type, double cumulative, MultiGroup[] multiGroup)
    {
        foreach (MultiGroup item in multiGroup)
        {
            if (item.max > cumulative)
            {
                if (type == RewardType.diamand)
                {
                    float random = Random.Range((float)FluHealWar.instance.JadeVole.cash_random[0], (float)FluHealWar.instance.JadeVole.cash_random[1]);
                    return item.multi * (1 + random);
                }
                else
                {
                    return item.multi;
                }
            }
        }
        return 1;
    }
    /// <summary>
    /// 现金金额系数(不含随机cashrandom)
    /// </summary>
    /// <returns></returns>
    public static double GetCashMultiWithOutRandom()
    {
        return GetMultiWithOutRandom(TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionHyper),
            FluHealWar.instance.JadeVole.cash_group);
    }
    public static double GetGoldMulti()
    {
        return GetMulti(RewardType.Gold, TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionCareGene), FluHealWar.instance.JadeVole.gold_group);
    }

    public static double GetCashMulti()
    {
        return GetMulti(RewardType.diamand, TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionHyper), FluHealWar.instance.JadeVole.cash_group);
    }
    //public static double GetAmazonMulti()
    //{
    //    return GetMulti(RewardType.Amazon, TownVoleBenefit.GetDouble(CRamble.sv_CumulativeAmazon), FluHealWar.instance.InitData.amazon_group);
    //}
    /// <summary>
    /// 获取权重系数
    /// </summary>
    /// <param name="cumulative"></param>
    /// <param name="multiGroup"></param>
    /// <returns></returns>
    private static double GetWeightMulti(double cumulative, MultiGroup[] multiGroup)
    {
        foreach (MultiGroup item in multiGroup)
        {
            if (item.max > cumulative)
            {
                return item.weight_multi;
            }
        }

        return 1;
    }
    /// <summary>
    /// 获取现金权重系数
    /// </summary>
    /// <returns></returns>
    public static double GetCashWeightMulti()
    {
        return GetWeightMulti(TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionHyper),
            FluHealWar.instance.JadeVole.cash_group);
    }



    /// <summary>
    /// 根据权重获取奖励index
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static int GetRewardIndexWithWeight(List<TurnRewardData> list)
    {
        double allweight = 0;
        foreach (TurnRewardData data in list)
        {
            allweight += data.weight;
        }
        float r = Random.Range(0, (float)allweight);
        int index = 0;
        float nowWeight = 0;
        for (int i = 0; i < list.Count; i++)
        {
            nowWeight += (float)list[i].weight;
            if (r < nowWeight)
            {
                index = i;

                Debug.Log(i + "," + list[i].num);
                break;
            }
        }
        return index;
    }

    public static int GetWheelMultiIndex(string type)
    {
        List<WheelMultiItem> list = new List<WheelMultiItem>();
        if (type == "diamand")
        {
            list = new List<WheelMultiItem>(FluHealWar.instance.BoneVole.wheel_reward_multi.diamand);
        }
        else if (type == "gold")
        {
            list = new List<WheelMultiItem>(FluHealWar.instance.BoneVole.wheel_reward_multi.gold);
        }
        else if (type == "add")
        {
            list = new List<WheelMultiItem>(FluHealWar.instance.BoneVole.wheel_reward_multi.add);
        }
        else if (type == "roll")
        {
            list = new List<WheelMultiItem>(FluHealWar.instance.BoneVole.wheel_reward_multi.roll);
        }
        else if (type == "remind")
        {
            list = new List<WheelMultiItem>(FluHealWar.instance.BoneVole.wheel_reward_multi.remind);
        }
        double allweight = 0;
        foreach (WheelMultiItem data in list)
        {
            allweight += data.weight;
        }
        float r = Random.Range(0, (float)allweight);
        int index = 0;
        float nowWeight = 0;
        for (int i = 0; i < list.Count; i++)
        {
            nowWeight += (float)list[i].weight;
            if (r < nowWeight)
            {
                index = i;
                break;
            }
        }
        return index;
    }
}


/// <summary>
/// 奖励类型
/// </summary>
public enum RewardType
{
    add, //刷新
    diamand,    //现金
    Gold,    //金币
    roll,    //撤回
    remind,    //魔法棒
}
