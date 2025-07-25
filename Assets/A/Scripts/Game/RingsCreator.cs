using UnityEngine;
using System;
using UnityEngine.U2D;

/// <summary>
/// Բ��������
/// </summary>
public class RingsCreator : SingletonMono<RingsCreator>
{
    /// <summary>
    /// ������Ϸ�Ļغ���
    /// </summary>
    private int steps = 0;

    /// <summary>
    /// �򵥲���
    /// </summary>
    private int easyStep = 10;

    /// <summary>
    /// ��ģʽ��ɫ����
    /// </summary>
    private int easyColorCount = 3;

    /// <summary>
    /// �еȲ���
    /// </summary>
    private int midStep = 20;

    /// <summary>
    /// �е�ģʽ��ɫ����
    /// </summary>
    private int midColorCount = 5;

    /// <summary>
    /// ��ǰ����������Բ��
    /// </summary>
    private GameObject currRing;

    //����ģʽȫ����ɫ

    /// <summary>
    /// �������ɵ�Բ��
    /// </summary>
    /// <param name="info">Ϊ(E_RingColor, E_RingSize)Ԫ������</param>
    public void Creat(object info = null)
    {
        CreatRing(info);
    }

    private void Start()
    {
        EventCenter.Instance.AddEventListener("CreateNewRing", CreatRing);   //�����µ�Բ���¼�
        EventCenter.Instance.AddEventListener("RecreateRing", Recreate);   //���´���Բ���¼�
    }

    /// <summary>
    /// ���ò���
    /// </summary>
    /// <param name="step"></param>
    public void SetSteps(int step)
    {
        steps = step;
    }

    /// <summary>
    /// ���´���Բ��
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
    /// ����Բ��
    /// </summary>
    private void CreatRing(object obj)
    {
        E_RingColor color;
        E_RingSize size;

        //��ָ����ɫ��С���������
        if (obj == null)
        {
            //�����ɫ
            int colorCount;
            //��ǰ�Ǽ򵥲���
            if (steps <= easyStep)
            {
                colorCount = easyColorCount;
            }
            //��ǰ���еȲ���
            else if (steps <= midStep + easyStep)
            {
                colorCount = midColorCount;
            }
            //��ǰ�����Ѳ���
            else
            {
                colorCount = Enum.GetValues(typeof(E_RingColor)).Length;
            }
            color = (E_RingColor)UnityEngine.Random.Range(0, colorCount);

            //����ߴ�
            size = (E_RingSize)UnityEngine.Random.Range(0, Enum.GetValues(typeof(E_RingSize)).Length);

            //���浱ǰԲ���������ϵ�Բ������
            PlayerPrefs.SetInt("RingsCreator_RingSize", (int)size);
            PlayerPrefs.SetInt("RingsCreator_RingColor", (int)color);
        }
        //�ƶ���ɫ��С������ɫ��Сȥ�������
        else
        {
            (E_RingColor, E_RingSize) ringInfo = ((E_RingColor, E_RingSize))obj;
            color = ringInfo.Item1;
            size = ringInfo.Item2;
            steps--;    //ָ����ɫ������������һ����Ϸʱ�Ѿ������õ�Բ���������Ѿ��Լӹ�
        }

        //����Բ��
        GameObject ring = GameObjectPool.Instance.GetObj("Ring", GameManager.Instance.ringPrefab);
        Sprite sprite = GameManager.Instance.ringAtlas.GetSprite("ring_" + color.ToString() + "_" + size.ToString());
        ring.GetComponent<Rings>().SetRing(size, color, sprite);
        ring.transform.position = transform.position;

        currRing = ring;

        //������Բ���󣬲�����1
        steps++;
        PlayerPrefs.SetInt("Steps", steps);     //�洢��ǰ����

        //�ж��Ƿ������Ϸ
        GameManager.Instance.IsGameOver(ring.GetComponent<Rings>());
    }
}
