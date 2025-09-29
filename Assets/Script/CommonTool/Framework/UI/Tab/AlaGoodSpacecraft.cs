using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Tab按钮样式脚本
/// </summary>

public class AlaGoodSpacecraft : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Icon")]    public Image Pull;
[UnityEngine.Serialization.FormerlySerializedAs("Title")]    public Text Sheep;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void YamWarmthUI(bool active, AlaSpacecraft controller, TabItem tabItem)
    {
        if (Sheep != null && controller.WarmthBelow != null)
        {
            Sheep.color = active ? controller.WarmthBelow : controller.SuitablyBelow;
        }
        if (gameObject.GetComponent<Image>() != null && controller.WarmthBG != null)
        {
            gameObject.GetComponent<Image>().sprite = active ? controller.WarmthBG : controller.SuitablyBG;
        }
        if (Pull != null && tabItem.WarmthPull != null)
        {
            Pull.sprite = active ? tabItem.WarmthPull : tabItem.SuitablyPull;
        }
    }
}
