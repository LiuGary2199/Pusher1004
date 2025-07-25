// Project: Pusher
// FileName: SplitReelInstrument.cs
// Author: AX
// CreateDate: 20230803
// CreateTime: 15:54
// Description:

using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SplitReelInstrument : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("bgGold")]    public GameObject ByRime;
[UnityEngine.Serialization.FormerlySerializedAs("bgSilver")]    public GameObject ByRegain;
[UnityEngine.Serialization.FormerlySerializedAs("bgTop")]    public GameObject ByEar;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
    public GameObject SinkMad;
[UnityEngine.Serialization.FormerlySerializedAs("coinImg")]    public GameObject BondMad;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public GameObject UnseenMad;
[UnityEngine.Serialization.FormerlySerializedAs("overImg")]    public GameObject IbexMad;
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    public GameObject BG;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Open")]    public GameObject At_Epic;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
    public Text SummerPort;
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]
    public LuckyObjType SummerOnce;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    public double SummerGod;



    public void FollyCop()
    {
        FollyMad();
        //bgTop.gameObject.SetActive(true);
    }


    public void PassSecretCopBulk(LuckyObjData luckyObjData)
    {
        BG.SetActive(true);
        SummerOnce = luckyObjData.LuckyObjType;
        SummerGod = luckyObjData.RewardNum;
        FollyMad();
        SummerPort.text = SummerGod+"";

        switch (SummerOnce)
        {
            case LuckyObjType.Cash:
                SinkMad.gameObject.SetActive(true);
                break;
            case LuckyObjType.Gold:
                BondMad.gameObject.SetActive(true);
                ByRegain.gameObject.SetActive(true);
                break;
            default:
                UnseenMad.gameObject.SetActive(true);
                ByRegain.gameObject.SetActive(true);
                break;
        }

    }

    public void PassBreechCopBulk()
    {
        BG.SetActive(true);
        FollyMad();
        IbexMad.gameObject.SetActive(true);
    }

    private void FollyMad()
    {
        ByEar.gameObject.SetActive(false);
        SinkMad.gameObject.SetActive(false);
        UnseenMad.gameObject.SetActive(false);
        BondMad.gameObject.SetActive(false);
        ByRegain.gameObject.SetActive(false);
        IbexMad.gameObject.SetActive(false);
        ByRime.gameObject.SetActive(true);
        
    }


    private void OnMouseOver()
    {
        if (ByEar.activeInHierarchy != true||SplitReelPlank.Instance.AxRome) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            //bgTop.gameObject.SetActive(false);
            BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.Sound_PopShow);
            SplitReelPlank.Instance.SkyExceedPeal(gameObject);
        }
    }

    public void KiwiIngenuity(GameObject Card, GameObject CardBack, GameObject CardFront,System.Action start, System.Action finish) 
    {
        Card.transform.DOScale(1.3f, 0.3f);
        Card.transform.DORotate(new Vector3(0, 90, 0), 0.3f).OnComplete(() =>
        {
            start();
            CardBack.SetActive(false);
            CardFront.SetActive(true);
            Card.transform.DOScale(1, 0.3f);
            Card.transform.DORotate(new Vector3(0, 0, 0), 0.3f).OnComplete(()=>
            {
                finish();
            });
        });
    }
}