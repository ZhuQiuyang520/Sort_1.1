using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 由于UI节点上直接使用LayoutGroup组件，会导致无法正确获取子元素的世界坐标
/// 所以自己写一个脚本，实现自动排列
/// </summary>
public class NeedUnfoldEurasian : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    public float Creator= 0;

    // Start is called before the first frame update
    void Start()
    {
        ReelectUnfold();
    }

    public void ReelectUnfold()
    {
        float y = 0;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeSelf)
            {
                RectTransform Inch= transform.GetChild(i).GetComponent<RectTransform>();
                Inch.anchorMin = new Vector2(0.5f, 1);
                Inch.anchorMax = new Vector2(0.5f, 1);
                Inch.anchoredPosition = new Vector2(Inch.position.x, y - Inch.sizeDelta.y / 2 - Creator * i);
                y -= Inch.sizeDelta.y;
            }
        }
    }
}
