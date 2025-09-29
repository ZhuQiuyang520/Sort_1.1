using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadAtTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    public Button[] Setup;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    public Sprite Neon1Cobalt;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    public Sprite Neon2Cobalt;
[UnityEngine.Serialization.FormerlySerializedAs("Close")]    public Button Board;

    // Start is called before the first frame update
    void Start()
    {
        Board.onClick.AddListener(FacialBoard);
        foreach (Button star in Setup)
        {
            star.onClick.AddListener(() =>
            {
                BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
                BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int index = indexStr == "" ? 0 : int.Parse(indexStr);
                MessyCross(index);
            });
        }
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        for (int i = 0; i < 5; i++)
        {
            Setup[i].gameObject.GetComponent<Image>().sprite = Neon2Cobalt;
        }
    }


    private void MessyCross(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Setup[i].gameObject.GetComponent<Image>().sprite = i <= index ? Neon1Cobalt : Neon2Cobalt;
        }
        MillXenonSister.RimIndicate().MoatXenon("1301", (index + 1).ToString());
        if (index < 3)
        {
            StartCoroutine(SwingTowel());
        } else
        {
            // 跳转到应用商店
            LoadAtBenefit.instance.FactAPCodAbsent();
            StartCoroutine(SwingTowel());
        }
        
        // 打点
        //MillXenonSister.GetInstance().SendEvent("1210", (index + 1).ToString());
    }

    IEnumerator SwingTowel(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
        BoardUIFend(GetType().Name);
    }

    public void FacialBoard()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoardUIFend(GetType().Name);
    }
}
