using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BuddyLuce
{
    Success,
    GoldNotEnough,
    DiamondNotEnouth,
    OutOfStock,
    PurchaseFailed,
    ExpNotEnouth,
    HealthNotEnough
}

public static class ErrorCodeMessage
{
    private static readonly Dictionary<BuddyLuce, string> Tuck= new Dictionary<BuddyLuce, string>
    {
        { BuddyLuce.Success, "操作成功" },
        { BuddyLuce.GoldNotEnough, "金币不足" },
        { BuddyLuce.DiamondNotEnouth, "钻石不足" },
        { BuddyLuce.OutOfStock, "库存不足" },
        { BuddyLuce.PurchaseFailed, "支付失败" },
        { BuddyLuce.ExpNotEnouth, "经验不足" },
        { BuddyLuce.HealthNotEnough, "体力不足" }
    };

    public static string RimBlanket(BuddyLuce errorCode)
    {
        if (Tuck.TryGetValue(errorCode, out string msg))
        {
            return msg;
        }
        return errorCode.ToString(); // 如果没有找到对应的描述，返回枚举值的字符串表示
    }
}
