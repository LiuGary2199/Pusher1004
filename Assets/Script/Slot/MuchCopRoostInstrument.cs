// Project: Plinko
// FileName: MuchCopRoostInstrument.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 15:50
// Description:

using System;
using System.Collections.Generic;
using Spine;
using UnityEngine;

public class MuchCopRoostInstrument : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("baseSlotObj")]    public GameObject TextMuchCop;
[UnityEngine.Serialization.FormerlySerializedAs("slotObjList")]    public List<GameObject> ThenCopPeal;
[UnityEngine.Serialization.FormerlySerializedAs("rewardObjList")]

    public List<SlotRewardType> SummerCopPeal;
    
    private int CudTwain;
    private int SummerTwain;


    private void Awake()
    {
        CudTwain = 33;
        SummerTwain = 30;
    }

    private void Start()
    {
        PassBulk();
    }

    public void PassBulk()
    {
        for (int i = 0; i < CudTwain; i++)
        {
            GameObject objItem = Instantiate(TextMuchCop, transform);
            Vector3 pos = new Vector3();
            pos.y = i - 2;
            objItem.transform.localPosition = pos;
            objItem.GetComponent<MuchCopInstrument>().PassBulkBallad();
            ThenCopPeal.Add(objItem);
        }
    }

    public void ComedySecretCop(SlotRewardType rewardData)
    {

        
        for (int i = SummerTwain; i < CudTwain; i++)
        {
            GameObject objItem = ThenCopPeal[i];

            if (i == SummerTwain)
            {
                objItem.GetComponent<MuchCopInstrument>().PassBulkAtBulk(rewardData);
            }
            else
            {
                objItem.GetComponent<MuchCopInstrument>().PassBulkBallad();
            }
        }
        
        SummerCopPeal = new List<SlotRewardType>();
        for (int i = SummerTwain-2; i < CudTwain; i++)
        {
            GameObject objItem = ThenCopPeal[i];
            SlotRewardType tempData = objItem.GetComponent<MuchCopInstrument>().ThenCopBulk;
            SummerCopPeal.Add(tempData);
        }
        
    }

    public void PotteryBulk()
    {
        // ClearData();
        AtPass();
    }

    private void AtPass()
    {
        for (int i = 0; i < CudTwain; i++)
        {
            GameObject objItem = ThenCopPeal[i];
            if (i < 5)
            {
                SlotRewardType tarItem = SummerCopPeal[i];
                objItem.GetComponent<MuchCopInstrument>().PassBulkAtBulk(tarItem);
            }
            else
            {
                objItem.GetComponent<MuchCopInstrument>().PassBulkBallad();
            }
        }
    }

}