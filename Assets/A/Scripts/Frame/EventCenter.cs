using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// �¼�����
/// </summary>
public class EventCenter : BaseManager<EventCenter>
{
    private Dictionary<string, UnityAction<object>> eventDic = new Dictionary<string, UnityAction<object>>();

    /// <summary>
    /// ����¼�����
    /// </summary>
    /// <param name="name">�¼���</param>
    /// <param name="action">�¼�������</param>
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
    /// �Ƴ��¼�����
    /// </summary>
    /// <param name="name">�¼���</param>
    /// <param name="action">Ҫ������¼�������</param>
    public void RemoveEventListener(string name, UnityAction<object> action)
    {
        if (eventDic.ContainsKey(name))
        {
            //���������¼����Ͱѽ����
            eventDic[name] -= action;
        }
    }

    /// <summary>
    /// ����¼�����
    /// һ����������õ�����ֹ�����ڴ�й©
    /// </summary>
    public void ClearAllEvent()
    {
        eventDic.Clear();
    }

    /// <summary>
    /// ɾ��ĳһָ���¼�
    /// </summary>
    /// <param name="eventName">ɾ�����¼���</param>
    public void Clear(string eventName)
    {
        if (eventDic.ContainsKey(eventName))
            eventDic.Remove(eventName);
    }

    /// <summary>
    /// �����¼�
    /// </summary>
    /// <param name="name">�������¼���</param>
    /// <param name="info">�¼�����</param>
    public void EventTrigger(string name, object info = null)
    {
        //���а�����¼��Ĵ�����ʱ����ִ��
        if (eventDic.ContainsKey(name))
            eventDic[name](info);
    }
}
