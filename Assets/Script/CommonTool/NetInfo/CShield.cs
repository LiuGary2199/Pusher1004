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

public class CShield
{
    #region 常量字段
    //登录url
    public const string StageLaw= "/api/client/user/getId?gameCode=";
    //配置url
    public const string ShieldLaw= "/api/client/config?gameCode=";
    //时间戳url
    public const string SwayLaw= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string CavernLaw= "/api/client/user/setAdjustId?gameCode=";
    
    public const string Bet_Threaten= "sys_language";

    public const string Bet_BigSH= "sys_AppSH";
    #endregion

    #region 本地存储的字符串


    public const string Dy_MyPassBulk= "sv_IsInitData";

    public const string Dy_Wet_Lid_Sink= "sv_big_win_cash";
    
    public const string msg_Video_Fluid_Key_Total= "msg_close_panel_and_start";

    public const string Dy_Tooth_Tele_Thunder= "sv_fever_time_current";

    public const string Dy_Narrow_Ask_From_Deter= "sv_finish_new_user_guide";

    public const string Dy_Detail_Tycoon_Snout= "sv_bigwin_weight_multi";
    
    
    
    
    
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string Dy_PupilEverTo= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string Dy_PupilRecoilTo= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string Dy_MyJobLonger= "sv_IsNewPlayer";

    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string Dy_AriseCloudTowRigor= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Dy_AriseCloudDate= "sv_DailyBounsDate";
    /// <summary>
    /// 新手引导完成的步数
    /// </summary>
    public const string Dy_JobEverMost= "sv_NewUserStep";
    /// <summary>
    /// 金币余额
    /// </summary>
    public const string Dy_RimeView= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string Dy_RelativelyRimeView= "sv_CumulativeGoldCoin";
    
    public const string Dy_Dust= "sv_Cash";

    public const string Dy_RelativelyDust= "sv_CumulativeCash";

    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string Dy_Coyote= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string Dy_RelativelyCoyote= "sv_CumulativeAmazon";
    
    public const string Dy_Chest_Half_Ice= "sv_steel_ball_num";

    public const string Dy_RelativelyFast= "sv_CumulativeBall";
    
    public const string Dy_Chest_Half_Toad= "sv_steel_ball_date";
    
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string Dy_AnkleLadeSway= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string Dy_SenseTowTroop= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string Dy_BurPearLullPlank= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string Dy_RelativelySparrow= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string Dy_ImpressJazzLegume= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string Dy_JobEverMostPurely= "sv_NewUserStepFinish";
    public const string Dy_Gild_Skull_Briny= "sv_task_level_count";
    // 是否第一次使用过slot
    public const string Dy_SenseMuch= "sv_FirstSlot";
    /// <summary>
    /// adjust adid
    /// </summary>
    public const string Dy_CavernJoin= "sv_AdjustAdid";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string Dy_We_Exert_Ice= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string Dy_Rodeo_We_Ice= "sv_total_ad_num";


    public const string Dy_Relax_Levy_Lid_777= "sv_first_bing_win_777";
    
    public const string Dy_Relax_Levy_Lid_Summer= "sv_first_bing_win_reward";
    public const string Raw_Mine_Sink_Reef= "msg_show_cash_mask";
    public const string Dy_Total_Dry_Its= "sv_start_fiy_box";
    public const string Dy_Relax_Sink_out= "sv_first_cash_out";
    public const string Raw_Mine_Solo_Ox= "msg_show_rate_us";
    public const string Dy_Relax_Then_again= "sv_first_slot_again";
    public const string Dy_Virtue_LIf_We_If= "sv_normal_win_ad_id";
    public const string Dy_Virtue_Lid_Weld= "sv_normal_win_type";
    public const string Dy_Teem_Weld= "sv_gems_type";
    public const string Dy_Subsist_Oat_Half= "sv_first_add_ball";
    public const string uspanel= "uspanel";
    public const string tixiananniu = "sv_tixiananniu";



    #endregion

    #region 监听发送的消息

    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string Be_RuggedEpic= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string Be_RuggedFolly= "mg_WindowClose";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string Be_ui_Amplification= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string Be_Ox_Estuary= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string Be_Ox_Aircraft= "mg_ui_addtoken";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string Be_Ox_Horseback= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string Be_LadeJourney= "mg_GameSuspend";

    #endregion

    #region 动态加载资源的路径

    // 金币图片
    public static string path_RimeView_Timely= "Art/Tex/UI/jiangli1";
    // 钻石图片
    public static string Rime_Troop_Timely_Forbid= "Art/Tex/UI/jiangli4";

    public static string Raw_Stag= "Prefab/Raw_Stag";
    public static string Raw_Add= "Prefab/Raw_Add";
    public static string Raw_Surplus= "Prefab/Raw_Surplus";
    public static string Raw_Prefer= "Prefab/Prefer";
    public static string Tex_10= "Art/Tex/Tex_10";
    public static string Law_8= "Art/Tex/Law_8";
    public static string IceRigor= "Art/Tex/BoxCount/x";

    #endregion
}

