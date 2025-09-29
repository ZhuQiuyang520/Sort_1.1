using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ShowUI : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ClockText")]    public Text VirusCart;
[UnityEngine.Serialization.FormerlySerializedAs("Pointer")]    public RectTransform Outwork;

    private long Continuum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void JadeFlyShow(long endTime)
    {
        Continuum = endTime - CureRend.Defense();

        StopCoroutine(nameof(ReelectVirus));
        StartCoroutine(nameof(ReelectVirus));
    }

    private IEnumerator ReelectVirus()
    {
        float angle = 0;
        while(Continuum > 0)
        {
            VirusCart.text = CureRend.TurbineEngulf(Continuum);
            Outwork.DORotate(new Vector3(0, 0, angle), 0.5f);
            angle = angle - 90 == -360 ? 0 : angle - 90;
            Continuum--;
            yield return new WaitForSeconds(1);
        }
        if (Continuum <= 0)
        {
            VirusCart.text = "Finished";
            Outwork.rotation = Quaternion.identity;
        }
    }
}
