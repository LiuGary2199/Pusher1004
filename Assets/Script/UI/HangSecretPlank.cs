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

public class HangSecretPlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button VideoWeb;
[UnityEngine.Serialization.FormerlySerializedAs("getRewardBtn")]    public Button WhySecretWeb;
[UnityEngine.Serialization.FormerlySerializedAs("GoldBtn")]    public Button RimeWeb;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]    public GameObject WeMad;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]    public GameObject WhyWebPort;
[UnityEngine.Serialization.FormerlySerializedAs("ballNum")]
    public Text HalfGod;
[UnityEngine.Serialization.FormerlySerializedAs("needGoldNum")]    public Text ProdRimeGod;


    private string CreepOnce;


    private void Start()
    {
        VideoWeb.onClick.AddListener(() =>
        {
            CreepOnce = "0";
            ADUncover.Variance.ToBreechSkyRigor();
            FollyHallPlank();
        });

        RimeWeb.onClick.AddListener(() =>
        {
            int buyCount = PlayerPrefs.GetInt("MoneyBuyBall", 1);
            double coincount = LadeBulkUncover.GetInstance().TowRime();
            double ProdGod= buyCount * 50000;
            if (ProdGod >= 300000)
            {
                ProdGod = 300000;
            }
            if (coincount >= ProdGod)
            {
                TowSecret();
                LadeBulkUncover.GetInstance().SkyRime(-ProdGod);
                PlayerPrefs.SetInt("MoneyBuyBall", buyCount + 1);
            }
            else 
            {
                WhySecretWeb.gameObject.SetActive(true);
                RimeWeb.gameObject.SetActive(false);
            }
        });

        WhySecretWeb.onClick.AddListener(() =>
        {
            if (!MoreBulkUncover.TowWhen(CShield.Dy_Subsist_Oat_Half)) {
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
            VideoWeb.gameObject.SetActive(false);
            WhyWebPort.transform.localPosition = new Vector3(0f, 0f, 0f);
            
        }
        else
        {
            WhyWebPort.transform.localPosition = new Vector3(37f, 0f, 0f);
            WeMad.gameObject.SetActive(true);
            VideoWeb.gameObject.SetActive(true);
            VideoWeb.GetComponent<CanvasGroup>().alpha = 0f;
            VideoWeb.enabled = false;


            VideoWeb.GetComponent<CanvasGroup>().alpha = 0f;
            DOTween.To(x => VideoWeb.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f)
                .OnComplete(() => { VideoWeb.enabled = true; });

            int buyCount = PlayerPrefs.GetInt("MoneyBuyBall", 1);
            double coincount = LadeBulkUncover.GetInstance().TowRime();
            double ProdGod= buyCount * 50000;
            ProdRimeGod.text = ProdGod.ToString();
            if (ProdGod >= 300000)
            {
                ProdGod = 300000;
            }
            if (coincount >= ProdGod)
            {
                WhySecretWeb.gameObject.SetActive(false);
                RimeWeb.gameObject.SetActive(true);
            }
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