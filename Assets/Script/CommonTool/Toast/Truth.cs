using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Truth : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    public Text TruthCart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);

        TruthCart.text = uiFormParams.ToString();
        StartCoroutine(nameof(HomeBoardTruth));
    }

    private IEnumerator HomeBoardTruth()
    {
        yield return new WaitForSeconds(2);
        BoardUIFend(GetType().Name);
    }

}
