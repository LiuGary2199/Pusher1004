using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 棋盘
/// </summary>
public class Chessboard : MonoBehaviour
{
    /// <summary>
    /// 棋盘上的格子
    /// </summary>
    private Grids[,] grids = new Grids[3, 3];

    /// <summary>
    /// 不同颜色的粒子
    /// </summary>
    public GameObject redParticle;
    public GameObject blueParticle;
    public GameObject greenParticle;
    public GameObject yellowParticle;
    public GameObject orangeParticle;
    public GameObject pinkParticle;
    public GameObject cyanParticle;

    void Start()
    {
        Init();
        EventCenter.Instance.AddEventListener("DragEnd", MatchRings);
    }

    /// <summary>
    /// 初始化棋盘上的格子
    /// </summary>
    void Init()
    {
        if(transform.childCount != 9)   Debug.LogError("棋盘的子物体数量必须为9");

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Grids grid = transform.GetChild(i * 3 + j).GetComponent<Grids>();
                grids[i, j] = grid;
            }
        }
    }

    /// <summary>
    /// 检测是否需要消除圆环
    /// </summary>
    /// <param name="obj"></param>
    void MatchRings(object obj)
    {
        if(obj is (Grids, Rings))   //obj是元祖，第一个元素是最新放置位置的Grids，第二个元素是最新放下的Rings
        {
            //grid就是最新的放置圆环的格子
            Grids grid = (((Grids, Rings))obj).Item1;
            int index = grid.transform.GetSiblingIndex();
            int col = index % 3;    //列
            int row = index / 3;    //行

            int count = 0;

            //判断是否可以消除所有同色圆环(同一个格子内有三个相同颜色的圆环则可以删除全部同色圆环)
            if(grid.GetRings().Item1 != null && grid.GetRings().Item2 != null && grid.GetRings().Item3 != null &&
                grid.GetRings().Item1.GetRingColor() == grid.GetRings().Item2.GetRingColor() && grid.GetRings().Item1.GetRingColor() == grid.GetRings().Item3.GetRingColor())
            {
                E_RingColor color = grid.GetRings().Item1.GetRingColor();

                //消除所有同色圆环
                for (int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        (Rings, Rings, Rings) rings = grids[i,j].GetRings();
                        //找到其他圆环的颜色
                        if (rings.Item1 != null && rings.Item1.GetRingColor() == color)
                        {
                            DestroyRing(rings.Item1, grids[i,j]);
                            count++;
                        }
                        if (rings.Item2 != null && rings.Item2.GetRingColor() == color)
                        {
                            DestroyRing(rings.Item2, grids[i,j]);
                            count++;
                        }
                        if (rings.Item3 != null && rings.Item3.GetRingColor() == color)
                        {
                            DestroyRing(rings.Item3, grids[i,j]);
                            count++;
                        }
                    }
                }
            }

            
            //判断是否消除一行一列或者一斜线上的所有同色圆环
            else
            {
                E_RingColor color = (((Grids, Rings))obj).Item2.GetRingColor();     //获取最新放下的圆环的颜色
                //判断是否可以消除一行
                bool isMatchRow = true;
                for(int i = 0; i < 3; i++)
                {
                    (Rings, Rings, Rings) rings = grids[row,i].GetRings();
                    if (rings.Item1 != null && rings.Item1.GetRingColor() == color) continue;
                    if (rings.Item2 != null && rings.Item2.GetRingColor() == color) continue;
                    if (rings.Item3 != null && rings.Item3.GetRingColor() == color) continue;
                    isMatchRow = false;
                    break;
                }
                //判断是否可以消除一列
                bool isMatchCol = true;
                for(int i = 0; i < 3; i++)
                {
                    (Rings, Rings, Rings) rings = grids[i,col].GetRings();
                    if (rings.Item1 != null && rings.Item1.GetRingColor() == color) continue;
                    if (rings.Item2 != null && rings.Item2.GetRingColor() == color) continue;
                    if (rings.Item3 != null && rings.Item3.GetRingColor() == color) continue;
                    isMatchCol = false;
                    break;
                }
                //判断是否可以消除主对角线
                bool isMathDiagonalMain = true;
                for(int i = 0; i < 3; i++)
                {
                    (Rings, Rings, Rings) rings = grids[i,i].GetRings();
                    if (rings.Item1 != null && rings.Item1.GetRingColor() == color) continue;
                    if (rings.Item2 != null && rings.Item2.GetRingColor() == color) continue;
                    if (rings.Item3 != null && rings.Item3.GetRingColor() == color) continue;
                    isMathDiagonalMain = false;
                    break;
                }
                //判断是否可以消除副对角线
                bool isMathDiagonalSub = true;
                for(int i = 0; i < 3; i++)
                {
                    (Rings, Rings, Rings) rings = grids[i,2-i].GetRings();
                    if (rings.Item1 != null && rings.Item1.GetRingColor() == color) continue;
                    if (rings.Item2 != null && rings.Item2.GetRingColor() == color) continue;
                    if (rings.Item3 != null && rings.Item3.GetRingColor() == color) continue;
                    isMathDiagonalSub = false;
                    break;
                }

                //消除一行
                if (isMatchRow)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        (Rings, Rings, Rings) rings = grids[row, i].GetRings();
                        if (rings.Item1 != null && rings.Item1.GetRingColor() == color)
                        {
                            DestroyRing(grids[row, i].GetRings().Item1, grids[row, i]);
                            count++;
                        }
                        if (rings.Item2 != null && rings.Item2.GetRingColor() == color)
                        {
                            DestroyRing(grids[row, i].GetRings().Item2, grids[row, i]);
                            count++;
                        }
                        if (rings.Item3 != null && rings.Item3.GetRingColor() == color)
                        {
                            DestroyRing(grids[row, i].GetRings().Item3, grids[row, i]);
                            count++;
                        }
                    }
                }
                //消除一列
                if (isMatchCol)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        (Rings, Rings, Rings) rings = grids[i, col].GetRings();
                        if (rings.Item1 != null && rings.Item1.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, col].GetRings().Item1, grids[i, col]);
                            count++;
                        }
                        if (rings.Item2 != null && rings.Item2.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, col].GetRings().Item2, grids[i, col]);
                            count++;
                        }
                        if (rings.Item3 != null && rings.Item3.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, col].GetRings().Item3, grids[i, col]);
                            count++;
                        }
                    }
                }
                //消除主对角线
                if (isMathDiagonalMain)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        (Rings, Rings, Rings) rings = grids[i, i].GetRings();
                        if (rings.Item1 != null && rings.Item1.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, i].GetRings().Item1, grids[i, i]);
                            count++;
                        }
                        if (rings.Item2 != null && rings.Item2.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, i].GetRings().Item2, grids[i, i]);
                            count++;
                        }
                        if (rings.Item3 != null && rings.Item3.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, i].GetRings().Item3, grids[i, i]);
                            count++;
                        }
                    }
                }
                //消除副对角线
                if (isMathDiagonalSub)
                {
                    for(int i = 0; i < 3; i++)
                    {
                        (Rings, Rings, Rings) rings = grids[i, 2 - i].GetRings();
                        if (rings.Item1 != null && rings.Item1.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, 2 - i].GetRings().Item1, grids[i, 2 - i]);
                            count++;
                        }
                        if (rings.Item2 != null && rings.Item2.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, 2 - i].GetRings().Item2, grids[i, 2 - i]);
                            count++;
                        }
                        if (rings.Item3 != null && rings.Item3.GetRingColor() == color)
                        {
                            DestroyRing(grids[i, 2 - i].GetRings().Item3, grids[i, 2 - i]);
                            count++;
                        }
                    }
                }
            }

            //回合结束，向事件中心更新分数
            if(count > 2)
            {
                AudioManager.Instance.PlayAudio(1);     //消除音效
                int score = (count - 2) * 10;              
                ScoreManager.Instance.AddScore(score);
            }
        }
        GameManager.Instance.RecordingGameInfo();     //每回合记录棋盘信息
    }

    /// <summary>
    /// 移除圆环
    /// </summary>
    /// <param name="grid"></param>
    void DestroyRing(Rings ring, Grids grid)
    {
        if(ring != null)
        {
            GameObjectPool.Instance.PushObj(ring.gameObject.name, ring.gameObject);
            grid.ResetRing(ring.GetRingSize());     //重置格子上的圆环
        }

        //播放粒子
        switch (ring.GetRingColor())
        {
            case E_RingColor.Red:
                GameObject redPar = GameObjectPool.Instance.GetObj("redParticle", redParticle);
                redPar.transform.position = grid.transform.position;
                redPar.GetComponent<ParticleSystem>().Play();
                break;
            case E_RingColor.Blue:
                GameObject bluePar = GameObjectPool.Instance.GetObj("blueParticle", blueParticle);
                bluePar.transform.position = grid.transform.position;
                bluePar.GetComponent<ParticleSystem>().Play();
                break;
            case E_RingColor.Green:
                GameObject greenPar = GameObjectPool.Instance.GetObj("greenParticle", greenParticle);
                greenPar.transform.position = grid.transform.position;
                greenPar.GetComponent<ParticleSystem>().Play();
                break;
            case E_RingColor.Yellow:
                GameObject yellowPar = GameObjectPool.Instance.GetObj("yellowParticle", yellowParticle);
                yellowPar.transform.position = grid.transform.position;
                yellowPar.GetComponent<ParticleSystem>().Play();
                break;
            case E_RingColor.Orange:
                GameObject orangePar = GameObjectPool.Instance.GetObj("orangeParticle", orangeParticle);
                orangePar.transform.position = grid.transform.position;
                orangePar.GetComponent<ParticleSystem>().Play();
                break;
            case E_RingColor.Pink:
                GameObject pinkPar = GameObjectPool.Instance.GetObj("pinkParticle", pinkParticle);
                pinkPar.transform.position = grid.transform.position;
                pinkPar.GetComponent<ParticleSystem>().Play();               
                break;
            case E_RingColor.Cyan:
                GameObject cyanPar = GameObjectPool.Instance.GetObj("cyanParticle", cyanParticle);
                cyanPar.transform.position = grid.transform.position;
                cyanPar.GetComponent<ParticleSystem>().Play();
                break;
            default:
                break;
        }
    }
}
