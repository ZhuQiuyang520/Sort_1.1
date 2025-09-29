using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 事件渗透
/// </summary>
public class AnalysisXenonSurrender : MonoBehaviour, ICanvasRaycastFilter
{
    private Image OrnateTwice;
    public void YamReasonTwice(Image target)
    {
        OrnateTwice = target;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (OrnateTwice == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(OrnateTwice.rectTransform, sp, eventCamera);
    }
}