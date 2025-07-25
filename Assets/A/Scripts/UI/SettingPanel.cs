using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 设置面板
/// </summary>
public class SettingPanel : MonoBehaviour
{
    /// <summary>
    /// 音效开关
    /// </summary>
    public Button soundBtn;

    public Button rePlayBtn;

    public Button backGame;

    /// <summary>
    /// 开启关闭音效的精灵
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
    /// 关闭设置面板
    /// </summary>
    void Close()
    {
        AudioManager.Instance.PlayAudio(0);     //按钮点击音效
        UIParent.Instance.SettingPanelActive(false);
    }

    /// <summary>
    /// 开启关闭音效
    /// </summary>
    private void RePlay()
    {
        AudioManager.Instance.PlayAudio(0);     //按钮点击音效
        EventCenter.Instance.EventTrigger("RestartGame");
        Close();
    }

    /// <summary>
    /// 切换音效开启状态
    /// </summary>
    private void Sound()
    {
        AudioManager.Instance.PlayAudio(0);     //按钮点击音效
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
    /// 设置音效按钮状态
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
