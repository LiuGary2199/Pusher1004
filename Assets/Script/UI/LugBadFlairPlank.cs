// Project: Plinko
// FileName: LugBadFlairPlank.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 16:00
// Description:

using System;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class LugBadFlairPlank : GoldUIStain
{
    public static LugBadFlairPlank Instance;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinBGAnim")]
    public SkeletonGraphic WetBadBGHurl;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinWordAnim")]    public SkeletonGraphic WetBadIncaHurl;
[UnityEngine.Serialization.FormerlySerializedAs("getMoreBtn")]
    public Button WhyHangWeb;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button WhyWeb;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]
    public GameObject WeMad;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]    public GameObject WhyWebPort;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
    public GameObject SinkMad;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
    public Text SummerPort;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinType")]
    public BigWinType WetBadOnce;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]
    public double SummerGod;

    private string CreepOnce;

    public override void Display()
    {
        base.Display();
        //BrownTip.GetInstance().PlayEffect(BrownOnce.UIMusic.sound_bigwin2_open);
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    private void Start()
    {
        WhyHangWeb.onClick.AddListener(() =>
        {
            if (MoreBulkUncover.TowSmooth(CShield.Dy_Relax_Levy_Lid_Summer) == "new")
            {
                MoreBulkUncover.GunSmooth(CShield.Dy_Relax_Levy_Lid_Summer, "done");
                MoreBulkUncover.GunSmooth(CShield.Dy_Total_Dry_Its, "done");

                FanwiseEnergyHatch.GetInstance().Cany(CShield.Raw_Mine_Sink_Reef);
                TowSecret();
            }
            else
            {
                ADUncover.Variance.PourSecretSteel((success) =>
                {
                    CreepOnce = "1";
                    TowSecret();
                }, "2");
            }
        });

        WhyWeb.onClick.AddListener(() =>
        {
            CreepOnce = "0";
            ADUncover.Variance.ToBreechSkyRigor();
            FollyPlank();
        });
    }

    public void PassBulk(double num)
    {
        ADUncover.Variance.HasteSwayParticipator();
        BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_bigwin2_open);
        SummerGod = num;
        SummerPort.text = "" + SummerGod;
        PassHurl();

        if (MoreBulkUncover.TowSmooth(CShield.Dy_Relax_Levy_Lid_Summer) == "new")
        {
            WhyWeb.gameObject.SetActive(false);
            WeMad.gameObject.SetActive(false);
            WhyWebPort.transform.localPosition = new Vector3(0f, 0f, 0f);
            MoreBulkUncover.GunWok(CShield.Dy_We_Exert_Ice, MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice) + 1);
        }
        else
        {
            WhyWebPort.transform.localPosition = new Vector3(37f, 0f, 0f);
            WeMad.gameObject.SetActive(true);
            WhyWeb.gameObject.SetActive(true);
            WhyWeb.GetComponent<CanvasGroup>().alpha = 0f;
            WhyWeb.enabled = false;

            DOTween.To(x => WhyWeb.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() =>
            {
                WhyWeb.enabled = true;
            });
        }
    }


    private void PassHurl()
    {
        WetBadBGHurl.AnimationState.SetAnimation(0, "chuxian", false);
        WetBadBGHurl.AnimationState.AddAnimation(0, "daiji", true, 0f);
        switch (WetBadOnce)
        {
            case BigWinType.BigWin:
                WetBadIncaHurl.AnimationState.SetAnimation(0, "Big_chuxian", false);
                WetBadIncaHurl.AnimationState.AddAnimation(0, "Big_daiji", true, 0f);

                break;
            case BigWinType.HugeWin:
                WetBadIncaHurl.AnimationState.SetAnimation(0, "Huge_chuxian", false);
                WetBadIncaHurl.AnimationState.AddAnimation(0, "Huge_daiji", true, 0f);
                break;
            default:
                WetBadIncaHurl.AnimationState.SetAnimation(0, "Mega_chuxian", false);
                WetBadIncaHurl.AnimationState.AddAnimation(0, "Mega_daiji", true, 0f);
                break;
        }
    }


    private void TowSecret()
    {
        CreepOnce = "1";

        LadePlank.Instance.SkyDust(SummerGod, transform);

        // IngenuityInstrument.CollectAni(LadePlank.Instance.cashImg.transform.position,
        //     Resources.Load<GameObject>("Art/FX/RewardImage"), new Vector3(0, 0, 0), LadePlank.Instance.transform,
        //     () => { });
        FollyPlank();
    }

    private void FollyPlank()
    {
        string aaa = MoreBulkUncover.TowSmooth(CShield.Raw_Mine_Solo_Ox);
        if (aaa == "new")
        {
            MoreBulkUncover.GunSmooth(CShield.Raw_Mine_Solo_Ox, "done");
            FanwiseEnergyHatch.GetInstance().Cany(CShield.Raw_Mine_Solo_Ox);
        }

        FanwiseEnergyHatch.GetInstance().Cany(CShield.msg_Video_Fluid_Key_Total);

        PlowSenseGarden.GetInstance().CanySense("1007", CreepOnce,SummerGod.ToString());
        FollyUIPeak(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }
}