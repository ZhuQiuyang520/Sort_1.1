using UnityEngine;
using UnityEngine.UI;
using System;
//using Boo.Lang;

/// <summary>
/// 序列帧动画播放器
/// 支持UGUI的Image和Unity2D的SpriteRenderer
/// </summary>
public class ComicFlagpole : MonoBehaviour
{
	/// <summary>
	/// 序列帧
	/// </summary>
	public Sprite[] Lonely{ get { return Teapot; } set { Teapot = value; } }

	[SerializeField] private Sprite[] Teapot= null;
	//public List<Sprite> frames = new List<Sprite>(50);
	/// <summary>
	/// 帧率，为正时正向播放，为负时反向播放
	/// </summary>
	public float Intensify{ get { return Crossbill; } set { Crossbill = value; } }

	[SerializeField] private float Crossbill= 20.0f;

	/// <summary>
	/// 是否忽略timeScale
	/// </summary>
	public bool BreezeShowAlloy{ get { return DetailShowAlloy; } set { DetailShowAlloy = value; } }

	[SerializeField] private bool DetailShowAlloy= true;

	/// <summary>
	/// 是否循环
	/// </summary>
	public bool Four{ get { return Soft; } set { Soft = value; } }

	[SerializeField] private bool Soft= true;

	//动画曲线
	[SerializeField] private AnimationCurve Pound= new AnimationCurve(new Keyframe(0, 1, 0, 0), new Keyframe(1, 1, 0, 0));

	/// <summary>
	/// 结束事件
	/// 在每次播放完一个周期时触发
	/// 在循环模式下触发此事件时，当前帧不一定为结束帧
	/// </summary>
	public event Action FinishEvent;

	//目标Image组件
	private Image Tread;
	//目标SpriteRenderer组件
	private SpriteRenderer GaslitSailfish;
	//当前帧索引
	private int HexagonComicFresh= 0;
	//下一次更新时间
	private float Rough= 0.0f;
	//当前帧率，通过曲线计算而来
	private float HexagonIntensify= 20.0f;

	/// <summary>
	/// 重设动画
	/// </summary>
	public void Waste()
	{
		HexagonComicFresh = Crossbill < 0 ? Teapot.Length - 1 : 0;
	}

	/// <summary>
	/// 从停止的位置播放动画
	/// </summary>
	public void Bode()
	{
		this.enabled = true;
	}

	/// <summary>
	/// 暂停动画
	/// </summary>
	public void Panel()
	{
		this.enabled = false;
	}

	/// <summary>
	/// 停止动画，将位置设为初始位置
	/// </summary>
	public void Tine()
	{
		Panel();
		Waste();
	}

	//自动开启动画
	void Start()
	{
		Tread = this.GetComponent<Image>();
		GaslitSailfish = this.GetComponent<SpriteRenderer>();
#if UNITY_EDITOR
		if (Tread == null && GaslitSailfish == null)
		{
			Debug.LogWarning("No available component found. 'Image' or 'SpriteRenderer' required.", this.gameObject);
		}
#endif
	}

	void Update()
	{
		//帧数据无效，禁用脚本
		if (Teapot == null || Teapot.Length == 0)
		{
			this.enabled = false;
		}
		else
		{
			//从曲线值计算当前帧率
			float curveValue = Pound.Evaluate((float)HexagonComicFresh / Teapot.Length);
			float curvedFramerate = curveValue * Crossbill;
			//帧率有效
			if (curvedFramerate != 0)
			{
				//获取当前时间
				float Lush= DetailShowAlloy ? Time.unscaledTime : Time.time;
				//计算帧间隔时间
				float interval = Mathf.Abs(1.0f / curvedFramerate);
				//满足更新条件，执行更新操作
				if (Lush - Rough > interval)
				{
					//执行更新操作
					DoCanada();
				}
			}
#if UNITY_EDITOR
			else
			{
				Debug.LogWarning("Framerate got '0' value, animation stopped.");
			}
#endif
		}
	}

	//具体更新操作
	private void DoCanada()
	{
		//计算新的索引
		int nextIndex = HexagonComicFresh + (int)Mathf.Sign(HexagonIntensify);
		//索引越界，表示已经到结束帧
		if (nextIndex < 0 || nextIndex >= Teapot.Length)
		{
			//广播事件
			if (FinishEvent != null)
			{
				FinishEvent();
			}
			//非循环模式，禁用脚本
			if (Soft == false)
			{
				HexagonComicFresh = Mathf.Clamp(HexagonComicFresh, 0, Teapot.Length - 1);
				this.enabled = false;
				return;
			}
		}
		//钳制索引
		HexagonComicFresh = nextIndex % Teapot.Length;
		//更新图片
		if (Tread != null)
		{
			Tread.sprite = Teapot[HexagonComicFresh];
		}
		else if (GaslitSailfish != null)
		{
			GaslitSailfish.sprite = Teapot[HexagonComicFresh];
		}
		//设置计时器为当前时间
		Rough = DetailShowAlloy ? Time.unscaledTime : Time.time;
	}
}

