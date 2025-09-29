/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class XenonInitialShoshone : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate onPaper;
    public VoidDelegate ByLeap;
    public VoidDelegate ByAvail;
    public VoidDelegate ByFist;
    public VoidDelegate ByUp;
    public VoidDelegate ByPotion;
    public VoidDelegate ByCanadaPotion;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static XenonInitialShoshone Rim(GameObject go)
    {
        XenonInitialShoshone listener = go.GetComponent<XenonInitialShoshone>();
        if (listener == null)
        {
            listener = go.AddComponent<XenonInitialShoshone>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (onPaper != null)
        {
            onPaper(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (ByLeap != null)
        {
            ByLeap(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (ByAvail != null)
        {
            ByAvail(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (ByFist != null)
        {
            ByFist(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (ByUp != null)
        {
            ByUp(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (ByPotion != null)
        {
            ByPotion(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (ByCanadaPotion != null)
        {
            ByCanadaPotion(gameObject);
        }
    }
}
