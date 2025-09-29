using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElegantTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("Yes")]    public Button Ago;
[UnityEngine.Serialization.FormerlySerializedAs("No")]    public Button Ax;

    private void Start()
    {
        Ago.onClick.AddListener(FacialCab);
        Ax.onClick.AddListener(FacialAx);
    }

    private void FacialCab()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        MillXenonSister.RimIndicate().MoatXenon("1012");
        ADBenefit.Indicate.AxFreelyKeyCreep();
        BoardUIFend(GetType().Name);
        BoneTowel.instance.FacialAppearCross();
    }

    private void FacialAx()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        BoardUIFend(GetType().Name);
    }
}
