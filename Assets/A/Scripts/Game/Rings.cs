using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Բ��
/// </summary>
public class Rings : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    /// <summary>
    /// Բ����С
    /// </summary>
    private E_RingSize ringSize;

    /// <summary>
    /// Բ����ɫ
    /// </summary>
    private E_RingColor ringColor;

    /// <summary>
    /// ��קʱ��ָ��Բ���ľ���
    /// </summary>
    private Vector3 deltaPos;

    /// <summary>
    /// �Ƿ������ק
    /// </summary>
    private bool canDrag = true;

    /// <summary>
    /// ��ָ����ʱ
    /// </summary>
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (!canDrag) return;
        //�õ����λ��
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(eventData.position);
        //�õ�Բ����λ��
        Vector3 ringPos = transform.position;
        //�����������
        deltaPos = clickPos - ringPos;
    }

    /// <summary>
    /// ��קʱ
    /// </summary>
    /// <param name="eventData"></param>
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (!canDrag) return;
        transform.position = Camera.main.ScreenToWorldPoint(eventData.position) - deltaPos;
    }

    /// <summary>
    /// ��ָ̧��ʱ
    /// </summary>
    /// <param name="eventData"></param>
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (!canDrag) return;
        //�ж�̧���λ���Ƿ������̷�Χ��
        Transform chessboard = GameManager.Instance.chessboard.transform;
        if (GameUtility.IsPointInSprite(chessboard.GetComponent<SpriteRenderer>(), Camera.main.ScreenToWorldPoint(eventData.position)))
        {
            //�ж�̧���λ���Ƿ��������ڵĸ�����
            for (int i = 0; i < chessboard.childCount; i++)
            {
                if (GameUtility.IsPointInSprite(chessboard.GetChild(i).GetComponent<SpriteRenderer>(), Camera.main.ScreenToWorldPoint(eventData.position)))
                {
                    //�жϸø����Ƿ��Ѿ���ͬ���ߴ��Բ���ˣ�����оͷ���ԭλ��
                    (Rings, Rings, Rings) rings = chessboard.GetChild(i).GetComponent<Grids>().GetRings();
                    switch (ringSize)
                    {
                        case E_RingSize.Big:
                            if (rings.Item1 != null)
                            {
                                //����ԭ����λ��
                                transform.position = RingsCreator.Instance.transform.position;
                                return;
                            }
                            break;
                        case E_RingSize.Medium:
                            if (rings.Item2 != null)
                            {
                                //����ԭ����λ��
                                transform.position = RingsCreator.Instance.transform.position;
                                return;
                            }
                            break;
                        case E_RingSize.Small:
                            if (rings.Item3 != null)
                            {
                                //����ԭ����λ��
                                transform.position = RingsCreator.Instance.transform.position;
                                return;
                            }
                            break;
                    }
                    transform.position = chessboard.GetChild(i).position;   //��Բ���ƶ��������ڵĸ�����
                    //������Ч
                    AudioManager.Instance.PlayAudio(0);
                    chessboard.GetChild(i).GetComponent<Grids>().AddRing(this);
                    canDrag = false;   //��ֹ��ק

                    EventCenter.Instance.EventTrigger("DragEnd", (chessboard.GetChild(i).GetComponent<Grids>(), this));   //������ק�����¼�
                    EventCenter.Instance.EventTrigger("CreateNewRing");   //�����µ�Բ��
                    return;
                }
            }
            //�������κ�һ�����ӣ��򷵻�ԭ����λ��
            transform.position = RingsCreator.Instance.transform.position;
        }
        //�ж�̧���λ���Ƿ��������ط�
        else
        {
            //����ԭ����λ��
            transform.position = RingsCreator.Instance.transform.position;
        }
    }

    /// <summary>
    /// ����Բ������
    /// </summary>
    public void SetRing(E_RingSize size, E_RingColor color, Sprite sprite, bool canDrag = true)
    {
        ringSize = size;
        ringColor = color;
        this.canDrag = canDrag;     //���ÿ�����ק
        
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    /// <summary>
    /// ��ȡԲ���ߴ�
    /// </summary>
    /// <returns>Բ���ĳߴ�</returns>
    public E_RingSize GetRingSize()
    {
        return ringSize;
    }

    /// <summary>
    /// ��ȡԲ������ɫ
    /// </summary>
    /// <returns>Բ������ɫ</returns>
    public E_RingColor GetRingColor()
    {
        return ringColor;
    }
}

/// <summary>
/// Բ����С
/// </summary>
public enum E_RingSize
{
    Big,    // ��Բ��
    Medium, // ��Բ��
    Small   // СԲ��
}

/// <summary>
/// Բ����ɫ
/// </summary>
public enum E_RingColor
{
    Red,
    Green,
    Blue,
    Yellow,
    Orange,
    Pink,
    Cyan,
}
