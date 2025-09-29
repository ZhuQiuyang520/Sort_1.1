using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 导航插件
/// </summary>

[Serializable]
public class TabItem
{
    public string AlaTale;
    [SerializeField]
    private GameObject Gland= null;
    public GameObject Towel{ get { return Gland; } }

    [SerializeField]
    private Button OweCorpse= null;
    public Button AlaCorpse{ get { return OweCorpse; } }

    public Sprite WarmthPull;
    public Sprite SuitablyPull;
}

public class AlaSpacecraft : MonoBehaviour
{
    [SerializeField]
[UnityEngine.Serialization.FormerlySerializedAs("items")]    public List<TabItem> Faith= null;
[UnityEngine.Serialization.FormerlySerializedAs("Content")]
    public GameObject Migrant;
[UnityEngine.Serialization.FormerlySerializedAs("ActiveAnimationObj")]    public GameObject WarmthGroundingHim;
[UnityEngine.Serialization.FormerlySerializedAs("ActiveBG")]    public Sprite WarmthBG;
[UnityEngine.Serialization.FormerlySerializedAs("InactiveBG")]    public Sprite SuitablyBG;
[UnityEngine.Serialization.FormerlySerializedAs("ActiveColor")]    public Color WarmthBelow;
[UnityEngine.Serialization.FormerlySerializedAs("InactiveColor")]    public Color SuitablyBelow;
    [Header("初始选中Tab名称")]
[UnityEngine.Serialization.FormerlySerializedAs("ActiveTab")]    public GameObject WarmthAla;

    private string PelletAlaTale;

    private Dictionary<string, GameObject> OwePanels;

    private Action<string, GameObject> EddyPretense;    // 打开tab回调

    // Start is called before the first frame update
    void Start()
    {
        OwePanels = new Dictionary<string, GameObject>();

        // Tab按钮绑定点击事件
        foreach (TabItem tabItem in Faith)
        {
            tabItem.AlaCorpse.onClick.AddListener(() =>
            {
                FactAla(tabItem.AlaTale);
            });
        }

        if (WarmthAla != null)
        {
            foreach(TabItem tab in Faith)
            {
                if (tab.AlaCorpse.gameObject == WarmthAla)
                {
                    PelletAlaTale = tab.AlaTale;
                    break;
                }
            }
            if (!string.IsNullOrEmpty(PelletAlaTale))
            {
                FactAla(PelletAlaTale);
            }
        }
    }

    /// <summary>
    /// 打开tab页面
    /// </summary>
    /// <param name="_tabName"></param>
    public GameObject FactAla(string _tabName)
    {
        if (!string.IsNullOrEmpty(PelletAlaTale) && OwePanels.ContainsKey(PelletAlaTale))
        {
            if (OwePanels[PelletAlaTale].GetComponent<RoarUILight>() != null)
            {
                OwePanels[PelletAlaTale].GetComponent<RoarUILight>().Hidding();
            }
            else
            {
                OwePanels[PelletAlaTale].SetActive(false);
            }
        }

        GameObject activeTabItem = null;
        foreach (TabItem tabItem in Faith)
        {
            tabItem.AlaCorpse.GetComponent<AlaGoodSpacecraft>().YamWarmthUI(tabItem.AlaTale.Equals(_tabName), this, tabItem);
            if (tabItem.AlaTale.Equals(_tabName))
            {
                activeTabItem = tabItem.AlaCorpse.gameObject;
                if (!OwePanels.ContainsKey(_tabName) && tabItem.Towel != null)
                {
                    GameObject tabItemPanel = Migrant.transform.Find(tabItem.Towel.name) == null ? Instantiate(tabItem.Towel, Migrant.transform) : tabItem.Towel;
                    OwePanels.Add(_tabName, tabItemPanel);
                }
            }
        }
        if (OwePanels.ContainsKey(_tabName))
        {
            if (OwePanels[_tabName].GetComponent<RoarUILight>() != null)
            {
                OwePanels[_tabName].GetComponent<RoarUILight>().Display(null);
            }
            else
            {
                OwePanels[_tabName]?.SetActive(true);
            }
        }

        PelletAlaTale = _tabName;

        StartCoroutine(WarmthItGrounding(activeTabItem));

        EddyPretense?.Invoke(_tabName, OwePanels.ContainsKey(_tabName) ? OwePanels[_tabName] : null);

        return OwePanels.ContainsKey(_tabName) ? OwePanels[_tabName] : null;
    }

    // tab背景动画
    private IEnumerator WarmthItGrounding(GameObject activeTabItem)
    {
        yield return new WaitForEndOfFrame();
        if (activeTabItem != null && WarmthGroundingHim != null)
        {
            WarmthGroundingHim.transform.SetParent(activeTabItem.transform);
            WarmthGroundingHim.transform.SetSiblingIndex(0);
            WarmthGroundingHim.GetComponent<RectTransform>().DOMoveX(activeTabItem.GetComponent<RectTransform>().position.x, 0.3f).SetEase(Ease.OutBack);
        }
    }

    /// <summary>
    /// 注册打开tab回调事件
    /// </summary>
    /// <param name="_callback"></param>
    public void HatcheryPretense(Action<string, GameObject> _callback)
    {
        EddyPretense = _callback;
    }
}
