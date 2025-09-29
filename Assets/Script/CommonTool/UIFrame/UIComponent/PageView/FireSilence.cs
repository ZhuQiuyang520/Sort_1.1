using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireSilence : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public RectTransform Love;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    public ZoneFuse Aggressive;
    private void Awake()
    {
        Aggressive.OnZoneFacial = Laboratory;
    }

    void Laboratory(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Love.GetComponent<RectTransform>().position = pos;
    }
}
