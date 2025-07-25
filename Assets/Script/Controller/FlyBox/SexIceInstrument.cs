// Project: HappyBingo
// FileName: SexIceInstrument.cs
// Author: AX
// CreateDate: 20221124
// CreateTime: 11:39
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SexIceInstrument : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("flyBox")]    public GameObject LotIce;

    private int _TeleOrnament;

    private int _ThunderSway;
[UnityEngine.Serialization.FormerlySerializedAs("isOnFlag")]
    public bool AxDyWith;

    private Dictionary<NormalRewardType, double> SummerArc;

    public static SexIceInstrument Instance;


    private void Awake()
    {
        Instance = this;
        _TeleOrnament = SapScanTip.instance.LadeBulk.base_config.bubble_time;
    }

    IEnumerator IceSwayOrnament()
    {
        while (AxDyWith)
        {
            if (_ThunderSway >= _TeleOrnament)
            {
                _ThunderSway = 0;
                ComedyFlyIce();
            }

            _ThunderSway++;
            //print(_currentTime);
            yield return new WaitForSeconds(1);
        }
    }


    public void CrestAndCabinIce()
    {
        AxDyWith = true;
        _ThunderSway = 0;
        StartCoroutine(IceSwayOrnament());
        ComedyFlyIce();
    }

    public void LumpIce()
    {
        if (!gameObject.activeInHierarchy) return;
        AxDyWith = false;
        StopCoroutine(IceSwayOrnament());
        if (transform.childCount > 0)
        {
            transform.gameObject.SetActive(false);
        }
    }

    public void GunIceWebSewage()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<SexGarden>().GunWebSewage();
        }
    }

    public void GunIceWebSubside()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<SexGarden>().GunWebSubside();
        }
    }

    public void AmateurIce()
    {
        gameObject.SetActive(true);
        if (gameObject.activeInHierarchy)
        {
            AxDyWith = true;
            StartCoroutine(IceSwayOrnament());
            if (transform.childCount > 0)
            {
                transform.GetChild(0).GetComponent<SexGarden>().SexRetool();
                transform.GetChild(0).GetComponent<Canvas>().sortingOrder = 120;
                transform.gameObject.SetActive(true);
            }
        }
    }

    public void ComedyFlyIce()
    {
        if (FalconErie.MyUnder()) return;
        if (MoreBulkUncover.TowSmooth(CShield.Dy_Total_Dry_Its) == "new") return;
        GameObject obj = Instantiate(LotIce, transform);
        obj.transform.SetParent(gameObject.transform);
        obj.SetActive(true);
    }

    public void SouthBulk()
    {
        AxDyWith = false;
        _ThunderSway = 0;
        if (transform.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    public void PearFlairPlank()
    {
        CropUncover.Instance.LadeLump();

        SummerArc = new Dictionary<NormalRewardType, double>();
        BubbleObjData bubbleObjData = GameUtil.GetBubbleObjData();
        
        string type = bubbleObjData.BubbleObjType.ToString();
        NormalRewardType SummerOnce= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
        SummerArc.Add(SummerOnce, bubbleObjData.RewardNum);
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_LIf_We_If,"6");
        MoreBulkUncover.GunSmooth(CShield.Dy_Virtue_Lid_Weld, "1013");
        SecretPlankUncover.Instance.PearVerifySecretPlank(SummerArc);

    }
}