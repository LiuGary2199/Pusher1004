using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����������
/// </summary>
public class ScoreManager : BaseManager<ScoreManager>
{
    /// <summary>
    /// ���ַ���
    /// </summary>
    private int score = 0;

    /// <summary>
    /// ���÷���
    /// </summary>
    /// <param name="score"></param>
    public void SetScore(int score)
    {
        this.score = score;

        //����һ�·�������;�˳�ʱ���½�������˷���
        PlayerPrefs.SetInt("Score", this.score);

        if (this.score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", this.score);
        }

        EventCenter.Instance.EventTrigger("UpdateScore", score);
    }

    /// <summary>
    /// ��÷���
    /// </summary>
    /// <param name="score">����</param>
    public void AddScore(int score)
    {
        this.score += score;

        if(this.score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", this.score);
        }

        EventCenter.Instance.EventTrigger("UpdateScore", score);

        //����һ�·�������;�˳�ʱ���½�������˷���
        PlayerPrefs.SetInt("Score", this.score);
    }

    /// <summary>
    /// ��ȡ���ַ���
    /// </summary>
    /// <returns>���ַ���</returns>
    public int GetScore()
    {
        return score;
    }

    /// <summary>
    /// ��ȡ��߷�
    /// </summary>
    /// <returns></returns>
    public int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore",0);
    }
}
