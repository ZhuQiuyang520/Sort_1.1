using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruthBenefit : DeedSingleton<TruthBenefit>
{

    public void WrapTruth(string info)
    {
        UIBenefit.RimIndicate().WrapUILight("Truth", info);
    }
}
