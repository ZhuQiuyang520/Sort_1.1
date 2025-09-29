/*
*
*   功能：整个UI框架的核心，用户程序通过调用本类，来调用本框架的大多数功能。  
*           功能1：关于入“栈”与出“栈”的UI窗体4个状态的定义逻辑
*                 入栈状态：
*                     Freeze();   （上一个UI窗体）冻结
*                     Display();  （本UI窗体）显示
*                 出栈状态： 
*                     Hiding();    (本UI窗体) 隐藏
*                     Redisplay(); (上一个UI窗体) 重新显示
*          功能2：增加“非栈”缓存集合。 
* 
* 
* ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
/// <summary>
/// UI窗体管理器脚本（框架核心脚本）
/// 主要负责UI窗体的加载、缓存、以及对于“UI窗体基类”的各种生命周期的操作（显示、隐藏、重新显示、冻结）。
/// </summary>
public class UIBenefit : MonoBehaviour
{
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("MainCanvas")]    public Canvas FlaxPillow;
    private static UIBenefit _Indicate= null;
    //ui窗体预设路径（参数1，窗体预设名称，2，表示窗体预设路径）
    private Dictionary<string, string> _GapLightPaths;
    //缓存所有的ui窗体
    private Dictionary<string, RoarUILight> _GapALLUILight;
    //栈结构标识当前ui窗体的集合
    private Stack<RoarUILight> _StaDefenseUILight;
    //当前显示的ui窗体
    private Dictionary<string, RoarUILight> _GapDefenseWrapUILight;
    //临时关闭窗口
    private List<UIFormParams> _SaltUILight;
    //ui根节点
    private Transform _SpyPillowEukaryote= null;
    //全屏幕显示的节点
    private Transform _SpySpring= null;
    //固定显示的节点
    private Transform _SpyTreat= null;
    //弹出节点
    private Transform _SpyPopMe= null;
    //ui特效节点
    private Transform _Net= null;
    //ui管理脚本的节点
    private Transform _SpyUIReplant= null;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("_TraUICamera")]    public Transform _SpyUIRotary= null;
    public Camera UIRotary{ get; private set; }
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PanelName")]    public string TowelTale;
    List<string> TowelTaleHard;
    public List<UIFormParams> SaltUILight    {
        get
        {
            return _SaltUILight;
        }
    }
    //得到实例
    public static UIBenefit RimIndicate()
    {
        if (_Indicate == null)
        {
            _Indicate = new GameObject("_UIManager").AddComponent<UIBenefit>();
            
        }
        return _Indicate;
    }
    //初始化核心数据，加载ui窗体路径到集合中
    public void Awake()
    {
        TowelTaleHard = new List<string>();
        //字段初始化
        _GapALLUILight = new Dictionary<string, RoarUILight>();
        _GapDefenseWrapUILight = new Dictionary<string, RoarUILight>();
        _SaltUILight = new List<UIFormParams>();
        _GapLightPaths = new Dictionary<string, string>();
        _StaDefenseUILight = new Stack<RoarUILight>();
        //初始化加载（根ui窗体）canvas预设
        JadeEnvyPillowHectare();
        //得到UI根节点，全屏节点，固定节点，弹出节点
        //Debug.Log("this.gameobject" + this.gameObject.name);
        _SpyPillowEukaryote = GameObject.FindGameObjectWithTag(OftIodine.SYS_TAG_CANVAS).transform;
        _SpySpring = FlankTavern.VeinDNAIssueMoss(_SpyPillowEukaryote.gameObject,OftIodine.SYS_NORMAL_NODE);
        _SpyTreat = FlankTavern.VeinDNAIssueMoss(_SpyPillowEukaryote.gameObject, OftIodine.SYS_FIXED_NODE);
        _SpyPopMe = FlankTavern.VeinDNAIssueMoss(_SpyPillowEukaryote.gameObject,OftIodine.SYS_POPUP_NODE);
        _Net = FlankTavern.VeinDNAIssueMoss(_SpyPillowEukaryote.gameObject, OftIodine.SYS_TOP_NODE);
        _SpyUIReplant = FlankTavern.VeinDNAIssueMoss(_SpyPillowEukaryote.gameObject,OftIodine.SYS_SCRIPTMANAGER_NODE);
        _SpyUIRotary = FlankTavern.VeinDNAIssueMoss(_SpyPillowEukaryote.gameObject, OftIodine.SYS_UICAMERA_NODE);
        //把本脚本作为“根ui窗体”的子节点
        FlankTavern.KeyIssueMossOrLegacyMoss(_SpyUIReplant, this.gameObject.transform);
        //根UI窗体在场景转换的时候，不允许销毁
        DontDestroyOnLoad(_SpyPillowEukaryote);
        //初始化ui窗体预设路径数据
        JadeUILightTrunkVole();
        //初始化UI相机参数，主要是解决URP管线下UI相机的问题
        JadeRotary();
    }
    private void KeyTowel(string name)
    {
        if (!TowelTaleHard.Contains(name))
        {
            TowelTaleHard.Add(name);
            TowelTale = name;
        }
    }
    private void GelTowel(string name)
    {
        if (TowelTaleHard.Contains(name))
        {
            TowelTaleHard.Remove(name);
        }
        if (TowelTaleHard.Count == 0)
        {
            TowelTale = "";
        }
        else
        {
            TowelTale = TowelTaleHard[0];
        }
    }
    //初始化加载（根ui窗体）canvas预设
    private void JadeEnvyPillowHectare()
    {
        FlaxPillow = NonnativeWar.RimIndicate().PikeRainy(OftIodine.SYS_PATH_CANVAS, false).GetComponent<Canvas>();
    }
    /// <summary>
    /// 显示ui窗体
    /// 功能：1根据ui窗体的名称，加载到所有ui窗体缓存集合中
    /// 2,根据不同的ui窗体的显示模式，分别做不同的加载处理
    /// </summary>
    /// <param name="IDFendTale">ui窗体预设的名称</param>
    public GameObject WrapUILight(string IDFendTale, object uiFormParams = null)
    {
        //参数的检查
        if (string.IsNullOrEmpty(IDFendTale)) return null;
        //根据ui窗体的名称，把加载到所有ui窗体缓存集合中
        //ui窗体的基类
        RoarUILight baseUIForms = PikeLightOrALLUILightWagon(IDFendTale);
        if (baseUIForms == null) return null;

        KeyTowel(IDFendTale);
        
        //判断是否清空“栈”结构体集合
        if (baseUIForms.DefenseUICare.NoGuardSharperFacial)
        {
            GuardPiqueMaser();
        }
        //根据不同的ui窗体的显示模式，分别做不同的加载处理
        switch (baseUIForms.DefenseUICare.UIForm_ShowMode)
        {
            case UIFormShowMode.Normal:
                AvailUILightRatio(IDFendTale, uiFormParams);
                break;
            case UIFormShowMode.ReverseChange:
                MessUILight(IDFendTale, uiFormParams);
                break;
            case UIFormShowMode.HideOther:
                AvailUIThirstOrRatioPalmAwake(IDFendTale, uiFormParams);
                break;
            case UIFormShowMode.Wait:
                AvailUILightRatioSaltBoard(IDFendTale, uiFormParams);
                break;
            default:
                break;
        }
        return baseUIForms.gameObject;
    }

    /// <summary>
    /// 关闭或返回上一个ui窗体（关闭当前ui窗体）
    /// </summary>
    /// <param name="strUIFormsName"></param>
    public void BoardSoColumnUILight(string strUIFormsName)
    {
        GelTowel(strUIFormsName);
        //Debug.Log("关闭窗体的名字是" + strUIFormsName);
        //ui窗体的基类
        RoarUILight baseUIForms = null;
        if (string.IsNullOrEmpty(strUIFormsName)) return;
        _GapALLUILight.TryGetValue(strUIFormsName,out baseUIForms);
        //所有窗体缓存中没有记录，则直接返回
        if (baseUIForms == null) return;
        //判断不同的窗体显示模式，分别处理
        switch (baseUIForms.DefenseUICare.UIForm_ShowMode)
        {
            case UIFormShowMode.Normal:
                FistUILightRatio(strUIFormsName);
                break;
            
            case UIFormShowMode.ReverseChange:
                HemUILight();
                break;
            case UIFormShowMode.HideOther:
                FistUILightLiftRatioSeaWrapAwake(strUIFormsName);
                break;
            case UIFormShowMode.Wait:
                FistUILightRatio(strUIFormsName);
                break;
            default:
                break;
        }
        
    }

    public void GuardLopUI()
    {
        foreach (var panel in RimWritingRamble(true))
        {
            BoardSoColumnUILight(panel.name);
        }
    }
    /// <summary>
    /// 显示下一个弹窗如果有的话
    /// </summary>
    public void WrapPoreHemMe()
    {
        if (_SaltUILight.Count > 0)
        {
            WrapUILight(_SaltUILight[0].IDFendTale, _SaltUILight[0].IDFendTriple);
            _SaltUILight.RemoveAt(0);
        }
    }

    /// <summary>
    /// 清空当前等待中的UI
    /// </summary>
    public void GuardSaltUILight()
    {
        if (_SaltUILight.Count > 0)
        {
            _SaltUILight = new List<UIFormParams>();
        }
    }
     /// <summary>
     /// 根据UI窗体的名称，加载到“所有UI窗体”缓存集合中
      /// 功能： 检查“所有UI窗体”集合中，是否已经加载过，否则才加载。
      /// </summary>
      /// <param name="uiFormsName">UI窗体（预设）的名称</param>
      /// <returns></returns>
    private RoarUILight PikeLightOrALLUILightWagon(string IDFendTale)
    {
        //加载的返回ui窗体基类
        RoarUILight baseUIResult = null;
        _GapALLUILight.TryGetValue(IDFendTale, out baseUIResult);
        if (baseUIResult == null)
        {
            //加载指定名称ui窗体
            baseUIResult = PikeUIFend(IDFendTale);

        }
        return baseUIResult;
    }
    /// <summary>
    /// 加载指定名称的“UI窗体”
    /// 功能：
    ///    1：根据“UI窗体名称”，加载预设克隆体。
    ///    2：根据不同预设克隆体中带的脚本中不同的“位置信息”，加载到“根窗体”下不同的节点。
    ///    3：隐藏刚创建的UI克隆体。
    ///    4：把克隆体，加入到“所有UI窗体”（缓存）集合中。
    /// 
    /// </summary>
    /// <param name="IDFendTale">UI窗体名称</param>
    private RoarUILight PikeUIFend(string IDFendTale)
    {
        string strUIFormPaths = null;
        GameObject goCloneUIPrefabs = null;
        RoarUILight baseUIForm = null;
        //根据ui窗体名称，得到对应的加载路径
        _GapLightPaths.TryGetValue(IDFendTale, out strUIFormPaths);
        if (!string.IsNullOrEmpty(strUIFormPaths))
        {
            //加载预制体
           goCloneUIPrefabs= NonnativeWar.RimIndicate().PikeRainy(strUIFormPaths, false);
        }
        //设置ui克隆体的父节点（根据克隆体中带的脚本中不同的信息位置信息）
        if(_SpyPillowEukaryote!=null && goCloneUIPrefabs != null)
        {
            baseUIForm = goCloneUIPrefabs.GetComponent<RoarUILight>();
            if (baseUIForm == null)
            {
                Debug.Log("baseUiForm==null! ,请先确认窗体预设对象上是否加载了baseUIForm的子类脚本！ 参数 IDFendTale="+IDFendTale);
                return null;
            }
            switch (baseUIForm.DefenseUICare.UIForms_Type)
            {
                case UIFormType.Normal:
                    goCloneUIPrefabs.transform.SetParent(_SpySpring, false);
                    break;
                case UIFormType.Fixed:
                    goCloneUIPrefabs.transform.SetParent(_SpyTreat, false);
                    break;
                case UIFormType.PopUp:
                    goCloneUIPrefabs.transform.SetParent(_SpyPopMe, false);
                    break;
                case UIFormType.Top:
                    goCloneUIPrefabs.transform.SetParent(_Net, false);
                    break;
                default:
                    break;
            }
            //设置隐藏
            goCloneUIPrefabs.SetActive(false);
            //把克隆体，加入到所有ui窗体缓存集合中
            _GapALLUILight.Add(IDFendTale, baseUIForm);
            return baseUIForm;
        }
        else
        {
            Debug.Log("_TraCanvasTransfrom==null Or goCloneUIPrefabs==null!! ,Plese Check!, 参数IDFendTale=" + IDFendTale);
        }
        Debug.Log("出现不可以预估的错误，请检查，参数 IDFendTale=" + IDFendTale);
        return null;
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="IDFendTale">窗体预设的名字</param>
    private void AvailUILightRatio(string IDFendTale, object uiFormParams)
    {
        //ui窗体基类
        RoarUILight baseUIForm;
        //从所有窗体集合中得到的窗体
        RoarUILight baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _GapDefenseWrapUILight.TryGetValue(IDFendTale, out baseUIForm);
        if (baseUIForm != null) return;
        //把当前窗体，加载到正在显示集合中
        _GapALLUILight.TryGetValue(IDFendTale, out baseUIFormFromAllCache);
        if (baseUIFormFromAllCache != null)
        {
            _GapDefenseWrapUILight.Add(IDFendTale, baseUIFormFromAllCache);
            //显示当前窗体
            baseUIFormFromAllCache.Display(uiFormParams);
            
        }
    }

    /// <summary>
    /// 卸载ui窗体从当前显示的集合缓存中
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void FistUILightRatio(string strUIFormsName)
    {
        //ui窗体基类
        RoarUILight baseUIForms;
        //正在显示ui窗体缓存集合没有记录，则直接返回
        _GapDefenseWrapUILight.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体，运行隐藏，且从正在显示ui窗体缓存集合中移除
        baseUIForms.Hidding();
        _GapDefenseWrapUILight.Remove(strUIFormsName);
    }

    /// <summary>
    /// 加载ui窗体到当前显示窗体集合，且，隐藏其他正在显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void AvailUIThirstOrRatioPalmAwake(string strUIFormsName, object uiFormParams)
    {
        //窗体基类
        RoarUILight baseUIForms;
        //所有窗体集合中的窗体基类
        RoarUILight baseUIFormsFromAllCache;
        _GapDefenseWrapUILight.TryGetValue(strUIFormsName, out baseUIForms);
        //正在显示ui窗体缓存集合里有记录，直接返回
        if (baseUIForms != null) return;
        Debug.Log("关闭其他窗体");
        //正在显示ui窗体缓存 与栈缓存集合里所有的窗体进行隐藏处理
        List<RoarUILight> ShowUIFormsList = new List<RoarUILight>(_GapDefenseWrapUILight.Values);
        foreach (RoarUILight baseUIFormsItem in ShowUIFormsList)
        {
            //Debug.Log("_DicCurrentShowUIForms---------" + baseUIFormsItem.transform.name);
            if (baseUIFormsItem.DefenseUICare.UIForms_Type == UIFormType.PopUp)
            {
                //baseUIFormsItem.Hidding();
                FistUILightLiftRatioSeaWrapAwake(baseUIFormsItem.GetType().Name);
            }
        }
        List<RoarUILight> CurrentUIFormsList = new List<RoarUILight>(_StaDefenseUILight);
        foreach (RoarUILight baseUIFormsItem in CurrentUIFormsList)
        {
            //Debug.Log("_StaCurrentUIForms---------"+baseUIFormsItem.transform.name);
            //baseUIFormsItem.Hidding();
            FistUILightLiftRatioSeaWrapAwake(baseUIFormsItem.GetType().Name);
        }
        //把当前窗体，加载到正在显示ui窗体缓存集合中 
        _GapALLUILight.TryGetValue(strUIFormsName, out baseUIFormsFromAllCache);
        if (baseUIFormsFromAllCache != null)
        {
            _GapDefenseWrapUILight.Add(strUIFormsName, baseUIFormsFromAllCache);
            baseUIFormsFromAllCache.Display(uiFormParams);
        }
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="IDFendTale">窗体预设的名字</param>
    private void AvailUILightRatioSaltBoard(string IDFendTale, object uiFormParams)
    {
        //ui窗体基类
        RoarUILight baseUIForm;
        //从所有窗体集合中得到的窗体
        RoarUILight baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _GapDefenseWrapUILight.TryGetValue(IDFendTale, out baseUIForm);
        if (baseUIForm != null) return;
        bool havePopUp = false;
        foreach (RoarUILight uiforms in _GapDefenseWrapUILight.Values)
        {
            if (uiforms.DefenseUICare.UIForms_Type == UIFormType.PopUp)
            {
                havePopUp = true;
                break;
            }
        }
        if (!havePopUp)
        {
            //把当前窗体，加载到正在显示集合中
            _GapALLUILight.TryGetValue(IDFendTale, out baseUIFormFromAllCache);
            if (baseUIFormFromAllCache != null)
            {
                _GapDefenseWrapUILight.Add(IDFendTale, baseUIFormFromAllCache);
                //显示当前窗体
                baseUIFormFromAllCache.Display(uiFormParams);

            }
        }
        else
        {
            _SaltUILight.Add(new UIFormParams() { IDFendTale = IDFendTale, IDFendTriple = uiFormParams });
        }
        
    }
    /// <summary>
    /// 卸载ui窗体从当前显示窗体集合缓存中，且显示其他原本需要显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void FistUILightLiftRatioSeaWrapAwake(string strUIFormsName)
    {
        //ui窗体基类
        RoarUILight baseUIForms;
        _GapDefenseWrapUILight.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体 ，运行隐藏状态，且从正在显示ui窗体缓存集合中删除
        baseUIForms.Hidding();
        _GapDefenseWrapUILight.Remove(strUIFormsName);
        //正在显示ui窗体缓存与栈缓存集合里素有窗体进行再次显示
        //foreach (RoarUILight baseUIFormsItem in _DicCurrentShowUIForms.Values)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
        //foreach (RoarUILight baseUIFormsItem in _StaCurrentUIForms)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
    }
    /// <summary>
    /// ui窗体入栈
    /// 功能：1判断栈里是否已经有窗体，有则冻结
    ///   2先判断ui预设缓存集合是否有指定的ui窗体，有则处理
    ///   3指定ui窗体入栈
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void MessUILight(string strUIFormsName, object uiFormParams)
    {
        //ui预设窗体
        RoarUILight baseUI;
        //判断栈里是否已经有窗体,有则冻结
        if (_StaDefenseUILight.Count > 0)
        {
            RoarUILight topUIForms = _StaDefenseUILight.Peek();
            topUIForms.Carbon();
            //Debug.Log("topUIForms是" + topUIForms.name);
        }
        //先判断ui预设缓存集合是否有指定ui窗体，有则处理
        _GapALLUILight.TryGetValue(strUIFormsName, out baseUI);
        if (baseUI != null)
        {
            baseUI.Display(uiFormParams);
        }
        else
        {
            Debug.Log(string.Format("/PushUIForms()/ baseUI==null! 核心错误，请检查 strUIFormsName={0} ", strUIFormsName));
        }
        //指定ui窗体入栈
        _StaDefenseUILight.Push(baseUI);
       
    }

    /// <summary>
    /// ui窗体出栈逻辑
    /// </summary>
    private void HemUILight()
    {

        if (_StaDefenseUILight.Count >= 2)
        {
            //出栈逻辑
            RoarUILight topUIForms = _StaDefenseUILight.Pop();
            //出栈的窗体进行隐藏
            topUIForms.Hidding(() => {
                //出栈窗体的下一个窗体逻辑
                RoarUILight nextUIForms = _StaDefenseUILight.Peek();
                //下一个窗体重新显示处理
                nextUIForms.Redisplay();
            });
        }
        else if (_StaDefenseUILight.Count == 1)
        {
            RoarUILight topUIForms = _StaDefenseUILight.Pop();
            //出栈的窗体进行隐藏处理
            topUIForms.Hidding();
        }
    }


    /// <summary>
    /// 初始化ui窗体预设路径数据
    /// </summary>
    private void JadeUILightTrunkVole()
    {
        IRambleBenefit configMgr = new RambleBenefitWeDeep(OftIodine.SYS_PATH_UIFORMS_CONFIG_INFO);
        if (_GapLightPaths != null)
        {
            _GapLightPaths = configMgr.AppHabitat;
        }
    }

    /// <summary>
    /// 初始化UI相机参数
    /// </summary>
    private void JadeRotary()
    {
        //当渲染管线为URP时，将UI相机的渲染方式改为Overlay，并加入主相机堆栈
        RenderPipelineAsset currentPipeline = GraphicsSettings.renderPipelineAsset;
        if (currentPipeline != null && currentPipeline.name == "UniversalRenderPipelineAsset")
        {
            UIRotary = _SpyUIRotary.GetComponent<Camera>();
            UIRotary.GetUniversalAdditionalCameraData().renderType = CameraRenderType.Overlay;
            Camera.main.GetUniversalAdditionalCameraData().cameraStack.Add(_SpyUIRotary.GetComponent<Camera>());
        }
    }

    /// <summary>
    /// 清空栈结构体集合
    /// </summary>
    /// <returns></returns>
    private bool GuardPiqueMaser()
    {
        if(_StaDefenseUILight!=null && _StaDefenseUILight.Count >= 1)
        {
            _StaDefenseUILight.Clear();
            return true;
        }
        return false;
    }
    /// <summary>
    /// 获取当前弹框ui的栈
    /// </summary>
    /// <returns></returns>
    public Stack<RoarUILight> RimDefenseFendPique()
    {
        return _StaDefenseUILight;
    }


    /// <summary>
    /// 根据panel名称获取panel gameObject
    /// </summary>
    /// <param name="IDFendTale"></param>
    /// <returns></returns>
    public GameObject RimTowelWeTale(string IDFendTale)
    {
        //ui窗体基类
        RoarUILight baseUIForm;
        //如果正在显示的集合中存在该窗体，直接返回
        _GapALLUILight.TryGetValue(IDFendTale, out baseUIForm);
        return baseUIForm?.gameObject;
    }

    /// <summary>
    /// 获取所有打开的panel（不包括Normal）
    /// </summary>
    /// <returns></returns>
    public List<GameObject> RimWritingRamble(bool containNormal = false)
    {
        List<GameObject> openingPanels = new List<GameObject>();
        List<RoarUILight> allUIFormsList = new List<RoarUILight>(_GapALLUILight.Values);
        foreach(RoarUILight panel in allUIFormsList)
        {
            if (panel.gameObject.activeInHierarchy)
            {
                if (containNormal || panel._DefenseUICare.UIForms_Type != UIFormType.Normal)
                {
                    openingPanels.Add(panel.gameObject);
                }
            }
        }

        return openingPanels;
    }
}

public class UIFormParams
{
    public string IDFendTale;   // 窗体名称
    public object IDFendTriple; // 窗体参数
}
