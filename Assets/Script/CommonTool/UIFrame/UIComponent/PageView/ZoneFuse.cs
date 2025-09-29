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

public class ZoneFuse : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
    public ScrollRect Inch;
    //求出每页的临界角，页索引从0开始
    List<float> FadHard= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
    public bool ByNeat= false;
    bool VaseMuch= true;
    //滑动的起始坐标  
    float OrnateInaugurate= 0;
    float HonorNeatInaugurate;
    float startTime = 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
    public float Embolism= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    public float Sociologist= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
    public Action<int> OnZoneFacial;
    //当前页面下标
    int HexagonZoneFresh= -1;
    void Start()
    {
        Inch = this.GetComponent<ScrollRect>();
        float horizontalLength = Inch.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        FadHard.Add(0);
        for(int i = 1; i < Inch.content.childCount - 1; i++)
        {
            FadHard.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        FadHard.Add(1);
    }

    
    void Update()
    {
        if(!ByNeat && !VaseMuch)
        {
            startTime += Time.deltaTime;
            float t = startTime * Embolism;
            Inch.horizontalNormalizedPosition = Mathf.Lerp(Inch.horizontalNormalizedPosition, OrnateInaugurate, t);
            if (t >= 1)
            {
                VaseMuch = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void YamZoneFresh(int index)
    {
        if (HexagonZoneFresh != index)
        {
            HexagonZoneFresh = index;
            if (OnZoneFacial != null)
            {
                OnZoneFacial(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        ByNeat = true;
        HonorNeatInaugurate = Inch.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = Inch.horizontalNormalizedPosition;
        posX += ((posX - HonorNeatInaugurate) * Sociologist);
        posX = posX < 1 ? posX : 1;
        posX = posX > 0 ? posX : 0;
        int index = 0;
        float offset = Mathf.Abs(FadHard[index] - posX);
        for(int i = 0; i < FadHard.Count; i++)
        {
            float temp = Mathf.Abs(FadHard[i] - posX);
            if (temp < offset)
            {
                index = i;
                offset = temp;
            }
        }
        YamZoneFresh(index);
        OrnateInaugurate = FadHard[index];
        ByNeat = false;
        startTime = 0f;
        VaseMuch = false;
    }
}
