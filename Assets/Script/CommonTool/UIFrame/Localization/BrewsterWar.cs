/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrewsterWar 
{
    public static BrewsterWar _Intricate;
    //语言翻译的缓存集合
    private Dictionary<string, string> _GapBrewsterRatio;

    private BrewsterWar()
    {
        _GapBrewsterRatio = new Dictionary<string, string>();
        //初始化语言缓存集合
        JadeBrewsterRatio();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static BrewsterWar RimIndicate()
    {
        if (_Intricate == null)
        {
            _Intricate = new BrewsterWar();
        }
        return _Intricate;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string WrapCart(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_GapBrewsterRatio!=null && _GapBrewsterRatio.Count >= 1)
        {
            _GapBrewsterRatio.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void JadeBrewsterRatio()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        IRambleBenefit config = new RambleBenefitWeDeep("LauguageJSONConfig");
        if (config != null)
        {
            _GapBrewsterRatio = config.AppHabitat;
        }
    }
}
