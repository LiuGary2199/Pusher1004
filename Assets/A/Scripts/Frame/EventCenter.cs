using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 事件中心
/// </summary>
public class EventCenter : BaseManager<EventCenter>
{
    private Dictionary<string, UnityAction<object>> eventDic = new Dictionary<string, UnityAction<object>>();

    /// <summary>
    /// 添加事件监听
    /// </summary>
    /// <param name="name">事件名</param>
    /// <param name="action">事件处理函数</param>
    public void AddEventListener(string name, UnityAction<object> action)
    {
        if (eventDic.ContainsKey(name))
        {
            eventDic[name] += action;
        }
        else
        {
            eventDic.Add(name, action);
        }
    }

    /// <summary>
    /// 移除事件监听
    /// </summary>
    /// <param name="name">事件名</param>
    /// <param name="action">要溢出的事件处理函数</param>
    public void RemoveEventListener(string name, UnityAction<object> action)
    {
        if (eventDic.ContainsKey(name))
        {
            //如果有这个事件，就把解除绑定
            eventDic[name] -= action;
        }
    }

    /// <summary>
    /// 清空事件中心
    /// 一般过场景会用到，防止出现内存泄漏
    /// </summary>
    public void ClearAllEvent()
    {
        eventDic.Clear();
    }

    /// <summary>
    /// 删除某一指定事件
    /// </summary>
    /// <param name="eventName">删除的事件名</param>
    public void Clear(string eventName)
    {
        if (eventDic.ContainsKey(eventName))
            eventDic.Remove(eventName);
    }

    /// <summary>
    /// 触发事件
    /// </summary>
    /// <param name="name">触发的事件名</param>
    /// <param name="info">事件参数</param>
    public void EventTrigger(string name, object info = null)
    {
        //当有绑定这个事件的处理函数时，就执行
        if (eventDic.ContainsKey(name))
            eventDic[name](info);
    }
}
