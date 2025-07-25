using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// ����
/// </summary>
public class Chessboard : MonoBehaviour
{
    /// <summary>
    /// �����ϵĸ���
    /// </summary>
    private Grids[,] grids = new Grids[3, 3];

    /// <summary>
    /// ��ͬ��ɫ������
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
    /// ��ʼ�������ϵĸ���
    /// </summary>
    void Init()
    {
        if(transform.childCount != 9)   Debug.LogError("���̵���������������Ϊ9");

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
    /// ����Ƿ���Ҫ����Բ��
    /// </summary>
    /// <param name="obj"></param>
    void MatchRings(object obj)
    {
        if(obj is (Grids, Rings))   //obj��Ԫ�棬��һ��Ԫ�������·���λ�õ�Grids���ڶ���Ԫ�������·��µ�Rings
        {
            //grid�������µķ���Բ���ĸ���
            Grids grid = (((Grids, Rings))obj).Item1;
            int index = grid.transform.GetSiblingIndex();
            int col = index % 3;    //��
            int row = index / 3;    //��

            int count = 0;

            //�ж��Ƿ������������ͬɫԲ��(ͬһ����������������ͬ��ɫ��Բ�������ɾ��ȫ��ͬɫԲ��)
            if(grid.GetRings().Item1 != null && grid.GetRings().Item2 != null && grid.GetRings().Item3 != null &&
                grid.GetRings().Item1.GetRingColor() == grid.GetRings().Item2.GetRingColor() && grid.GetRings().Item1.GetRingColor() == grid.GetRings().Item3.GetRingColor())
            {
                E_RingColor color = grid.GetRings().Item1.GetRingColor();

                //��������ͬɫԲ��
                for (int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        (Rings, Rings, Rings) rings = grids[i,j].GetRings();
                        //�ҵ�����Բ������ɫ
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

            
            //�ж��Ƿ�����һ��һ�л���һб���ϵ�����ͬɫԲ��
            else
            {
                E_RingColor color = (((Grids, Rings))obj).Item2.GetRingColor();     //��ȡ���·��µ�Բ������ɫ
                //�ж��Ƿ��������һ��
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
                //�ж��Ƿ��������һ��
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
                //�ж��Ƿ�����������Խ���
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
                //�ж��Ƿ�����������Խ���
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

                //����һ��
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
                //����һ��
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
                //�������Խ���
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
                //�������Խ���
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

            //�غϽ��������¼����ĸ��·���
            if(count > 2)
            {
                AudioManager.Instance.PlayAudio(1);     //������Ч
                int score = (count - 2) * 10;              
                ScoreManager.Instance.AddScore(score);
            }
        }
        GameManager.Instance.RecordingGameInfo();     //ÿ�غϼ�¼������Ϣ
    }

    /// <summary>
    /// �Ƴ�Բ��
    /// </summary>
    /// <param name="grid"></param>
    void DestroyRing(Rings ring, Grids grid)
    {
        if(ring != null)
        {
            GameObjectPool.Instance.PushObj(ring.gameObject.name, ring.gameObject);
            grid.ResetRing(ring.GetRingSize());     //���ø����ϵ�Բ��
        }

        //��������
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
