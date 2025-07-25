using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// 游戏页面
/// </summary>
public class GamePanel : MonoBehaviour
{
    /// <summary>
    /// 本局分数
    /// </summary>
    public Text scoreText;

    /// <summary>
    /// 历史最高分
    /// </summary>
    public Text bestScoreText;

    /// <summary>
    /// 设置按钮
    /// </summary>
    public Button settingBtn;

    /// <summary>
    /// 回收站按钮
    /// </summary>
    public Button trashCanBtn;

    private void Start()
    {
        settingBtn.onClick.AddListener(() =>
        {
            UIParent.Instance.SettingPanelActive(true);
            AudioManager.Instance.PlayAudio(0);     //按钮点击音效
        });

        trashCanBtn.onClick.AddListener(() =>
        {
            AudioManager.Instance.PlayAudio(0);     //按钮点击音效

            A_ADManager.Instance.playRewardVideo((b) =>
            {
                if (b)
                {
                    EventCenter.Instance.EventTrigger("RecreateRing");
                }
            }); 
        });

        //注册分数更新事件
        EventCenter.Instance.AddEventListener("UpdateScore", ShowScore);
        ScoreManager.Instance.SetScore(PlayerPrefs.GetInt("Score", 0));
    }

    /// <summary>
    /// 显示分数
    /// </summary>
    /// <param name="score"></param>
    private void ShowScore(object score)
    {
        int oldScore = int.Parse(scoreText.text);   //旧的分数
        int newScore = ScoreManager.Instance.GetScore();   //新的分数
        DOTween.To(() => oldScore, x =>
        {
            scoreText.text = x.ToString();
        }, newScore, 0.5f);
        bestScoreText.text = "BEST " + ScoreManager.Instance.GetBestScore().ToString();
    }
}
