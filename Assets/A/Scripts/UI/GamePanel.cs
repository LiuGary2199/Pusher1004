using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// ��Ϸҳ��
/// </summary>
public class GamePanel : MonoBehaviour
{
    /// <summary>
    /// ���ַ���
    /// </summary>
    public Text scoreText;

    /// <summary>
    /// ��ʷ��߷�
    /// </summary>
    public Text bestScoreText;

    /// <summary>
    /// ���ð�ť
    /// </summary>
    public Button settingBtn;

    /// <summary>
    /// ����վ��ť
    /// </summary>
    public Button trashCanBtn;

    private void Start()
    {
        settingBtn.onClick.AddListener(() =>
        {
            UIParent.Instance.SettingPanelActive(true);
            AudioManager.Instance.PlayAudio(0);     //��ť�����Ч
        });

        trashCanBtn.onClick.AddListener(() =>
        {
            AudioManager.Instance.PlayAudio(0);     //��ť�����Ч

            A_ADManager.Instance.playRewardVideo((b) =>
            {
                if (b)
                {
                    EventCenter.Instance.EventTrigger("RecreateRing");
                }
            }); 
        });

        //ע����������¼�
        EventCenter.Instance.AddEventListener("UpdateScore", ShowScore);
        ScoreManager.Instance.SetScore(PlayerPrefs.GetInt("Score", 0));
    }

    /// <summary>
    /// ��ʾ����
    /// </summary>
    /// <param name="score"></param>
    private void ShowScore(object score)
    {
        int oldScore = int.Parse(scoreText.text);   //�ɵķ���
        int newScore = ScoreManager.Instance.GetScore();   //�µķ���
        DOTween.To(() => oldScore, x =>
        {
            scoreText.text = x.ToString();
        }, newScore, 0.5f);
        bestScoreText.text = "BEST " + ScoreManager.Instance.GetBestScore().ToString();
    }
}
