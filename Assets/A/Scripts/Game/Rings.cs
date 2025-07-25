using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 圆环
/// </summary>
public class Rings : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    /// <summary>
    /// 圆环大小
    /// </summary>
    private E_RingSize ringSize;

    /// <summary>
    /// 圆环颜色
    /// </summary>
    private E_RingColor ringColor;

    /// <summary>
    /// 拖拽时手指和圆环的距离
    /// </summary>
    private Vector3 deltaPos;

    /// <summary>
    /// 是否可以拖拽
    /// </summary>
    private bool canDrag = true;

    /// <summary>
    /// 手指按下时
    /// </summary>
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (!canDrag) return;
        //得到点击位置
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(eventData.position);
        //得到圆环的位置
        Vector3 ringPos = transform.position;
        //计算两点距离
        deltaPos = clickPos - ringPos;
    }

    /// <summary>
    /// 拖拽时
    /// </summary>
    /// <param name="eventData"></param>
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (!canDrag) return;
        transform.position = Camera.main.ScreenToWorldPoint(eventData.position) - deltaPos;
    }

    /// <summary>
    /// 手指抬起时
    /// </summary>
    /// <param name="eventData"></param>
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (!canDrag) return;
        //判断抬起的位置是否在棋盘范围内
        Transform chessboard = GameManager.Instance.chessboard.transform;
        if (GameUtility.IsPointInSprite(chessboard.GetComponent<SpriteRenderer>(), Camera.main.ScreenToWorldPoint(eventData.position)))
        {
            //判断抬起的位置是否在棋盘内的格子中
            for (int i = 0; i < chessboard.childCount; i++)
            {
                if (GameUtility.IsPointInSprite(chessboard.GetChild(i).GetComponent<SpriteRenderer>(), Camera.main.ScreenToWorldPoint(eventData.position)))
                {
                    //判断该格子是否已经有同样尺寸的圆环了，如果有就返回原位置
                    (Rings, Rings, Rings) rings = chessboard.GetChild(i).GetComponent<Grids>().GetRings();
                    switch (ringSize)
                    {
                        case E_RingSize.Big:
                            if (rings.Item1 != null)
                            {
                                //返回原来的位置
                                transform.position = RingsCreator.Instance.transform.position;
                                return;
                            }
                            break;
                        case E_RingSize.Medium:
                            if (rings.Item2 != null)
                            {
                                //返回原来的位置
                                transform.position = RingsCreator.Instance.transform.position;
                                return;
                            }
                            break;
                        case E_RingSize.Small:
                            if (rings.Item3 != null)
                            {
                                //返回原来的位置
                                transform.position = RingsCreator.Instance.transform.position;
                                return;
                            }
                            break;
                    }
                    transform.position = chessboard.GetChild(i).position;   //将圆环移动到棋盘内的格子中
                    //设置音效
                    AudioManager.Instance.PlayAudio(0);
                    chessboard.GetChild(i).GetComponent<Grids>().AddRing(this);
                    canDrag = false;   //禁止拖拽

                    EventCenter.Instance.EventTrigger("DragEnd", (chessboard.GetChild(i).GetComponent<Grids>(), this));   //触发拖拽结束事件
                    EventCenter.Instance.EventTrigger("CreateNewRing");   //创建新的圆环
                    return;
                }
            }
            //不属于任何一个格子，则返回原来的位置
            transform.position = RingsCreator.Instance.transform.position;
        }
        //判断抬起的位置是否在其他地方
        else
        {
            //返回原来的位置
            transform.position = RingsCreator.Instance.transform.position;
        }
    }

    /// <summary>
    /// 设置圆环属性
    /// </summary>
    public void SetRing(E_RingSize size, E_RingColor color, Sprite sprite, bool canDrag = true)
    {
        ringSize = size;
        ringColor = color;
        this.canDrag = canDrag;     //设置可以拖拽
        
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    /// <summary>
    /// 获取圆环尺寸
    /// </summary>
    /// <returns>圆环的尺寸</returns>
    public E_RingSize GetRingSize()
    {
        return ringSize;
    }

    /// <summary>
    /// 获取圆环的颜色
    /// </summary>
    /// <returns>圆环的颜色</returns>
    public E_RingColor GetRingColor()
    {
        return ringColor;
    }
}

/// <summary>
/// 圆环大小
/// </summary>
public enum E_RingSize
{
    Big,    // 大圆环
    Medium, // 中圆环
    Small   // 小圆环
}

/// <summary>
/// 圆环颜色
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
