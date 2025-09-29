/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIFireWar : MonoBehaviour
{
    private static UIFireWar _Indicate= null;
    //ui根节点对象
    private GameObject _SoPillowEnvy= null;
    //ui脚本节点对象
    private Transform _TraUIReplantMoss= null;
    //顶层面板
    private GameObject _SoOrTowel;
    //遮罩面板
    private GameObject _SoFireTowel;
    //ui摄像机
    private Camera _UIRotary;
    //ui摄像机原始的层深
    private float _ForesterUIRotaryRelay;
    //获取实例
    public static UIFireWar RimIndicate()
    {
        if (_Indicate == null)
        {
            _Indicate = new GameObject("_UIMaskMgr").AddComponent<UIFireWar>();
        }
        return _Indicate;
    }
    private void Awake()
    {
        _SoPillowEnvy = GameObject.FindGameObjectWithTag(OftIodine.SYS_TAG_CANVAS);
        _TraUIReplantMoss = FlankTavern.VeinDNAIssueMoss(_SoPillowEnvy, OftIodine.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        FlankTavern.KeyIssueMossOrLegacyMoss(_TraUIReplantMoss, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _SoOrTowel = _SoPillowEnvy;
        _SoFireTowel = FlankTavern.VeinDNAIssueMoss(_SoPillowEnvy, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UIRotary = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UIRotary != null)
        {
            //得到ui相机原始的层深
            _ForesterUIRotaryRelay = _UIRotary.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void YamFireInfect(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _SoOrTowel.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _SoFireTowel.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _SoFireTowel.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _SoFireTowel.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 220 / 255F);
                _SoFireTowel.GetComponent<Image>().color = newColor2;
                BlanketUnloadLogic.RimIndicate().Moat(CRamble.mg_WindowFact);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _SoFireTowel.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 240F / 255F);
                _SoFireTowel.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_SoFireTowel.activeInHierarchy)
                {
                    _SoFireTowel.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _SoFireTowel.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UIRotary != null)
        {
            _UIRotary.depth = _UIRotary.depth + 100;
        }
    }
    public void PalmFireInfect()
    {
        if (UIBenefit.RimIndicate().SaltUILight.Count > 0 || UIBenefit.RimIndicate().RimDefenseFendPique().Count > 0)
        {
            return;
        }
        Color newColor3 = new Color(_SoFireTowel.GetComponent<Image>().color.r, _SoFireTowel.GetComponent<Image>().color.g, _SoFireTowel.GetComponent<Image>().color.b,0);
        _SoFireTowel.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void HungryFireInfect()
    {
        if (UIBenefit.RimIndicate().SaltUILight.Count > 0 || UIBenefit.RimIndicate().RimDefenseFendPique().Count > 0)
        {
            return;
        }
        // 检查是否有其他 PopUp 窗口正在显示
        bool hasOtherPopUp = false;
        var openingPanels = UIBenefit.RimIndicate().RimWritingRamble(true);
        foreach (var panel in openingPanels)
        {
            var baseUIForm = panel.GetComponent<RoarUILight>();
            if (baseUIForm != null && baseUIForm.DefenseUICare.UIForms_Type == UIFormType.PopUp)
            {
                hasOtherPopUp = true;
                // 将遮罩放在最后一个 PopUp 窗口下面
                _SoFireTowel.transform.SetAsLastSibling();
                panel.transform.SetAsLastSibling();
                break;
            }
        }

        // 只有在没有其他 PopUp 窗口时才关闭遮罩
        if (!hasOtherPopUp)
        {
            //顶层窗体上移
            _SoOrTowel.transform.SetAsFirstSibling();
            //禁用遮罩窗体
            if (_SoFireTowel.activeInHierarchy)
            {
                _SoFireTowel.SetActive(false);
                BlanketUnloadLogic.RimIndicate().Moat(CRamble.To_InfectBoard);
            }
            //恢复当前ui摄像机的层深
            if (_UIRotary != null)
            {
                _UIRotary.depth = _ForesterUIRotaryRelay;
            }
        }
    }
}
