﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 消息管理器
/// </summary>
public class BlanketUnloadLogic:DeedSingleton<BlanketUnloadLogic>
{
    //保存所有消息事件的字典
    //key使用字符串保存消息的名称
    //value使用一个带自定义参数的事件，用来调用所有注册的消息
    private Dictionary<string, Action<BlanketVole>> PerceptualBlanket;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    private BlanketUnloadLogic()
    {
        JadeVole();
    }

    private void JadeVole()
    {
        //初始化消息字典
        PerceptualBlanket = new Dictionary<string, Action<BlanketVole>>();
    }

    /// <summary>

    /// 注册消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Hatchery(string key, Action<BlanketVole> action)
    {
        if (!PerceptualBlanket.ContainsKey(key))
        {
            PerceptualBlanket.Add(key, null);
        }
        PerceptualBlanket[key] += action;
    }



    /// <summary>
    /// 注销消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Hamper(string key, Action<BlanketVole> action)
    {
        if (PerceptualBlanket.ContainsKey(key) && PerceptualBlanket[key] != null)
        {
            PerceptualBlanket[key] -= action;
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="data">消息传递数据，可以不传</param>
    public void Moat(string key, BlanketVole data = null)
    {
        if (PerceptualBlanket.ContainsKey(key) && PerceptualBlanket[key] != null)
        {
            PerceptualBlanket[key](data);
        }
    }

    /// <summary>
    /// 清空所有消息
    /// </summary>
    public void Guard()
    {
        PerceptualBlanket.Clear();
    }
}
