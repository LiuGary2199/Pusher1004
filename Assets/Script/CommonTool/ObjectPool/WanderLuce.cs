/*
 *   管理对象的池子
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderLuce 
{
    private Queue<GameObject> m_LuceBison;
    //池子名称
    private string m_LuceHail;
    //父物体
    protected Transform m_Onward;
    //缓存对象的预制体
    private GameObject Inside;
    //最大容量
    private int m_YewRigor;
    //默认最大容量
    protected const int m_OrbitalYewRigor= 20;
    public GameObject Encase    {
        get => Inside;set { Inside = value;  }
    }
    //构造函数初始化
    public WanderLuce()
    {
        m_YewRigor = m_OrbitalYewRigor;
        m_LuceBison = new Queue<GameObject>();
    }
    //初始化
    public virtual void Pass(string poolName,Transform transform)
    {
        m_LuceHail = poolName;
        m_Onward = transform;
    }
    //取对象
    public virtual GameObject Tow()
    {
        GameObject obj;
        if (m_LuceBison.Count > 0)
        {
            obj = m_LuceBison.Dequeue();
        }
        else
        {
            obj = GameObject.Instantiate<GameObject>(Inside);
            obj.transform.SetParent(m_Onward);
            obj.SetActive(false);
        }
        obj.SetActive(true);
        return obj;
    }
    //回收对象
    public virtual void Mediate(GameObject obj)
    {
        if (m_LuceBison.Contains(obj)) return;
        if (m_LuceBison.Count >= m_YewRigor)
        {
            GameObject.Destroy(obj);
        }
        else
        {
            m_LuceBison.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    /// <summary>
    /// 回收所有激活的对象
    /// </summary>
    public virtual void MediateEye()
    {
        Transform[] child = m_Onward.GetComponentsInChildren<Transform>();
        foreach (Transform item in child)
        {
            if (item == m_Onward)
            {
                continue;
            }
            
            if (item.gameObject.activeSelf)
            {
                Mediate(item.gameObject);
            }
        }
    }
    //销毁
    public virtual void Sixteen()
    {
        m_LuceBison.Clear();
    }
}
