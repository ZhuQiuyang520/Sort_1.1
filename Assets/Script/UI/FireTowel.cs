using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FireTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("Mask")]    public GameObject Fire;

    public static FireTowel instance;

    public void InflexiblyLeafy(System.Action finish = null)
    {
        Fire.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        Fire.GetComponent<Image>().DOFade(1, 0.5f).OnComplete(() =>
        {
            finish();
            Fire.GetComponent<Image>().DOFade(0, 0.5f).SetDelay(0.4f).OnComplete(() =>
            {
                BoardUIFend(GetType().Name);
            });
        });
    }
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
