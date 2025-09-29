using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpyBenefit : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("FlyItem")]    public GameObject SpyGood;
    public static SpyBenefit Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isOpenFly")]
    public bool ByFactSpy;
[UnityEngine.Serialization.FormerlySerializedAs("leftOrRight")]    public int LinkSoComer;
[UnityEngine.Serialization.FormerlySerializedAs("FlyParent")]    public Transform SpyLegacy;
    private int _HonorFactShow;
    private int _HubKeyShow;

    private GameObject Era;

    private void Awake()
    {
        Instance = this;
        _HubKeyShow = 0;
        ByFactSpy = true;
        _HonorFactShow = FluHealWar.instance.BoneVole.bubble_cd;
        LinkSoComer = 0;
    }

    private void OnEnable()
    {
        if (!ByFactSpy)
        {
            if (Era != null)
            {
                Era.GetComponent<FlyItem>().DestroyFlyItem();
            }
            ByFactSpy = !ByFactSpy;
        }
        FactIESpy();
    }

    public void FactIESpy()
    {
        StopCoroutine(nameof(FactSpyAgency));
        StartCoroutine(nameof(FactSpyAgency));
    }
    IEnumerator FactSpyAgency()
    {
        while (ByFactSpy)
        {
            if (_HubKeyShow >= _HonorFactShow)
            {
                StitchSpyGood();
            }
            _HubKeyShow++;
            yield return new WaitForSeconds(1);
        }
    }

    public void CodifySpyGood()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<FlyItem>().DestroyFlyItem();
            ByFactSpy = true;
        }
    }

    public void StitchSpyGood()
    {
        if (!ByFactSpy) { return; }
        // 新增：引导阶段禁止飞行气泡
        if (PlayerPrefs.GetInt(VoleBenefit.TownValid) <= 2 || VerbalRend.NoSquat())
        {
            return;
        }
        //if (BubbleManager.GetInstance().IsWinGame()) { return; }
        //  if ( LevelManager.GetInstance().CurLevel > 1 && !VerbalRend.IsApple
        ByFactSpy = false;
        _HubKeyShow = 0;
        Era = Instantiate(SpyGood.gameObject);
        Era.transform.SetParent(SpyLegacy, false);
        Era.transform.localScale = Vector3.one;
        Era.transform.localPosition = LinkSoComer == 0 ? new Vector3(-650, 0, 0) : new Vector3(650, 0, 0);
    }

    //public void SendFlyCollider(BubbleItem bubble)
    //{
    //    KeyValuesUpdate key = new KeyValuesUpdate(StringConst.SendFlyCollider, bubble);
    //    BlanketUnload.SendMessage(StringConst.SendFlyCollider, key);
    //}
}
