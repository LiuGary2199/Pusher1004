using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using LitJson;
using Lofelt.NiceVibrations;
public class DenialUncover : MonoBehaviour
{
    static public DenialUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Pool")]
    public GameObject At_Luce;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Pool_1")]    public GameObject At_Luce_1;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Pool")]    public GameObject Port_Luce;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemPerfab")]    public GameObject SummerLessViewer;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemGroup")]    public Transform SummerLessRoost;
[UnityEngine.Serialization.FormerlySerializedAs("fxPool")]    public LuceUncover AtLuce;
[UnityEngine.Serialization.FormerlySerializedAs("fxPool_1")]    public LuceUncover AtLuce_1;
[UnityEngine.Serialization.FormerlySerializedAs("TextPool")]    public LuceUncover PortLuce;
    private int CudStableGod;
[UnityEngine.Serialization.FormerlySerializedAs("currentBucketNum")]    public int ThunderStableGod;
[UnityEngine.Serialization.FormerlySerializedAs("ColumnGroup")]    public GameObject TwelveRoost;
[UnityEngine.Serialization.FormerlySerializedAs("centerDoor")]    public GameObject centerTopi;
[UnityEngine.Serialization.FormerlySerializedAs("coinPagodaPerfab")]    public GameObject BondElevenViewer;
[UnityEngine.Serialization.FormerlySerializedAs("fX_Fever")]    public GameObject fX_Close;
[UnityEngine.Serialization.FormerlySerializedAs("fX_BigWin")]    public GameObject fX_LugBad;
[UnityEngine.Serialization.FormerlySerializedAs("fX_BoxGroup")]    public GameObject fX_IceRoost;
[UnityEngine.Serialization.FormerlySerializedAs("haveLittleGame")]    public bool GripBackupLade= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPause")]    public bool AxHaste= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPushFever")]    /// <summary>
    /// 是否进入fever
    /// </summary>
    public bool AxSourClose= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPushBigWin")]    /// <summary>
    /// 是否正在777
    /// </summary>
    public bool AxSourLugBad= false;
    int CalciteGoldViewRigor;
