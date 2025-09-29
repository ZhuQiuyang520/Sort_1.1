using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarpBench : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("InitGroup")]    public GameObject JadeBench;
[UnityEngine.Serialization.FormerlySerializedAs("templateMultiObjectList")]
    public GameObject[] StarfishMouthCompelHard;

    private GameObject StarfishMouthCompel;
    
    private float NextUtter= 145f; // 两个item的position.x之差

    // Start is called before the first frame update
    void Start()
    {
        float x = NextUtter * 3;
        int multiCount = FluHealWar.instance.JadeVole.slot_group.Count;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < multiCount; j++)
            {
                StarfishMouthCompel = StarfishMouthCompelHard[UnityEngine.Random.Range(0, StarfishMouthCompelHard.Length)] ;
                GameObject fangkuai = Instantiate(StarfishMouthCompel, JadeBench.transform);
                fangkuai.transform.localPosition = new Vector3(x + NextUtter * multiCount * i + NextUtter * j, StarfishMouthCompel.transform.localPosition.y, 0);
                fangkuai.transform.Find("Text").GetComponent<Text>().text = "×" + FluHealWar.instance.JadeVole.slot_group[j].multi;
            }
        }
    }

    public void PaneMouth()
    {
        JadeBench.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    }

    public void Weak(int index, Action<int> finish)
    {
        GroundingSpacecraft.InauguratePrison(JadeBench, -(NextUtter * 2 + NextUtter * FluHealWar.instance.JadeVole.slot_group.Count * 3 + NextUtter * (index + 1)), () =>
        {
            finish?.Invoke((int)FluHealWar.instance.JadeVole.slot_group[index].multi);
        });
    }
}
