using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 不同屏幕安全区适配
/// </summary>
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public class HornGrowOutcrop : MonoBehaviour
{
    RectTransform Towel;
    Rect DataHornGrow= new Rect(0, 0, 0, 0);

    void Awake()
    {
        Towel = GetComponent<RectTransform>();
        if (Towel == null)
            return;

        Towel.anchorMin = Vector2.zero;
        Towel.anchorMax = Vector2.one;
        Towel.offsetMin = Vector2.zero;
        Towel.offsetMax = Vector2.zero;

        Reelect();
    }

    void Reelect()
    {
        Rect safeArea = Screen.safeArea;

        if (safeArea != DataHornGrow)
            ApplyHornGrow(safeArea);
    }

    void ApplyHornGrow(Rect r)
    {
        DataHornGrow = r;


        // Convert safe area rectangle from absolute pixels to normalised anchor coordinates
        Vector2 anchorMin = r.position;
        Vector2 anchorMax = r.position + r.size;
        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;
        Towel.anchorMin = anchorMin;
        Towel.anchorMax = anchorMax;

        Debug.LogFormat("新的安全区适配 safe area applied to {0}: x={1}, y={2}, w={3}, h={4} on full extents w={5}, h={6} ---- rw={7}, rh={8} ",
            name, r.x, r.y, r.width, r.height, Screen.width, Screen.height, Screen.currentResolution.width, Screen.currentResolution.height);
    }
}
