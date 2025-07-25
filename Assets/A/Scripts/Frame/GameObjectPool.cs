using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 对象池模块
/// </summary>
public class GameObjectPool : BaseManager<GameObjectPool>
{
    public Dictionary<string, Queue<GameObject>> poolDic = new Dictionary<string, Queue<GameObject>>();

    //取某一个子模块中的对象
    public GameObject GetObj(string name, GameObject prefab = null)
    {
        GameObject obj = null;
        //判断有这个子模块并且子模块中还得有对象
        if (poolDic.ContainsKey(name) && poolDic[name].Count > 0)
        {
            //拿到第0个对象
            obj = poolDic[name].Dequeue();
        }
        else
        {
            if (prefab != null) 
            { 
                //如果池子里没有对象就创建对象
                obj = GameObject.Instantiate(prefab);
                //将对象的名字设置为和池子子模块的名字一样，这样就可以在PushObj中用对象名字存储
                obj.name = name;
            }
            else
            {
                Debug.LogError("没有找到对象：" + name);
            }
        }
        //物体激活，让其显示
        obj.SetActive(true);
        return obj;
    }

    //向某一个子模块中存暂时不用的对象
    public void PushObj(string name, GameObject obj)
    {
        //把物体失活，让其隐藏
        obj.SetActive(false);
        //如果没有这个子模块就就创建子模块再存
        if (!poolDic.ContainsKey(name))
        {
            poolDic.Add(name, new Queue<GameObject>());
        }
        poolDic[name].Enqueue(obj);   
    }

    /// <summary>
    /// 清空缓存池
    /// 切换场景的时候需要清空，否则会内存泄漏
    /// </summary>
    public void Clear()
    {
        poolDic.Clear();
    }
}
