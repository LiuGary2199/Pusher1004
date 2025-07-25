/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WanderLuceUncover : MailPerformer<WanderLuceUncover>
{
    //管理objectpool的字典
    private Dictionary<string, WanderLuce> m_LuceLop;
    private Transform m_TendResonance=null;
    //构造函数
    public WanderLuceUncover()
    {
        m_LuceLop = new Dictionary<string, WanderLuce>();      
    }
    
    //创建一个新的对象池
    public T ComedyWanderLuce<T>(string poolName) where T : WanderLuce, new()
    {
        if (m_LuceLop.ContainsKey(poolName))
        {
            return m_LuceLop[poolName] as T;
        }
        if (m_TendResonance == null)
        {
            m_TendResonance = this.transform;
        }      
        GameObject obj = new GameObject(poolName);
        obj.transform.SetParent(m_TendResonance);
        T King= new T();
        King.Pass(poolName, obj.transform);
        m_LuceLop.Add(poolName, King);
        return King;
    }
    //取对象
    public GameObject TowLadeWander(string poolName)
    {
        if (m_LuceLop.ContainsKey(poolName))
        {
            return m_LuceLop[poolName].Tow();
        }
        return null;
    }
    //回收对象
    public void MediateLadeWander(string poolName,GameObject go)
    {
        if (m_LuceLop.ContainsKey(poolName))
        {
            m_LuceLop[poolName].Mediate(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_LuceLop.Clear();
        GameObject.Destroy(m_TendResonance);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool CarveLuce(string poolName)
    {
        return m_LuceLop.ContainsKey(poolName) ? true : false;
    }
}
