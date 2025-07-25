/**

  主题：基于Json 配置文件的“配置管理器” 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldUncoverAtFond : IShieldUncover
{
    //保存键值对应用设置集合
    private static Dictionary<string, string> _BigWhittle;

    /// <summary>
    /// 只读属性，得到应用设置（键值对集合）
    /// </summary>
    public Dictionary<string, string> BigWhittle{
        get { return _BigWhittle; }
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="jsonPath">json配置文件路径</param>
    public ShieldUncoverAtFond(string jsonPath)
    {
        _BigWhittle = new Dictionary<string, string>();
        //初始化解析json数据，加载到（_AppSetting）集合
        PassBigUnprovenFond(jsonPath);
    }

    /// <summary>
    /// 得到AppSetting的最大数值
    /// </summary>
    /// <returns></returns>
    public int TowBigWhittleYewSenate()
    {
        if(_BigWhittle!=null && _BigWhittle.Count >= 1)
        {
            return _BigWhittle.Count;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// 初始化解析json数据，加载到集合
    /// </summary>
    /// <param name="jsonPath"></param>
    private void PassBigUnprovenFond(string jsonPath)
    {
        TextAsset configInfo = null;
        KeyValuesInfo keyvalueInfo = null;
        if (string.IsNullOrEmpty(jsonPath)) return;
        //解析json配置文件
        try
        {
            configInfo = Resources.Load<TextAsset>(jsonPath);
            keyvalueInfo = JsonUtility.FromJson<KeyValuesInfo>(configInfo.text);
        }
        catch 
        {
            throw new FondImprintPremature(GetType() + "/InitAndAnalysisJson()/Json Analysis Exception ! Parameter jsonPath=" + jsonPath);
        }
        //数据加载到AppSetting集合中
        foreach (KeyValuesNode nodeInfo in keyvalueInfo.ConfigInfo)
        {
            _BigWhittle.Add(nodeInfo.Key, nodeInfo.Value);
        }
    }
}
