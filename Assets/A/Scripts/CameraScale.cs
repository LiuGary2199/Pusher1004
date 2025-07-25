using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 摄像机缩放脚本，适应不同分辨率的屏幕
/// </summary>
public class CameraScale : MonoBehaviour
{
    void Awake()
    {
        //得到设计分辨率
        Vector2 designResolution = GameObject.Find("Canvas").GetComponent<CanvasScaler>().referenceResolution;
        //得到实际分辨率
        Vector2 actualResolution = new Vector2(Screen.width, Screen.height);

        //得到设计分辨率的宽到实际分辨率的宽的比例
        float widthScale = designResolution.x / actualResolution.x;
        //得到将实际分辨率的宽缩放到设计分辨率高点宽后，实际分辨率的高
        float height = actualResolution.y * widthScale;

        //设置摄像机的size
        float orthoSize = Camera.main.orthographicSize;
        //缩放后的摄像机size
        Camera.main.orthographicSize = height * orthoSize / designResolution.y;
    }
}
