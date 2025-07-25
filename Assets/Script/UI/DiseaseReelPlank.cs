// Project: Plinko
// FileName: DiseaseReelPlank.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 10:28
// Description:

using System;
using System.Collections.Generic;
using DG.Tweening;
using ScratchCardAsset;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DiseaseReelPlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    // public SkeletonGraphic titleAnim;

    public Button VideoWeb;
[UnityEngine.Serialization.FormerlySerializedAs("targetCard")]
    public ScratchCardManager NotionReel;
[UnityEngine.Serialization.FormerlySerializedAs("mainCard")]    public ScratchCardManager BarbReel;
[UnityEngine.Serialization.FormerlySerializedAs("cardLessProgress")]
    public float ZoneNearProbable;
[UnityEngine.Serialization.FormerlySerializedAs("targetNum01")]
    public Text NotionGod01;
[UnityEngine.Serialization.FormerlySerializedAs("targetNum02")]    public Text NotionGod02;
[UnityEngine.Serialization.FormerlySerializedAs("mainCardObjList")]
    public List<DiseaseCopInstrument> BarbReelCopPeal;

    private bool NotionReelWith;
    private bool BarbReelWith;

    private int ClassicBadYewRigor;
    private int BillBadRigor;

    private List<int> NotionGodPeal;

    private Dictionary<NormalRewardType, double> SummerArc;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]    
    public SkeletonGraphic AllowHurl;


    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        PlowSenseGarden.GetInstance().CanySense("1008");

        AllowHurl.AnimationState.SetAnimation(0, "chuxian", false);
        AllowHurl.AnimationState.AddAnimation(0, "daiji", true, 0f);

        NotionReelWith = false;
        BarbReelWith = false;

        PassLadeBulk();
        BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_littlegame_show);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }
    protected override void Awake()
    {
        base.Awake();
        ClassicBadYewRigor = SapScanTip.instance.LadeBulk.base_config.scratch_win_max_count;
        //scratchWinMaxCount = 3;
        BillBadRigor = 0;
    }

    private void Start()
    {
        VideoWeb.onClick.AddListener(() => { FollyDiseaseReelPlank(); });

        FanwiseEnergyHatch.GetInstance().Engineer(CShield.msg_Video_Fluid_Key_Total,
            (messageData) => { FollyDiseaseReelPlank(); });
        
        PassLadeBulk();
    }

    private void Update()
    {
        if (!NotionReelWith && NotionReel.Progress.GetProgress() > 0.7f)
        {
            NotionReelWith = true;
            NotionReel.FillScratchCard();
            if (BarbReelWith)
            {
                PearDiseaseFlair();
            }
        }

        if (!BarbReelWith && BarbReel.Progress.GetProgress() > ZoneNearProbable)
        {
            BarbReelWith = true;
            BarbReel.FillScratchCard();
            if (NotionReelWith)
            {
                PearDiseaseFlair();
            }
        }
    }


    private void PearBackupFlairPlank()
    {
        if (SummerArc.Count > 0)
        {
            MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_Lid_Weld, "1009");
 
            MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_LIf_We_If,"3");
            SecretPlankUncover.Instance.PearVerifySecretPlank(SummerArc);
            // VerifyBadFlairPlank.Instance.InitData(rewardMap, GetType().Name);
        }
        else
        {
            FollyDiseaseReelPlank();
        }
    }

    private void PearDiseaseFlair()
    {
        List<DiseaseCopInstrument> FenPeal= new List<DiseaseCopInstrument>();


        foreach (DiseaseCopInstrument obj in BarbReelCopPeal)
        {
            if (NotionGodPeal.Contains(obj.BarbGod))
            {
                string type = obj.ClassicCopBulk.ScratchObjType.ToString();
                NormalRewardType SummerOnce= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
                if (SummerArc.ContainsKey(SummerOnce))
                {
                    SummerArc[SummerOnce] =
                        SummerArc[SummerOnce] + obj.ClassicCopBulk.RewardNum;
                }
                else
                {
                    SummerArc.Add(SummerOnce, obj.ClassicCopBulk.RewardNum);
                }

                FenPeal.Add(obj);
            }
        }

        float timeTemp = 0f;

        for (int i = 0; i < FenPeal.Count; i++)
        {
            DiseaseCopInstrument obj = FenPeal[i];
            obj.transform.DOScale(1, 0f).SetDelay(timeTemp).OnComplete(() => { obj.PearAlbedo(); });

            timeTemp += 0.15f;
        }

        Invoke(nameof(PearBackupFlairPlank), 0.6f + timeTemp);
    }


    private int TowBalladCopGod()
    {
        return Random.Range(1, 71);
    }

    private void PassLadeBulk()
    {
        SummerArc = new Dictionary<NormalRewardType, double>();
        NotionGodPeal = TowAlbedoPeal();
        BillBadRigor = Random.Range(2, ClassicBadYewRigor);

        NotionReel.MainCamera = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();;
        BarbReel.MainCamera = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();;
 
        List<int> mainNumList = new List<int>();
        for (int i = 0; i < BillBadRigor; i++)
        {
            int Onset= Random.Range(0, 2);
            int num = NotionGodPeal[Onset];
            mainNumList.Add(num);
        }

        while (mainNumList.Count < 9)
        {
            int num = TowBalladCopGod();
            if (!mainNumList.Contains(num))
            {
                mainNumList.Add(num);
            }
        }

        mainNumList = BalladErie.BalladHour(mainNumList);

        for (int i = 0; i < mainNumList.Count; i++)
        {
            BarbReelCopPeal[i].PassBulk(mainNumList[i], NotionGodPeal.Contains(mainNumList[i]));
        }
    }

    private List<int> TowAlbedoPeal()
    {
        List<int> targetList = new List<int>();
        int num1 = TowBalladCopGod();
        targetList.Add(num1);
        int num2 = TowBalladCopGod();
        while (num1 == num2)
        {
            num2 = TowBalladCopGod();
        }

        targetList.Add(num2);
        NotionGod01.text = num1.ToString();
        NotionGod02.text = num2.ToString();

        return targetList;
    }

    private void FollyDiseaseReelPlank()
    {
        if (!gameObject.activeInHierarchy) return;
        NotionReel.ClearScratchCard();
        BarbReel.ClearScratchCard();
        Invoke(nameof(FollyPlank), 0.2f);
    }

    private void FollyPlank()
    {
        // MoreBulkUncover.SetInt(CShield.sv_ad_trial_num, MoreBulkUncover.GetInt(CShield.sv_ad_trial_num) + 1);
        CropUncover.Instance.LadeAmateur();
        FollyUIPeak(GetType().Name);

        // PillarManager.Instance.StartLittleGameTimeBar();
        // EntombUncover.Instance.ReStartGame();
        // MuchUncover.Instance.inLittleGame = false;
    }
}