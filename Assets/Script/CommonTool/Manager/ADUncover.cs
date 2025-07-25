using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using com.adjust.sdk;
using LitJson;
using DG.Tweening;

public class ADUncover : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("MAX_SDK_KEY")]    public string MAX_SDK_KEY= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_REWARD_ID")]    public string MAX_REWARD_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_INTER_ID")]    public string MAX_INTER_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("isTest")]
    public bool AxLoop= false;
    public static ADUncover Variance{ get; private set; }
    public int loopTime = 0;
    private int SlatePattern;   // 广告加载失败后，重新加载广告次数
    private bool AxWetlandAd;     // 是否正在播放广告，用于判断切换前后台时是否增加计数

    public int GainTossSwayNervous{ get; private set; }   // 距离上次广告的时间间隔
    public int Moisten101{ get; private set; }     // 定时插屏(101)计数器
    public int Moisten102{ get; private set; }     // NoThanks插屏(102)计数器
    public int Moisten103{ get; private set; }     // 后台回前台插屏(103)计数器

    private string SummerSuspendHail;
    private Action<bool> SummerNineBackUnload;    // 激励视频回调
    private bool SummerRagtime;     // 激励视频是否成功收到奖励
    private string SummerTwain;     // 激励视频的打点

    private string TransmissionSuspendHail;
    private int TransmissionOnce;      // 当前播放的插屏类型，101/102/103
    private string TransmissionTwain;     // 插屏广告的的打点
    public bool MuralSwayParticipator{ get; private set; } // 定时插屏暂停播放

    private List<Action<ADType>> WeFinnishAmbitious;    // 广告播放完成回调列表，用于其他系统广告计数（例如商店看广告任务）

    private long TranslucentHasteInfertile;     // 切后台时的时间戳
    private Ad_CustomData SecretOfBlowerBulk; //激励视频自定义数据
    private Ad_CustomData ParticipatorOfBlowerBulk; //插屏自定义数据
    private double ParticipatorOutnumber= 0;
    private void Awake()
    {
        Variance = this;
    }

    private void OnEnable()
    {
        MuralSwayParticipator = false;
        AxWetlandAd = false;
        GainTossSwayNervous = 999;  // 初始时设置一个较大的值，不阻塞插屏广告
        SummerRagtime = false;

        // Android平台将Adjust的adid传给Max；iOS将randomKey传给Max
#if UNITY_ANDROID
        MaxSdk.SetSdkKey(TowMatterBulk.FurnaceDES(MAX_SDK_KEY));
        // 将adjust id 传给Max
        string adjustId = MoreBulkUncover.TowSmooth(CShield.Dy_CavernJoin);
        if (string.IsNullOrEmpty(adjustId))
        {
            adjustId = Adjust.getAdid();
        }
        if (!string.IsNullOrEmpty(adjustId))
        {
            MaxSdk.SetUserId(adjustId);
            MaxSdk.InitializeSdk();
            MoreBulkUncover.GunSmooth(CShield.Dy_CavernJoin, adjustId);
        }
        else
        {
            StartCoroutine(LadCavernJoin());
        }
#else
        MaxSdk.SetSdkKey(TowMatterBulk.FurnaceDES(MAX_SDK_KEY));
        MaxSdk.SetUserId(MoreBulkUncover.TowSmooth(CShield.Dy_PupilEverTo));
        MaxSdk.InitializeSdk();
#endif

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
        {
            // 打开调试模式
            //MaxSdk.ShowMediationDebugger();

            ConversionCheerfulHub();
            MaxSdk.SetCreativeDebuggerEnabled(true);

            // 每秒执行一次计数

           loopTime = TimerManager.Instance.StartTimer(1f, () => {
               RegardPrimal();
            }, true,false);
            // InvokeRepeating(nameof(RegardPrimal), 1, 1);
        };
    }

    private void OnDestroy()
    {
        if (loopTime > 0)
        {
            TimerManager.Instance.StopTimer(loopTime);
        }
    }


        IEnumerator LadCavernJoin()
    {
        int i = 0;
        while (i < 5)
        {
            yield return new WaitForSeconds(1);
            if (FalconErie.MyDomain())
            {
                MaxSdk.SetUserId(MoreBulkUncover.TowSmooth(CShield.Dy_PupilEverTo));
                MaxSdk.InitializeSdk();
                yield break;
            }
            else
            {
                string adjustId = Adjust.getAdid();
                if (!string.IsNullOrEmpty(adjustId))
                {
                    MaxSdk.SetUserId(adjustId);
                    MaxSdk.InitializeSdk();
                    MoreBulkUncover.GunSmooth(CShield.Dy_CavernJoin, adjustId);
                    yield break;
                }
            }
            i++;
        }
        if (i == 5)
        {
            MaxSdk.SetUserId(MoreBulkUncover.TowSmooth(CShield.Dy_PupilEverTo));
            MaxSdk.InitializeSdk();
        }
    }

    public void ConversionCheerfulHub()
    {
        // Attach callback
        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
        MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
        MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnInterstitialRevenuePaidEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

        // Load the first rewarded ad
        RaceCheerfulOf();

        // Load the first interstitial
        RaceParticipator();
    }

    private void RaceCheerfulOf()
    {
        MaxSdk.LoadRewardedAd(MAX_REWARD_ID);
    }

    private void RaceParticipator()
    {
        MaxSdk.LoadInterstitial(MAX_INTER_ID);
    }

    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is ready for you to show. MaxSdk.IsRewardedAdReady(adUnitId) now returns 'true'.

        // Reset retry attempt
        SlatePattern = 0;
        SummerSuspendHail = adInfo.NetworkName;

        SecretOfBlowerBulk = new Ad_CustomData();
        SecretOfBlowerBulk.user_id = CashOutManager.GetInstance().Data.UserID;
        SecretOfBlowerBulk.version = Application.version;
        SecretOfBlowerBulk.request_id = CashOutManager.GetInstance().EcpmRequestID();
        SecretOfBlowerBulk.vendor = adInfo.NetworkName;
    }

    private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Rewarded ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

        SlatePattern++;
        double retryDelay = Math.Pow(2, Math.Min(6, SlatePattern));

        Invoke(nameof(RaceCheerfulOf), (float)retryDelay);
    }

    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        BrownTip.GetInstance().MeBrownCoarse = !BrownTip.GetInstance().MeBrownCoarse;
        Time.timeScale = 0;
