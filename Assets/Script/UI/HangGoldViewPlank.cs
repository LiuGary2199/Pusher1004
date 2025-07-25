// Project: Plinko
// FileName: HangSecretPlank.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 10:00
// Description:

using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class HangGoldViewPlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button VideoWeb;
[UnityEngine.Serialization.FormerlySerializedAs("getRewardBtn")]    public Button WhySecretWeb;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeBtn")]    public Button ListenerWeb;
[UnityEngine.Serialization.FormerlySerializedAs("NoExchangeBtn")]    public GameObject NoListenerWeb;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]
    public GameObject WeMad;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]
    public GameObject WhyWebPort;
[UnityEngine.Serialization.FormerlySerializedAs("ballNum")]
    public Text HalfGod;
[UnityEngine.Serialization.FormerlySerializedAs("NeedNum")]    public Text BabyGod;
[UnityEngine.Serialization.FormerlySerializedAs("needNum")]    public int ProdGod;
    private string CreepOnce;


    private void Start()
    {
        BabyGod.text = ProdGod.ToString();
        VideoWeb.onClick.AddListener(() =>
        {
            CreepOnce = "0";
            ADUncover.Variance.ToBreechSkyRigor();
            FollyHallPlank();
        });

        ListenerWeb.onClick.AddListener(() =>
        {
            double coincount = LadeBulkUncover.GetInstance().TowRime();
            if (coincount >= ProdGod)
            {
                LadeBulkUncover.GetInstance().SkyRime(-ProdGod);
                VagueFastUncover.Instance.SkySteelFast();
                //LadePlank.Instance.goldNumText.text = LadeBulkUncover.GetInstance().GetGold() + "";
                LadePlank.Instance.JobRimeGodPort.text = LadeBulkUncover.GetInstance().TowRime() + "";
                FollyHallPlank();
            }
        });

        WhySecretWeb.onClick.AddListener(() =>
        {
            if (!MoreBulkUncover.TowWhen(CShield.Dy_Subsist_Oat_Half))
            {
                MoreBulkUncover.GunWhen(CShield.Dy_Subsist_Oat_Half, true);
                TowSecret();
            }
            else
            {
                ADUncover.Variance.PourSecretSteel((success) => { TowSecret(); }, "8");
            }
        });

        HalfGod.text = "" + SapScanTip.instance.LadeBulk.base_config.ball_limit;
    }


    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        double coincount = LadeBulkUncover.GetInstance().TowRime();
        ListenerWeb.gameObject.SetActive(coincount >= ProdGod);
        NoListenerWeb.SetActive(coincount < ProdGod);
        // if (FalconErie.IsApple())
        // {
        //     adImg.gameObject.SetActive(false);
        //     getBtnText.transform.localPosition = new Vector3(37f, 0f, 0f);
        //     closeBtn.gameObject.SetActive(true);
        // }
        // else
        // {
        if (!MoreBulkUncover.TowWhen(CShield.Dy_Subsist_Oat_Half))
        {
            WeMad.gameObject.SetActive(false);
            //closeBtn.gameObject.SetActive(false);
            WhyWebPort.transform.localPosition = new Vector3(0f, 0f, 0f);

        }
        else
        {
            WhyWebPort.transform.localPosition = new Vector3(37f, 0f, 0f);
            WeMad.gameObject.SetActive(true);
            VideoWeb.gameObject.SetActive(true);
           // closeBtn.GetComponent<CanvasGroup>().alpha = 0f;
           // closeBtn.enabled = false;


            //closeBtn.GetComponent<CanvasGroup>().alpha = 0f;
           // DOTween.To(x => closeBtn.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() => { closeBtn.enabled = true; });
        }
        // }
    }

    private void TowSecret()
    {
        CreepOnce = "1";
        VagueFastUncover.Instance.SkySteelFast();
        FollyHallPlank();
    }


    private void FollyHallPlank()
    {
        PlowSenseGarden.GetInstance().CanySense("1015", CreepOnce);
        CropUncover.Instance.LadeAmateur();
        FollyUIPeak(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }
}
