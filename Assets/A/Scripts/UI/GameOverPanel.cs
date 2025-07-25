using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 游戏结束面板
/// </summary>
public class GameOverPanel : MonoBehaviour
{
    /// <summary>
    /// 游戏得分文本
    /// </summary>
    public Text scoreText;

    /// <summary>
    /// 历史最高分文本
    /// </summary>
    public Text bestScoreText;

    /// <summary>
    /// 新游戏按钮
    /// </summary>
    public Button newGameBtn;

    private void Start()
    {
        newGameBtn.onClick.AddListener(() => 
        {
            AudioManager.Instance.PlayAudio(0);     //按钮点击音效
            EventCenter.Instance.EventTrigger("RestartGame");
            Close();
        });
    }

    /// <summary>
    /// 关闭页面
    /// </summary>
    void Close()
    {
        UIParent.Instance.GameOverPanelActive(false);
    }

    private void OnEnable()
    {
        scoreText.text = ScoreManager.Instance.GetScore().ToString();
        bestScoreText.text = ScoreManager.Instance.GetBestScore().ToString();
    }
}
