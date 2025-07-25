using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuceUncover : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("pool")]    public List<GameObject> King;
[UnityEngine.Serialization.FormerlySerializedAs("prefab")]    public GameObject Inside;
    private Transform InsideOnward;
    private string TomatoHail;

    public void PassLuceUncover(GameObject obj, Transform parent, int count, string _objectName)
    {
        Inside = obj;
        TomatoHail = _objectName;
        King = new List<GameObject>();
        InsideOnward = parent;
        int TotalTwain= 0;
        for (int k = 0; k < InsideOnward.childCount; k++)
        {
            if (InsideOnward.GetChild(k).name.Contains(TomatoHail))
            {
                King.Add(InsideOnward.GetChild(k).gameObject);
                TotalTwain++;
            }
        }
        for (int i = TotalTwain; i < count; i++)
        {
            GameObject objClone = GameObject.Instantiate(Inside, InsideOnward) as GameObject;
            //objClone.transform.parent = prefabParent;//为克隆出来的子弹指定父物体
            objClone.name = TomatoHail + "(" + i.ToString() + ")";
            objClone.SetActive(false);
            King.Add(objClone);
        }
    }
    public void EthnicLuceSkyLess(GameObject obj)
    {
        King.Add(obj);
    }

    public GameObject TowWander()
    {
        //遍历缓存池 找空闲的物体
        foreach (GameObject iter in King)
        {
            if (iter != null && !iter.activeSelf)
            {
                iter.transform.SetParent(InsideOnward);
                iter.SetActive(true);
                return iter;
            }
        }
        GameObject newPrefab = GameObject.Instantiate(Inside) as GameObject;
        newPrefab.transform.SetParent(InsideOnward);
        newPrefab.name = TomatoHail + "(" + King.Count.ToString() + ")"  ;
        newPrefab.SetActive(true);
        King.Add(newPrefab);
        return newPrefab;
    }

    public void FollyEye()
    {
        foreach (GameObject iter in King)
        {
            if (iter.activeSelf)
            {
                iter.SetActive(false);
            }
        }
    }
    public void SixteenEye()
    {
        foreach (GameObject iter in King)
        {
            Destroy(iter);
        }
        Destroy(InsideOnward);
        Destroy(this.gameObject);
    }
}
