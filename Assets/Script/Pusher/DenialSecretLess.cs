using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class RewardItemPerfabs
{
    public GameObject CodeViewViewer_1;
    public GameObject CodeViewViewer_5;
    public GameObject CodeViewViewer_10;
    public GameObject CodeViewViewer_50;
    public GameObject CodeViewViewer_100;
    public GameObject CodeViewViewer_200;
    public GameObject CodeViewViewer_500;
    public GameObject SinkViewViewer_1;
    public GameObject SinkViewViewer_5;
    public GameObject SinkViewViewer_10;
    public GameObject SinkViewViewer_50;
    public GameObject SinkViewViewer_100;
    public GameObject SinkViewViewer_200;
    public GameObject SinkViewViewer_500;
    public GameObject NailDustViewer;
    public GameObject CapSurplusViewer;
    public GameObject CapStagViewer;
    public GameObject CapAddViewer;
    public GameObject FaucetViewer;
    public GameObject ClassicReelViewer;
    public GameObject GammaReelViewer;
    public GameObject WetViewViewer;
    public GameObject appleViewer;

}
public class DenialSecretLess : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]    public PusherRewardType SummerOnce;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    public double SummerGod;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemPerfabs")]    public RewardItemPerfabs SummerLessDogwood;
    bool DyeTossSewer= false;
    public void BookSecretLess(PusherRewardType type, bool canPlay = true)
    {
        DyeTossSewer = canPlay;
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        SummerOnce = type;
        if (FalconErie.MyUnder() && type == PusherRewardType.CoinCash)
        {
            type = PusherRewardType.CoinGold;
            SummerOnce = PusherRewardType.CoinGold;
        }
        switch (type)
        {
            case PusherRewardType.CoinGold:
                BookRimeView();
                break;
            case PusherRewardType.CoinCash:
                BookDustView();
                break;
            case PusherRewardType.RollCash:
                SummerLessDogwood.NailDustViewer.SetActive(true);
                break;
            case PusherRewardType.LuckyCard:
                SummerLessDogwood.GammaReelViewer.SetActive(true);
                break;
            case PusherRewardType.ScratchCard:
                SummerLessDogwood.ClassicReelViewer.SetActive(true);
                break;
            case PusherRewardType.GemDiamond:
                SummerLessDogwood.CapSurplusViewer.SetActive(true);
                break;
            case PusherRewardType.GemBlue:
                SummerLessDogwood.CapStagViewer.SetActive(true);
                break;
            case PusherRewardType.GemRed:
                SummerLessDogwood.CapAddViewer.SetActive(true);
                break;
            case PusherRewardType.Golden:
                SummerLessDogwood.FaucetViewer.SetActive(true);
                break;
            case PusherRewardType.BigCoin:
                SummerLessDogwood.WetViewViewer.SetActive(true);
                break;
        }

    }
    public void BookRimeView()
    {
        int num = BulkAfricaUncover.GetInstance().WhyRimeViewGod();
        if (FalconErie.MyUnder())
        {
            SummerLessDogwood.appleViewer.SetActive(true);
        }
        else
        {
            switch (num)
            {
                case 1:
                    SummerLessDogwood.CodeViewViewer_1.SetActive(true);
                    break;
                case 5:
                    SummerLessDogwood.CodeViewViewer_5.SetActive(true);
                    break;
                case 10:
                    SummerLessDogwood.CodeViewViewer_10.SetActive(true);
                    break;
                case 50:
                    SummerLessDogwood.CodeViewViewer_50.SetActive(true);
                    break;
                case 100:
                    SummerLessDogwood.CodeViewViewer_100.SetActive(true);
                    break;
                case 200:
                    SummerLessDogwood.CodeViewViewer_200.SetActive(true);
                    break;
                case 500:
                    SummerLessDogwood.CodeViewViewer_500.SetActive(true);
                    break;
            }
        }
        
        SummerGod = num;
    }
    public void BookDustView()
    {
        int num = BulkAfricaUncover.GetInstance().WhyDustViewGod();
        if (FalconErie.MyUnder())
        {
            SummerLessDogwood.appleViewer.SetActive(true);
        }
        else
        {
            switch (num)
            {
                case 1:
                    SummerLessDogwood.SinkViewViewer_1.SetActive(true);
                    break;
                case 5:
                    SummerLessDogwood.SinkViewViewer_5.SetActive(true);
                    break;
                case 10:
                    SummerLessDogwood.SinkViewViewer_10.SetActive(true);
                    break;
                case 50:
                    SummerLessDogwood.SinkViewViewer_50.SetActive(true);
                    break;
                case 100:
                    SummerLessDogwood.SinkViewViewer_100.SetActive(true);
                    break;
                case 200:
                    SummerLessDogwood.SinkViewViewer_200.SetActive(true);
                    break;
                case 500:
                    SummerLessDogwood.SinkViewViewer_500.SetActive(true);
                    break;
            }
        }
        SummerGod = num / 100f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (DyeTossSewer)
        {
            if (GetComponent<Rigidbody>() != null)
            {
                if (SummerOnce == PusherRewardType.CoinCash || SummerOnce == PusherRewardType.CoinGold)
                {
                    if (transform.position.y < 1.269)
                    {
                        DyeTossSewer = false;
                        BrownOnce.SceneMusic type = (BrownOnce.SceneMusic)Enum.Parse(typeof(BrownOnce.SceneMusic), "sound_coin_collide_" + UnityEngine.Random.Range(1,5));
                        BrownTip.GetInstance().TossClutch(type, 0.1f);
                    }
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