#endif
    }

    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
        RaceCheerfulOf();
        AxWetlandAd = false;
    }

    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {

    }

    private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is hidden. Pre-load the next ad
#if UNITY_IOS
        Time.timeScale = 1;
        BrownTip.GetInstance().MeBrownCoarse = !BrownTip.GetInstance().MeBrownCoarse;
#endif

        AxWetlandAd = false;
        RaceCheerfulOf();
        if (SummerRagtime)
        {
            SummerRagtime = false;
            SummerNineBackUnload?.Invoke(true);

            PerryOfTossRagtime(ADType.Rewarded);
            PlowSenseGarden.GetInstance().CanySense("9007", SummerTwain);
        }
        else
        {
            //rewardCallBackAction?.Invoke(false);
        }

        // 上报ecpm
        CashOutManager.GetInstance().ReportEcpm(adInfo, SecretOfBlowerBulk.request_id, "REWARD");
    }

    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        // The rewarded ad displayed and the user should receive the reward.
        SummerRagtime = true;
    }

    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        // Ad revenue paid. Use this callback to track user revenue.
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        PlowSenseGarden.GetInstance().CanySense("9008", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
      //  CavernPassUncover.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        string adjustAdid = CavernPassUncover.Instance.TowCavernJoin();
        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(adjustAdid))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (rewarded), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Rewarded revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is ready for you to show. MaxSdk.IsInterstitialReady(adUnitId) now returns 'true'

        // Reset retry attempt
        SlatePattern = 0;
        TransmissionSuspendHail = adInfo.NetworkName;

        ParticipatorOfBlowerBulk = new Ad_CustomData();
        ParticipatorOfBlowerBulk.user_id = CashOutManager.GetInstance().Data.UserID;
        ParticipatorOfBlowerBulk.version = Application.version;
        ParticipatorOfBlowerBulk.request_id = CashOutManager.GetInstance().EcpmRequestID();
        ParticipatorOfBlowerBulk.vendor = adInfo.NetworkName;
    }

    private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Interstitial ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds)

        SlatePattern++;
        double retryDelay = Math.Pow(2, Math.Min(6, SlatePattern));

        Invoke(nameof(RaceParticipator), (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        BrownTip.GetInstance().MeBrownCoarse = !BrownTip.GetInstance().MeBrownCoarse;
        Time.timeScale = 0;
#endif
    }

    private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad failed to display. AppLovin recommends that you load the next ad.
        RaceParticipator();
        AxWetlandAd = false;
    }

    private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        PlowSenseGarden.GetInstance().CanySense("9108", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
      //  CavernPassUncover.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(CavernPassUncover.Instance.TowCavernJoin()))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (interstitial), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        string adjustAdid = CavernPassUncover.Instance.TowCavernJoin();
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Interstitial revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is hidden. Pre-load the next ad.
#if UNITY_IOS
        Time.timeScale = 1;
        BrownTip.GetInstance().MeBrownCoarse = !BrownTip.GetInstance().MeBrownCoarse;
#endif
        RaceParticipator();

        PerryOfTossRagtime(ADType.Interstitial);
        PlowSenseGarden.GetInstance().CanySense("9107", TransmissionTwain);
        // 上报ecpm
        CashOutManager.GetInstance().ReportEcpm(adInfo, ParticipatorOfBlowerBulk.request_id, "INTER");
    }


    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    /// <param name="callBack"></param>
    /// <param name="index"></param>
    public void PourSecretSteel(Action<bool> callBack, string index)
    {
        if (AxLoop)
        {
            callBack(true);
            PerryOfTossRagtime(ADType.Rewarded);
            return;
        }

        bool rewardVideoReady = MaxSdk.IsRewardedAdReady(MAX_REWARD_ID);
        SummerNineBackUnload = callBack;
        if (rewardVideoReady)
        {
            // 打点
            SummerTwain = index;
            PlowSenseGarden.GetInstance().CanySense("9002", index);
            AxWetlandAd = true;
            SummerRagtime = false;
            string placement = index + "_" + SummerSuspendHail;
            SecretOfBlowerBulk.placement_id = placement;
            MaxSdk.ShowRewardedAd(MAX_REWARD_ID, placement, JsonMapper.ToJson(SecretOfBlowerBulk));
        }
        else
        {
            PhotoUncover.GetInstance().PearPhoto("No ads right now, please try it later.");
            // rewardCallBackAction(false);
        }
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index"></param>
    public void PourParticipatorOf(int index)
    {
        if (index == 101 || index == 102 || index == 103)
        {
            UnityEngine.Debug.LogError("广告点位不允许为101、102、103");
            return;
        }

        PourParticipator(index);
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index">101/102/103</param>
    /// <param name="customIndex">用户自定义点位</param>
    private void PourParticipator(int index, int customIndex = 0)
    {
        TransmissionOnce = index;

        if (AxWetlandAd)
        {
            return;
        }

        // 当用户过关数 < trial_MaxNum时，不弹插屏广告
        int sv_trialNum = MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice);
        int trial_MaxNum = int.Parse(SapScanTip.instance.ShieldBulk.trial_MaxNum);
        if (sv_trialNum < trial_MaxNum)
        {
            return;
        }

        // 时间间隔低于阈值，不播放广告
        if (GainTossSwayNervous < int.Parse(SapScanTip.instance.ShieldBulk.inter_freq))
        {
            return;
        }

        if (AxLoop)
        {
            PerryOfTossRagtime(ADType.Interstitial);
            return;
        }

        bool interstitialVideoReady = MaxSdk.IsInterstitialReady(MAX_INTER_ID);
        if (interstitialVideoReady)
        {
            if (TransmissionOnce == 101)
            {
                AxWetlandAd = true;
                DOVirtual.DelayedCall(2f, () => //停顿
                {
                    UIManager.GetInstance().FollyNoHanderUIStain(nameof(StifleDeal));
                    // 打点
                    string point = index.ToString();
                    if (customIndex > 0)
                    {
                        point += customIndex.ToString().PadLeft(2, '0');
                    }
                    TransmissionTwain = point;
                    PlowSenseGarden.GetInstance().CanySense("9102", point);
                    string placement = point + "_" + TransmissionSuspendHail;
                    ParticipatorOfBlowerBulk.placement_id = placement;
                    MaxSdk.ShowInterstitial(MAX_INTER_ID, placement, JsonMapper.ToJson(ParticipatorOfBlowerBulk));
                });
            }
            else
            {
                AxWetlandAd = true;
                // 打点
                string point = index.ToString();
                if (customIndex > 0)
                {
                    point += customIndex.ToString().PadLeft(2, '0');
                }
                TransmissionTwain = point;
                PlowSenseGarden.GetInstance().CanySense("9102", point);
                string placement = point + "_" + TransmissionSuspendHail;
                ParticipatorOfBlowerBulk.placement_id = placement;
                MaxSdk.ShowInterstitial(MAX_INTER_ID, placement, JsonMapper.ToJson(ParticipatorOfBlowerBulk));
            }
        }
    }

    /// <summary>
    /// 每秒更新一次计数器 - 101计数器 和 时间间隔计数器
    /// </summary>
    private void RegardPrimal()
    {
        GainTossSwayNervous++;

        int relax_interval = int.Parse(SapScanTip.instance.ShieldBulk.relax_interval);
        // 计时器阈值设置为0或负数时，关闭广告101；
        // 播放广告期间不计数；
        if (relax_interval <= 0 || AxWetlandAd)
        {
            return;
        }
        else
        {
            Moisten101++;
            if (Moisten101 >= relax_interval && !MuralSwayParticipator)
            {
                PourParticipator(101);
            }
            if (Moisten101 + 2 >= relax_interval && !MuralSwayParticipator)
            {
                if (AxWetlandAd)
                {
                    return;
                }

                // 当用户过关数 < trial_MaxNum时，不弹插屏广告
                int sv_trialNum = MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice);
                int trial_MaxNum = int.Parse(SapScanTip.instance.ShieldBulk.trial_MaxNum);
                if (sv_trialNum < trial_MaxNum)
                {
                    return;
                }

                // 时间间隔低于阈值，不播放广告
                if (GainTossSwayNervous < int.Parse(SapScanTip.instance.ShieldBulk.inter_freq))
                {
                    return;
                }

                if (AxLoop)
                {
                    PerryOfTossRagtime(ADType.Interstitial);
                    return;
                }

                bool interstitialVideoReady = MaxSdk.IsInterstitialReady(MAX_INTER_ID);
                if (interstitialVideoReady)
                {
                    ParticipatorOutnumber = GameUtil.GetInterstitialData();
                    UIManager.GetInstance().PearUIStain(nameof(StifleDeal));
                    StifleDeal.Instance.MyPassBulk(ParticipatorOutnumber);
                }
            }
        }
    }

    /// <summary>
    /// NoThanks插屏 - 102
    /// </summary>
    public void ToBreechSkyRigor(int customIndex = 0)
    {
        // 用户行为累计次数计数器阈值设置为0或负数时，关闭广告102
        int nextlevel_interval = int.Parse(SapScanTip.instance.ShieldBulk.nextlevel_interval);
        if (nextlevel_interval <= 0)
        {
            return;
        }
        else
        {
            Moisten102 = MoreBulkUncover.TowWok("NoThanksCount") + 1;
            MoreBulkUncover.GunWok("NoThanksCount", Moisten102);
            if (Moisten102 >= nextlevel_interval)
            {
                PourParticipator(102, customIndex);
            }
        }
    }

    /// <summary>
    /// 前后台切换计数器 - 103
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            // 切回前台
            if (!AxWetlandAd)
            {
                // 前后台切换时，播放间隔计数器需要累加切到后台的时间
                if (TranslucentHasteInfertile > 0)
                {
                    GainTossSwayNervous += (int)(TossErie.Extinct() - TranslucentHasteInfertile);
                    TranslucentHasteInfertile = 0;
                }
                // 后台切回前台累计次数，后台配置为0或负数，关闭该广告
                int inter_b2f_count = int.Parse(SapScanTip.instance.ShieldBulk.inter_b2f_count);
                if (inter_b2f_count <= 0)
                {
                    return;
                }
                else
                {
                    Moisten103++;
                    if (Moisten103 >= inter_b2f_count)
                    {
                        PourParticipator(103);
                    }
                }
            }
        }
        else
        {
            // 切到后台
            TranslucentHasteInfertile = TossErie.Extinct();
        }
    }

    /// <summary>
    /// 暂停定时插屏播放 - 101
    /// </summary>
    public void HasteSwayParticipator()
    {
        MuralSwayParticipator = true;
    }

    /// <summary>
    /// 恢复定时插屏播放 - 101
    /// </summary>
    public void RetoolSwayParticipator()
    {
        MuralSwayParticipator = false;
    }

    /// <summary>
    /// 更新游戏的TrialNum
    /// </summary>
    /// <param name="num"></param>
    public void TenantBraveGod(int num)
    {
        MoreBulkUncover.GunWok(CShield.Dy_We_Exert_Ice, num);
    }

    /// <summary>
    /// 注册看广告的回调事件
    /// </summary>
    /// <param name="callback"></param>
    public void EngineerTossUnfairly(Action<ADType> callback)
    {
        if (WeFinnishAmbitious == null)
        {
            WeFinnishAmbitious = new List<Action<ADType>>();
        }

        if (!WeFinnishAmbitious.Contains(callback))
        {
            WeFinnishAmbitious.Add(callback);
        }
    }

    /// <summary>
    /// 广告播放成功后，执行看广告回调事件
    /// </summary>
    private void PerryOfTossRagtime(ADType adType)
    {
        AxWetlandAd = false;
        // 播放间隔计数器清零
        GainTossSwayNervous = 0;
        // 插屏计数器清零
        if (adType == ADType.Interstitial)
        {
            // 计数器清零
            if (TransmissionOnce == 101)
            {
                LadePlank.Instance.SkyDust(ParticipatorOutnumber);
                Moisten101 = 0;
            }
            else if (TransmissionOnce == 102)
            {
                Moisten102 = 0;
                MoreBulkUncover.GunWok("NoThanksCount", 0);
            }
            else if (TransmissionOnce == 103)
            {
                Moisten103 = 0;
            }
        }

        // 看广告总数+1
        MoreBulkUncover.GunWok(CShield.Dy_Rodeo_We_Ice + adType.ToString(), MoreBulkUncover.TowWok(CShield.Dy_Rodeo_We_Ice + adType.ToString()) + 1);

        // 回调
        if (WeFinnishAmbitious != null && WeFinnishAmbitious.Count > 0)
        {
            foreach (Action<ADType> callback in WeFinnishAmbitious)
            {
                callback?.Invoke(adType);
            }
        }
    }

    /// <summary>
    /// 获取总的看广告次数
    /// </summary>
    /// <returns></returns>
    public int TowAnkleOfGod(ADType adType)
    {
        return MoreBulkUncover.TowWok(CShield.Dy_Rodeo_We_Ice + adType.ToString());
    }
}

public enum ADType { Interstitial, Rewarded }

[System.Serializable]
public class Ad_CustomData //广告自定义数据
{
    public string user_id; //用户id
    public string version; //版本号
    public string request_id; //请求id
    public string vendor; //渠道
    public string placement_id; //广告位id
}