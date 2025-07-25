using UnityEngine;
using UnityEngine.U2D;

/// <summary>
/// 游戏管理器
/// </summary>
public class GameManager : SingletonMono<GameManager>
{
    /// <summary>
    /// 棋盘
    /// </summary>
    public Chessboard chessboard;

    /// <summary>
    /// 垃圾桶
    /// </summary>
    public SpriteRenderer trashCan;

    /// <summary>
    /// 圆环预制体
    /// </summary>
    public GameObject ringPrefab;

    /// <summary>
    /// 圆环图集
    /// </summary>
    public SpriteAtlas ringAtlas;

    /// <summary>
    /// 是否重新开始游戏
    /// </summary>
    private bool isRestart = false;

    public bool isDeleteData = false;

    protected override void Awake()
    {
        base.Awake();

        //清除所有数据
        if (isDeleteData)
        {
            PlayerPrefs.DeleteAll();
        }
    }

    void Start()
    {
        //注册重新开始游戏事件监听
        EventCenter.Instance.AddEventListener("RestartGame", RestartGame);

        RecoverGame();
    }

    /// <summary>
    /// 判断游戏是否结束
    /// </summary>
    /// <param name="ring">新创建的圆环</param>
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
    /// 记录游戏信息
    /// </summary>
    public void RecordingGameInfo()
    {
        //记录棋盘上的圆环信息
        for(int i = 0; i < chessboard.transform.childCount; i++)
        {
            Grids grid = chessboard.transform.GetChild(i).GetComponent<Grids>();
            (Rings, Rings, Rings) rings = grid.GetRings();

            //大环信息
            if(rings.Item1 != null)
            {
                PlayerPrefs.SetInt(i + "_Big", (int)rings.Item1.GetRingColor());
            }
            else
            {
                PlayerPrefs.SetInt(i + "_Big", -1);
            }

            //中环信息
            if(rings.Item2 != null)
            {
                PlayerPrefs.SetInt(i + "_Medium", (int)rings.Item2.GetRingColor());
            }
            else
            {
                PlayerPrefs.SetInt(i + "_Medium", -1);
            }

            //小环信息
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
    /// 恢复游戏
    /// </summary>
    private void RecoverGame()
    {
        if(PlayerPrefs.GetInt("IsGameOver", 0) == 1)
        {
            PlayerPrefs.SetInt("IsGameOver", 0);
            RestartGame(new object());
        }

        //恢复棋盘
        for(int i = 0; i < chessboard.transform.childCount; i++)
        {
            //大圆环
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

            //中圆环
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

            //小圆环
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
        //恢复游戏步数
        RingsCreator.Instance.SetSteps(PlayerPrefs.GetInt("Steps", 0));        

        if (!isRestart)
        {
            //恢复圆环创造器的状态
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
    /// 创建在棋盘上的圆环
    /// </summary>
    private void CreatRingToGrid(E_RingSize size, E_RingColor color, int index)
    {
        GameObject ring = GameObjectPool.Instance.GetObj("Ring", ringPrefab);
        Sprite sprite = ringAtlas.GetSprite("ring_" + color.ToString() + "_" + size.ToString());
        ring.GetComponent<Rings>().SetRing(size, color, sprite, false);     //已经在棋盘上的圆环不允许拖动了
        ring.transform.position = chessboard.transform.GetChild(index).position;

        chessboard.transform.GetChild(index).GetComponent<Grids>().AddRing(ring.GetComponent<Rings>()); 
    }

    /// <summary>
    /// 删除在棋盘上的圆环
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
    /// 重置游戏
    /// </summary>
    private void ResetGame()
    {
        //重置棋盘上的圆环信息
        for (int i = 0; i < chessboard.transform.childCount; i++)
        {
            PlayerPrefs.SetInt(i + "_Big", -1);
            PlayerPrefs.SetInt(i + "_Medium", -1);
            PlayerPrefs.SetInt(i + "_Small", -1);
        }

        //重置当前分数
        PlayerPrefs.SetInt("Score", 0);

        //重置当前步数
        PlayerPrefs.SetInt("Steps", 0);
        Debug.Log("重置游戏成功！" + PlayerPrefs.GetInt("Steps"));

        PlayerPrefs.SetInt("IsGameOver", 0);

        isRestart = true;
    }

    /// <summary>
    /// 重新开始游戏
    /// </summary>
    private void RestartGame(object obj)
    {
        ResetGame();
        RecoverGame();
        ScoreManager.Instance.SetScore(0);
    }
}
