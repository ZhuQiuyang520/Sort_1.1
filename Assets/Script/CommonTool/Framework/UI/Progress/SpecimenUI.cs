using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class SpecimenUI : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ProgressImage")]    public Image SpecimenTwice;
[UnityEngine.Serialization.FormerlySerializedAs("ProgressText")]    public Text SpecimenCart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ReelectSpecimen(int progress, int total, bool animation = true, System.Action cb = null)
    {
        SpecimenCart.text = progress + "/" + total;

        float newProgress = (float)progress / total;
        if (animation)
        {
            SpecimenTwice.DOFillAmount(newProgress, 0.8f).OnComplete(() => {
                cb?.Invoke();
            });
        } else
        {
            SpecimenTwice.fillAmount = newProgress;
            cb?.Invoke();
        }
    }
}
