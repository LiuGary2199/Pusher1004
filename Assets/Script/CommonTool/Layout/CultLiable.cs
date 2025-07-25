using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class CultLiable : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    public TargetType Albedo_Once;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    public LayoutType Liable_Once;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    public RunTime Toe_Sway;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    public float Liable_Senate;
    private void Awake()
    {
        if (Toe_Sway == RunTime.Awake)
        {
            InfestUnload();
        }
    }
    private void Start()
    {
        if (Toe_Sway == RunTime.Start)
        {
            InfestUnload();
        }
    }

    public void InfestUnload()
    {
        if (Liable_Once == LayoutType.Sprite_First_Weight)
        {
            if (Albedo_Once == TargetType.UGUI)
            {

                float scale = Screen.width / Liable_Senate;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(scale, scale, scale);
            }
        }
        if (Liable_Once == LayoutType.Screen_First_Weight)
        {
            if (Albedo_Once == TargetType.Scene)
            {
                float scale = TowMatterBulk.GetInstance().WhyUprootQuina() / Liable_Senate;
                transform.localScale = transform.localScale * scale;
            }
        }
        
        if (Liable_Once == LayoutType.Bottom)
        {
            if (Albedo_Once == TargetType.Scene)
            {
                float screen_bottom_y = TowMatterBulk.GetInstance().WhyUprootWinter() / -2;
                screen_bottom_y += (Liable_Senate + (TowMatterBulk.GetInstance().WhyTimelyFoil(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
