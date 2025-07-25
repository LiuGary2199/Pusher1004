using UnityEngine;
using DG.Tweening;

/// <summary>
/// UI������
/// </summary>
public class UIParent : SingletonMono<UIParent>
{
    void Start()
    {
        // ������Ϸ�����¼�
        EventCenter.Instance.AddEventListener("GameOver", (o) =>
        {
            GameOverPanelActive(true);
        });
    }

    /// <summary>
    /// ������弤��ʧ��״̬
    /// </summary>
    /// <param name="isActive">�Ƿ񼤻�</param>
    public void SettingPanelActive(bool isActive)
    {
        Transform settingPanel = transform.Find("SettingPanel");
        Transform board = settingPanel.Find("Board");
        if (isActive)
        {
            AudioManager.Instance.PlayAudio(2); //������Ϸ������Ч
            settingPanel.gameObject.SetActive(true);
            board.localScale = new Vector3(0.6f, 0.6f, 0);  //board��С
            board.DOScaleX(1, 0.2f).SetEase(Ease.Linear); //board�Ŵ�
            board.DOScaleY(1, 0.2f).SetEase(Ease.OutBack); //board�Ŵ�
        }
        else
        {
            board.DOScale(0.6f, 0.2f).SetEase(Ease.InQuad).OnComplete(() => {
                settingPanel.gameObject.SetActive(false);
            }); //board��С
        }
    }

    /// <summary>
    /// ��Ϸ������弤��ʧ��״̬
    /// </summary>
    /// <param name="isActive">�Ƿ񼤻�</param>
    public void GameOverPanelActive(bool isActive)
    {     
        Transform gameOverPanel = transform.Find("GameOverPanel");
        Transform board = gameOverPanel.Find("Board");
        if (isActive)
        {
            AudioManager.Instance.PlayAudio(2); //������Ϸ������Ч
            gameOverPanel.gameObject.SetActive(true);
            board.localScale = new Vector3(0.6f, 0.6f, 0);  //board��С
            board.DOScaleX(1, 0.2f).SetEase(Ease.Linear); //board�Ŵ�
            board.DOScaleY(1, 0.2f).SetEase(Ease.OutBack); //board�Ŵ�
        }
        else
        {
            board.DOScale(0.6f, 0.2f).SetEase(Ease.InQuad).OnComplete(() => {
                gameOverPanel.gameObject.SetActive(false);
            }); //board��С
        }
    }

    /// <summary>
    /// �����޹����弤��ʧ��״̬
    /// </summary>
    /// <param name="isActive"></param>
    public void NoAdsPanelActive(bool isActive)
    {
        Transform noAdsPanel = transform.Find("NoAdsPanel");
        noAdsPanel.gameObject.SetActive(isActive);
    }
}
