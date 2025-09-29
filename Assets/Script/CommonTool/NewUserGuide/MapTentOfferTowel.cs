using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapTentOfferTowel : RoarUILight
{
    public static MapTentOfferTowel instance;
[UnityEngine.Serialization.FormerlySerializedAs("Hand")]
    public GameObject Duck;

    /// <summary>
    /// 高亮显示目标
    /// </summary>
    private GameObject Ornate;
[UnityEngine.Serialization.FormerlySerializedAs("Text")]
    public Text Cart;
    /// <summary>
    /// 区域范围缓存
    /// </summary>
    private Vector3[] Synonym= new Vector3[4];
    /// <summary>
    /// 最终的偏移x
    /// </summary>
    private float OrnateAttireX= 0;
    /// <summary>
    /// 最终的偏移y
    /// </summary>
    private float OrnateAttireY= 0;
    /// <summary>
    /// 遮罩材质
    /// </summary>
    private Material Pristine;
    /// <summary>
    /// 当前的偏移x
    /// </summary>
    private float HexagonAttireX= 0f;
    /// <summary>
    /// 当前的偏移y
    /// </summary>
    private float HexagonAttireY= 0f;
    /// <summary>
    /// 高亮区域缩放的动画时间
    /// </summary>
    private float FormatShow= 0.1f;
    /// <summary>
    /// 事件渗透组件
    /// </summary>
    private AnalysisXenonSurrender StoveSurrender;

    protected override void Awake()
    {
        base.Awake();

        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// 显示引导遮罩
    /// </summary>
    /// <param name="_target">要引导到的目标对象</param>
    /// <param name="text">引导说明文案</param>

    public void WrapOffer(GameObject _target, string text)
    {
        if (_target == null)
        {
            Duck.SetActive(false);
            if (Pristine == null)
            {
                Pristine = GetComponent<Image>().material;
            }
            Pristine.SetVector("_Center", new Vector4(0, 0, 0, 0));
            Pristine.SetFloat("_SliderX", 0);
            Pristine.SetFloat("_SliderY", 0);
            // 如果没有target，点击任意区域关闭引导
            GetComponent<Button>().onClick.AddListener(() =>
            {
                BoardUIFend(GetType().Name);
            });
        }
        else
        {
            DOTween.Kill("NewUserHandAnimation");
            Jade(_target);
            GetComponent<Button>().onClick.RemoveAllListeners();
        }

        if (!string.IsNullOrEmpty(text))
        {
            Cart.text = text;
            Cart.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            Cart.transform.parent.gameObject.SetActive(false);
        }
    }

    private float OrnateUtter= 1;
    private float OrnateUseful= 1;
    public void Jade(GameObject _target)
    {
        this.Ornate = _target;

        StoveSurrender = GetComponent<AnalysisXenonSurrender>();
        if (StoveSurrender != null)
        {
            StoveSurrender.YamReasonTwice(_target.GetComponent<Image>());
        }

        Canvas canvas = UIBenefit.RimIndicate().FlaxPillow.GetComponent<Canvas>();

        //获取高亮区域的四个顶点的世界坐标
        if (Ornate.GetComponent<RectTransform>() != null)
        {
            Ornate.GetComponent<RectTransform>().GetWorldCorners(Synonym);
        }
        else
        {
            Vector3 pos = Camera.main.WorldToScreenPoint(_target.transform.position);
            pos = UIBenefit.RimIndicate()._SpyUIRotary.GetComponent<Camera>().ScreenToWorldPoint(pos);
            Synonym[0] = new Vector3(pos.x - OrnateUtter, pos.y - OrnateUseful);
            Synonym[1] = new Vector3(pos.x - OrnateUtter, pos.y + OrnateUseful);
            Synonym[2] = new Vector3(pos.x + OrnateUtter, pos.y + OrnateUseful);
            Synonym[3] = new Vector3(pos.x + OrnateUtter, pos.y - OrnateUseful);
        }
        //计算高亮显示区域在画布中的范围
        OrnateAttireX = Vector2.Distance(NurseOrPillowLeg(canvas, Synonym[0]), NurseOrPillowLeg(canvas, Synonym[3])) / 2f;
        OrnateAttireY = Vector2.Distance(NurseOrPillowLeg(canvas, Synonym[0]), NurseOrPillowLeg(canvas, Synonym[1])) / 2f;
        //计算高亮显示区域的中心
        float x = Synonym[0].x + ((Synonym[3].x - Synonym[0].x) / 2);
        float y = Synonym[0].y + ((Synonym[1].y - Synonym[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Career= NurseOrPillowLeg(canvas, centerWorld);
        //设置遮罩材质中的中心变量
        Vector4 centerMat = new Vector4(Career.x, Career.y, 0, 0);
        Pristine = GetComponent<Image>().material;
        Pristine.SetVector("_Center", centerMat);
        //计算当前高亮显示区域的半径
        RectTransform canRectTransform = canvas.transform as RectTransform;
        if (canRectTransform != null)
        {
            //获取画布区域的四个顶点
            canRectTransform.GetWorldCorners(Synonym);
            //计算偏移初始值
            for (int i = 0; i < Synonym.Length; i++)
            {
                if (i % 2 == 0)
                {
                    HexagonAttireX = Mathf.Max(Vector3.Distance(NurseOrPillowLeg(canvas, Synonym[i]), Career), HexagonAttireX);
                }
                else
                {
                    HexagonAttireY = Mathf.Max(Vector3.Distance(NurseOrPillowLeg(canvas, Synonym[i]), Career), HexagonAttireY);
                }
            }
        }
        //设置遮罩材质中当前偏移的变量
        Pristine.SetFloat("_SliderX", HexagonAttireX);
        Pristine.SetFloat("_SliderY", HexagonAttireY);
        Duck.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(WrapDuck(Career));
    }

    private IEnumerator WrapDuck(Vector2 center)
    {
        Duck.SetActive(false);
        yield return new WaitForSeconds(FormatShow);

        Duck.transform.localPosition = center;
        DuckGrounding();

        Duck.SetActive(true);
    }
    /// <summary>
    /// 收缩速度
    /// </summary>
    private float FormatObstacleX= 0f;
    private float FormatObstacleY= 0f;
    private void Update()
    {
        if (Pristine == null) return;

        HexagonAttireX = OrnateAttireX;
        Pristine.SetFloat("_SliderX", HexagonAttireX);
        HexagonAttireY = OrnateAttireY;
        Pristine.SetFloat("_SliderY", HexagonAttireY);
        //从当前偏移量到目标偏移量差值显示收缩动画
        //float valueX = Mathf.SmoothDamp(currentOffsetX, targetOffsetX, ref shrinkVelocityX, shrinkTime);
        //float valueY = Mathf.SmoothDamp(currentOffsetY, targetOffsetY, ref shrinkVelocityY, shrinkTime);
        //if (!Mathf.Approximately(valueX, currentOffsetX))
        //{
        //    currentOffsetX = valueX;
        //    material.SetFloat("_SliderX", currentOffsetX);
        //}
        //if (!Mathf.Approximately(valueY, currentOffsetY))
        //{
        //    currentOffsetY = valueY;
        //    material.SetFloat("_SliderY", currentOffsetY);
        //}


    }

    /// <summary>
    /// 世界坐标转换为画布坐标
    /// </summary>
    /// <param name="canvas">画布</param>
    /// <param name="world">世界坐标</param>
    /// <returns></returns>
    private Vector2 NurseOrPillowLeg(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }

    public void DuckGrounding()
    {

        var s = DOTween.Sequence();
        s.Append(Duck.transform.DOLocalMoveY(Duck.transform.localPosition.y + 10f, 0.5f));
        s.Append(Duck.transform.DOLocalMoveY(Duck.transform.localPosition.y, 0.5f));
        s.Join(Duck.transform.DOScaleY(1.1f, 0.125f));
        s.Join(Duck.transform.DOScaleX(0.9f, 0.125f).OnComplete(() =>
        {
            Duck.transform.DOScaleY(0.9f, 0.125f);
            Duck.transform.DOScaleX(1.1f, 0.125f).OnComplete(() =>
            {
                Duck.transform.DOScale(1f, 0.125f);
            });
        }));
        s.SetLoops(-1);
        s.SetId("NewUserHandAnimation");
    }

    public void OnDisable()
    {
        DOTween.Kill("NewUserHandAnimation");
    }
}
