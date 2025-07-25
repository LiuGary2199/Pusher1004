// Project: Plinko
// FileName: VerifyBadFlairPlank.cs
// Author: AX
// CreateDate: 20230515
// CreateTime: 16:01
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Spine.Unity;

public class VerifyBadFlairPlank : GoldUIStain
{
    public static VerifyBadFlairPlank Instance;
[UnityEngine.Serialization.FormerlySerializedAs("normalSlot")]
    public VerifyMuchInstrument VirtueMuch;
[UnityEngine.Serialization.FormerlySerializedAs("getMoreBtn")]
    public Button WhyHangWeb;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button WhyWeb;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop01")]
    public GameObject SummerEat01;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop02")]    public GameObject SummerEat02;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop03")]    public GameObject SummerEat03;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]
    public SkeletonGraphic AllowHurl;


    private Dictionary<NormalRewardType, double> SummerArc;


    private string CreepOnce;

    private string Inuit2;
    private string Inuit3;

    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        //BrownTip.GetInstance().PlayEffect(BrownOnce.UIMusic.sound_bigwin1_open);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }
    private void Start()
    {
        WhyHangWeb.onClick.AddListener(() =>
        {
            ADUncover.Variance.PourSecretSteel((success) =>
            {
                CreepOnce = "1";
                WhyHangWeb.gameObject.SetActive(false);
                WhyWeb.gameObject.SetActive(false);
                TossMuch();
            }, MoreBulkUncover.TowSmooth(CShield.Dy_Virtue_LIf_We_If));
        });

        WhyWeb.onClick.AddListener(() =>
        {
            ADUncover.Variance.ToBreechSkyRigor();
            CreepOnce = "0";
            TowSecret();
        });
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        SummerArc = new Dictionary<NormalRewardType, double>();
    }

    public void PassBulk(Dictionary<NormalRewardType, double> map)
    {
        BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_bigwin1_open);

        AllowHurl.AnimationState.SetAnimation(0, "chuxian", false);
        AllowHurl.AnimationState.AddAnimation(0, "daiji", true, 0f);

        VirtueMuch.PassMessy();
        WhyHangWeb.gameObject.SetActive(true);
        WhyWeb.gameObject.SetActive(true);
        WhyWeb.GetComponent<CanvasGroup>().alpha = 0f;
        WhyWeb.enabled = false;

        DOTween.To(x => WhyWeb.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() =>
        {
            WhyWeb.enabled = true;
        });
        SummerArc = map;

        SummerEat02.gameObject.SetActive(false);
        SummerEat02.gameObject.SetActive(false);
        SummerEat03.gameObject.SetActive(false);
        SummerEat01.transform.localScale = new Vector3(1f, 1f, 1f);
        SummerEat02.transform.localScale = new Vector3(1f, 1f, 1f);
        SummerEat03.transform.localScale = new Vector3(1f, 1f, 1f);

        List<NormalRewardType> keyList = new List<NormalRewardType>();
        List<double> valueList = new List<double>();

        foreach (var item in SummerArc)
        {
            keyList.Add(item.Key);
            valueList.Add(item.Value);
        }

        if (SummerArc.Count == 1)
        {
            SummerEat01.transform.localPosition = new Vector3(0f, 380f, 0f);
            SummerEat01.transform.localScale *= 1.2f;
            SummerEat01.gameObject.SetActive(true);
            SummerEat01.gameObject.GetComponent<VerifySecretEatInstrument>().PassBulk(keyList[0], valueList[0]);
            Inuit2 = valueList[0].ToString();
            Inuit3 = TowFlask3(keyList[0]);
        }

        if (SummerArc.Count == 2)
        {
            SummerEat01.transform.localPosition = new Vector3(-220f, 350f, 0f);
            SummerEat02.transform.localPosition = new Vector3(220f, 350f, 0f);

            SummerEat01.gameObject.SetActive(true);
            SummerEat02.gameObject.SetActive(true);
            SummerEat01.gameObject.GetComponent<VerifySecretEatInstrument>().PassBulk(keyList[0], valueList[0]);
            SummerEat02.gameObject.GetComponent<VerifySecretEatInstrument>().PassBulk(keyList[1], valueList[1]);
            Inuit2 = "0";
            Inuit3 = "0";
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i] == NormalRewardType.Cash)
                {
                    Inuit2 = valueList[i].ToString();
                    Inuit3 = "1";
                }
            }
        }

        if (SummerArc.Count == 3)
        {
            SummerEat01.transform.localPosition = new Vector3(0f, 500f, 0f);
            SummerEat02.transform.localPosition = new Vector3(-240f, 250f, 0f);
            SummerEat03.transform.localPosition = new Vector3(240f, 250f, 0f);

            SummerEat01.transform.localScale *= 0.8f;
            SummerEat02.transform.localScale *= 0.8f;
            SummerEat03.transform.localScale *= 0.8f;

            SummerEat01.gameObject.SetActive(true);
            SummerEat02.gameObject.SetActive(true);
            SummerEat03.gameObject.SetActive(true);

            SummerEat01.gameObject.GetComponent<VerifySecretEatInstrument>().PassBulk(keyList[0], valueList[0]);
            SummerEat02.gameObject.GetComponent<VerifySecretEatInstrument>().PassBulk(keyList[1], valueList[1]);
            SummerEat03.gameObject.GetComponent<VerifySecretEatInstrument>().PassBulk(keyList[2], valueList[2]);

            Inuit2 = "0";
            Inuit3 = "0";
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i] == NormalRewardType.Cash)
                {
                    Inuit2 = valueList[i].ToString();
                    Inuit3 = "1";
                }
            }
        }
    }

    private int TowMuchTwain()
    {
        int sumWeight = 0;
        foreach (RewardMultiItem wg in SapScanTip.instance.PassBulk.RewardMultiList)
        {
            sumWeight += wg.weight;
        }

        int r = Random.Range(0, sumWeight);
        int nowWeight = 0;
        int Onset= 0;
        foreach (RewardMultiItem wg in SapScanTip.instance.PassBulk.RewardMultiList)
        {
            nowWeight += wg.weight;
            if (nowWeight > r)
            {
                return Onset;
            }

            Onset++;
        }

        return 0;
    }


    private string TowFlask3(NormalRewardType type)
    {
        switch (type)
        {
            case NormalRewardType.Cash:
                return "1";
            case NormalRewardType.Gold:
                return "2";
            default:
                return "3";
        }
    }


    private void TossMuch()
    {
        int Onset= TowMuchTwain();
        VirtueMuch.SaltMuch(Onset, (multi) =>
        {
            if (SummerEat01.activeInHierarchy)
            {
                SummerEat01.gameObject.GetComponent<VerifySecretEatInstrument>().SenateGodHurl(multi);
            }

            if (SummerEat02.activeInHierarchy)
            {
                SummerEat02.gameObject.GetComponent<VerifySecretEatInstrument>().SenateGodHurl(multi);
            }

            if (SummerEat03.activeInHierarchy)
            {
                SummerEat03.gameObject.GetComponent<VerifySecretEatInstrument>().SenateGodHurl(multi);
            }

            Invoke(nameof(TowSecret), 1f);
        });
    }

    private void FollyVerifyPlank()
    {
        if (MoreBulkUncover.TowSmooth(CShield.Dy_Virtue_Lid_Weld) == "1014")
        {
            Inuit3 = "1";
            String gemType = MoreBulkUncover.TowSmooth(CShield.Dy_Teem_Weld);
            switch (gemType)
            {
                case "Yellow":
                    Inuit3 = "1";
                    break;
                case "Blue":
                    Inuit3 = "2";
                    break;
                case "Silver":
                    Inuit3 = "3";
                    break;
                default:
                    Inuit3 = "4";
                    break;
            }

            PlowSenseGarden.GetInstance()
                .CanySense(MoreBulkUncover.TowSmooth(CShield.Dy_Virtue_Lid_Weld), CreepOnce, Inuit2, Inuit3);
        }
        else
        {
            PlowSenseGarden.GetInstance()
                .CanySense(MoreBulkUncover.TowSmooth(CShield.Dy_Virtue_Lid_Weld), CreepOnce, Inuit2, Inuit3);
        }

        FanwiseEnergyHatch.GetInstance().Cany(CShield.msg_Video_Fluid_Key_Total);
        // FanwiseEnergyHatch.GetInstance().Send(CShield.msg_show_cash_mask);

        FollyUIPeak(GetType().Name);
    }

    private void TowSecret()
    {
        if (SummerEat01.activeInHierarchy)
        {
            SummerEat01.gameObject.GetComponent<VerifySecretEatInstrument>().TowVerifyBadSecret();
        }

        if (SummerEat02.activeInHierarchy)
        {
            SummerEat02.gameObject.GetComponent<VerifySecretEatInstrument>().TowVerifyBadSecret();
        }

        if (SummerEat03.activeInHierarchy)
        {
            SummerEat03.gameObject.GetComponent<VerifySecretEatInstrument>().TowVerifyBadSecret();
        }

        FollyVerifyPlank();
    }
}