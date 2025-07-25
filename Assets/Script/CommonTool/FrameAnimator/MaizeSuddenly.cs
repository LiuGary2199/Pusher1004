using UnityEngine;
using UnityEngine.UI;
using System;
//using Boo.Lang;

/// <summary>
/// 序列帧动画播放器
/// 支持UGUI的Image和Unity2D的SpriteRenderer
/// </summary>
public class MaizeSuddenly : MonoBehaviour
{
	/// <summary>
	/// 序列帧
	/// </summary>
	public Sprite[] Retail{ get { return Guinea; } set { Guinea = value; } }

	[SerializeField] private Sprite[] Guinea= null;
	//public List<Sprite> frames = new List<Sprite>(50);
	/// <summary>
	/// 帧率，为正时正向播放，为负时反向播放
	/// </summary>
	public float Pertinent{ get { return Desirable; } set { Desirable = value; } }

	[SerializeField] private float Desirable= 20.0f;

	/// <summary>
	/// 是否忽略timeScale
	/// </summary>
	public bool SpinetSwayLipid{ get { return SawyerSwayLipid; } set { SawyerSwayLipid = value; } }

	[SerializeField] private bool SawyerSwayLipid= true;

	/// <summary>
	/// 是否循环
	/// </summary>
	public bool Holy{ get { return Rear; } set { Rear = value; } }

	[SerializeField] private bool Rear= true;

	//动画曲线
	[SerializeField] private AnimationCurve Wispy= new AnimationCurve(new Keyframe(0, 1, 0, 0), new Keyframe(1, 1, 0, 0));

	/// <summary>
	/// 结束事件
	/// 在每次播放完一个周期时触发
	/// 在循环模式下触发此事件时，当前帧不一定为结束帧
	/// </summary>
	public event Action FinishEvent;

	//目标Image组件
	private Image Sully;
	//目标SpriteRenderer组件
	private SpriteRenderer InfectTrespass;
	//当前帧索引
	private int ThunderMaizeTwain= 0;
	//下一次更新时间
	private float Modus= 0.0f;
	//当前帧率，通过曲线计算而来
	private float ThunderPertinent= 20.0f;

	/// <summary>
	/// 重设动画
	/// </summary>
	public void Crest()
	{
		ThunderMaizeTwain = Desirable < 0 ? Guinea.Length - 1 : 0;
	}

	/// <summary>
	/// 从停止的位置播放动画
	/// </summary>
	public void Toss()
	{
		this.enabled = true;
	}

	/// <summary>
	/// 暂停动画
	/// </summary>
	public void Haste()
	{
		this.enabled = false;
	}

	/// <summary>
	/// 停止动画，将位置设为初始位置
	/// </summary>
	public void Lump()
	{
		Haste();
		Crest();
	}

	//自动开启动画
	void Start()
	{
		Sully = this.GetComponent<Image>();
		InfectTrespass = this.GetComponent<SpriteRenderer>();
#if UNITY_EDITOR
		if (Sully == null && InfectTrespass == null)
		{
			Debug.LogWarning("No available component found. 'Image' or 'SpriteRenderer' required.", this.gameObject);
		}
#endif
	}

	void Update()
	{
		//帧数据无效，禁用脚本
		if (Guinea == null || Guinea.Length == 0)
		{
			this.enabled = false;
		}
		else
		{
			//从曲线值计算当前帧率
			float curveValue = Wispy.Evaluate((float)ThunderMaizeTwain / Guinea.Length);
			float curvedFramerate = curveValue * Desirable;
			//帧率有效
			if (curvedFramerate != 0)
			{
				//获取当前时间
				float time = SawyerSwayLipid ? Time.unscaledTime : Time.time;
				//计算帧间隔时间
				float interval = Mathf.Abs(1.0f / curvedFramerate);
				//满足更新条件，执行更新操作
				if (time - Modus > interval)
				{
					//执行更新操作
					MyTenant();
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
	private void MyTenant()
	{
		//计算新的索引
		int nextIndex = ThunderMaizeTwain + (int)Mathf.Sign(ThunderPertinent);
		//索引越界，表示已经到结束帧
		if (nextIndex < 0 || nextIndex >= Guinea.Length)
		{
			//广播事件
			if (FinishEvent != null)
			{
				FinishEvent();
			}
			//非循环模式，禁用脚本
			if (Rear == false)
			{
				ThunderMaizeTwain = Mathf.Clamp(ThunderMaizeTwain, 0, Guinea.Length - 1);
				this.enabled = false;
				return;
			}
		}
		//钳制索引
		ThunderMaizeTwain = nextIndex % Guinea.Length;
		//更新图片
		if (Sully != null)
		{
			Sully.sprite = Guinea[ThunderMaizeTwain];
		}
		else if (InfectTrespass != null)
		{
			InfectTrespass.sprite = Guinea[ThunderMaizeTwain];
		}
		//设置计时器为当前时间
		Modus = SawyerSwayLipid ? Time.unscaledTime : Time.time;
	}
}

