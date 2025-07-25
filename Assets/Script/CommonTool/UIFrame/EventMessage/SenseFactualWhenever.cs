/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SenseFactualWhenever : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate GoAdult;
    public VoidDelegate GoDown;
    public VoidDelegate GoBrawl;
    public VoidDelegate GoDare;
    public VoidDelegate GoNo;
    public VoidDelegate GoExceed;
    public VoidDelegate GoTenantExceed;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static SenseFactualWhenever Tow(GameObject go)
    {
        SenseFactualWhenever listener = go.GetComponent<SenseFactualWhenever>();
        if (listener == null)
        {
            listener = go.AddComponent<SenseFactualWhenever>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (GoAdult != null)
        {
            GoAdult(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (GoDown != null)
        {
            GoDown(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (GoBrawl != null)
        {
            GoBrawl(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (GoDare != null)
        {
            GoDare(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (GoNo != null)
        {
            GoNo(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (GoExceed != null)
        {
            GoExceed(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (GoTenantExceed != null)
        {
            GoTenantExceed(gameObject);
        }
    }
}
