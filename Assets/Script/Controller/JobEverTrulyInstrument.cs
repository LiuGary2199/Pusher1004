// Project: Plinko
// FileName: JobEverTrulyInstrument.cs
// Author: AX
// CreateDate: 20230526
// CreateTime: 15:28
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class JobEverTrulyInstrument : MonoBehaviour
{
    public static JobEverTrulyInstrument Instance;
[UnityEngine.Serialization.FormerlySerializedAs("step1Btn")]
    public Button Bard1Web;
[UnityEngine.Serialization.FormerlySerializedAs("step2Btn")]
    public Button Bard2Web;
[UnityEngine.Serialization.FormerlySerializedAs("step3Btn")]
    public Button Bard3Web;
[UnityEngine.Serialization.FormerlySerializedAs("step4Btn")]
    public Button Bard4Web;
[UnityEngine.Serialization.FormerlySerializedAs("cashMaskObj")]
    public GameObject SinkWordCop;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Bard1Web.onClick.AddListener(() =>
        {
            Bard1Web.gameObject.SetActive(false);
            Invoke(nameof(PearMost2Web), 0.3f);
        });

        Bard2Web.onClick.AddListener(() =>
        {
            Bard2Web.gameObject.SetActive(false);
            Invoke(nameof(PearMost3Web), 0.3f);
        });


        Bard3Web.onClick.AddListener(() =>
        {
            Bard3Web.gameObject.SetActive(false);
            Invoke(nameof(PearMost4Web), 0.3f);
        });


        Bard4Web.onClick.AddListener(() =>
        {
            Bard4Web.gameObject.SetActive(false);
            CabinLade();
        });

        FanwiseEnergyHatch.GetInstance().Engineer(CShield.Raw_Mine_Sink_Reef,
            (messageData) =>
            {
                Invoke(nameof(PearDustWord),0.5f);
            });


        PassBulk();
    }


    private void PearMost2Web()
    {
        Bard2Web.gameObject.SetActive(true);
    }

    private void PearMost3Web()
    {
        Bard3Web.gameObject.SetActive(true);
    }

    private void PearMost4Web()
    {
        Bard4Web.gameObject.SetActive(true);
    }

    private void CabinLade()
    {
        MoreBulkUncover.GunSmooth(CShield.Dy_Narrow_Ask_From_Deter, "done");
        CropUncover.Instance.LadeAmateur();
    }

    public void PassBulk()
    {
        if (MoreBulkUncover.TowSmooth(CShield.Dy_Narrow_Ask_From_Deter) == "new" && !FalconErie.MyUnder())
        {
            Bard1Web.gameObject.SetActive(true);
            Bard2Web.gameObject.SetActive(false);
            Bard3Web.gameObject.SetActive(false);
            Bard4Web.gameObject.SetActive(false);
            SinkWordCop.gameObject.SetActive(false);
            CropUncover.Instance.LadeLump();
        }
        else
        {
            Bard1Web.gameObject.SetActive(false);
            Bard2Web.gameObject.SetActive(false);
            Bard3Web.gameObject.SetActive(false);
            Bard4Web.gameObject.SetActive(false);
            SinkWordCop.gameObject.SetActive(false);
        }
    }


    public void PearDustWord()
    {
        if (MoreBulkUncover.TowSmooth(CShield.Dy_Relax_Sink_out) == "new")
        {
            MoreBulkUncover.GunSmooth(CShield.Dy_Relax_Sink_out, "done");

            if (FalconErie.MyUnder())
            {
                return;
            }

            CropUncover.Instance.LadeLump();
            SinkWordCop.gameObject.SetActive(true);
        }
        else
        {
            CropUncover.Instance.LadeAmateur();
            SinkWordCop.gameObject.SetActive(false);
        }
    }
}