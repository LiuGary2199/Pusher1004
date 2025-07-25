// Project: HappyBingo-Real
// FileName: SongWordPlank.cs
// Author: AX
// CreateDate: 20230220
// CreateTime: 9:55
// Description:

using UnityEngine;
using UnityEngine.UI;

public class SongWordPlankSense : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetX")]    public float NotionCarbonX;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetY")]    public float NotionCarbonY;
    private Material Platelet;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetX")]
    public float ThunderCarbonX;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetY")]    public float ThunderCarbonY;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosX")]
    public float NotionPosX;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosY")]    public float NotionIceY;
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]
    public float BelongSway= 0.3f;
    private WirelessSenseMagnetism CreepMagnetism;
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    public GameObject NotionCop;


    private float BelongBedcoverX= 0f;
    private float BelongBedcoverY= 0f;


    private void Start()
    {
        Vector4 centerMat = new Vector4(NotionPosX, NotionIceY, 0, 0);
        Platelet = GetComponent<Image>().material;
        Platelet.SetVector("_Center", centerMat);


        CreepMagnetism = GetComponent<WirelessSenseMagnetism>();
        if (CreepMagnetism != null)
        {
            CreepMagnetism.GunAlbedoEgypt(NotionCop.gameObject.GetComponent<Image>());
        }
    }

    private void Update()
    {
        
        //从当前偏移量到目标偏移量差值显示收缩动画
        float valueX = Mathf.SmoothDamp(ThunderCarbonX, NotionCarbonX, ref BelongBedcoverX, BelongSway);
        float valueY = Mathf.SmoothDamp(ThunderCarbonY, NotionCarbonY, ref BelongBedcoverY, BelongSway);
        if (!Mathf.Approximately(valueX, ThunderCarbonX))
        {
            ThunderCarbonX = valueX;
            Platelet.SetFloat("_SliderX", ThunderCarbonX);
        }

        if (!Mathf.Approximately(valueY, ThunderCarbonY))
        {
            ThunderCarbonY = valueY;
            Platelet.SetFloat("_SliderY", ThunderCarbonY);
        }
    }
    
    
    /// <summary>
    /// 世界坐标转换为画布坐标
    /// </summary>
    /// <param name="canvas">画布</param>
    /// <param name="world">世界坐标</param>
    /// <returns></returns>
    private Vector2 AwaitNoStripeIce(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }
    
}