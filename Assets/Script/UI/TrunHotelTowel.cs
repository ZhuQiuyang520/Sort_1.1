using DG.Tweening;
using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrunHotelTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("bigWheelItem")]    //public List<GameObject> LightList;
    public GameObject NowArrowGood;
[UnityEngine.Serialization.FormerlySerializedAs("smallWheelItem")]    public GameObject smallArrowGood;
[UnityEngine.Serialization.FormerlySerializedAs("smallWheel")]    public GameObject TitleArrow;
[UnityEngine.Serialization.FormerlySerializedAs("bigWheel")]    public GameObject NowArrow;
[UnityEngine.Serialization.FormerlySerializedAs("pointer")]    public GameObject Fertile;
[UnityEngine.Serialization.FormerlySerializedAs("spinButton")]    public Button LowaCorpse;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_TurnAni")]
    public GameObject Up_PlowBus;
[UnityEngine.Serialization.FormerlySerializedAs("curve")]
    public AnimationCurve Pound;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_Light_1")]
    public GameObject Up_Trunk_1;
[UnityEngine.Serialization.FormerlySerializedAs("Fx_Light_2")]    public GameObject Up_Trunk_2;

    List<GameObject> NowGoodHard;
    bool ByJade= false;

    private RewardPanelData _SpinetVole;

    public override void Display(object uiFormParams)
    {
        base.Display(uiFormParams);
        Up_Trunk_1.SetActive(false);
        Up_Trunk_2.SetActive(false);
        Up_PlowBus.SetActive(false);
        MillXenonSister.RimIndicate().MoatXenon("1004");
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.Success);
        LowaCorpse.gameObject.SetActive(true);
        PaneArrow();
        _SpinetVole = new RewardPanelData();
    }

    private void Start()
    {
        
        LowaCorpse.onClick.AddListener(Lowa);
    }

    void PaneArrow()
    {
        if (!ByJade)
        {
            ByJade = true;
            NowGoodHard = new List<GameObject>();
            for (int i = 0; i < 8; i++)
            {
                TurnRewardData rewardItem = FluHealWar.instance.BoneVole.wheel_reward_weight_group[i];
                GameObject bigItem = Instantiate(NowArrowGood, NowArrow.transform);
                string type = rewardItem.type;
                //if (VerbalRend.IsApple() && (type == "cash"))
                //{
                //    type = "gold";
                //}
                bigItem.GetComponent<BigWheelItem>().initIcon(type);
                bigItem.GetComponent<BigWheelItem>().text.text = rewardItem.num.ToString();
                bigItem.transform.eulerAngles = new Vector3(0, 0, -i * (360 / 8f));
                NowGoodHard.Add(bigItem);
            }
            for (int i = 0; i < 6; i++)
            {
                WheelMultiItem multiItem = FluHealWar.instance.BoneVole.wheel_reward_multi.diamand[i];
                GameObject smallItem = Instantiate(smallArrowGood, TitleArrow.transform);
                smallItem.GetComponent<SmallWheelItem>().text.text = "×" + multiItem.multi.ToString();
                smallItem.transform.eulerAngles = new Vector3(0, 0, i * (360 / 6f));
            }
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                TurnRewardData rewardItem = FluHealWar.instance.BoneVole.wheel_reward_weight_group[i];
                GameObject bigItem = NowGoodHard[i];
                bigItem.GetComponent<BigWheelItem>().initIcon(rewardItem.type);
                bigItem.GetComponent<BigWheelItem>().text.text = rewardItem.num.ToString();
            }
        }
        LowaCorpse.transform.localScale = Vector3.zero;
        LowaCorpse.transform.DOScale(new Vector3(0.7f, 0.7f, 1), 0.2f).SetDelay(0.2f);
        NowArrow.transform.eulerAngles = new Vector3(0, 0, 180);
        TitleArrow.transform.eulerAngles = new Vector3(0, 0, 0);

    }
    public void Lowa()
    {
        Up_PlowBus.SetActive(true);
        CashOutManager.RimIndicate().AddTaskValue("Wheel", 1);
        BoneBenefit.RimIndicate().HabitatOrgan(RealmCare.UIMusic.pop_up);
        BoneBenefit.RimIndicate().HabitatTitle(HapticPatterns.PresetType.LightImpact);
        //StartCoroutine(pointerAnimation());
        int bigIndex = GameUtil.GetRewardIndexWithWeight(FluHealWar.instance.BoneVole.wheel_reward_weight_group);
        TurnRewardData rewardData = FluHealWar.instance.BoneVole.wheel_reward_weight_group[bigIndex];
        int smallIndex = GameUtil.GetWheelMultiIndex(rewardData.type);
        float multi = (float)FluHealWar.instance.BoneVole.wheel_reward_multi.diamand[smallIndex].multi;

        NowArrow.transform.DORotate(new Vector3(0, 0, 360 * 10 + (360 / 8f) * bigIndex), 3f, RotateMode.FastBeyond360).SetDelay(0.2f).SetEase(Pound);
        TitleArrow.transform.DORotate(new Vector3(0, 0, -360 * 10 - (360 / 6f) * smallIndex), 3f, RotateMode.FastBeyond360).SetDelay(0.2f).SetEase(Pound).OnComplete(() => {

            Up_Trunk_1.SetActive(true);
            Up_Trunk_2.SetActive(true);
            StartCoroutine(PineAllGrounding(() =>
            {
                Debug.Log(rewardData.type + ", " + rewardData.num + ", ×" + multi);
                AidRimModuleTowel(rewardData.type, multi * (float)rewardData.num);
            }));
        });
        LowaCorpse.gameObject.SetActive(false);

        StartCoroutine(FertileGrounding());
    }
    IEnumerator FertileGrounding()
    {
        yield return new WaitForSeconds(0.2f);
        Sequence seq = DOTween.Sequence();
        seq.Append(Fertile.transform.DOLocalRotate(new Vector3(0, 0, -20 + UnityEngine.Random.Range(-2f, 2f)), 2f / 36 * 0.3f)
            .SetEase(Ease.Linear));
        seq.Append(Fertile.transform.DOLocalRotate(new Vector3(0, 0, 0), 2f / 36 * 0.7f).SetEase(Ease.Linear));
        seq.AppendCallback(() => {
            //HapticPatterns.PlayPreset(HapticPatterns.PresetType.Selection);
        });
        seq.SetLoops(50);
        seq.SetEase(Pound);
        seq.Play();
    }
    /// <summary>
    /// 中奖动画
    /// </summary>
    /// <param name="finish"></param>
    public IEnumerator PineAllGrounding(System.Action finish)
    {
        //var light = DOTween.Sequence();
        //fx_wheel.SetActive(true);
        //light.Append(LightList[0].GetComponent<Image>().DOFade(1, 0.15f));
        //light.Append(LightList[0].GetComponent<Image>().DOFade(0, 0.15f));
        //light.SetLoops(5, LoopType.Restart);
        //var light_1 = DOTween.Sequence();
        //light_1.Append(LightList[1].GetComponent<Image>().DOFade(1, 0.15f));
        //light_1.Append(LightList[1].GetComponent<Image>().DOFade(0, 0.15f));
        //light_1.SetLoops(5, LoopType.Restart);
        yield return new WaitForSeconds(1.5f);
        //LightList[1].GetComponent<Image>().color = new Color(1, 1, 1, 1);
        //LightList[0].GetComponent<Image>().color = new Color(1, 1, 1, 1);
        finish();
    }
    /// <summary>
    /// 弹出奖励弹窗
    /// </summary>
    /// <param name="type">奖励类型</param>
    /// <param name="num">奖励金额</param>
    public void AidRimModuleTowel(string type, float num)
    {
        RewardType rewardType = RewardType.Gold;
        if (type == "diamand")
        {
            rewardType = RewardType.diamand;
            //if (VerbalRend.IsApple())
            //{
            //    rewardType = RewardType.Gold;
            //}
        }
        if (type == "gold")
        {
            rewardType = RewardType.Gold;
        }
        if (type == "add")
        {
            rewardType = RewardType.add;
        }
        if (type == "roll")
        {
            rewardType = RewardType.roll;
        }
        if (type == "remind")
        {
            rewardType = RewardType.remind;
        }
        _SpinetVole.AcidCare = "LuckyWheel";
        
        _SpinetVole.Gap_Module.Add(rewardType, num);
        BoardUIFend(GetType().Name);
        UIBenefit.RimIndicate().WrapUILight(nameof(LunarDireTowel), _SpinetVole);
        ADBenefit.Indicate.NarrowShowImprisonment();
    }
}
