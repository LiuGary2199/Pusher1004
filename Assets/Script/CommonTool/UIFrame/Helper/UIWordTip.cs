﻿/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIWordTip : MonoBehaviour
{
    private static UIWordTip _Variance= null;
    //ui根节点对象
    private GameObject _GoStripeTend= null;
    //ui脚本节点对象
    private Transform _YetUIAverageList= null;
    //顶层面板
    private GameObject _OxToPlank;
    //遮罩面板
    private GameObject _OxWordPlank;
    //ui摄像机
    private Camera _UIUproot;
    //ui摄像机原始的层深
    private float _DramaticUIUprootRealm;
    //获取实例
    public static UIWordTip GetInstance()
    {
        if (_Variance == null)
        {
            _Variance = new GameObject("_UIMaskMgr").AddComponent<UIWordTip>();
        }
        return _Variance;
    }
    private void Awake()
    {
        _GoStripeTend = GameObject.FindGameObjectWithTag(EndLondon.SYS_TAG_CANVAS);
        _YetUIAverageList = GrazeInform.FlaxTheChickList(_GoStripeTend, EndLondon.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        GrazeInform.SkyChickListNoOnwardList(_YetUIAverageList, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _OxToPlank = _GoStripeTend;
        _OxWordPlank = GrazeInform.FlaxTheChickList(_GoStripeTend, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UIUproot = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UIUproot != null)
        {
            //得到ui相机原始的层深
            _DramaticUIUprootRealm = _UIUproot.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void GunWordRugged(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _OxToPlank.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _OxWordPlank.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _OxWordPlank.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _OxWordPlank.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 220 / 255F);
                _OxWordPlank.GetComponent<Image>().color = newColor2;
                FanwiseEnergyHatch.GetInstance().Cany(CShield.Be_RuggedEpic);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _OxWordPlank.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 240F / 255F);
                _OxWordPlank.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_OxWordPlank.activeInHierarchy)
                {
                    _OxWordPlank.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _OxWordPlank.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UIUproot != null)
        {
            _UIUproot.depth = _UIUproot.depth + 100;
        }
    }
    public void AfarWordRugged()
    {
        if (UIManager.GetInstance().MoatUIStain.Count > 0 || UIManager.GetInstance().TowExtinctPeakShrub().Count > 0)
        {
            return;
        }
        Color newColor3 = new Color(_OxWordPlank.GetComponent<Image>().color.r, _OxWordPlank.GetComponent<Image>().color.g, _OxWordPlank.GetComponent<Image>().color.b,0);
        _OxWordPlank.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void ModifyWordRugged()
    {
        if (UIManager.GetInstance().MoatUIStain.Count > 0 || UIManager.GetInstance().TowExtinctPeakShrub().Count > 0)
        {
            return;
        }
        //顶层窗体上移
        _OxToPlank.transform.SetAsFirstSibling();
        //禁用遮罩窗体
        if (_OxWordPlank.activeInHierarchy)
        {
            _OxWordPlank.SetActive(false);
            FanwiseEnergyHatch.GetInstance().Cany(CShield.Be_RuggedFolly);
        }
        //恢复当前ui摄像机的层深
        if (_UIUproot != null)
        {
            _UIUproot.depth = _DramaticUIUprootRealm;
        }
    }
}
