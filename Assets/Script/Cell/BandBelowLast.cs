using Lofelt.NiceVibrations;
using sf_database;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static RealmCare;

public class BandBelowLast : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ShopTog")]    public Toggle BandHit;
[UnityEngine.Serialization.FormerlySerializedAs("BuyButton")]
    public Button LipCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("BGImage")]
    public Image BGTwice;
[UnityEngine.Serialization.FormerlySerializedAs("NullImage")]
    public Image AideTwice;
[UnityEngine.Serialization.FormerlySerializedAs("SkinPrice")]
    public Text TossDaunt;
[UnityEngine.Serialization.FormerlySerializedAs("LevelText")]
    public Text ValidCart;
[UnityEngine.Serialization.FormerlySerializedAs("SelectStatus")]
    public GameObject PotionAbrupt;
[UnityEngine.Serialization.FormerlySerializedAs("BuyStatus")]    public GameObject LipAbrupt;
[UnityEngine.Serialization.FormerlySerializedAs("NullStatus")]    public GameObject AideAbrupt;
[UnityEngine.Serialization.FormerlySerializedAs("LevelStatus")]    public GameObject ValidAbrupt;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_Shoplock")]
    public GameObject Up_Handbook;

    //�Ѿ�ӵ�е�ȫ��Ƥ��
    private List<int> ALLToss= new List<int>();
    private Action<ShopConfig> LipFiring;
    private int SadRimToss;

    private ShopConfig BandVole;

    private string BelowTwiceCure= "Art/Tex/Sprite/UI/BandTowel/Color/";
    private string TubeTwiceCure= "Art/Tex/Sprite/UI/BandTowel/Tube/";
    private string TwiceCure;
    private Action<ShopConfig, Vector3> BandOfferFiring;

    private bool NoPaper= false;

    private void OnEnable()
    {
        if (BandVole != null)
        {
            ValidCart.text = "Level " + BandVole.unclock_lv;
        }
    }

    public void Jade(ToggleGroup group , ShopConfig data , Action<ShopConfig> AC , Action<ShopConfig, Vector3> AcGuide)
    {
        BandOfferFiring = AcGuide;
        BandHit.group = group;
        BandHit.onValueChanged.AddListener(FacialHit);
        if (data.type == 2)
        {
            Invoke(nameof(NephewBandOffer), 0.1f);
            TwiceCure = BelowTwiceCure;
        }
        else if (data.type == 1)
        {
            TwiceCure = TubeTwiceCure;
        }
#if UNITY_EDITOR
        BGTwice.sprite = Resources.Load(TwiceCure + data.pic, typeof(Sprite)) as Sprite;
#else
        BGImage.sprite = Resources.Load(ImagePath + data.pic, typeof(Sprite)) as Sprite;
#endif
        BandVole = data;
        LipFiring = AC;

        if (data.id == 0)
        {
            AideTwice.sprite = Resources.Load(TwiceCure + data.pic, typeof(Sprite)) as Sprite;
            BGTwice.gameObject.SetActive(false);

            AideAbrupt.SetActive(true);
        }
        else
        {
            BGTwice.gameObject.SetActive(true);
            if (data.type == 2)
            {
                SadRimToss = PlayerPrefs.GetInt(VoleBenefit.TownSadToss);
                ALLToss = VoleBenefit.RimHard(VoleBenefit.TownLopBelowToss);
            }
            else if (data.type == 1)
            {
                SadRimToss = PlayerPrefs.GetInt(VoleBenefit.TownDarnToss);
                ALLToss = VoleBenefit.RimHard(VoleBenefit.TownLopDarnToss);
            }
            //��ǰӵ�е�����Ƥ��
            //�жϵ�ǰƤ���ǲ�������ʹ�õ�
            if (ALLToss.Contains(data.id))
            {
                PotionAbrupt.SetActive(true);
                if (data.id == SadRimToss)
                {
                    FacialHit(true);
                }
            }
            else
            {
                if (data.unclock_lv > PlayerPrefs.GetInt(VoleBenefit.TownValid))
                {
                    ValidAbrupt.SetActive(true);
                    //string str = string.Format(I18NManager.Instance.GetText("Level_Limit{0}"),data.unclock_lv);
                    //LevelText.text = str;
                    ValidCart.text = "Level " + data.unclock_lv;
                }
                else
                {
                    LipAbrupt.SetActive(true);
                    NoPaper = true;
                    TossDaunt.text = data.price.ToString();
                }
            }
        }
        LipCorpse.onClick.AddListener(LipBelowBench);
    }

    public void LipBelowBench()
    {
        if (NoPaper)
        {
            BoneBenefit.RimIndicate().HabitatOrgan(UIMusic.click);
            int CurPlayerCoin = PlayerPrefs.GetInt(CRamble.Dy_GoldGene);
            if (CurPlayerCoin >= BandVole.price)
            {
                NoPaper = false;
                MillXenonSister.RimIndicate().MoatXenon("1006");
                BaseUseCoin useCoin = new BaseUseCoin();
                useCoin.Bongo_id = PlayerPrefs.GetInt(VoleBenefit.TownValid);
                useCoin.Plank = BandVole.price;
                BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.Selection);
                GroundingBench.ToErieBandBus(Up_Handbook, gameObject, () =>
                {
                    if (BandVole.type == 1)
                    {
                        useCoin.Index = "tube";
                        PlayerPrefs.SetInt(VoleBenefit.TownDarnToss, BandVole.id);
                    }
                    else if (BandVole.type == 2)
                    {
                        useCoin.Index = "color";
                        PlayerPrefs.SetInt(VoleBenefit.TownSadToss, BandVole.id);
                    }
                    LipFiring(BandVole);
                    LipAbrupt.SetActive(false);
                    PotionAbrupt.SetActive(true);
                    FacialHit(true);
                });

            }
            else
            {
                //UIBenefit.GetInstance().ShowUIForms(nameof(DeemBandSully));
            }
        }
    }

    public void FacialHit(bool open)
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        if (open)
        {
            BandHit.isOn = true;
            if (BandVole.type == 2)
            {
                PlayerPrefs.SetInt(VoleBenefit.TownSadToss,BandVole.id);
                BoneBenefit.RimIndicate().PikeSadToss();
            }
            else if (BandVole.type == 1)
            {
                PlayerPrefs.SetInt(VoleBenefit.TownDarnToss, BandVole.id);
            }
        }
    }

    private void NephewBandOffer()
    {
        BandOfferFiring(BandVole, LipCorpse.transform.position);
    }
}
