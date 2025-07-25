using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����ģ��
/// </summary>
public class GameObjectPool : BaseManager<GameObjectPool>
{
    public Dictionary<string, Queue<GameObject>> poolDic = new Dictionary<string, Queue<GameObject>>();

    //ȡĳһ����ģ���еĶ���
    public GameObject GetObj(string name, GameObject prefab = null)
    {
        GameObject obj = null;
        //�ж��������ģ�鲢����ģ���л����ж���
        if (poolDic.ContainsKey(name) && poolDic[name].Count > 0)
        {
            //�õ���0������
            obj = poolDic[name].Dequeue();
        }
        else
        {
            if (prefab != null) 
            { 
                //���������û�ж���ʹ�������
                obj = GameObject.Instantiate(prefab);
                //���������������Ϊ�ͳ�����ģ�������һ���������Ϳ�����PushObj���ö������ִ洢
                obj.name = name;
            }
            else
            {
                Debug.LogError("û���ҵ�����" + name);
            }
        }
        //���弤�������ʾ
        obj.SetActive(true);
        return obj;
    }

    //��ĳһ����ģ���д���ʱ���õĶ���
    public void PushObj(string name, GameObject obj)
    {
        //������ʧ���������
        obj.SetActive(false);
        //���û�������ģ��;ʹ�����ģ���ٴ�
        if (!poolDic.ContainsKey(name))
        {
            poolDic.Add(name, new Queue<GameObject>());
        }
        poolDic[name].Enqueue(obj);   
    }

    /// <summary>
    /// ��ջ����
    /// �л�������ʱ����Ҫ��գ�������ڴ�й©
    /// </summary>
    public void Clear()
    {
        poolDic.Clear();
    }
}
