/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MandibleTip 
{
    public static MandibleTip _Sensitive;
    //语言翻译的缓存集合
    private Dictionary<string, string> _LopMandibleTonal;

    private MandibleTip()
    {
        _LopMandibleTonal = new Dictionary<string, string>();
        //初始化语言缓存集合
        PassMandibleTonal();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static MandibleTip GetInstance()
    {
        if (_Sensitive == null)
        {
            _Sensitive = new MandibleTip();
        }
        return _Sensitive;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string PearPort(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_LopMandibleTonal!=null && _LopMandibleTonal.Count >= 1)
        {
            _LopMandibleTonal.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void PassMandibleTonal()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        IShieldUncover config = new ShieldUncoverAtFond("LauguageJSONConfig");
        if (config != null)
        {
            _LopMandibleTonal = config.BigWhittle;
        }
    }
}
