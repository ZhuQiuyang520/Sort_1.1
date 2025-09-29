using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeBenefitRoleTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("LastPlayTimeCounterText")]    public Text DataBodeShowBookletCart;
[UnityEngine.Serialization.FormerlySerializedAs("Counter101Text")]    public Text Booklet101Cart;
[UnityEngine.Serialization.FormerlySerializedAs("Counter102Text")]    public Text Booklet102Cart;
[UnityEngine.Serialization.FormerlySerializedAs("Counter103Text")]    public Text Booklet103Cart;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumText")]    public Text TaintTieCart;
[UnityEngine.Serialization.FormerlySerializedAs("PlayRewardedAdButton")]    public Button BodeSaturateMeCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("PlayInterstitialAdButton")]    public Button BodeImprisonmentMeCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("NoThanksButton")]    public Button AxFreelyCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumButton")]    public Button TaintTieCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button BoardCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("TimeInterstitialText")]    public Text ShowImprisonmentCart;
[UnityEngine.Serialization.FormerlySerializedAs("PauseTimeInterstitialButton")]    public Button PanelShowImprisonmentCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("ResumeTimeInterstitialButton")]    public Button NarrowShowImprisonmentCorpse;

    private void Start()
    {
        InvokeRepeating(nameof(WrapBookletCart), 0, 0.5f);

        BoardCorpse.onClick.AddListener(() => {
            BoardUIFend(GetType().Name);
        });

        BodeSaturateMeCorpse.onClick.AddListener(() => {
            ADBenefit.Indicate.PineModuleProwl((success) => { }, "10");
        });

        BodeImprisonmentMeCorpse.onClick.AddListener(() => {
            ADBenefit.Indicate.PineImprisonmentMe(1);
        });

        AxFreelyCorpse.onClick.AddListener(() => {
            ADBenefit.Indicate.AxFreelyKeyCreep();
        });

        TaintTieCorpse.onClick.AddListener(() => {
            ADBenefit.Indicate.CanadaTaintTie(TownVoleBenefit.RimDot(CRamble.Dy_Of_Crane_Mob) + 1);
            TaintTieCart.text = TownVoleBenefit.RimDot(CRamble.Dy_Of_Crane_Mob).ToString();
        });

        PanelShowImprisonmentCorpse.onClick.AddListener(() => {
            ADBenefit.Indicate.PanelShowImprisonment();
            WrapPanelShowImprisonment();
        });

        NarrowShowImprisonmentCorpse.onClick.AddListener(() => {
            ADBenefit.Indicate.NarrowShowImprisonment();
            WrapPanelShowImprisonment();
        });

    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        TaintTieCart.text = TownVoleBenefit.RimDot(CRamble.Dy_Of_Crane_Mob).ToString();
        WrapPanelShowImprisonment();
    }

    private void WrapBookletCart()
    {
        DataBodeShowBookletCart.text = ADBenefit.Indicate.HaleBodeShowBooklet.ToString();
        Booklet101Cart.text = ADBenefit.Indicate.Fanwise101.ToString();
        Booklet102Cart.text = ADBenefit.Indicate.Fanwise102.ToString();
        Booklet103Cart.text = ADBenefit.Indicate.Fanwise103.ToString();
    }

    private void WrapPanelShowImprisonment()
    {
        ShowImprisonmentCart.text = ADBenefit.Indicate.SweetShowImprisonment ? "已暂停" : "未暂停";
    }
}
