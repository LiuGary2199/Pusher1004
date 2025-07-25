/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChoiceLace : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
    public Less PloyDirt;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
    public ScrollRect WeightSong;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
    //content
    public RectTransform Kinship;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
    public float Fashion= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
    public float RodeoQuina;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
    public float RodeoWinter;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
    public int SleeperRigor;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
    public bool AxWork= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
    public int TotalTwain;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
    public int GainTwain;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
    public float PloyWinter= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
    //缓存的itemlist
    public List<Less> PloyPeal;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
    public List<Less> SleeperPeal;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
    public List<int> CapPeal;

    void Start()
    {
        RodeoWinter = this.GetComponent<RectTransform>().sizeDelta.y;
        RodeoQuina = this.GetComponent<RectTransform>().sizeDelta.x;
        Kinship = WeightSong.content;
        PassBulk();

    }
    //初始化
    public void PassBulk()
    {
        SleeperRigor = Mathf.CeilToInt(RodeoWinter / VerbWinter) + 1;
        for (int i = 0; i < SleeperRigor; i++)
        {
            this.SkyLess();
        }
        TotalTwain = 0;
        GainTwain = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        GunBulk(numberList);
    }
    //设置数据
    void GunBulk(List<int> list)
    {
        CapPeal = list;
        TotalTwain = 0;
        if (BulkRigor <= SleeperRigor)
        {
            GainTwain = BulkRigor;
        }
        else
        {
            GainTwain = SleeperRigor - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = TotalTwain; i < GainTwain; i++)
        {
            Less obj = EatLess();
            if (obj == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                obj.gameObject.name = i.ToString();

                obj.gameObject.SetActive(true);
                obj.transform.localPosition = new Vector3(0, -i * VerbWinter, 0);
                SleeperPeal.Add(obj);
                TenantLess(i, obj);
            }

        }
        Kinship.sizeDelta = new Vector2(RodeoQuina, BulkRigor * VerbWinter - Fashion);
        AxWork = true;
    }
    //更新item
    public void TenantLess(int index, Less obj)
    {
        int d = CapPeal[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public Less EatLess()
    {
        Less obj = null;
        if (PloyPeal.Count > 0)
        {
            obj = PloyPeal[0];
            obj.gameObject.SetActive(true);
            PloyPeal.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return obj;
    }
    //item进入itemlist
    public void SourLess(Less obj)
    {
        PloyPeal.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int BulkRigor    {
        get
        {
            return CapPeal.Count;
        }
    }
    //每一行的高
    public float VerbWinter    {
        get
        {
            return PloyWinter + Fashion;
        }
    }
    //添加item到缓存列表中
    public void SkyLess()
    {
        GameObject obj = Instantiate(PloyDirt.gameObject);
        obj.transform.SetParent(Kinship);
        RectTransform Body= obj.GetComponent<RectTransform>();
        Body.anchorMin = new Vector2(0.5f, 1);
        Body.anchorMax = new Vector2(0.5f, 1);
        Body.pivot = new Vector2(0.5f, 1);
        obj.SetActive(false);
        obj.transform.localScale = Vector3.one;
        Less o = obj.GetComponent<Less>();
        PloyPeal.Add(o);
    }



    void Update()
    {
        if (AxWork)
        {
            Choice();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Choice()
    {
        float vy = Kinship.anchoredPosition.y;
        float rollUpTop = (TotalTwain + 1) * VerbWinter;
        float rollUnderTop = TotalTwain * VerbWinter;

        if (vy > rollUpTop && GainTwain < BulkRigor)
        {
            //上边界移除
            if (SleeperPeal.Count > 0)
            {
                Less obj = SleeperPeal[0];
                SleeperPeal.RemoveAt(0);
                SourLess(obj);
            }
            TotalTwain++;
        }
        float rollUpBottom = (GainTwain - 1) * VerbWinter - Fashion;
        if (vy < rollUpBottom - RodeoWinter && TotalTwain > 0)
        {
            //下边界减少
            GainTwain--;
            if (SleeperPeal.Count > 0)
            {
                Less obj = SleeperPeal[SleeperPeal.Count - 1];
                SleeperPeal.RemoveAt(SleeperPeal.Count - 1);
                SourLess(obj);
            }

        }
        float rollUnderBottom = GainTwain * VerbWinter - Fashion;
        if (vy > rollUnderBottom - RodeoWinter && GainTwain < BulkRigor)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            Less go = EatLess();
            SleeperPeal.Add(go);
            go.transform.localPosition = new Vector3(0, -GainTwain * VerbWinter);
            TenantLess(GainTwain, go);
            GainTwain++;
        }


        if (vy < rollUnderTop && TotalTwain > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            TotalTwain--;
            Less go = EatLess();
            SleeperPeal.Insert(0, go);
            TenantLess(TotalTwain, go);
            go.transform.localPosition = new Vector3(0, -TotalTwain * VerbWinter);
        }

    }
}