[UnityEngine.Serialization.FormerlySerializedAs("EpicOrFollyCop")]
    public EpicOrFollyCop EpicOrFollyCop;
    public JobSing NewSkin;


    private void OnApplicationPause(bool focus)
    {
        if (focus)
        {
            Debug.Log("进入后台");
            HintEyeSecretLess();
        }
        else
        {
            Debug.Log("进入前台");
        }
    }


    private void Awake()
    {
        Instance = this;
        
    }

    private void Start()
    {
        //EpicOrFollyCop.FaunaCopPurge();
        NewSkin.SetSkin();
        CudStableGod = 26;
        ThunderStableGod = MoreBulkUncover.TowWok(CShield.Dy_Tooth_Tele_Thunder);
        SummerLessRoost.gameObject.AddComponent<LuceUncover>().PassLuceUncover(SummerLessViewer,SummerLessRoost,300,"RewardItem");
        AtLuce.PassLuceUncover(At_Luce, AtLuce.transform, 50, "fxPool");
        AtLuce_1.PassLuceUncover(At_Luce_1, AtLuce_1.transform, 20, "fxPool_1");
        PortLuce.PassLuceUncover(Port_Luce, PortLuce.transform, 50, "TextPool");
        YardEyeSecretLess();
        TotalDenial();
        if (FalconErie.MyUnder())
        {
            MuchUncover.Instance.FollyMuchBG();
        }
    }


    /// <summary>
    /// 推币机启动
    /// </summary>
    public void TotalDenial()
    {
        DenialIngenuityUncover.Instance.WolfCabinMust();
        if (FalconErie.MyUnder())//新报更改该 审核期间去掉slot显示
        {
            DenialIngenuityUncover.Instance.FollyMuchIce();
        }
        else
        {
            DenialIngenuityUncover.Instance.ItsCabinMust();
        }
        LobeGoldOfSecret();
    }


    /// <summary>
    /// 推币机暂停
    /// </summary>
    public void MuralDenial()
    {
        if(!AxHaste)
        {
            AxHaste = true;
            //推板移动
            DenialIngenuityUncover.Instance.WolfHasteMust();
            //小球停止运动
            EntombUncover.Instance.MuralEyeFast();
            //rewarditem停止运动
            MuralSecretLess();
            //slot暂停
            MuchUncover.Instance.MuchLump();
            //暂停自动掉落物品
            MuralCultGoldOfSecret();
            //fever暂停
            if (AxSourClose)
            {
                if (FalconErie.MyUnder())
                {
                    JobCloseSwayUncover.Instance.LumpClose();
                }
                else
                {
                    CloseSwayUncover.Instance.LumpClose();
                }
                StopCoroutine(nameof(ToothIllMoatSway));
            }
            if (AxSourLugBad && WetBadIllSway > 0)
            {
                StopCoroutine(nameof(WetBadIllMoatSway));
            }
            if (CalciteGoldViewRigor > 0)
            {
                StopCoroutine(nameof(IdeaSafePermNoMoatSway));
            }
        }
    }
    /// <summary>
    /// 推币机恢复
    /// </summary>
    public void ScantyDenial()
    {
        if (AxHaste)
        {
            AxHaste = false;
            //推板恢复
            DenialIngenuityUncover.Instance.WolfRetoolMust();
            //小球恢复
            EntombUncover.Instance.ScantyEyeFast();
            //rewarditem恢复
            ScantySecretLess();
            //slot恢复
            MuchUncover.Instance.MuchAtCabin();
            //恢复自动掉落物品
            ScantyCultGoldOfSecret();
            //fever恢复
            if (AxSourClose)
            {
                if (FalconErie.MyUnder())
                {
                    JobCloseSwayUncover.Instance.AtCabinCloseSway();
                }
                else
                {
                    CloseSwayUncover.Instance.AtCabinCloseSway();
                }
                StartCoroutine(nameof(ToothIllMoatSway));
            }
            if (AxSourLugBad && WetBadIllSway > 0)
            {
                StartCoroutine(nameof(WetBadIllMoatSway));
            }
            if (CalciteGoldViewRigor > 0)
            {
                StartCoroutine(nameof(IdeaSafePermNoMoatSway));
            }
        }
    }
    /// <summary>
    /// 暂停奖励物体
    /// </summary>
    void MuralSecretLess()
    {
        if (SummerLessRoost.GetComponent<LuceUncover>() != null)
        {
            List<GameObject> list = SummerLessRoost.GetComponent<LuceUncover>().King;
            foreach (GameObject rewardItem in list)
            {
                rewardItem.GetComponent<SiliceousHaste>().MuralSiliceous();
            }
        }
    }
    /// <summary>
    /// 恢复奖励物体
    /// </summary>
    void ScantySecretLess()
    {
        List<GameObject> list = SummerLessRoost.GetComponent<LuceUncover>().King;
        foreach (GameObject rewardItem in list)
        {
            rewardItem.GetComponent<SiliceousHaste>().ScantySiliceous();
        }
    }


    /// <summary>
    /// pusher奖励掉落台下
    /// </summary>
    public void WhyGoldSecret(PusherRewardType type, double rewardNum)
    {
        if (AxSourClose)
        {
            BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_getReward,0.1f);
        }
        else
        {
            BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_getReward,0.1f);
        }
        SkyStableGod();
        BulkAfricaUncover.GetInstance().OatDenialSecret(type,rewardNum);
        if (type == PusherRewardType.RollCash || type == PusherRewardType.ScratchCard || type == PusherRewardType.LuckyCard)
        {
            GripBackupLade = false;
        }
    }


    /// <summary>
    /// 触发slot
    /// </summary>
    public void TotalMuch()
    {
        if (AxHaste)
        {
            return;
        }
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
        BulkAfricaUncover.GetInstance().WhyMuchSecretBulk((slotRewardType)=> {
            MuchUncover.Instance.TossMuch(slotRewardType, () =>
            {
                Debug.Log("finish");
                if (slotRewardType != SlotRewardType.Null)
                {
                    BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_slot_reward);
                    HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
                }

                switch (slotRewardType)
                {
                    case SlotRewardType.BigWin:
                      //  SOHOShopManager.instance.AddTaskValue("777", 1);
                        LugBad();
                        break;
                    case SlotRewardType.Cash1:
                        IdeaSafeDustPermNo(25);
                        break;
                    case SlotRewardType.Cash2:
                        IdeaSafeDustPermNo(50);
                        break;
                    case SlotRewardType.Cash3:
                        IdeaSafeDustPermNo(100);
                        break;
                    case SlotRewardType.SkillWall:
                        LadTideNo();
                        break;
                    case SlotRewardType.SkillBigCoin:
                        WetViewGold();
                        break;
                    case SlotRewardType.SkillLong:
                        WolfSkyObey();
                        break;
                    case SlotRewardType.GemBlue:
                        IdeaPermNo(PusherRewardType.GemBlue);
                        break;
                    case SlotRewardType.GemRed:
                        IdeaPermNo(PusherRewardType.GemRed);
                        break;
                    case SlotRewardType.GemDiamond:
                        IdeaPermNo(PusherRewardType.GemDiamond);
                        break;
                    case SlotRewardType.Golden:
                        IdeaPermNo(PusherRewardType.Golden);
                        break;
                    case SlotRewardType.Null:
                        break;
                }
            });
        });
    }


    /// <summary>
    /// 自动掉落间隔时间
    /// </summary>
    float WeSecretCDSway= 0;
    /// <summary>
    /// 自动掉落广告奖励(现金卷/刮刮卡/翻牌)
    /// </summary>
    public void LobeGoldOfSecret()
    {
        WeSecretCDSway = SapScanTip.instance.LadeBulk.base_config.little_game_time;
        StartCoroutine(nameof(LobeGoldOfSecretMoatSway));
    }
    /// <summary>
    /// 暂停自动掉落等时
    /// </summary>
    public void MuralCultGoldOfSecret()
    {
        StopCoroutine(nameof(LobeGoldOfSecretMoatSway));
    }
    /// <summary>
    /// 恢复自动掉落等时
    /// </summary>
    public void ScantyCultGoldOfSecret()
    {
        StartCoroutine(nameof(LobeGoldOfSecretMoatSway));
    }
    /// <summary>
    /// 自动掉落等时
    /// </summary>
    /// <returns></returns>
    IEnumerator LobeGoldOfSecretMoatSway()
    {
        while(WeSecretCDSway > 0 || GripBackupLade || MoreBulkUncover.TowSmooth(CShield.Raw_Mine_Solo_Ox) == "new")
        {
            yield return new WaitForSeconds(1);
            WeSecretCDSway--;
        }
        if (!FalconErie.MyUnder())
        {
            PusherRewardType type = BulkAfricaUncover.GetInstance().WhyCultGoldOfOnce();
            IdeaPermNo(type);
            GripBackupLade = true;
        }
        LobeGoldOfSecret();
    }


    /// <summary>
    /// 技能-大金币-投掷
    /// </summary>
    public void WetViewGold()
    {
        IdeaPermNo(PusherRewardType.BigCoin, () => {
            
            WetViewShelf();
        });
    }
    /// <summary>
    /// 技能-大金币-震动
    /// </summary>
    public void WetViewShelf()
    {
        Debug.Log("大金币-震动");
        Vector3 startPos = Camera.main.transform.position;
        BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_column_bomb);
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.HeavyImpact);
        Camera.main.DOShakePosition(0.5f, 0.28f, 30, 2, true).SetEase(Ease.Linear).OnComplete(() =>
        {
            Camera.main.transform.localPosition = startPos;
        });
        for (int i = 0; i < SummerLessRoost.childCount; i++)
        {
            Transform rewardItem = SummerLessRoost.GetChild(i);
            if(rewardItem.GetComponent<Rigidbody>())
            {
                rewardItem.GetComponent<Rigidbody>().AddForce(new Vector3(0, 150, -80));
            }
        }
    }


    /// <summary>
    /// 技能-推板加长
    /// </summary>
    public void WolfSkyObey()
    {
        //单次推板加长时间
        float time = 10;
        DenialIngenuityUncover.Instance.WolfSkyObey(time);
    }


    /// <summary>
    /// 技能-墙
    /// </summary>
    public void LadTideNo()
    {
        //单次升墙时间
        float time = 10;
        DenialIngenuityUncover.Instance.LadTideNo(time);
    }


   
    /// <summary>
    /// 并排掉落多个
    /// </summary>
    /// <param name="count"></param>
    /// <param name="delay"></param>
    void IdeaSafeDustPermNo(int count)
    {
        CalciteGoldViewRigor += count;
        if (CalciteGoldViewRigor == count)
        {
            StartCoroutine(nameof(IdeaSafePermNoMoatSway));
        }
    }

    
    /// <summary>
    /// 并排掉落延迟
    /// </summary>
    /// <param name="type"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    IEnumerator IdeaSafePermNoMoatSway()
    {
        BulkAfricaUncover.GetInstance().MineGoldDustViewRigor(true, CalciteGoldViewRigor);
        while (CalciteGoldViewRigor > 0)
        {
            BulkAfricaUncover.GetInstance().MineGoldDustViewRigor(false,CalciteGoldViewRigor);
            CalciteGoldViewRigor--;
            BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_creat_coin, 0.1f);
            IdeaPermNo(PusherRewardType.CoinCash, null, (int)Mathf.PingPong(CalciteGoldViewRigor, 4) + 1);
            yield return new WaitForSeconds(0.1f);
        }
    }


    /// <summary>
    /// 从上空掉落物体
    /// </summary>
    /// <param name="dropObj"></param>
    void IdeaPermNo(PusherRewardType type, Action block = null, int index = 0)
    {
        GameObject rewardItemObj = WhySecretLess(type);
        switch (type)
        {
            case PusherRewardType.CoinGold:
                rewardItemObj.transform.eulerAngles = WhyBalladLaborStance();
                break;
            case PusherRewardType.CoinCash:
                rewardItemObj.transform.eulerAngles = WhyBalladLaborStance();
                break;
            default:
                
                break;
            
        }
        if (rewardItemObj != null)
        {
            
            if (index == 0)
            {
                rewardItemObj.transform.position = new Vector3(UnityEngine.Random.Range(-1.5f,1.5f), 7, -1.6f);
            }
            else
            {
                float[] targetXArray = new float[] {-1.6f,-0.8f,0,0.8f,1.6f };
                rewardItemObj.transform.position = new Vector3(targetXArray[index - 1], 7, -1.6f);
            }
        }
        if (block != null)
        {
            rewardItemObj.AddComponent<SewerageNoble>().LadNobleUnload(block);
        }
    }


    /// <summary>
    /// 根据类型获得对应奖励物体
    /// </summary>
    /// <returns></returns>
    public GameObject WhySecretLess(PusherRewardType type)
    {
        GameObject rewardItem = SummerLessRoost.GetComponent<LuceUncover>().TowWander();
        rewardItem.GetComponent<DenialSecretLess>().BookSecretLess(type);
        rewardItem.GetComponent<Rigidbody>().velocity = Vector3.zero;
        rewardItem.transform.eulerAngles = Vector3.zero;
        rewardItem.SetActive(true);
        return rewardItem;
    }

    bool AxElevenPicnic= false;
    /// <summary>
    /// 777
    /// </summary>
    void LugBad()
    {
        PlowSenseGarden.GetInstance().CanySense("1005");
        BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_slot_777);
        AxSourLugBad = true;
        fX_LugBad.SetActive(true);
        DenialIngenuityUncover.Instance.WolfEyeMust(()=> {
            centerTopi.GetComponent<Rigidbody>().DOMoveY(-3, 0.5f).OnComplete(() => {
                BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_enter_allbox);
                GameObject pagodaGroup = PoundViewEleven(20);
                centerTopi.transform.DOMoveY(0.664f, 0.5f);
                EntombUncover.Instance.PoundSeekView(10);
                AxElevenPicnic = false;
                pagodaGroup.transform.DOMoveY(0.74f,2f).OnComplete(()=> {
                    BondElevenAboard(pagodaGroup);
                });
            });
        });
        
    }
    /// <summary>
    /// 创建币塔
    /// </summary>
    /// <param name="heightCount">币塔层数</param>
    GameObject PoundViewEleven(int heightCount, bool isLoad = false)
    {
        bool isUnlock = false;
        List<Vector3> pointList = new List<Vector3>();
        List<Vector3> eulerList = new List<Vector3>();
        for (int i = 0; i < BondElevenViewer.transform.childCount; i++)
        {
            Transform targetTrans = BondElevenViewer.transform.GetChild(i);
            pointList.Add(targetTrans.localPosition);
            eulerList.Add(targetTrans.eulerAngles);
        }
        GameObject pagodaGroup = new GameObject();
        pagodaGroup.AddComponent<PicnicEleven>().Front = () =>
        {
            if (!isUnlock)
            {
                isUnlock = true;
                pagodaGroup.GetComponent<PicnicEleven>().enabled = false;
                //Destroy(pagodaGroup.GetComponent<Rigidbody>());
                //for (int i = 0; i < pagodaGroup.transform.childCount; i++)
                //{
                //    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
                //    cashCoin.AddComponent<Rigidbody>();
                //    cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
                //    cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
                //}
            }
        };
        pagodaGroup.transform.position = new Vector3(0, centerTopi.transform.position.y + 0.076f, -3.671f);
        pagodaGroup.transform.SetParent(DenialUncover.Instance.SummerLessRoost);
        for (int i = 0; i < heightCount; i++)
        {
            GameObject tempObject = new GameObject();
            for (int j = 0; j < 7; j++)
            {
                GameObject cashCoin = DenialUncover.Instance.WhySecretLess(PusherRewardType.CoinCash);
                cashCoin.transform.SetParent(tempObject.transform);
                cashCoin.transform.localPosition = pointList[j];
                cashCoin.transform.eulerAngles = eulerList[j];
                cashCoin.layer = 0;
                if (!isLoad)
                {
                    Destroy(cashCoin.GetComponent<Rigidbody>());
                }
            }
            tempObject.transform.position = pagodaGroup.transform.position + new Vector3(0, 0.1074f * i, 0);
            tempObject.transform.eulerAngles = new Vector3(0, i * 3, 0);
            for (int k = tempObject.transform.childCount - 1; k >= 0; k--)
            {
                tempObject.transform.GetChild(k).SetParent(pagodaGroup.transform);
            }
            Destroy(tempObject);
        }
        return pagodaGroup;
    }
    
    /// <summary>
    /// 币塔解封
    /// </summary>
    /// <param name="pagodaGroup"></param>
    void BondElevenAboard(GameObject pagodaGroup)
    {

        //for (int i = 0; i < pagodaGroup.transform.childCount; i++)
        //{
        //    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
        //    cashCoin.layer = 6;
        //}
        //pagodaGroup.layer = 6;
        //pagodaGroup.AddComponent<Rigidbody>().mass = 30;
        //isUnlock = true;
        //Destroy(pagodaGroup.GetComponent<Rigidbody>());
        AxElevenPicnic = true;
        for (int i = pagodaGroup.transform.childCount - 1; i >= 0; i--)
        {
            Debug.Log(i);
            GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
            cashCoin.AddComponent<Rigidbody>();
            cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
            cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
            cashCoin.transform.SetParent(SummerLessRoost);
            if (AxHaste)
            {
                cashCoin.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        fX_LugBad.SetActive(false);
        WetBadIllSway = 5f;
        StartCoroutine(nameof(WetBadIllMoatSway));
    }
    float WetBadIllSway= 0;
    /// <summary>
    /// 777结算
    /// </summary>
    IEnumerator WetBadIllMoatSway()
    {
        while(WetBadIllSway > 0)
        {
            yield return new WaitForSeconds(1);
            WetBadIllSway--;
        }
        AxSourLugBad = false;
        BulkAfricaUncover.GetInstance().WetBadIll();
        if (!AxSourClose)
        {
            //奖励弹窗
            SecretPlankUncover.Instance.PearLugSecretPlank(GameUtil.GetBigWinCash());
        }
    }


    /// <summary>
    /// 开始fever
    /// </summary>
    public void ToothCabin()
    {
        BrownTip.GetInstance().TossMe(BrownOnce.UIMusic.sound_fever_bgm);
        DenialUncover.Instance.AxSourClose = true;
        DenialIngenuityUncover.Instance.WolfCabinMust(true);
        EntombUncover.Instance.ToothCabinIcePottery(10);
        EntombUncover.Instance.ToothCabinCultGoldFast();
        fX_Close.SetActive(true);
        foreach (GameObject fx_Box in fX_IceRoost.GetComponent<IceRoost>().Redesign)
        {
            fx_Box.GetComponent<Outright>().FX_Flora.SetActive(true);
        }
        ToothSway = SapScanTip.instance.LadeBulk.base_config.fever_time;
        StartCoroutine(nameof(ToothIllMoatSway));
    }
    /// <summary>
    /// fever剩余时间
    /// </summary>
    float ToothSway= 0;
    /// <summary>
    /// 结束fever等时
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    IEnumerator ToothIllMoatSway()
    {
        while (ToothSway > 0)
        {
            yield return new WaitForSeconds(1);
            ToothSway--;
        }
        fX_Close.SetActive(false);
        foreach (GameObject fx_Box in fX_IceRoost.GetComponent<IceRoost>().Redesign)
        {
            fx_Box.GetComponent<Outright>().FX_Flora.SetActive(false);
        }
        AxSourClose = false;
        DenialIngenuityUncover.Instance.WolfCabinMust(true);
        EntombUncover.Instance.ToothIllIcePottery();
        EntombUncover.Instance.ToothIllCultGoldFast();
        ToothIll();
    }
    /// <summary>
    /// fever结算
    /// </summary>
    void ToothIll()
    {
        BulkAfricaUncover.GetInstance().ToothIll();
        BrownTip.GetInstance().TossMe(BrownOnce.UIMusic.sound_bgm);
        if (!AxSourLugBad)
        {
            //结算弹窗
            SecretPlankUncover.Instance.PearLugSecretPlank(GameUtil.GetBigWinCash());
        }
    }


    public void TossClose() 
    {
        foreach (SpriteRenderer sr in TwelveRoost.GetComponent<TwelveUncover>().PebblePeal) 
        {
            sr.sprite = Resources.Load<Sprite>(CShield.Law_8);
        }
        
    }

    /// <summary>
    /// fever累计次数
    /// </summary>
    public void SkyStableGod()
    {
        if (!AxSourClose)
        {
            // 增加fever 数值
            if (FalconErie.MyUnder())
            {
                JobCloseSwayUncover.Instance.SkyCloseFast();
            }
            else
            {
                CloseSwayUncover.Instance.SkyCloseFast();
            }
            ThunderStableGod++;
            if (ThunderStableGod >= SapScanTip.instance.LadeBulk.base_config.fever_limit)
            {
                ThunderStableGod = 0;
                ToothCabin();
            }
        }
        
    }


    

    Vector3 WhyBalladLaborStance()
    {
        Vector3 v3 = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));
        return v3;
    }



    /// <summary>
    /// 保存全部物体
    /// </summary>
    public void HintEyeSecretLess()
    {
        List<RewardItemSaveData> saveList = new List<RewardItemSaveData>();
        if (AxSourLugBad && !AxElevenPicnic)
        {
            foreach (GameObject item in SummerLessRoost.GetComponent<LuceUncover>().King)
            {
                if (item.activeSelf && item.transform.parent == SummerLessRoost && item.GetComponent<DenialSecretLess>().SummerOnce != PusherRewardType.BigCoin)
                {
                    RewardItemSaveData saveData = new RewardItemSaveData();
                    saveData.type = item.GetComponent<DenialSecretLess>().SummerOnce;
                    saveData.num = item.GetComponent<DenialSecretLess>().SummerGod;
                    saveData.x = item.transform.position.x;
                    saveData.y = item.transform.position.y;
                    saveData.z = item.transform.position.z;
                    saveData.No = item.transform.eulerAngles.x;
                    saveData.Dy = item.transform.eulerAngles.y;
                    saveData.So = item.transform.eulerAngles.z;
                    saveList.Add(saveData);
                }
            }
            MoreBulkUncover.GunWhen("save_data_inbigwin", true);
        }
        else
        {
            foreach (GameObject item in SummerLessRoost.GetComponent<LuceUncover>().King)
            {
                if (item.activeSelf && item.GetComponent<DenialSecretLess>().SummerOnce != PusherRewardType.BigCoin)
                {
                    RewardItemSaveData saveData = new RewardItemSaveData();
                    saveData.type = item.GetComponent<DenialSecretLess>().SummerOnce;
                    saveData.num = item.GetComponent<DenialSecretLess>().SummerGod;
                    saveData.x = item.transform.position.x;
                    saveData.y = item.transform.position.y;
                    saveData.z = item.transform.position.z;
                    saveData.No = item.transform.eulerAngles.x;
                    saveData.Dy = item.transform.eulerAngles.y;
                    saveData.So = item.transform.eulerAngles.z;
                    saveList.Add(saveData);
                }
            }
            MoreBulkUncover.GunWhen("save_data_inbigwin", false);
        }
        //SaveData savedata = new SaveData();
        //savedata.saveList = saveList;
        string saveJson = JsonMapper.ToJson(saveList);
        MoreBulkUncover.GunSmooth("save_data",saveJson);
    }

    /// <summary>
    /// 读取全部物体
    /// </summary>
    public void YardEyeSecretLess()
    {
        string saveJson = MoreBulkUncover.TowSmooth("save_data");
        if (saveJson != null && saveJson.Length > 0)
        {
            foreach (GameObject rewardItem in SummerLessRoost.GetComponent<LuceUncover>().King)
            {
                rewardItem.SetActive(false);
            }
            List<RewardItemSaveData> saveList = JsonMapper.ToObject<List<RewardItemSaveData>>(saveJson);
            if (MoreBulkUncover.TowWhen("save_data_inbigwin"))
            {
                PoundViewEleven(20,true);
            }
            foreach (RewardItemSaveData data in saveList)
            {
                if (data.type == PusherRewardType.ScratchCard || data.type == PusherRewardType.LuckyCard || data.type == PusherRewardType.RollCash)
                {
                    GripBackupLade = true;
                }
                GameObject rewardItem = SummerLessRoost.GetComponent<LuceUncover>().TowWander();
                rewardItem.transform.position = new Vector3((float)data.x, (float)data.y, (float)data.z);
                rewardItem.transform.eulerAngles = new Vector3((float)data.No, (float)data.Dy, (float)data.So);
                rewardItem.GetComponent<DenialSecretLess>().BookSecretLess(data.type,false);
            }
        } else
        {
            if (FalconErie.MyUnder())
            {
                foreach (GameObject coin in SummerLessRoost.GetComponent<LuceUncover>().King)
                {
                    if (coin.activeSelf)
                    {
                        coin.GetComponent<DenialSecretLess>().BookSecretLess(PusherRewardType.CoinGold,false);
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            LugBad();
        // SecretPlankUncover.Instance.ShowBigRewardPanel(10);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WetViewGold();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            IdeaSafeDustPermNo(25);
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            DenialMuchIceSewerage.Instance.TossAgeMuch();

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            IdeaPermNo(PusherRewardType.GemRed);
            IdeaPermNo(PusherRewardType.GemBlue);
            IdeaPermNo(PusherRewardType.GemDiamond);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!AxHaste)
            {
                MuralDenial();
            }
            else
            {
                ScantyDenial();
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToothCabin();
        }
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    SOHOShopManager.instance.AddTaskValue("777", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    SOHOShopManager.instance.AddTaskValue("golden", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    SOHOShopManager.instance.AddTaskValue("AD", 1);
        //}
    }


    

}
//public class SaveData
//{
//    public List<RewardItemSaveData> saveList;
//}
public class RewardItemSaveData
{
    public PusherRewardType type;
    public double num;
    public double x;
    public double y;
    public double z;
    public double No;
    public double Dy;
    public double So;
}