﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 消息管理器
/// </summary>
public class FanwiseEnergyHatch:MailPerformer<FanwiseEnergyHatch>
{
    //保存所有消息事件的字典
    //key使用字符串保存消息的名称
    //value使用一个带自定义参数的事件，用来调用所有注册的消息
    private Dictionary<string, Action<FanwiseBulk>> AssessmentFanwise;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    private FanwiseEnergyHatch()
    {
        PassBulk();
    }

    private void PassBulk()
    {
        //初始化消息字典
        AssessmentFanwise = new Dictionary<string, Action<FanwiseBulk>>();
    }

    /// <summary>

    /// 注册消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Engineer(string key, Action<FanwiseBulk> action)
    {
        if (!AssessmentFanwise.ContainsKey(key))
        {
            AssessmentFanwise.Add(key, null);
        }
        AssessmentFanwise[key] += action;
    }



    /// <summary>
    /// 注销消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Belong(string key, Action<FanwiseBulk> action)
    {
        if (AssessmentFanwise.ContainsKey(key) && AssessmentFanwise[key] != null)
        {
            AssessmentFanwise[key] -= action;
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="data">消息传递数据，可以不传</param>
    public void Cany(string key, FanwiseBulk data = null)
    {
        if (AssessmentFanwise.ContainsKey(key) && AssessmentFanwise[key] != null)
        {
            AssessmentFanwise[key](data);
        }
    }

    /// <summary>
    /// 清空所有消息
    /// </summary>
    public void South()
    {
        AssessmentFanwise.Clear();
    }
}
