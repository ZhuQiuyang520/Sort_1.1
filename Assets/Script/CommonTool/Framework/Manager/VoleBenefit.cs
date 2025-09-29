using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShuiState
{
    None,
    Daoshui,
    Beidaoshui
}
public enum PopupType
{
    Vase,
    Remind,
    RollBack,
    Game,
    Home
}

public enum BasePointData
{
    home_app_level_start_20001 = 20001,
    home_app_level_end_20002 = 20002,
    home_item_item_obatin_20003 = 20003,
    home_item_item_use_20004 = 20004,
    home_app_get_coins_20005 = 20005,
    home_app_use_coins_20006 = 20006,
}

public class BaseStartGame
{
    public int Bongo_id;
    public int Solitude_nums;
    public int Berg_Heal;
    public int Rib_Heal;
}

public class BaseEndGame
{
    public int Bongo_id;
    public string Bongo_Danger;
    public int Fee_Solitude_Heal;
    public int Fee_Berg_Heal;
    public int Fee_Rib_Heal;
    public int Lush;
    public int Mate;
}

public class BaseGetProp
{
    public string type;
    public int Arouse;
    public string Inn;
}
public class BaseUseProp
{
    public string type;
    public int Arouse;
    public int Index;
}
public class BaseGetCoin
{
    public int Plank;
    public string Inn;
    public int Bongo_id;
}
public class BaseUseCoin
{
    public int Plank;
    public string Index;
    public int Bongo_id;
}

public static class MessageCode
{
    public static string ReelectClauseBelow= "10001";
    public static string SilkProwlDodge= "10002";
    public static string KeySully= "10003";
    public static string CarcassOral= "10004";
    public static string RimInfectOral= "10005";
    public static string ValidOffer= "10006";
    public static string ReelectDesigner= "10007";
    public static string BoardBuckHandle= "10008";
    public static string StitchClauseBranch= "10009";
    public static string ReelectInfect= "10010";
    public static string StitchModule= "10011";
    public static string ReelectModuleLeg= "10012";
}


/// <summary>
/// 数据管理器
/// </summary>

public class VoleBenefit
{
    //存储当前关卡
    public const string TownValid= "SaveLevel";
    //存储关卡障碍色
    public const string TownSquirrelValid= "SaveObstacleLevel";
    //存储游戏关卡轮数
    public const string TownValidEver= "SaveLevelBout";
    //存储当前使用的皮肤id
    public const string TownSadToss= "SaveCurSkin";
    //存储已经拥有的所有颜色皮肤
    public const string TownLopBelowToss= "SaveColorSkin";
    //存储已经拥有的所有瓶子皮肤
    public const string TownLopDarnToss= "SaveAllVaseSkin";
    //存储当前使用的瓶子皮肤
    public const string TownDarnToss= "SaveVaseSkin";
    //瓶子道具数量
    public const string TownDarnOral= "SaveVaseProp";
    //提示道具数量
    public const string TownInfectOral= "SaveRemindProp";
    //回退道具数量
    public const string TownStockingOral= "SaveRollbackProp";
    //是否开启商店引导
    public const string TownToErieBand= "SaveUnLockShop";
    //保存当前是否开启震动
    public const string TownDiffusely= "SaveVibration";
    //保存当前是否开启音乐
    public const string TownOrgan= "SaveSound";
    //保存当前是否开启音效
    public const string TownRealm= "SaveMusic";
    //保存当前语言
    public const string TownDesigner= "SaveLanguage";
    //已完成权重关卡
    public const string BranchWeightValid= "FinishWeightLevel";

    public const string ValidOffer= "LevelGuide";

    public static void YamHard(string key, int ListCount, int Number)
    {
        PlayerPrefs.SetInt(key + ListCount, Number);
        PlayerPrefs.SetInt(key, ListCount + 1);
    }

    public static List<int> RimHard(string key)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < PlayerPrefs.GetInt(key); i++)
        {
            list.Add(PlayerPrefs.GetInt(key + i));
        }
        return list;
    }

}

public class JsonName
{
    public static string Valid= "levelconfig";
    public static string Thirteen= "constant";
    public static string Evidence= "Languageconfig";
    public static string Work= "shop";
    public static string Toss= "colorconfig";
}

public class ConstantName
{
    public static string Go_Sewage= "rv_config";
    public static string Dot_Sewage= "int_config";
    public static string Dot_cd= "int_cd";
    public static string Dot_Sear_Dy= "int_back_cd";
    public static string All_Grope= "win_coins";
    public static string All_Of_Grope= "win_ad_coins";
    public static string Factory_Work_lv= "unclock_shop_lv";
    public static string Structure_Heal= "withdrawn_nums";
    public static string Lily_Heal= "Hint_nums";
    public static string Key_Remnant_Heal= "add_bottles_nums";
    public static string Structure_Of_Heal= "withdrawn_ad_nums";
    public static string Lily_Of_Heal= "Hint_ad_nums";
    public static string Remnant_Of_Heal= "bottles_ad_nums";
    public static string Structure_Cheep= "withdrawn_price";
    public static string Lily_Cheep= "Hint_price";
    public static string Elusive_Cheep= "bottles_price";
    public static string Printer_Demand= "Privacy_Policy";
    public static string Load_At= "Rate_Us";
    public static string Species_Arch= "initial_coin";
    public static string Continuous= "rateconfig";
}

public class LevelGuideInfo
{
    public class LevelGuideData
    {
        public int OfferDarnID;
    }

    public static Dictionary<int, LevelGuideData> OfferGap= new Dictionary<int, LevelGuideData>()
    {
        {0,new LevelGuideData{OfferDarnID = 0} },
        {1,new LevelGuideData{OfferDarnID = 1} }
    };
}

public class GameConfigData
{
    public int Housewares;
    public int However_Arch;
    public string Destine_us;
    public string Country_Butter;
    public int Berg_Cheep;
    public int Remnant_Cheep;
    public int Potential_Cheep;
    public int Foe_Of_Grope;
    public int Foe_Grope;
    public int He_Sewage;
    public string Attractiveness;
}


public class ColorConfigData
{
    public enum ConfigType
    {
        levelconfig,
        language,
        colorConfig
    }
    public class configData
    {
        public string Tale;
        public ConfigType Care;
    }

    public static List<configData> DeepHard= new List<configData>()
    {
        new configData{Tale = "colorconfig.json" , Care = ConfigType.colorConfig},
        new configData{Tale = "language.json" , Care = ConfigType.language},
        new configData{Tale = "levelconfig.json" , Care = ConfigType.levelconfig }
    };
}
