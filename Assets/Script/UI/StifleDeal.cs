using System;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class StifleDeal : GoldUIStain
{
    public static StifleDeal Instance;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
    public Text SummerPort;

   
    public override void Display()
    {
        SummerPort.text = "";
        base.Display();
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    private void Start()
    {
    }
    public void MyPassBulk(double num)
    {
        SummerPort.text = num.ToString();
    }
    public void PassBulk(double num)
    {
        SummerPort.text = num.ToString();
    }
    public override void Hidding()
    {
        base.Hidding();
    }
}