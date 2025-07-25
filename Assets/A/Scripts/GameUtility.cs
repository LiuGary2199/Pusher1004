using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��Ϸ��Ҫ�õ��Ĺ�����
/// </summary>
public class GameUtility : MonoBehaviour
{
    /// <summary>
    /// �жϵ��Ƿ��ھ�����
    /// </summary>
    /// <param name="targetSprite"></param>
    /// <param name="point"></param>
    /// <returns></returns>
    public static bool IsPointInSprite(SpriteRenderer targetSprite, Vector3 point)
    {
        // �����������ת��Ϊ����ı�������
        Vector3 localPoint = targetSprite.transform.InverseTransformPoint(point);
        localPoint = new Vector3( localPoint.x * targetSprite.transform.lossyScale.x, localPoint.y * targetSprite.transform.lossyScale.y, 0);

        // ��ȡ����ı߽磨�������꣩
        Bounds bounds = targetSprite.bounds;
        Vector3 localBoundsMin = bounds.min - targetSprite.transform.position;
        Vector3 localBoundsMax = bounds.max - targetSprite.transform.position;

        // �жϵ��Ƿ��ڱ߽���
        return localPoint.x >= localBoundsMin.x && localPoint.x <= localBoundsMax.x &&
               localPoint.y >= localBoundsMin.y && localPoint.y <= localBoundsMax.y;
    }

}
