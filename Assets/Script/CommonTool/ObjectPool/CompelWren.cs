/*
 *   管理对象的池子
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompelWren 
{
    private Queue<GameObject> m_WrenModus;
    //池子名称
    private string m_WrenTale;
    //父物体
    protected Transform m_Legacy;
    //缓存对象的预制体
    private GameObject Design;
    //最大容量
    private int m_WitCreep;
    //默认最大容量
    protected const int m_SharplyWitCreep= 20;
    public GameObject Outcry    {
        get => Design;set { Design = value;  }
    }
    //构造函数初始化
    public CompelWren()
    {
        m_WitCreep = m_SharplyWitCreep;
        m_WrenModus = new Queue<GameObject>();
    }
    //初始化
    public virtual void Jade(string poolName,Transform transform)
    {
        m_WrenTale = poolName;
        m_Legacy = transform;
    }
    //取对象
    public virtual GameObject Rim()
    {
        GameObject Era;
        if (m_WrenModus.Count > 0)
        {
            Era = m_WrenModus.Dequeue();
        }
        else
        {
            Era = GameObject.Instantiate<GameObject>(Design);
            Era.transform.SetParent(m_Legacy);
            Era.SetActive(false);
        }
        Era.SetActive(true);
        return Era;
    }
    //回收对象
    public virtual void Yucatan(GameObject obj)
    {
        if (m_WrenModus.Contains(obj)) return;
        if (m_WrenModus.Count >= m_WitCreep)
        {
            GameObject.Destroy(obj);
        }
        else
        {
            m_WrenModus.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    /// <summary>
    /// 回收所有激活的对象
    /// </summary>
    public virtual void YucatanLop()
    {
        Transform[] child = m_Legacy.GetComponentsInChildren<Transform>();
        foreach (Transform item in child)
        {
            if (item == m_Legacy)
            {
                continue;
            }
            
            if (item.gameObject.activeSelf)
            {
                Yucatan(item.gameObject);
            }
        }
    }
    //销毁
    public virtual void Martian()
    {
        m_WrenModus.Clear();
    }
}
