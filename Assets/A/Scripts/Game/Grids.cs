using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����
/// </summary>
public class Grids : MonoBehaviour
{
    /// <summary>
    /// �����ϵĴ�Բ��
    /// </summary>
    private Rings bigRing = null;

    /// <summary>
    /// �����ϵ���Բ��
    /// </summary>
    private Rings middleRing = null;

    /// <summary>
    /// �����ϵ�СԲ��
    /// </summary>
    private Rings smallRing = null;

    /// <summary>
    /// ���Բ��
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
    /// ��ȡ�����ϵ�Բ��
    /// </summary>
    /// <returns>�����ϵĴ��С�СԲ��</returns>
    public (Rings, Rings, Rings) GetRings()
    {
        return (bigRing, middleRing, smallRing);
    }

    /// <summary>
    /// ����Բ��
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
