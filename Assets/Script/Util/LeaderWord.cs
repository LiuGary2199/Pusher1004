using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderWord : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    public GameObject NotionCop;
[UnityEngine.Serialization.FormerlySerializedAs("CurrentRadius")]
    public float ExtinctHawaii;
[UnityEngine.Serialization.FormerlySerializedAs("TargetRadius")]    public float AlbedoHawaii;
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]    public float BelongSway= 0f;

    private Material Platelet;


    private WirelessSenseMagnetism CreepMagnetism;


    private void Start()
    {
        Vector3 targetPos = NotionCop.transform.localPosition * 0.7f;
        Vector4 centerMat = new Vector4(targetPos.x, targetPos.y, 0, 0);
        Platelet = GetComponent<Image>().material;
        Platelet.SetVector("_Center", centerMat);


        CreepMagnetism = GetComponent<WirelessSenseMagnetism>();
        if (CreepMagnetism != null)
        {
            CreepMagnetism.GunAlbedoEgypt(NotionCop.gameObject.GetComponent<Image>());
        }
    }


    /// <summary>
    /// 收缩速度
    /// </summary>
    private float BelongBedcover= 0f;

    private void Update()
    {
        float value = Mathf.SmoothDamp(ExtinctHawaii, AlbedoHawaii, ref BelongBedcover, BelongSway);
        if (!Mathf.Approximately(value, ExtinctHawaii))
        {
            ExtinctHawaii = value;
            Platelet.SetFloat("_Slider", ExtinctHawaii);
        }
    }
}