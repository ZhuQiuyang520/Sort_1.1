/**
 * 
 * 常量配置
 * 
 * 
 * **/
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRamble
{
    #region 常量字段
    //登录url
    public const string AdaptMar= "/api/client/user/getId?gameCode=";
    //配置url
    public const string RambleMar= "/api/client/config?gameCode=";
    //时间戳url
    public const string ShowMar= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string CommonMar= "/api/client/user/setAdjustId?gameCode=";
    #endregion

    #region 本地存储的字符串
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string Dy_EnjoyTentId= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string Dy_EnjoyWanderNo= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string Dy_NoMapSpiral= "sv_IsNewPlayer";

    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string Dy_StudyPriceRimCreep= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Dy_StudyPriceDate= "sv_DailyBounsDate";
    /// <summary>
    /// 新手引导完成的步数
    /// </summary>
    public const string Dy_MapTentFind= "sv_NewUserStep";
    /// <summary>
    /// 金币余额
    /// </summary>
    public const string Dy_GoldGene= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string Dy_RevolutionCareGene= "sv_CumulativeGoldCoin";
    /// <summary>
    /// 钻石/现金余额
    /// </summary>
    public const string Dy_Hyper= "sv_Token";
    /// <summary>
    /// 累计钻石/现金总数
    /// </summary>
    public const string Dy_RevolutionHyper= "sv_CumulativeToken";
    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string Dy_Height= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string Dy_RevolutionHeight= "sv_CumulativeAmazon";
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string Dy_SplitBoneShow= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string Dy_TrulyRimHyper= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string Dy_DieWrapLoadTowel= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string Dy_RevolutionFlipper= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string Dy_SoloistPumpMental= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string Dy_MapTentFindBranch= "sv_NewUserStepFinish";
    public const string Dy_Ring_Bongo_Plank= "sv_task_level_count";
    // 是否第一次使用过slot
    public const string Dy_TrulyWarp= "sv_FirstSlot";
    /// <summary>
    /// adjust adid
    /// </summary>
    public const string Dy_CommonFlat= "sv_AdjustAdid";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string Dy_Of_Crane_Mob= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string Dy_Roman_Of_Mob= "sv_total_ad_num";
    /// <summary>
    /// 语言
    /// </summary>
    public const string Her_Evidence= "Language";

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
    //金币数量
    public const string TownGeneStress= "SaveCoinNumber";
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

    #endregion

    #region 监听发送的消息

    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string mg_WindowFact= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string To_InfectBoard= "mg_WindowClose";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string To_ui_Receptiveness= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string To_ID_Breadth= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string To_ID_Observer= "mg_ui_addtoken";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string To_ID_Efficient= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string To_BoneRevolve= "mg_GameSuspend";

    /// <summary>
    /// 游戏资源数量变化
    /// </summary>
    public static string To_GoodFacial_= "mg_ItemChange_";

    /// <summary>
    /// 活动状态变更
    /// </summary>
    public static string To_BoundaryHoneyFacial_= "mg_ActivityStateChange_";

    /// <summary>
    /// 关卡最大等级变更
    /// </summary>
    public static string To_ValidWitValidFacial= "mg_LevelMaxLevelChange";

    #endregion

    #region 动态加载资源的路径

    // 金币图片
    public static string Hone_GoldGene_Cobalt= "Art/Tex/UI/jiangli1";
    // 钻石图片
    public static string Hone_Hyper_Cobalt_Anyway= "Art/Tex/UI/jiangli4";

    #endregion
}
