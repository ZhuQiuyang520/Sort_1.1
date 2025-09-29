/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CompelWrenBenefit : DeedSingleton<CompelWrenBenefit>
{
    //管理objectpool的字典
    private Dictionary<string, CompelWren> m_WrenGap;
    private Transform m_EnvyIntensely=null;
    //构造函数
    public CompelWrenBenefit()
    {
        m_WrenGap = new Dictionary<string, CompelWren>();      
    }
    
    //创建一个新的对象池
    public T StitchCompelWren<T>(string poolName) where T : CompelWren, new()
    {
        if (m_WrenGap.ContainsKey(poolName))
        {
            return m_WrenGap[poolName] as T;
        }
        if (m_EnvyIntensely == null)
        {
            m_EnvyIntensely = this.transform;
        }      
        GameObject Era= new GameObject(poolName);
        Era.transform.SetParent(m_EnvyIntensely);
        T pool = new T();
        pool.Jade(poolName, Era.transform);
        m_WrenGap.Add(poolName, pool);
        return pool;
    }
    //取对象
    public GameObject RimBoneCompel(string poolName)
    {
        if (m_WrenGap.ContainsKey(poolName))
        {
            return m_WrenGap[poolName].Rim();
        }
        return null;
    }
    //回收对象
    public void YucatanBoneCompel(string poolName,GameObject go)
    {
        if (m_WrenGap.ContainsKey(poolName))
        {
            m_WrenGap[poolName].Yucatan(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_WrenGap.Clear();
        GameObject.Destroy(m_EnvyIntensely);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool ForteWren(string poolName)
    {
        return m_WrenGap.ContainsKey(poolName) ? true : false;
    }
}
