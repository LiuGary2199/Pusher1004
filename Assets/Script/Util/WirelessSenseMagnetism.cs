using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 事件渗透
/// </summary>
public class WirelessSenseMagnetism : MonoBehaviour, ICanvasRaycastFilter
{
    private Image NotionEgypt;
    private RectTransform NotionSong;
    public void GunAlbedoEgypt(Image target)
    {
        NotionEgypt = target;
    }
    public void GunAlbedoSong(RectTransform rect)
    {
        NotionSong = rect;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (NotionEgypt == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(NotionEgypt.rectTransform, sp, eventCamera);
    }
}