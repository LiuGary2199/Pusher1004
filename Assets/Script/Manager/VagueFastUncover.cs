// Project: Plinko
// FileName: VagueFastUncover.cs
// Author: AX
// CreateDate: 20230427
// CreateTime: 15:20
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class VagueFastUncover : MonoBehaviour
{
    public static VagueFastUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("currentBallNum")]
    public int ThunderFastGod;

    private float HalfSight;

    private double AdversityOr;

    private bool PestWith;

    private bool AxCloseSway;

    string SoSway;

    private bool ChestFastRome;

    private void Awake()
    {
        Instance = this;
        HalfSight = SapScanTip.instance.LadeBulk.base_config.ball_limit;
        AdversityOr = SapScanTip.instance.LadeBulk.base_config.multiball_cd;
        ThunderFastGod = MoreBulkUncover.TowWok(CShield.Dy_Chest_Half_Ice);
    }

    private void Start()
    {
        PotteryBulk();
        StartCoroutine(nameof(HealthyVagueFast));
    }


    public bool GoldFast()
    {
        ThunderFastGod = MoreBulkUncover.TowWok(CShield.Dy_Chest_Half_Ice);
        if (ThunderFastGod <1)
        {
            VerifyGroupUncover.Instance.PearHangSecretPlank();
            return false;
        }

        ThunderFastGod--;
        PotteryBulk();
        return true;
    }

    public bool GoldViewForUnder()//审核用的 
    {
        ThunderFastGod = MoreBulkUncover.TowWok(CShield.Dy_Chest_Half_Ice);
        if (ThunderFastGod < 1)
        {
            VerifyGroupUncover.Instance.PearHangGoldViewPlank();
            return false;
        }
        ThunderFastGod--;
        PotteryBulk();
        return true;
    }


    public void SkySteelFast()
    {
        ThunderFastGod = SapScanTip.instance.LadeBulk.base_config.ball_limit;
        StopCoroutine(nameof(HealthyVagueFastSway));
        SoSway = "";
        // LadePlank.Instance.cdText.text = cdTime;
        PotteryBulk();
    }


    private void PotteryBulk()
    {
        //Debug.Log("currentBallNum"+ currentBallNum);
        MoreBulkUncover.GunWok(CShield.Dy_Chest_Half_Ice, ThunderFastGod);
        LadeBulkUncover.GetInstance().SkyFast(ThunderFastGod);
        LadePlank.Instance.HalfGodPort.text = ThunderFastGod + "";
        LadePlank.Instance.ListenerGodPort.text = ThunderFastGod + "";
        // LadePlank.Instance.cdText.text = cdTime;
    }



    IEnumerator HealthyVagueFast()
    {
        while (ThunderFastGod > -10)
        {
            if (ThunderFastGod < HalfSight)
            {
                string time = MoreBulkUncover.TowSmooth(CShield.Dy_Chest_Half_Toad);
                if (time.Length == 0)
                {
                    MoreBulkUncover.GunSmooth(CShield.Dy_Chest_Half_Toad, DateTime.Now.ToString());
                    StopCoroutine(nameof(HealthyVagueFastSway));
                    StartCoroutine(nameof(HealthyVagueFastSway));
                }
                else
                {
                    int timenow = TowMatterBulk.GetInstance().RayTossDome(time, DateTime.Now);
                    int a = (int) ( timenow / AdversityOr);
                    if (a >= 1)
                    {
                        ThunderFastGod += a;
                  
                        MoreBulkUncover.GunSmooth(CShield.Dy_Chest_Half_Toad, DateTime.Now.ToString());
                        if (ThunderFastGod < HalfSight)
                        {
                            LadeBulkUncover.GetInstance().SkyFast(a);
                            StopCoroutine(nameof(HealthyVagueFastSway));
                            StartCoroutine(nameof(HealthyVagueFastSway));
                        }
                        else
                        {
                            LadeBulkUncover.GetInstance().SkyFast((int)(ThunderFastGod-HalfSight));
                            ThunderFastGod = (int) HalfSight;
                            StopCoroutine(nameof(HealthyVagueFastSway));
                            SoSway = "";
                            // LadePlank.Instance.cdText.text = cdTime;
                        }
                    }
                    else
                    {
                        if (SoSway == "")
                        {
                            StopCoroutine(nameof(HealthyVagueFastSway));
                            StartCoroutine(nameof(HealthyVagueFastSway));
                        }
                    }
                }

                PotteryBulk();
            }

            yield return new WaitForSeconds((float) 0.05);
        }
    }

    IEnumerator HealthyVagueFastSway()
    {
        for (int i = (int) AdversityOr; i > 0; i--)
        {
            SoSway = i + "s";
            // LadePlank.Instance.cdText.text = cdTime;
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator SenateVagueFastRome()
    {
        // yield return new WaitForSeconds((float) multiballCd);
        yield return new WaitForSeconds(0.5f);
        ChestFastRome = false;
    }
}