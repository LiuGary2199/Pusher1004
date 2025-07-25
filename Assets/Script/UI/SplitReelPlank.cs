// Project: Pusher
// FileName: SplitReelPlank.cs
// Author: AX
// CreateDate: 20230803
// CreateTime: 15:55
// Description:

using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;
using Spine.Unity;

public class SplitReelPlank : GoldUIStain
{
    public static SplitReelPlank Instance;
[UnityEngine.Serialization.FormerlySerializedAs("luckyCardList")]
    public List<GameObject> GammaReelPeal;
[UnityEngine.Serialization.FormerlySerializedAs("selectObjList")]    public List<GameObject> TurtleCopPeal;
[UnityEngine.Serialization.FormerlySerializedAs("rewardMap")]
    public Dictionary<NormalRewardType, double> SummerArc;
[UnityEngine.Serialization.FormerlySerializedAs("luckyObjDataList")]
    public List<LuckyObjData> GammaCopBulkPeal;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]
    public bool AxRome;
    private bool AxSate;
[UnityEngine.Serialization.FormerlySerializedAs("onThanksWeight")]
    public int GoBreechGospel;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]
    public SkeletonGraphic AllowHurl;

    private int BillRigor;
    private int LidYewRigor;

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        LidYewRigor = SapScanTip.instance.LadeBulk.base_config.lucky_card_win_max_count;
    }

    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        PassSplitReel();
        AllowHurl.AnimationState.SetAnimation(0, "chuxian", false);
        AllowHurl.AnimationState.AddAnimation(0, "daiji", true, 0f);
        BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_littlegame_show);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }

    private void Start()
    {
        FanwiseEnergyHatch.GetInstance().Engineer(CShield.msg_Video_Fluid_Key_Total,
            (messageData) => { FollySplitReelPlank(); });
    }

    private void FollySplitReelPlank()
    {
        if (!gameObject.activeInHierarchy) return;
        FollyUIPeak(GetType().Name);
    }

    public void PassSplitReel()
    {
        BillRigor = Random.Range(2, LidYewRigor) + 1;
        GammaCopBulkPeal = new List<LuckyObjData>();

        AxRome = true;
        AxSate = false;
        for (int i = 0; i < GammaReelPeal.Count; i++)
        {
            GameObject obj = GammaReelPeal[i].gameObject;
            if (i == 4)
            {
                obj.GetComponent<SplitReelInstrument>().PassBreechCopBulk();
            }
            else
            {
                LuckyObjData objData = GameUtil.GetLuckyCardObjData();
                GammaCopBulkPeal.Add(objData);
                obj.GetComponent<SplitReelInstrument>().PassSecretCopBulk(objData);
            }

            obj.GetComponent<SplitReelInstrument>().At_Epic.SetActive(false);
        }

        TurtleCopPeal = new List<GameObject>();
        SummerArc = new Dictionary<NormalRewardType, double>();

        Invoke(nameof(MyCup), 3f);
    }


    private void MyCup()
    {
        float EnjoySway= 0.5f;

        for (int i = 0; i < GammaReelPeal.Count; i++)
        {
            GameObject obj = GammaReelPeal[i].gameObject;
            Vector3 objPos = obj.transform.localPosition;

            //obj.GetComponent<SplitReelInstrument>().CloseObj(); 
            obj.GetComponent<SplitReelInstrument>().KiwiIngenuity(obj, obj.GetComponent<SplitReelInstrument>().BG,
                obj.GetComponent<SplitReelInstrument>().ByEar, () => { },
                () =>
                {
                    obj.transform.DOLocalMove(new Vector3(0, 0, 0), 0.5f).OnComplete(() =>
                    {
                        obj.transform.DOLocalMove(objPos, 0.5f).SetDelay(EnjoySway);
                    });
                });
            EnjoySway = +0.1f;
        }

        Invoke(nameof(EpicRome), 2f);
    }

    private void EpicRome()
    {
        AxRome = false;
    }

    private void SkySecretArc(LuckyObjData rewardObj)
    {
        string type = rewardObj.LuckyObjType.ToString();
        NormalRewardType SummerOnce= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
        if (SummerArc.ContainsKey(SummerOnce))
        {
            SummerArc[SummerOnce] =
                SummerArc[SummerOnce] + rewardObj.RewardNum;
        }
        else
        {
            SummerArc.Add(SummerOnce, rewardObj.RewardNum);
        }
    }

    private void PearFlairPlank()
    {
        for (int i = 0; i < GammaReelPeal.Count; i++)
        {
            GameObject obj = GammaReelPeal[i].gameObject;
            obj.GetComponent<SplitReelInstrument>().At_Epic.SetActive(false);
        }
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_Lid_Weld, "1011");
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_LIf_We_If,"4");
        SecretPlankUncover.Instance.PearVerifySecretPlank(SummerArc);
    }

    public void SkyExceedPeal(GameObject obj)
    {
        TurtleCopPeal.Add(obj);

        if (TurtleCopPeal.Count < BillRigor && !AxSate)
        {
            int num = Random.Range(0, GammaCopBulkPeal.Count);
            LuckyObjData objData = GammaCopBulkPeal[num];
            obj.GetComponent<SplitReelInstrument>().KiwiIngenuity(obj, obj.GetComponent<SplitReelInstrument>().ByEar,
                obj.GetComponent<SplitReelInstrument>().BG, () =>
                {
                    obj.GetComponent<SplitReelInstrument>().At_Epic.SetActive(true);
                    obj.GetComponent<SplitReelInstrument>().PassSecretCopBulk(objData);
                }, () => { });
            SkySecretArc(objData);
            GammaCopBulkPeal.Remove(objData);
        }
        else
        {
            BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_scratch_reward);
            AxSate = true;
            AxRome = true;
            obj.GetComponent<SplitReelInstrument>().KiwiIngenuity(obj, obj.GetComponent<SplitReelInstrument>().ByEar,
                obj.GetComponent<SplitReelInstrument>().BG,
                () => { obj.GetComponent<SplitReelInstrument>().PassBreechCopBulk(); }, () => { });
            Invoke(nameof(PearFlairPlank), 2f);
        }
    }
}