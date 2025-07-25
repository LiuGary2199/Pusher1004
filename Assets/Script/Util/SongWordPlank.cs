using UnityEngine;
using UnityEngine.UI;

public class SongWordPlank : GoldUIStain
{
    [Header("目标设置")]
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    public GameObject NotionCop;
[UnityEngine.Serialization.FormerlySerializedAs("padding")]    public float Meaning= 10f; // 目标周围的边距

    [Header("动画设置")]
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]    public float BelongSway= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetX")]    public float NotionCarbonX;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetY")]    public float NotionCarbonY;

    private Material Platelet;
    private RectTransform NotionSong;
    private Canvas NotionStripe;
    private RectTransform ReefSong;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetX")]
    public float ThunderCarbonX;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetY")]    public float ThunderCarbonY;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosX")]    public float NotionPosX;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosY")]    public float NotionIceY;

    private float BelongBedcoverX= 0f;
    private float BelongBedcoverY= 0f;
    private WirelessSenseMagnetism CreepMagnetism;
    private bool MapAlbedoCop= false;

    private void Start()
    {
        ReefSong = GetComponent<RectTransform>();
        Platelet = GetComponent<Image>().material;
        CreepMagnetism = GetComponent<WirelessSenseMagnetism>();

        // 检查是否有目标对象
        if (NotionCop != null)
        {
            NotionSong = NotionCop.GetComponent<RectTransform>();
            if (NotionSong != null)
            {
                NotionStripe = NotionCop.GetComponentInParent<Canvas>();
                if (NotionStripe != null)
                {
                    MapAlbedoCop = true;
                    TenantAlbedoDespondent();
                }
            }
        }

        if (!MapAlbedoCop)
        {
            // 原逻辑：使用Inspector中设置的参数
            Vector4 centerMat = new Vector4(NotionPosX, NotionIceY, 0, 0);
            Platelet.SetVector("_Center", centerMat);
        }

        if (CreepMagnetism != null && MapAlbedoCop)
        {
            CreepMagnetism.GunAlbedoSong(NotionSong);
        }
    }

    private void Update()
    {
        if (MapAlbedoCop)
        {
            TenantAlbedoDespondent();
        }

        // 原逻辑：平滑动画
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

    private void TenantAlbedoDespondent()
    {
        // 获取目标在屏幕空间的位置
        Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(NotionStripe.worldCamera, NotionSong.position);

        // 转换为遮罩面板的本地坐标
        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(ReefSong, screenPos, NotionStripe.worldCamera, out localPos);

        // 设置遮罩中心为目标中心
        NotionPosX = localPos.x;
        NotionIceY = localPos.y;
        Platelet.SetVector("_Center", new Vector4(NotionPosX, NotionIceY, 0, 0));

        // 设置遮罩大小为目标大小加上边距
        NotionCarbonX = (NotionSong.rect.width / 2) + Meaning;
        NotionCarbonY = (NotionSong.rect.height / 2) + Meaning;
    }

    // 外部调用：设置新的目标对象
    public void GunAlbedo(GameObject newTarget)
    {
        NotionCop = newTarget;

        if (NotionCop != null)
        {
            NotionSong = NotionCop.GetComponent<RectTransform>();
            if (NotionSong != null)
            {
                NotionStripe = NotionCop.GetComponentInParent<Canvas>();
                if (NotionStripe != null)
                {
                    MapAlbedoCop = true;
                    TenantAlbedoDespondent();

                    if (CreepMagnetism != null)
                    {
                        CreepMagnetism.GunAlbedoSong(NotionSong);
                    }
                }
            }
        }
        else
        {
            MapAlbedoCop = false;
        }
    }
}