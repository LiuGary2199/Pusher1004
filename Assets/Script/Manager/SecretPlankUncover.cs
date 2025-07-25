// Project: Pusher
// FileName: SecretPlankUncover.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 17:33
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;

public class SecretPlankUncover : MonoBehaviour
{
    public static SecretPlankUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]    public bool AxRome;


    protected void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        AxRome = false;

        FanwiseEnergyHatch.GetInstance().Engineer(CShield.msg_Video_Fluid_Key_Total,
            (messageData) => { FollyRome(); });
    }


    private void FollyRome()
    {
        AxRome = false;
    }


    // show big win panel
    public void PearLugSecretPlank(double num)
    {
        if (AxRome) return;

        AxRome = true;
        if (FalconErie.MyUnder())
        {
            return;
        }
        CropUncover.Instance.LadeLump();
        UIManager.GetInstance().PearUIStain(nameof(LugBadFlairPlank));
        LugBadFlairPlank.Instance.PassBulk(num);
    }

    // show normal win panel
    public void PearVerifySecretPlank(Dictionary<NormalRewardType, double> rewardMap)
    {
        if (AxRome) return;
        AxRome = true;
        UIManager.GetInstance().PearUIStain(nameof(VerifyBadFlairPlank));
        VerifyBadFlairPlank.Instance.PassBulk(rewardMap);
    }


    public void PearDustFillSecret()
    {
        CropUncover.Instance.LadeLump();
        Dictionary<NormalRewardType, double> SummerArc= new Dictionary<NormalRewardType, double>();

        double num = GameUtil.GetCashRollReward();
        SummerArc[NormalRewardType.RollCash] = num;
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_Lid_Weld, "1012");
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_LIf_We_If,"5");
        PearVerifySecretPlank(SummerArc);
    }

}