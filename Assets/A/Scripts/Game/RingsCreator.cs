using UnityEngine;
using System;
using UnityEngine.U2D;

/// <summary>
/// 圆环生成器
/// </summary>
public class RingsCreator : SingletonMono<RingsCreator>
{
    /// <summary>
    /// 本局游戏的回合数
    /// </summary>
    private int steps = 0;

    /// <summary>
    /// 简单步数
    /// </summary>
    private int easyStep = 10;

    /// <summary>
    /// 简单模式颜色数量
    /// </summary>
    private int easyColorCount = 3;

    /// <summary>
    /// 中等步数
    /// </summary>
    private int midStep = 20;

    /// <summary>
    /// 中等模式颜色数量
    /// </summary>
    private int midColorCount = 5;

    /// <summary>
    /// 当前创建出来的圆环
    /// </summary>
    private GameObject currRing;

    //困难模式全部颜色

    /// <summary>
    /// 设置生成的圆环
    /// </summary>
    /// <param name="info">为(E_RingColor, E_RingSize)元祖类型</param>
    public void Creat(object info = null)
    {
        CreatRing(info);
    }

    private void Start()
    {
        EventCenter.Instance.AddEventListener("CreateNewRing", CreatRing);   //创建新的圆环事件
        EventCenter.Instance.AddEventListener("RecreateRing", Recreate);   //重新创建圆环事件
    }

    /// <summary>
    /// 设置步数
    /// </summary>
    /// <param name="step"></param>
    public void SetSteps(int step)
    {
        steps = step;
    }

    /// <summary>
    /// 重新创建圆环
    /// </summary>
    public void Recreate(object obj)
    {
        if (currRing != null)
        {
            GameObjectPool.Instance.PushObj(currRing.name, currRing);
        }
        Creat();
    }

    /// <summary>
    /// 创建圆环
    /// </summary>
    private void CreatRing(object obj)
    {
        E_RingColor color;
        E_RingSize size;

        //不指定颜色大小，随机生成
        if (obj == null)
        {
            //随机颜色
            int colorCount;
            //当前是简单步数
            if (steps <= easyStep)
            {
                colorCount = easyColorCount;
            }
            //当前是中等步数
            else if (steps <= midStep + easyStep)
            {
                colorCount = midColorCount;
            }
            //当前是困难步数
            else
            {
                colorCount = Enum.GetValues(typeof(E_RingColor)).Length;
            }
            color = (E_RingColor)UnityEngine.Random.Range(0, colorCount);

            //随机尺寸
            size = (E_RingSize)UnityEngine.Random.Range(0, Enum.GetValues(typeof(E_RingSize)).Length);

            //保存当前圆环创造器上的圆环参数
            PlayerPrefs.SetInt("RingsCreator_RingSize", (int)size);
            PlayerPrefs.SetInt("RingsCreator_RingColor", (int)color);
        }
        //制定颜色大小则按照颜色大小去随机生成
        else
        {
            (E_RingColor, E_RingSize) ringInfo = ((E_RingColor, E_RingSize))obj;
            color = ringInfo.Item1;
            size = ringInfo.Item2;
            steps--;    //指定颜色是用来创建上一次游戏时已经创建好的圆环，步数已经自加过
        }

        //创建圆环
        GameObject ring = GameObjectPool.Instance.GetObj("Ring", GameManager.Instance.ringPrefab);
        Sprite sprite = GameManager.Instance.ringAtlas.GetSprite("ring_" + color.ToString() + "_" + size.ToString());
        ring.GetComponent<Rings>().SetRing(size, color, sprite);
        ring.transform.position = transform.position;

        currRing = ring;

        //创建完圆环后，步数加1
        steps++;
        PlayerPrefs.SetInt("Steps", steps);     //存储当前步数

        //判断是否结束游戏
        GameManager.Instance.IsGameOver(ring.GetComponent<Rings>());
    }
}
