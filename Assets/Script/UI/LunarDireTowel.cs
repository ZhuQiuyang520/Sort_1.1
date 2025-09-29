using DG.Tweening;
using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LunarDireTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("AwardDesc")]    public Text DodgeShop;
[UnityEngine.Serialization.FormerlySerializedAs("Coin")]    public GameObject Gene;
[UnityEngine.Serialization.FormerlySerializedAs("Diamand")]    public GameObject Abreast;
[UnityEngine.Serialization.FormerlySerializedAs("Remind")]    public GameObject Infect;
[UnityEngine.Serialization.FormerlySerializedAs("AddVase")]    public GameObject KeyDarn;
[UnityEngine.Serialization.FormerlySerializedAs("Rollback")]    public GameObject Stocking;
[UnityEngine.Serialization.FormerlySerializedAs("Free")]
    public Button Husk;
[UnityEngine.Serialization.FormerlySerializedAs("Get")]    public Button Rim;
[UnityEngine.Serialization.FormerlySerializedAs("SlotBG")]    public WarpBench WarpBG;
[UnityEngine.Serialization.FormerlySerializedAs("ShowList")]
    // 显示列表
    public List<GameObject> WrapHard;

    private double SpinetGrand;
    private RewardPanelData _SpinetVole;

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        JadeWrapHard();
        WarpBG.PaneMouth();
        Husk.interactable = true;
        WrapBus(() => { });
    }

    protected override void OnMessageReceived(object uiFormParams)
    {
        base.OnMessageReceived(uiFormParams);
        _SpinetVole = (RewardPanelData)uiFormParams;
        Abreast.gameObject.SetActive(false);
        Gene.gameObject.SetActive(false);
        KeyDarn.gameObject.SetActive(false);
        Stocking.gameObject.SetActive(false);
        Infect.gameObject.SetActive(false);
        if (_SpinetVole.AcidCare == "LuckyWheel")
        {
            foreach (var item in _SpinetVole.Gap_Module)
            {
                switch (item.Key)
                {
                    case RewardType.add:
                        KeyDarn.SetActive(true);
                        SpinetGrand = item.Value;
                        break;
                    case RewardType.diamand:
                        Abreast.SetActive(true);
                        SpinetGrand = item.Value;
                        break;
                    case RewardType.Gold:
                        Gene.SetActive(true);
                        SpinetGrand = item.Value;
                        break;
                    case RewardType.roll:
                        Stocking.SetActive(true);
                        SpinetGrand = item.Value;
                        break;
                    case RewardType.remind:
                        Infect.SetActive(true);
                        SpinetGrand = item.Value;
                        break;
                    default:
                        break;
                }
            }
        }
        DodgeShop.text = "+ " + SpinetGrand;
    }

    private void Start()
    {
        Husk.onClick.AddListener(FacialHusk);
        Rim.onClick.AddListener(PaperRim);
    }
    public void JadeWrapHard()
    {
        for (int i = 0; i < WrapHard.Count; i++)
        {
            WrapHard[i].transform.localScale = new Vector3(0, 0, 0);
        }
    }

        private void FacialHusk()
    {
        MillXenonSister.RimIndicate().MoatXenon("9001", "1");
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        ADBenefit.Indicate.PineModuleProwl((success) =>
        {
            if (success)
            {
                MillXenonSister.RimIndicate().MoatXenon("9003", "1");
                Husk.interactable = false;
                PineWarp();
            }
        }, "1");
    }
    private void PaperRim()
    {
        ADBenefit.Indicate.AxFreelyKeyCreep();
        FacialRim();
    }

    private void FacialRim()
    {
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.click);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        foreach (var item in _SpinetVole.Gap_Module)
        {
            switch (item.Key)
            {
                case RewardType.add:
                    PlayerPrefs.SetInt(VoleBenefit.TownDarnOral, PlayerPrefs.GetInt(VoleBenefit.TownDarnOral) + (int)SpinetGrand);
                    BlanketBenefit.RimIndicate().Dimension(MessageCode.KeySully, PopupType.Vase);
                    break;
                case RewardType.roll:
                    PlayerPrefs.SetInt(VoleBenefit.TownStockingOral, PlayerPrefs.GetInt(VoleBenefit.TownStockingOral) + (int)SpinetGrand);
                    BlanketBenefit.RimIndicate().Dimension(MessageCode.KeySully, PopupType.RollBack);
                    break;
                case RewardType.remind:
                    PlayerPrefs.SetInt(VoleBenefit.TownInfectOral, PlayerPrefs.GetInt(VoleBenefit.TownInfectOral) + (int)SpinetGrand);
                    BlanketBenefit.RimIndicate().Dimension(MessageCode.KeySully, PopupType.Remind);
                    
                    break;
                case RewardType.Gold:
                    BoneVoleBenefit.RimIndicate().RibCare(SpinetGrand);
                    break;
                case RewardType.diamand:
                    BoneTowel.instance.SpyGene(Abreast.transform, SpinetGrand);
                    break;
                default:
                    break;
            }
        }
        


        BoardUIFend(GetType().Name);
    }

    private int WedWarpMouthFresh()
    {
        int sumWeight = 0;
        foreach (SlotItem wg in FluHealWar.instance.JadeVole.slot_group)
        {
            sumWeight += wg.weight;
        }
        int r = Random.Range(0, sumWeight);
        int nowWeight = 0;
        int index = 0;
        foreach (SlotItem wg in FluHealWar.instance.JadeVole.slot_group)
        {
            nowWeight += wg.weight;
            if (nowWeight > r)
            {
                return index;
            }
            index++;
        }
        return 0;
    }

    private void PineWarp()
    {
        int index = WedWarpMouthFresh();
        WarpBG.Weak(index, (multi) => {
            // slot结束后的回调
            GroundingSpacecraft.FacialStress(SpinetGrand, SpinetGrand * multi, 0, DodgeShop, "+", () =>
            {
                SpinetGrand = SpinetGrand * multi;
                
                DodgeShop.text = "+ " + StressRend.TwelveOrFan(SpinetGrand);
                FacialRim();
            });
        });
    }

    public void WrapBus(System.Action finish) 
    {
        float Lush= 0;
        for (int i = 0; i < WrapHard.Count; i++)
        {
            int index = i;
            GameObject Era= WrapHard[i];
            Era.transform.DOScale(new Vector3(1,1,1), 0.3f).SetEase(Ease.OutBack).SetDelay(Lush).OnComplete(() =>
            {
                if (index == WrapHard.Count - 1)
                {
                    finish?.Invoke();
                }
            });
            Lush += 0.1f;
        }
    }
}
