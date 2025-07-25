// Project: Pusher
// FileName: DisposeCrowdPlank.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 10:20
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisposeCrowdPlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button VideoWeb;
[UnityEngine.Serialization.FormerlySerializedAs("objList")]
    public List<GameObject> FenPeal;

    private List<GemsDataItem> CapBulkPeal;
    private void Start()
    {
        VideoWeb.onClick.AddListener(() =>
        {
            FollyPlank();
        });
        
        
        FanwiseEnergyHatch.GetInstance().Engineer(CShield.msg_Video_Fluid_Key_Total,
            (messageData) => {FollyPlank(); });

    }


    protected override void Awake()
    {
        base.Awake();
        CapBulkPeal = SapScanTip.instance.LadeBulk.Gem_Reward_list;
    }

    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        PassBulk();
    }

    private void PassBulk()
    {
        for (int i = 0; i < FenPeal.Count; i++)
        {
            GameObject objItem = FenPeal[i];
            objItem.GetComponent<DisposeCopInstrument>().TeemBulkLess = CapBulkPeal[i];
            objItem.GetComponent<DisposeCopInstrument>().PassBulk();
        }
    }


    private void FollyPlank()
    {
        PassBulk();
        CropUncover.Instance.LadeAmateur();
        FollyUIPeak(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }
}