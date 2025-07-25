using UnityEngine;
using UnityEngine.U2D;

/// <summary>
/// ��Ϸ������
/// </summary>
public class GameManager : SingletonMono<GameManager>
{
    /// <summary>
    /// ����
    /// </summary>
    public Chessboard chessboard;

    /// <summary>
    /// ����Ͱ
    /// </summary>
    public SpriteRenderer trashCan;

    /// <summary>
    /// Բ��Ԥ����
    /// </summary>
    public GameObject ringPrefab;

    /// <summary>
    /// Բ��ͼ��
    /// </summary>
    public SpriteAtlas ringAtlas;

    /// <summary>
    /// �Ƿ����¿�ʼ��Ϸ
    /// </summary>
    private bool isRestart = false;

    public bool isDeleteData = false;

    protected override void Awake()
    {
        base.Awake();

        //�����������
        if (isDeleteData)
        {
            PlayerPrefs.DeleteAll();
        }
    }

    void Start()
    {
        //ע�����¿�ʼ��Ϸ�¼�����
        EventCenter.Instance.AddEventListener("RestartGame", RestartGame);

        RecoverGame();
    }

    /// <summary>
    /// �ж���Ϸ�Ƿ����
    /// </summary>
    /// <param name="ring">�´�����Բ��</param>
    /// <returns></returns>
    public void IsGameOver(Rings ring)
    {
        E_RingSize size = ring.GetRingSize();
        for(int i = 0; i < chessboard.transform.childCount; i++)
        {
            Grids grid = chessboard.transform.GetChild(i).GetComponent<Grids>();
            (Rings, Rings, Rings) rings = grid.GetRings();
            
            if(size == E_RingSize.Big && rings.Item1 == null) return;
            if(size == E_RingSize.Medium && rings.Item2 == null) return;
            if(size == E_RingSize.Small && rings.Item3 == null) return;
        }
        EventCenter.Instance.EventTrigger("GameOver");
        PlayerPrefs.SetInt("IsGameOver", 1);
    }

    /// <summary>
    /// ��¼��Ϸ��Ϣ
    /// </summary>
    public void RecordingGameInfo()
    {
        //��¼�����ϵ�Բ����Ϣ
        for(int i = 0; i < chessboard.transform.childCount; i++)
        {
            Grids grid = chessboard.transform.GetChild(i).GetComponent<Grids>();
            (Rings, Rings, Rings) rings = grid.GetRings();

            //����Ϣ
            if(rings.Item1 != null)
            {
                PlayerPrefs.SetInt(i + "_Big", (int)rings.Item1.GetRingColor());
            }
            else
            {
                PlayerPrefs.SetInt(i + "_Big", -1);
            }

            //�л���Ϣ
            if(rings.Item2 != null)
            {
                PlayerPrefs.SetInt(i + "_Medium", (int)rings.Item2.GetRingColor());
            }
            else
            {
                PlayerPrefs.SetInt(i + "_Medium", -1);
            }

            //С����Ϣ
            if(rings.Item3 != null)
            {
                PlayerPrefs.SetInt(i + "_Small", (int)rings.Item3.GetRingColor());
            }
            else
            {
                PlayerPrefs.SetInt(i + "_Small", -1);
            }
        }
    }

