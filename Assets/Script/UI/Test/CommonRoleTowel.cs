using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommonRoleTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button BoardCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustAdidText")]    public Text CommonFlatCart;
[UnityEngine.Serialization.FormerlySerializedAs("ServerIdText")]    public Text WanderNoCart;
[UnityEngine.Serialization.FormerlySerializedAs("ActCounterText")]    public Text LeoBookletCart;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustTypeText")]    public Text CommonCareCart;
[UnityEngine.Serialization.FormerlySerializedAs("ResetActCountButton")]    public Button WasteLeoCreepCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("AddActCountButton")]    public Button KeyLeoCreepCorpse;

    // Start is called before the first frame update
    void Start()
    {
        BoardCorpse.onClick.AddListener(() => {
            BoardUIFend(GetType().Name);
        });

        WasteLeoCreepCorpse.onClick.AddListener(() => {
            CommonJadeBenefit.Instance.WasteLeoCreep();
        });

        KeyLeoCreepCorpse.onClick.AddListener(() => {
            CommonJadeBenefit.Instance.KeyLeoCreep("test");
        });
    }

    private void WrapBookletCart()
    {
        CommonFlatCart.text = CommonJadeBenefit.Instance.RimCommonFlat();
        WanderNoCart.text = TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyWanderNo);
        LeoBookletCart.text = CommonJadeBenefit.Instance._HexagonCreep.ToString();
        CommonCareCart.text = TownVoleBenefit.RimSyntax("sv_ADJustInitType");
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        InvokeRepeating(nameof(WrapBookletCart), 0, 0.5f);
    }

    public override void Hidding()
    {
        base.Hidding();
        CancelInvoke(nameof(WrapBookletCart));
    }
}
