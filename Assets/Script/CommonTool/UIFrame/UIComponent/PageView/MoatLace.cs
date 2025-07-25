/**
 * 
 * 左右滑动的页面视图
 * 
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class MoatLace : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
    public ScrollRect Body;
    //求出每页的临界角，页索引从0开始
    List<float> VasPeal= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
    public bool AxSeed= false;
    bool SlipMust= true;
    //滑动的起始坐标  
    float NotionImpossible= 0;
    float TotalSeedImpossible;
    float startTime = 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
    public float Diagonal= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    public float Celebratory= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
    public Action<int> DyPageSenate;
    //当前页面下标
    int ThunderMoatTwain= -1;
    void Start()
    {
        Body = this.GetComponent<ScrollRect>();
        float horizontalLength = Body.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        VasPeal.Add(0);
        for(int i = 1; i < Body.content.childCount - 1; i++)
        {
            VasPeal.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        VasPeal.Add(1);
    }

    
    void Update()
    {
        if(!AxSeed && !SlipMust)
        {
            startTime += Time.deltaTime;
            float t = startTime * Diagonal;
            Body.horizontalNormalizedPosition = Mathf.Lerp(Body.horizontalNormalizedPosition, NotionImpossible, t);
            if (t >= 1)
            {
                SlipMust = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void GunMoatTwain(int index)
    {
        if (ThunderMoatTwain != index)
        {
            ThunderMoatTwain = index;
            if (DyPageSenate != null)
            {
                DyPageSenate(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        AxSeed = true;
        TotalSeedImpossible = Body.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = Body.horizontalNormalizedPosition;
        posX += ((posX - TotalSeedImpossible) * Celebratory);
        posX = posX < 1 ? posX : 1;
        posX = posX > 0 ? posX : 0;
        int Onset= 0;
        float offset = Mathf.Abs(VasPeal[Onset] - posX);
        for(int i = 0; i < VasPeal.Count; i++)
        {
            float temp = Mathf.Abs(VasPeal[i] - posX);
            if (temp < offset)
            {
                Onset = i;
                offset = temp;
            }
        }
        GunMoatTwain(Onset);
        NotionImpossible = VasPeal[Onset];
        AxSeed = false;
        startTime = 0f;
        SlipMust = false;
    }
}
