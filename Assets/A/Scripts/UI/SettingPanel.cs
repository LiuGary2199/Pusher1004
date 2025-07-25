using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �������
/// </summary>
public class SettingPanel : MonoBehaviour
{
    /// <summary>
    /// ��Ч����
    /// </summary>
    public Button soundBtn;

    public Button rePlayBtn;

    public Button backGame;

    /// <summary>
    /// �����ر���Ч�ľ���
    /// </summary>
    public Sprite openSoundSpr;
    public Sprite closeSoundSpr;

    void Start()
    {
        rePlayBtn.onClick.AddListener(RePlay);
        backGame.onClick.AddListener(Close);
        soundBtn.onClick.AddListener(Sound);

        SetSoundBtn();
    }

    /// <summary>
    /// �ر��������
    /// </summary>
    void Close()
    {
        AudioManager.Instance.PlayAudio(0);     //��ť�����Ч
        UIParent.Instance.SettingPanelActive(false);
    }

    /// <summary>
    /// �����ر���Ч
    /// </summary>
    private void RePlay()
    {
        AudioManager.Instance.PlayAudio(0);     //��ť�����Ч
        EventCenter.Instance.EventTrigger("RestartGame");
        Close();
    }

    /// <summary>
    /// �л���Ч����״̬
    /// </summary>
    private void Sound()
    {
        AudioManager.Instance.PlayAudio(0);     //��ť�����Ч
        if (AudioManager.Instance.SoundIsOn)
        {
            AudioManager.Instance.SoundIsOn = false;
            soundBtn.image.sprite = closeSoundSpr;
        }
        else
        {
            AudioManager.Instance.SoundIsOn = true;
            soundBtn.image.sprite = openSoundSpr;
        }
    }

    /// <summary>
    /// ������Ч��ť״̬
    /// </summary>
    private void SetSoundBtn()
    {
        if (AudioManager.Instance.SoundIsOn)
        {
            soundBtn.image.sprite = openSoundSpr;
        }
        else
        {
            soundBtn.image.sprite = closeSoundSpr;
        }
    }
}
