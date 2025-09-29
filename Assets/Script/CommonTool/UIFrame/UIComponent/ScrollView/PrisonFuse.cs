/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrisonFuse : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
    public ScrollViewItem NextLast;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
    public ScrollRect InventRift;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
    //content
    public RectTransform Juniper;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
    public float Creator= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
    public float RomanUtter;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
    public float RomanUseful;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
    public int KnuckleCreep;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
    public bool ByNeck= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
    public int HonorFresh;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
    public int HaleFresh;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
    public float NextUseful= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
    //缓存的itemlist
    public List<ScrollViewItem> NextHard;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
    public List<ScrollViewItem> KnuckleHard;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
    public List<int> DNAHard;

    void Start()
    {
        RomanUseful = this.GetComponent<RectTransform>().sizeDelta.y;
        RomanUtter = this.GetComponent<RectTransform>().sizeDelta.x;
        Juniper = InventRift.content;
        JadeVole();

    }
    //初始化
    public void JadeVole()
    {
        KnuckleCreep = Mathf.CeilToInt(RomanUseful / WifeUseful) + 1;
        for (int i = 0; i < KnuckleCreep; i++)
        {
            this.KeyGood();
        }
        HonorFresh = 0;
        HaleFresh = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        YamVole(numberList);
    }
    //设置数据
    void YamVole(List<int> list)
    {
        DNAHard = list;
        HonorFresh = 0;
        if (VoleCreep <= KnuckleCreep)
        {
            HaleFresh = VoleCreep;
        }
        else
        {
            HaleFresh = KnuckleCreep - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = HonorFresh; i < HaleFresh; i++)
        {
            ScrollViewItem Era= HemGood();
            if (Era == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                Era.gameObject.name = i.ToString();

                Era.gameObject.SetActive(true);
                Era.transform.localPosition = new Vector3(0, -i * WifeUseful, 0);
                KnuckleHard.Add(Era);
                CanadaGood(i, Era);
            }

        }
        Juniper.sizeDelta = new Vector2(RomanUtter, VoleCreep * WifeUseful - Creator);
        ByNeck = true;
    }
    //更新item
    public void CanadaGood(int index, ScrollViewItem obj)
    {
        int d = DNAHard[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public ScrollViewItem HemGood()
    {
        ScrollViewItem Era= null;
        if (NextHard.Count > 0)
        {
            Era = NextHard[0];
            Era.gameObject.SetActive(true);
            NextHard.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return Era;
    }
    //item进入itemlist
    public void MessGood(ScrollViewItem obj)
    {
        NextHard.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int VoleCreep    {
        get
        {
            return DNAHard.Count;
        }
    }
    //每一行的高
    public float WifeUseful    {
        get
        {
            return NextUseful + Creator;
        }
    }
    //添加item到缓存列表中
    public void KeyGood()
    {
        GameObject Era= Instantiate(NextLast.gameObject);
        Era.transform.SetParent(Juniper);
        RectTransform Inch= Era.GetComponent<RectTransform>();
        Inch.anchorMin = new Vector2(0.5f, 1);
        Inch.anchorMax = new Vector2(0.5f, 1);
        Inch.pivot = new Vector2(0.5f, 1);
        Era.SetActive(false);
        Era.transform.localScale = Vector3.one;
        ScrollViewItem o = Era.GetComponent<ScrollViewItem>();
        NextHard.Add(o);
    }



    void Update()
    {
        if (ByNeck)
        {
            Prison();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Prison()
    {
        float vy = Juniper.anchoredPosition.y;
        float rollUpTop = (HonorFresh + 1) * WifeUseful;
        float rollUnderTop = HonorFresh * WifeUseful;

        if (vy > rollUpTop && HaleFresh < VoleCreep)
        {
            //上边界移除
            if (KnuckleHard.Count > 0)
            {
                ScrollViewItem Era= KnuckleHard[0];
                KnuckleHard.RemoveAt(0);
                MessGood(Era);
            }
            HonorFresh++;
        }
        float rollUpBottom = (HaleFresh - 1) * WifeUseful - Creator;
        if (vy < rollUpBottom - RomanUseful && HonorFresh > 0)
        {
            //下边界减少
            HaleFresh--;
            if (KnuckleHard.Count > 0)
            {
                ScrollViewItem Era= KnuckleHard[KnuckleHard.Count - 1];
                KnuckleHard.RemoveAt(KnuckleHard.Count - 1);
                MessGood(Era);
            }

        }
        float rollUnderBottom = HaleFresh * WifeUseful - Creator;
        if (vy > rollUnderBottom - RomanUseful && HaleFresh < VoleCreep)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            ScrollViewItem go = HemGood();
            KnuckleHard.Add(go);
            go.transform.localPosition = new Vector3(0, -HaleFresh * WifeUseful);
            CanadaGood(HaleFresh, go);
            HaleFresh++;
        }


        if (vy < rollUnderTop && HonorFresh > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            HonorFresh--;
            ScrollViewItem go = HemGood();
            KnuckleHard.Insert(0, go);
            CanadaGood(HonorFresh, go);
            go.transform.localPosition = new Vector3(0, -HonorFresh * WifeUseful);
        }

    }
}
