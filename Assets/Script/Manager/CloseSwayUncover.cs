// Project: Plinko
// FileName: CloseSwayUncover.cs
// Author: AX
// CreateDate: 20230508
// CreateTime: 16:04
// Description:

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class 
    CloseSwayUncover : MonoBehaviour
{
    public static CloseSwayUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("progressImg")]
    public Image EmployeeMad;

    private int ToothSight;
    private int ToothSway;

    private int ThunderSway;
    private int ThunderFast;
[UnityEngine.Serialization.FormerlySerializedAs("isFeverTime")]
    public bool AxCloseSway;

    private double TotalDust;
    private double NutDust;

    private bool PestCloseSway;

    private void Awake()
    {
        Instance = this;
        AxCloseSway = false;
        PestCloseSway = false;
        ToothSight = SapScanTip.instance.LadeBulk.base_config.fever_limit;
        ToothSway = SapScanTip.instance.LadeBulk.base_config.fever_time;
    }

    private void Start()
    {
        SouthBulk();
    }


    private void Update()
    {
        if (AxCloseSway)
        {
            if (!PestCloseSway)
            {
                EmployeeMad.fillAmount -= Time.deltaTime / ToothSway;
                if (EmployeeMad.fillAmount == 0)
                {
                    FollyCloseSway();
                }
            }
        }
    }

    public void LumpClose()
    {
        PestCloseSway = true;
    }

    public void AtCabinCloseSway()
    {
        PestCloseSway = false;
    }

    public void SouthBulk()
    {
        ThunderFast = MoreBulkUncover.TowWok(CShield.Dy_Tooth_Tele_Thunder);
        PotteryProbable();
    }


    public void SkyCloseFast()
    {
        if (AxCloseSway) return;

        ThunderFast++;
        MoreBulkUncover.GunWok(CShield.Dy_Tooth_Tele_Thunder, ThunderFast);
        PotteryProbable();
        if (ThunderFast >= ToothSight)
        {
            CabinCloseSway();
        }
    }

    private void CabinCloseSway()
    {
        MoreBulkUncover.GunWok(CShield.Dy_Tooth_Tele_Thunder, 0);
        PlowSenseGarden.GetInstance().CanySense("1006");

        // BrownTip.GetInstance().PlayBg(BrownOnce.UIMusic.sound_fever_bgm);

        // startCash = MoreBulkUncover.GetDouble(CShield.sv_CumulativeCash);
        AxCloseSway = true;
        ThunderSway = ToothSway;
        // PillarManager.Instance.CloseBigWinPillar();
        // VagueFastUncover.Instance.StartFeverTimeForSteelBall();
        // PillarManager.Instance.PillarGroupMove();
        // Fx_Group.Instance.FX_Fever.SetActive(true);
    }

    private void FollyCloseSway()
    {
        // BrownTip.GetInstance().PlayBg(BrownOnce.UIMusic.sound_bgm);

        // Fx_Group.Instance.FX_Fever.SetActive(false);
        AxCloseSway = false;
        // VagueFastUncover.Instance.CloseFeverTimeForSteelBall();
        SouthBulk();
        if (FalconErie.MyUnder()) return;

        // endCash = MoreBulkUncover.GetDouble(CShield.sv_CumulativeCash);
        // double cash = Math.Round((endCash - startCash), 2);
        // MoreBulkUncover.SetDouble(CShield.sv_big_win_cash, cash);
        // EntombUncover.Instance.StopGame();

        // MoreBulkUncover.SetString(CShield.sv_big_win_type, "1007");
        // MoreBulkUncover.SetString(CShield.sv_big_win_ad_id, "3");

        // UIHollow.GetInstance().ShowUIForms(nameof(LugBadFlairPlank));
        // double num = 10;
        // SecretPlankUncover.Instance.ShowBigRewardPanel(num);
    }

    private void PotteryProbable()
    {
        EmployeeMad.fillAmount = 1f * ThunderFast / ToothSight;
    }
}