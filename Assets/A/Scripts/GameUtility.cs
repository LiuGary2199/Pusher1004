using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏需要用到的工具类
/// </summary>
public class GameUtility : MonoBehaviour
{
    /// <summary>
    /// 判断点是否在精灵内
    /// </summary>
    /// <param name="targetSprite"></param>
    /// <param name="point"></param>
    /// <returns></returns>
    public static bool IsPointInSprite(SpriteRenderer targetSprite, Vector3 point)
    {
        // 将世界坐标点转换为精灵的本地坐标
        Vector3 localPoint = targetSprite.transform.InverseTransformPoint(point);
        localPoint = new Vector3( localPoint.x * targetSprite.transform.lossyScale.x, localPoint.y * targetSprite.transform.lossyScale.y, 0);

        // 获取精灵的边界（本地坐标）
        Bounds bounds = targetSprite.bounds;
        Vector3 localBoundsMin = bounds.min - targetSprite.transform.position;
        Vector3 localBoundsMax = bounds.max - targetSprite.transform.position;

        // 判断点是否在边界内
        return localPoint.x >= localBoundsMin.x && localPoint.x <= localBoundsMax.x &&
               localPoint.y >= localBoundsMin.y && localPoint.y <= localBoundsMax.y;
    }

}
