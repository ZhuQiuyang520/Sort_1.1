using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using sf_database;
using DG.Tweening;

/// <summary>
/// ShopPanelView - 自动生成的UI视图脚本
/// </summary>
public class BandTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("CoinNumber")]    
#region 
    //UI组件
    public Text GeneStress;
[UnityEngine.Serialization.FormerlySerializedAs("ShopObj")]    public GameObject BandHim;
[UnityEngine.Serialization.FormerlySerializedAs("ColorGroup")]    public ToggleGroup BelowBench;
[UnityEngine.Serialization.FormerlySerializedAs("ColorScroll")]    public GameObject BelowPrison;
[UnityEngine.Serialization.FormerlySerializedAs("ColorContent")]    public Transform BelowMigrant;
[UnityEngine.Serialization.FormerlySerializedAs("TubeGroup")]    public ToggleGroup ClueBench;
[UnityEngine.Serialization.FormerlySerializedAs("TubeScroll")]    public GameObject CluePrison;
[UnityEngine.Serialization.FormerlySerializedAs("TubeContent")]    public Transform ClueMigrant;
[UnityEngine.Serialization.FormerlySerializedAs("ColorTog")]    public Toggle BelowHit;
[UnityEngine.Serialization.FormerlySerializedAs("TubeTog")]    public Toggle ClueHit;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button BoardOff;
[UnityEngine.Serialization.FormerlySerializedAs("Hand")]    public GameObject Duck;
    private bool NoBandOffer= false;
    private List<ShopConfig> BandHard= new List<ShopConfig>();
    private int SadGeneStress;
    #endregion

    #region 生命周期函数

    protected override void Awake()
    {
        BandHard = FluHealWar.instance.BoneVole.shop;
    }

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        MillXenonSister.RimIndicate().MoatXenon("1005");
        SadGeneStress = PlayerPrefs.GetInt(CRamble.Dy_GoldGene);
        GeneStress.text = SadGeneStress.ToString();
        if (PlayerPrefs.GetInt(VoleBenefit.TownValid) >= FluHealWar.instance.BoneVole.initgamedata.unclock_shop_lv && PlayerPrefs.GetInt(VoleBenefit.TownToErieBand) == 0)
        {
            NoBandOffer = true;
            PlayerPrefs.SetInt(VoleBenefit.TownToErieBand, 1);
        }
        FacialBelow(true);
    }

    private void Start()
    {
        BelowHit.onValueChanged.AddListener(FacialBelow);
        ClueHit.onValueChanged.AddListener(FacialClue);
        BoardOff.onClick.AddListener(Board);
        BoneBenefit.RimIndicate().StifleTranslation(BelowMigrant.GetComponent<RectTransform>());
        BoneBenefit.RimIndicate().StifleTranslation(ClueMigrant.GetComponent<RectTransform>());
        BoneBenefit.RimIndicate().StifleTranslation(Duck.GetComponent<RectTransform>());
        
    }

    #endregion

    public void FacialBelow(bool open)
    {
        BelowPrison.gameObject.SetActive(open);
        if (open)
        {
            BelowHit.isOn = true;
            if (BelowMigrant.childCount == 0)
            {
                foreach (var item in BandHard)
                {
                    if (item.type == 2)
                    {
                        BandLast(BelowMigrant).Jade(BelowBench, item , FacialLipTossGene , BandOffer);
                    }
                }
            }
        }
    }

    public void BandOffer(ShopConfig shop , Vector3 Pos)
    {
        if (NoBandOffer)
        {
            if (shop.price <= SadGeneStress && shop.unclock_lv != 0 && shop.unclock_lv <= PlayerPrefs.GetInt(VoleBenefit.TownValid))
            {
                Duck.transform.position = Pos;
                Duck.SetActive(true);
                GroundingBench.DuckBus(Duck, Pos, true);
            }
        }
    }
    public void FacialClue(bool open)
    {
        CluePrison.gameObject.SetActive(open);
        if (open)
        {
            if (NoBandOffer)
            {
                NoBandOffer = false;
                Duck.SetActive(false);
                DOTween.Kill("handanimation");
            }

            ClueHit.isOn = true;
            if (ClueMigrant.childCount == 0)
            {
                foreach (var item in BandHard)
                {
                    if (item.type == 1 || item.type == 3)
                    {
                        BandLast(ClueMigrant).Jade(ClueBench, item, FacialLipTossGene, BandOffer);
                    }
                }
            }
        }
        
    }

    public void Board()
    {
        //UIBenefit.GetInstance().CloseUI();
        BoardUIFend(GetType().Name);
        BlanketBenefit.RimIndicate().Dimension(MessageCode.ReelectClauseBelow);
    }

    public void FacialLipTossGene(ShopConfig Data)
    {
        if (NoBandOffer)
        {
            NoBandOffer = false;
            DOTween.Kill("handanimation");
            Duck.SetActive(false);
        }
        
        SadGeneStress -= Data.price;
        PlayerPrefs.SetInt(CRamble.Dy_GoldGene, SadGeneStress);
        GeneStress.text = SadGeneStress.ToString();

        //购买之后存储购买数据
        if (Data.type == 1)
        {
            PlayerPrefs.SetInt(VoleBenefit.TownDarnToss, Data.id);
            List<int> VaseList = VoleBenefit.RimHard(VoleBenefit.TownLopDarnToss);
            VoleBenefit.YamHard(VoleBenefit.TownLopDarnToss, VaseList.Count, Data.id);
        }
        else if(Data.type == 2)
        {
            PlayerPrefs.SetInt(VoleBenefit.TownSadToss, Data.id);
            List<int> ColorList = VoleBenefit.RimHard(VoleBenefit.TownLopBelowToss);
            VoleBenefit.YamHard(VoleBenefit.TownLopBelowToss, ColorList.Count, Data.id);
        }
    }

    BandBelowLast BandLast(Transform Content)
    {
        GameObject Go = Instantiate<GameObject>(BandHim);
        Go.transform.SetParent(Content, false);
        BandBelowLast cell = Go.GetComponent<BandBelowLast>();
        return cell;
    }
}
