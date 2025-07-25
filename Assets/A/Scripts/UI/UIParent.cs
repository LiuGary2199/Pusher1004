using UnityEngine;
using DG.Tweening;

/// <summary>
/// UI父物体
/// </summary>
public class UIParent : SingletonMono<UIParent>
{
    void Start()
    {
        // 监听游戏结束事件
        EventCenter.Instance.AddEventListener("GameOver", (o) =>
        {
            GameOverPanelActive(true);
        });
    }

    /// <summary>
    /// 设置面板激活失活状态
    /// </summary>
    /// <param name="isActive">是否激活</param>
    public void SettingPanelActive(bool isActive)
    {
        Transform settingPanel = transform.Find("SettingPanel");
        Transform board = settingPanel.Find("Board");
        if (isActive)
        {
            AudioManager.Instance.PlayAudio(2); //播放游戏结束音效
            settingPanel.gameObject.SetActive(true);
            board.localScale = new Vector3(0.6f, 0.6f, 0);  //board变小
            board.DOScaleX(1, 0.2f).SetEase(Ease.Linear); //board放大
            board.DOScaleY(1, 0.2f).SetEase(Ease.OutBack); //board放大
        }
        else
        {
            board.DOScale(0.6f, 0.2f).SetEase(Ease.InQuad).OnComplete(() => {
                settingPanel.gameObject.SetActive(false);
            }); //board缩小
        }
    }

    /// <summary>
    /// 游戏结束面板激活失活状态
    /// </summary>
    /// <param name="isActive">是否激活</param>
    public void GameOverPanelActive(bool isActive)
    {     
        Transform gameOverPanel = transform.Find("GameOverPanel");
        Transform board = gameOverPanel.Find("Board");
        if (isActive)
        {
            AudioManager.Instance.PlayAudio(2); //播放游戏结束音效
            gameOverPanel.gameObject.SetActive(true);
            board.localScale = new Vector3(0.6f, 0.6f, 0);  //board变小
            board.DOScaleX(1, 0.2f).SetEase(Ease.Linear); //board放大
            board.DOScaleY(1, 0.2f).SetEase(Ease.OutBack); //board放大
        }
        else
        {
            board.DOScale(0.6f, 0.2f).SetEase(Ease.InQuad).OnComplete(() => {
                gameOverPanel.gameObject.SetActive(false);
            }); //board缩小
        }
    }

    /// <summary>
    /// 设置无广告面板激活失活状态
    /// </summary>
    /// <param name="isActive"></param>
    public void NoAdsPanelActive(bool isActive)
    {
        Transform noAdsPanel = transform.Find("NoAdsPanel");
        noAdsPanel.gameObject.SetActive(isActive);
    }
}
