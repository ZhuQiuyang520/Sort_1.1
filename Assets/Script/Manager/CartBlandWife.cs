using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartBlandWife : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("targetText")]    //目标文本组件
    public Text OrnateCart;

    // Start is called before the first frame update
    private void Start()
    {
        //创建下划线
        LedgeBlandWife();
    }

    //方法，创建下划线
    private void LedgeBlandWife()
    {
        //空引用直接返回
        if (OrnateCart == null) return;

        //复制目标文本的属性
        Text underlineText = Instantiate(OrnateCart) as Text;

        //设置下划线的父物体
        underlineText.transform.SetParent(OrnateCart.transform);

        //获取RectTransform组件
        RectTransform underlineRT = underlineText.rectTransform;

        //设置下划线的位置
        underlineRT.anchoredPosition3D = Vector3.zero;
        underlineRT.anchorMax = Vector2.one;
        underlineRT.anchorMin = Vector2.zero;
        underlineRT.offsetMax = Vector2.zero;
        underlineRT.offsetMin = Vector2.zero;

        //设置下划线的缩放
        underlineRT.transform.localScale = Vector3.one;

        //设置下划线文本的初始值
        underlineText.text = "_";

        //单个下划线宽度
        float singleUnderlineWidth = underlineText.preferredWidth;

        //文本总宽度
        float targetTextWidth = OrnateCart.preferredWidth;

        //计算需要多少个“_”字符
        int underlineCount = Mathf.RoundToInt(targetTextWidth / singleUnderlineWidth);

        //添加“_”字符
        for (int i = 0; i < underlineCount; i++)
        {
            underlineText.text += "_";
        }
    }
}

