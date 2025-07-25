using System;
using System.Collections;
using com.adjust.sdk;
using UnityEngine;
using Random = UnityEngine.Random;

public class CavernPassUncover : MonoBehaviour
{
    public static CavernPassUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("adjustID")]
    public string BotanyID;     // 由遇总的打包工具统一修改，无需手动配置

    //用户adjust 状态KEY
    private string sv_ADHopePassOnce= "sv_ADJustInitType";

    //adjust 时间戳
    private string Dy_ADHopeSway= "sv_ADJustTime";

    //adjust行为计数器
    public int _ThunderRigor{ get; private set; }


    private void Awake()
    {
        Instance = this;
        MoreBulkUncover.GunSmooth(Dy_ADHopeSway, TossErie.Extinct().ToString());

#if UNITY_IOS
        MoreBulkUncover.GunSmooth(sv_ADHopePassOnce, AdjustStatus.OpenAsAct.ToString());
        CavernPass();
#endif
    }

    private void Start()
    {
        _ThunderRigor = 0;
    }


    void CavernPass()
    {
        AdjustConfig adjustConfig = new AdjustConfig(BotanyID, AdjustEnvironment.Production, false);
        adjustConfig.setLogLevel(AdjustLogLevel.Verbose);
        adjustConfig.setSendInBackground(false);
        adjustConfig.setEventBufferingEnabled(false);
        adjustConfig.setLaunchDeferredDeeplink(true);
        Adjust.start(adjustConfig);

        StartCoroutine(MoreCavernJoin());
    }

    private IEnumerator MoreCavernJoin()
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
                MoreBulkUncover.GunSmooth(CShield.Dy_CavernJoin, adjustAdid);
                SapScanTip.instance.CanyCavernJoin();
                yield break;
            }
        }
    }

    public string TowCavernJoin()
    {
        return MoreBulkUncover.TowSmooth(CShield.Dy_CavernJoin);
    }

    /// <summary>
    /// 获取adjust初始化状态
    /// </summary>
    /// <returns></returns>
    public string TowCavernBarrel()
    {
        return MoreBulkUncover.TowSmooth(sv_ADHopePassOnce);
    }

    /*
     *  API
     *  标记老用户
     */
    public void JoyEverGun()
    {
        
        print("old user add adjust status");
        MoreBulkUncover.GunSmooth(sv_ADHopePassOnce, AdjustStatus.OldUser.ToString());
        PlowSenseGarden.GetInstance().CanySense("1093", TowCavernSway());
    }


    /*
     *  API
     *  Adjust 初始化
     */
    public void PassCavernBulk(bool isOldUser = false)
    {
        #if UNITY_IOS
            return;
        #endif
        if (MoreBulkUncover.TowSmooth(sv_ADHopePassOnce) == "" && isOldUser)
        {
            JoyEverGun();
        }
        // 如果后台配置的adjust_init_act_position <= 0，直接初始化
        if (string.IsNullOrEmpty(SapScanTip.instance.ShieldBulk.adjust_init_act_position) || int.Parse(SapScanTip.instance.ShieldBulk.adjust_init_act_position) <= 0)
        {
            MoreBulkUncover.GunSmooth(sv_ADHopePassOnce, AdjustStatus.OpenAsAct.ToString());
        }
        print(" user init adjust by status :" + MoreBulkUncover.TowSmooth(sv_ADHopePassOnce));
        //用户二次登录 根据标签初始化
        if (MoreBulkUncover.TowSmooth(sv_ADHopePassOnce) == AdjustStatus.OldUser.ToString() || MoreBulkUncover.TowSmooth(sv_ADHopePassOnce) == AdjustStatus.OpenAsAct.ToString())
        {
            print("second login  and  init adjust");
            CavernPass();
        }
    }



    /*
     * API
     *  记录行为累计次数
     *  @param2 打点参数
     */
    public void SkyCupRigor(string param2 = "")
    {
#if UNITY_IOS
            return;
#endif
        if (MoreBulkUncover.TowSmooth(sv_ADHopePassOnce) != "") return;
        _ThunderRigor++;
        print(" add up to :" + _ThunderRigor);
        if (string.IsNullOrEmpty(SapScanTip.instance.ShieldBulk.adjust_init_act_position) || _ThunderRigor == int.Parse(SapScanTip.instance.ShieldBulk.adjust_init_act_position))
        {
            RaceCavernDyCup(param2);
        }
    }

    /*
     * API
     * 根据行为 初始化 adjust
     *  @param2 打点参数 
     */
    public void RaceCavernDyCup(string param2 = "")
    {
        if (MoreBulkUncover.TowSmooth(sv_ADHopePassOnce) != "") return;

        // 根据比例分流   adjust_init_rate_act  行为比例
        if (string.IsNullOrEmpty(SapScanTip.instance.ShieldBulk.adjust_init_rate_act) || int.Parse(SapScanTip.instance.ShieldBulk.adjust_init_rate_act) > Random.Range(0, 100))
        {
            print("user finish  act  and  init adjust");
            MoreBulkUncover.GunSmooth(sv_ADHopePassOnce, AdjustStatus.OpenAsAct.ToString());
            CavernPass();

            // 上报点位 新用户达成 且 初始化
            PlowSenseGarden.GetInstance().CanySense("1091", TowCavernSway(), param2);
        }
        else
        {
            print("user finish  act  and  not init adjust");
            MoreBulkUncover.GunSmooth(sv_ADHopePassOnce, AdjustStatus.CloseAsAct.ToString());
            // 上报点位 新用户达成 且  不初始化
            PlowSenseGarden.GetInstance().CanySense("1092", TowCavernSway(), param2);
        }
    }

    
    /*
     * API
     *  重置当前次数
     */
    public void CrestCupRigor()
    {
        print("clear current ");
        _ThunderRigor = 0;
    }


    // 获取启动时间
    private string TowCavernSway()
    {
        return TossErie.Extinct() - long.Parse(MoreBulkUncover.TowSmooth(Dy_ADHopeSway)) + "";
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