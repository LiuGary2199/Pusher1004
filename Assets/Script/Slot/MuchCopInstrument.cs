// Project: Plinko
// FileName: MuchCopInstrument.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 14:21
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class MuchCopInstrument : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BigWin")]    public GameObject LugBad;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_1")]    public GameObject Dust_1;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_2")]    public GameObject Dust_2;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_3")]    public GameObject Dust_3;
[UnityEngine.Serialization.FormerlySerializedAs("SkillWall")]    public GameObject ErodeTide;
[UnityEngine.Serialization.FormerlySerializedAs("SkillBigCoin")]    public GameObject ErodeLugView;
[UnityEngine.Serialization.FormerlySerializedAs("SkillLong")]    public GameObject ErodeObey;
[UnityEngine.Serialization.FormerlySerializedAs("GemBlue")]    public GameObject RawStag;
[UnityEngine.Serialization.FormerlySerializedAs("GemRed")]    public GameObject RawAdd;
[UnityEngine.Serialization.FormerlySerializedAs("GemDiamond")]    public GameObject RawSurplus;
[UnityEngine.Serialization.FormerlySerializedAs("Golden")]    public GameObject Prefer;
[UnityEngine.Serialization.FormerlySerializedAs("slotObjData")]
    //public Text numText;

    public SlotRewardType ThenCopBulk;


    public void PassBulkBallad()
    {
        ThenCopBulk = GameUtil.GetSlotObjDataWithOutThanks();
        PassBulkAtBulk(ThenCopBulk);
    }

    public void PassBulkAtBulk(SlotRewardType targetObj)
    {
        //if (FalconErie.IsApple())
        //{
        //    if (targetObj.SlotObjType == SlotObjType.Cash)
        //    {
        //        targetObj.SlotObjType = SlotObjType.Ball;
        //    }
        //}

        ThenCopBulk = targetObj;
        FollyMad();
        PearMad();
    }


    private void FollyMad()
    {
        LugBad.gameObject.SetActive(false);
        Dust_1.gameObject.SetActive(false);
        Dust_2.gameObject.SetActive(false);
        Dust_3.gameObject.SetActive(false);
        ErodeTide.gameObject.SetActive(false);
        ErodeLugView.gameObject.SetActive(false);
        ErodeObey.gameObject.SetActive(false);
        RawStag.gameObject.SetActive(false);
        RawAdd.gameObject.SetActive(false);
        RawSurplus.gameObject.SetActive(false);
        Prefer.gameObject.SetActive(false);
    }


    private void PearMad()
    {
        switch (ThenCopBulk)
        {
            case SlotRewardType.BigWin:
                LugBad.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash1:
                Dust_1.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash2:
                Dust_2.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash3:
                Dust_3.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillWall:
                ErodeTide.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillBigCoin:
                ErodeLugView.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillLong:
                ErodeObey.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemBlue:
                RawStag.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemRed:
                RawAdd.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemDiamond:
                RawSurplus.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            default:
                Prefer.gameObject.SetActive(true);
                //numText.text = "";
                break;
        }
    }
}