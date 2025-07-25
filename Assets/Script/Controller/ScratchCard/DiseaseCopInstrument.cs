// Project: Plinko
// FileName: DiseaseCopInstrument.cs
// Author: AX
// CreateDate: 20230522
// CreateTime: 10:13
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class DiseaseCopInstrument : MonoBehaviour
{
    public static DiseaseCopInstrument Instance;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
    public GameObject SinkMad;
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]    public GameObject CodeMad;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public GameObject UnseenMad;
[UnityEngine.Serialization.FormerlySerializedAs("circleImg")]    public GameObject GatherMad;
[UnityEngine.Serialization.FormerlySerializedAs("mainNumText")]
    public Text BarbGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]    public Text SummerGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("mainNum")]
    public int BarbGod;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    public double SummerGod;
[UnityEngine.Serialization.FormerlySerializedAs("scratchObjData")]
    public ScratchObjData ClassicCopBulk;

    private void Awake()
    {
        Instance = this;
    }


    private void FollyMad()
    {
        CodeMad.gameObject.SetActive(false);
        SinkMad.gameObject.SetActive(false);
        UnseenMad.gameObject.SetActive(false);
        GatherMad.gameObject.SetActive(false);
    }

    private void PearMad()
    {
        switch (ClassicCopBulk.ScratchObjType)
        {
            case ScratchObjType.Amazon:
                SummerGod = ClassicCopBulk.RewardNum * GameUtil.GetAmazonMulti();
                SummerGodPort.text = "" + SummerGod;
                UnseenMad.gameObject.SetActive(true);
                break;
            case ScratchObjType.Cash:
                double cashNum = ClassicCopBulk.RewardNum * GameUtil.GetCashMultiWithOutRandom();
                SummerGod = Math.Round(cashNum, 2);
                SummerGodPort.text = "" + SummerGod;
                SinkMad.gameObject.SetActive(true);
                break;
            default:
                SummerGod = ClassicCopBulk.RewardNum * GameUtil.GetGoldMulti();
                SummerGodPort.text = "" + SummerGod;
                CodeMad.gameObject.SetActive(true);
                break;
        }
        ClassicCopBulk.RewardNum = SummerGod;
    }

    public void PearAlbedo()
    {
        // BrownTip.GetInstance().PlayEffect(BrownOnce.UIMusic.sound_scratch_reward);
        GatherMad.gameObject.SetActive(true);
        BarbGodPort.color = new Color(1f, 1f, 0f);
    }

    public void PassBulk(int num, bool isRewardNumber = false)
    {
        BarbGod = num;
        BarbGodPort.text = num + "";
        BarbGodPort.color = new Color(1f, 1f, 1f);
        if (isRewardNumber)
        {
            ClassicCopBulk = GameUtil.GetScratchObjData();
        }
        else
        {
            int Briny= SapScanTip.instance.LadeBulk.scratch_data_list.Count;
            ScratchDataItem item = SapScanTip.instance.LadeBulk.scratch_data_list[UnityEngine.Random.Range(0, Briny)];
            ClassicCopBulk = new ScratchObjData();
            ClassicCopBulk.RewardNum = item.reward_num;
            ClassicCopBulk.ScratchObjType = (ScratchObjType)Enum.Parse(typeof(ScratchObjType), item.type);
        }

        if (FalconErie.MyUnder())
        {
            ClassicCopBulk.ScratchObjType = ScratchObjType.Gold;
        }

        FollyMad();
        PearMad();
    }
}