using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static RealmCare;
using DG.Tweening;

/// <summary>
/// LoadPanelView - 自动生成的UI视图脚本
/// </summary>
public class PikeTowel : RoarUILight
{
[UnityEngine.Serialization.FormerlySerializedAs("ListArray")]
    #region UI组件
    public GameObject[] HardMaser;
    public static PikeTowel Instance;
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    public Image RetainTwice;
[UnityEngine.Serialization.FormerlySerializedAs("ProgressText")]    public Text SpecimenCart;
[UnityEngine.Serialization.FormerlySerializedAs("LoadingItems")]
    public List<GameObject> HectareWheel;
    #endregion

    #region 生命周期函数

    private void Start()
    {
        MillXenonSister.RimIndicate().MoatXenon("1001");
        MillXenonSister.RimIndicate().WoodBoneSpecimen();
        GroundingBench.HectareBus(HectareWheel);
        for (int i = 0; i < HardMaser.Length; i++)
        {
            BoneBenefit.RimIndicate().StifleTranslation(HardMaser[i].GetComponent<RectTransform>());
        }
        RetainTwice.fillAmount = 0;
        SpecimenCart.text = "0%";
        CashOutManager.RimIndicate().StartTime = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }

    #endregion

    #region 事件绑定
    private void Update()
    {
        // 如果没有登录成功，进度卡在60%，显示“登录中”
        // 如果登录后没有成功获取配置，进度卡在80%，显示“获取配置中”
        // 如果登录成功，获取配置成功，但有其他问题，进度卡在90%，显示“初始化中”
        if (RetainTwice.fillAmount <= 0.8f || (FluHealWar.instance.Prone && CashOutManager.RimIndicate().Ready))
        {
            RetainTwice.fillAmount += Time.deltaTime * 0.2f;
            SpecimenCart.text = (int)(RetainTwice.fillAmount * 100) + "%";

            if (RetainTwice.fillAmount >= 1)
            {
                // 安卓平台特殊屏蔽规则 被屏蔽玩家显示提示 阻止进入
                if (VerbalRend.SleeperStiltCreep())
                {
                    this.enabled = false;
                    return;
                }
                    
                VerbalRend.NoSquat();
                Destroy(transform.parent.gameObject);
                FlaxBenefit.instance.SealJade();
                CashOutManager.RimIndicate().ReportEvent_LoadingTime();
            }
        }

    }
    #endregion

}
