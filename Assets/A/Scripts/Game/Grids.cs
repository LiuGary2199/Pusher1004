using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 格子
/// </summary>
public class Grids : MonoBehaviour
{
    /// <summary>
    /// 格子上的大圆环
    /// </summary>
    private Rings bigRing = null;

    /// <summary>
    /// 格子上的中圆环
    /// </summary>
    private Rings middleRing = null;

    /// <summary>
    /// 格子上的小圆环
    /// </summary>
    private Rings smallRing = null;

    /// <summary>
    /// 添加圆环
    /// </summary>
    /// <param name="ring"></param>
    public void AddRing(Rings ring)
    {
        switch (ring.GetRingSize())
        {
            case E_RingSize.Big:
                bigRing = ring;
                break;
            case E_RingSize.Medium:
                middleRing = ring;
                break;
            case E_RingSize.Small:
                smallRing = ring;
                break;
        }
    }

    /// <summary>
    /// 获取格子上的圆环
    /// </summary>
    /// <returns>格子上的大、中、小圆环</returns>
    public (Rings, Rings, Rings) GetRings()
    {
        return (bigRing, middleRing, smallRing);
    }

    /// <summary>
    /// 重置圆环
    /// </summary>
    /// <param name="ringSize"></param>
    public void ResetRing(E_RingSize ringSize)
    {
        switch (ringSize)
        {
            case E_RingSize.Big:
                bigRing = null;
                break;
            case E_RingSize.Medium:
                middleRing = null;
                break;
            case E_RingSize.Small:
                smallRing = null;
                break;
        }
    }
}
