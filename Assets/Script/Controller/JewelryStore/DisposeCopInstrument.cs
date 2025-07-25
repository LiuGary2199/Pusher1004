// Project: Pusher
// FileName: DisposeCopInstrument.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 10:42
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisposeCopInstrument : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button WhyWeb;
[UnityEngine.Serialization.FormerlySerializedAs("btnBgY")]    public Image btnMeY;
[UnityEngine.Serialization.FormerlySerializedAs("silverImg")]
    public GameObject silverMad;
[UnityEngine.Serialization.FormerlySerializedAs("blueImg")]    public GameObject FeelMad;
[UnityEngine.Serialization.FormerlySerializedAs("yellowImg")]    public GameObject MassifMad;
[UnityEngine.Serialization.FormerlySerializedAs("goldBarImg")]    public GameObject CodeRagMad;
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]
    public Image CodeMad;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    public Image SinkMad;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public Image UnseenMad;
[UnityEngine.Serialization.FormerlySerializedAs("sliderProgress")]
    public Image UnsungProbable;
[UnityEngine.Serialization.FormerlySerializedAs("gemsNum")]    public Text TeemGod;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    public Text EmployeePort;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]    public Text SummerGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("maxNum")]
    public int CudGod;
[UnityEngine.Serialization.FormerlySerializedAs("currentNum")]    public int ThunderGod;
[UnityEngine.Serialization.FormerlySerializedAs("gemsDataItem")]
    public GemsDataItem TeemBulkLess;
    private GemsType BillRawOnce;
    private RewardType SummerOnce;

    
    private Dictionary<NormalRewardType, double> SummerArc;

    private void Start()
    {
        WhyWeb.onClick.AddListener(() =>
        {
            if (!btnMeY.gameObject.activeInHierarchy)
            {
                return;
            }

            TowSecret();
        });
    }

    private void FollyLordMad()
    {
        silverMad.gameObject.SetActive(false);
        FeelMad.gameObject.SetActive(false);
        MassifMad.gameObject.SetActive(false);
        CodeRagMad.gameObject.SetActive(false);
    }

    private void PearLordMad()
    {
        switch (BillRawOnce)
        {
            case GemsType.Silver:
                silverMad.gameObject.SetActive(true);
                break;
            case GemsType.Blue:
                FeelMad.gameObject.SetActive(true);
                break;
            case GemsType.Yellow:
                MassifMad.gameObject.SetActive(true);
                break;
            default:
                CodeRagMad.gameObject.SetActive(true);
                break;
        }
    }

    private void FollySecretMad()
    {
        CodeMad.gameObject.SetActive(false);
        SinkMad.gameObject.SetActive(false);
        UnseenMad.gameObject.SetActive(false);
    }

    private void PearSecretMad()
    {
        switch (SummerOnce)
        {
            case RewardType.Gold:
                CodeMad.gameObject.SetActive(true);
                break;
            case RewardType.Cash:
                SinkMad.gameObject.SetActive(true);
                break;
            default:
                UnseenMad.gameObject.SetActive(true);
                break;
        }
    }

    public void PassBulk()
    {
        BillRawOnce = (GemsType) Enum.Parse(typeof(GemsType), TeemBulkLess.gem_type);
        SummerOnce = (RewardType) Enum.Parse(typeof(RewardType), TeemBulkLess.reward_type);
        SummerGodPort.text = TeemBulkLess.reward_num + "";

        if (FalconErie.MyUnder())
        {
            SummerOnce = RewardType.Gold;
        }

        FollyLordMad();
        PearLordMad();
        FollySecretMad();
        PearSecretMad();

        ThunderGod = MoreBulkUncover.TowWok(BillRawOnce.ToString());
        CudGod = TeemBulkLess.gem_limit;

        EmployeePort.text = (ThunderGod < CudGod ? ThunderGod : CudGod) + "/" + CudGod;
        TeemGod.text = "x " + CudGod;
        UnsungProbable.fillAmount = (ThunderGod < CudGod ? ThunderGod : CudGod) * 1.0f / CudGod;
        btnMeY.gameObject.SetActive(ThunderGod >= CudGod);
    }


    public void TowSecret()
    {
        
        SummerArc = new Dictionary<NormalRewardType, double>();
        NormalRewardType SummerOnce= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), TeemBulkLess.reward_type);
        SummerArc.Add(SummerOnce, TeemBulkLess.reward_num);
        
        ThunderGod = 0;
        MoreBulkUncover.GunWok(BillRawOnce.ToString(),0);
        // InitData();
        // UIHollow.GetInstance().CloseOrReturnUIForms(GetType().Name);
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_LIf_We_If,"7");
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_Lid_Weld, "1014");
        MoreBulkUncover.GunSmooth(CShield.Dy_Teem_Weld, BillRawOnce.ToString());
        SecretPlankUncover.Instance.PearVerifySecretPlank(SummerArc);
        
    }
}