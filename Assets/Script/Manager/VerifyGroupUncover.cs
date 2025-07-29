// Project: Pusher
// FileName: VerifyGroupUncover.cs
// Author: AX
// CreateDate: 20230821
// CreateTime: 9:30
// Description:

using System;
using UnityEngine;

public class VerifyGroupUncover : MonoBehaviour
{
    public static VerifyGroupUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]    public bool AxRome;


    protected void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        AxRome = false;

        // FanwiseEnergyHatch.GetInstance().Register(CShield.msg_close_panel_and_start,
        //     (messageData) => { CloseLock(); });
    }


    /*
     *
     * 各类弹窗
     */
    public void PearLuckyReelPlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        AxRome = true;
        CropUncover.Instance.LadeLump();
        PlowSenseGarden.GetInstance().CanySense("1010");
        MoreBulkUncover.GunWok(CShield.Dy_We_Exert_Ice, MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice) + 1);
        UIManager.GetInstance().PearUIStain(nameof(SplitReelPlank));
    }

    public void PearDiseaseReelPlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        AxRome = true;
        CropUncover.Instance.LadeLump();
        PlowSenseGarden.GetInstance().CanySense("1008");
        MoreBulkUncover.GunWok(CShield.Dy_We_Exert_Ice, MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice) + 1);
        UIManager.GetInstance().PearUIStain(nameof(DiseaseReelPlank));
    }

    public void PearDisposeCrowdPlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;

        if (TossErie.Extinct() - MoreBulkUncover.TowWok("sv_show_gems_times") < 10)
        {
            return;
        }

        MoreBulkUncover.GunWok("sv_show_gems_times", (int) TossErie.Extinct());

        AxRome = true;
        CropUncover.Instance.LadeLump();

        UIManager.GetInstance().PearUIStain(nameof(DisposeCrowdPlank));
    }

    public void PearWhittlePlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        AxRome = true;
        CropUncover.Instance.LadeLump();
        UIManager.GetInstance().PearUIStain(nameof(WhittlePlank));
    }
    public void PearJobWhittlePlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        AxRome = true;
        CropUncover.Instance.LadeLump();
        UIManager.GetInstance().PearUIStain(nameof(JobSingWhittlePlank));
    }
    public void PearHangSecretPlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        AxRome = true;
        CropUncover.Instance.LadeLump();
        UIManager.GetInstance().PearUIStain(nameof(HangSecretPlank));
    }
    public void PearHangGoldViewPlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        AxRome = true;
        CropUncover.Instance.LadeLump();
        UIManager.GetInstance().PearUIStain(nameof(HangGoldViewPlank));
    }

    public void PearHangMuchPlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        AxRome = true;
        CropUncover.Instance.LadeLump();
        UIManager.GetInstance().PearUIStain(nameof(HangMuchPlank));
    }
    
    public void PearLullUsPlank()
    {
        if (AxRome || CropUncover.Instance.FareRome) return;
        if (MoreBulkUncover.TowSmooth(CShield.uspanel) ==  "done")
        {
            return;
        }

        if (FalconErie.MyUnder())
        {
            return;
        }
        AxRome = true;
        CropUncover.Instance.LadeLump();
        UIManager.GetInstance().PearUIStain(nameof(LullMePlank));
        MoreBulkUncover.GunSmooth(CShield.uspanel, "done");
    }
}