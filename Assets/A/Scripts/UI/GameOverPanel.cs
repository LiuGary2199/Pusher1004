using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��Ϸ�������
/// </summary>
public class GameOverPanel : MonoBehaviour
{
    /// <summary>
    /// ��Ϸ�÷��ı�
    /// </summary>
    public Text scoreText;

    /// <summary>
    /// ��ʷ��߷��ı�
    /// </summary>
    public Text bestScoreText;

    /// <summary>
    /// ����Ϸ��ť
    /// </summary>
    public Button newGameBtn;

    private void Start()
    {
        newGameBtn.onClick.AddListener(() => 
        {
            AudioManager.Instance.PlayAudio(0);     //��ť�����Ч
            EventCenter.Instance.EventTrigger("RestartGame");
            Close();
        });
    }

    /// <summary>
    /// �ر�ҳ��
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
