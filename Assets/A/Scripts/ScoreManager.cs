using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 分数管理器
/// </summary>
public class ScoreManager : BaseManager<ScoreManager>
{
    /// <summary>
    /// 本局分数
    /// </summary>
    private int score = 0;

    /// <summary>
    /// 设置分数
    /// </summary>
    /// <param name="score"></param>
    public void SetScore(int score)
    {
        this.score = score;

        //保存一下分数，中途退出时重新进入继续此分数
        PlayerPrefs.SetInt("Score", this.score);

        if (this.score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", this.score);
        }

        EventCenter.Instance.EventTrigger("UpdateScore", score);
    }

    /// <summary>
    /// 获得分数
    /// </summary>
    /// <param name="score">分数</param>
    public void AddScore(int score)
    {
        this.score += score;

        if(this.score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", this.score);
        }

        EventCenter.Instance.EventTrigger("UpdateScore", score);

        //保存一下分数，中途退出时重新进入继续此分数
        PlayerPrefs.SetInt("Score", this.score);
    }

    /// <summary>
    /// 获取本局分数
    /// </summary>
    /// <returns>本局分数</returns>
    public int GetScore()
    {
        return score;
    }

    /// <summary>
    /// 获取最高分
    /// </summary>
    /// <returns></returns>
    public int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore",0);
    }
}