    /// <summary>
    /// �ָ���Ϸ
    /// </summary>
    private void RecoverGame()
    {
        if(PlayerPrefs.GetInt("IsGameOver", 0) == 1)
        {
            PlayerPrefs.SetInt("IsGameOver", 0);
            RestartGame(new object());
        }

        //�ָ�����
        for(int i = 0; i < chessboard.transform.childCount; i++)
        {
            //��Բ��
            int big = PlayerPrefs.GetInt(i + "_Big", -1);
            if(big != -1)
            {
                E_RingColor bigColor = (E_RingColor)PlayerPrefs.GetInt(i + "_Big", -1);
                CreatRingToGrid(E_RingSize.Big, bigColor, i);
            }
            else if(big == -1 && chessboard.transform.GetChild(i).GetComponent<Grids>().GetRings().Item1 != null)
            {
                DeleteRingFromGrid(chessboard.transform.GetChild(i).GetComponent<Grids>(), E_RingSize.Big);
            }

            //��Բ��
            int medium = PlayerPrefs.GetInt(i + "_Medium", -1);
            if(medium != -1)
            {
                E_RingColor mediumColor = (E_RingColor)PlayerPrefs.GetInt(i + "_Medium", -1);
                CreatRingToGrid(E_RingSize.Medium, mediumColor, i);
            }
            else if (medium == -1 && chessboard.transform.GetChild(i).GetComponent<Grids>().GetRings().Item2 != null)
            {
                DeleteRingFromGrid(chessboard.transform.GetChild(i).GetComponent<Grids>(), E_RingSize.Medium);
            }

            //СԲ��
            int small = PlayerPrefs.GetInt(i + "_Small", -1);
            if(small != -1)
            {
                E_RingColor smallColor = (E_RingColor)PlayerPrefs.GetInt(i + "_Small", -1);
                CreatRingToGrid(E_RingSize.Small, smallColor, i);
            }
            else if(small == -1 && chessboard.transform.GetChild(i).GetComponent<Grids>().GetRings().Item3 != null)
            {
                DeleteRingFromGrid(chessboard.transform.GetChild(i).GetComponent<Grids>(), E_RingSize.Small);
            }
        }
        //�ָ���Ϸ����
        RingsCreator.Instance.SetSteps(PlayerPrefs.GetInt("Steps", 0));        

        if (!isRestart)
        {
            //�ָ�Բ����������״̬
            E_RingColor currColor = (E_RingColor)PlayerPrefs.GetInt("RingsCreator_RingColor", 0);
            E_RingSize currSize = (E_RingSize)PlayerPrefs.GetInt("RingsCreator_RingSize", 0);
            RingsCreator.Instance.Creat((currColor, currSize));
        }
        else
        {
            RingsCreator.Instance.Recreate(new object());
            isRestart = false;
        }
    }

    /// <summary>
    /// �����������ϵ�Բ��
    /// </summary>
    private void CreatRingToGrid(E_RingSize size, E_RingColor color, int index)
    {
        GameObject ring = GameObjectPool.Instance.GetObj("Ring", ringPrefab);
        Sprite sprite = ringAtlas.GetSprite("ring_" + color.ToString() + "_" + size.ToString());
        ring.GetComponent<Rings>().SetRing(size, color, sprite, false);     //�Ѿ��������ϵ�Բ���������϶���
        ring.transform.position = chessboard.transform.GetChild(index).position;

        chessboard.transform.GetChild(index).GetComponent<Grids>().AddRing(ring.GetComponent<Rings>()); 
    }

    /// <summary>
    /// ɾ���������ϵ�Բ��
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="size"></param>
    private void DeleteRingFromGrid(Grids grid, E_RingSize size)
    {
        GameObject ring;
        if(size == E_RingSize.Big)
        {
            ring = grid.GetRings().Item1.gameObject;
        }
        else if(size == E_RingSize.Medium)
        {
            ring = grid.GetRings().Item2.gameObject;
        }
        else
        {
            ring = grid.GetRings().Item3.gameObject;
        }

        GameObjectPool.Instance.PushObj(ring.name, ring);
        grid.ResetRing(size);
    }

    /// <summary>
    /// ������Ϸ
    /// </summary>
    private void ResetGame()
    {
        //���������ϵ�Բ����Ϣ
        for (int i = 0; i < chessboard.transform.childCount; i++)
        {
            PlayerPrefs.SetInt(i + "_Big", -1);
            PlayerPrefs.SetInt(i + "_Medium", -1);
            PlayerPrefs.SetInt(i + "_Small", -1);
        }

        //���õ�ǰ����
        PlayerPrefs.SetInt("Score", 0);

        //���õ�ǰ����
        PlayerPrefs.SetInt("Steps", 0);
        Debug.Log("������Ϸ�ɹ���" + PlayerPrefs.GetInt("Steps"));

        PlayerPrefs.SetInt("IsGameOver", 0);

        isRestart = true;
    }

    /// <summary>
    /// ���¿�ʼ��Ϸ
    /// </summary>
    private void RestartGame(object obj)
    {
        ResetGame();
        RecoverGame();
        ScoreManager.Instance.SetScore(0);
    }
}
