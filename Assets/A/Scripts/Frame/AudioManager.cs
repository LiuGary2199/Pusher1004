using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 音乐音效管理器
/// </summary>
public class AudioManager : SingletonMono<AudioManager>
{
    /// <summary>
    /// 音效列表
    /// </summary>
    public AudioClip[] soundClips;

    /// <summary>
    /// 得到音效是否静音
    /// </summary>
    public bool SoundIsOn
    {
        get 
        {
            bool soundIsOn = PlayerPrefs.GetInt("SoundIsOn", 1) == 1;
            return soundIsOn;
        }
        set 
        {
            PlayerPrefs.SetInt("SoundIsOn", value? 1 : 0);
        }
    }

    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="index">音效下标</param>
    public void PlayAudio(int index)
    {
        if (!SoundIsOn) return;
        GameObject soundSource = GameObjectPool.Instance.GetObj("soundSource", transform.Find("SoundSource").gameObject);
        AudioSource audioSource = soundSource.GetComponent<AudioSource>();
        audioSource.clip = soundClips[index];
        audioSource.loop = false;
        audioSource.Play();
        StartCoroutine(RecoveryAudio(audioSource));
    }

    /// <summary>
    /// 回收音效
    /// </summary>
    private IEnumerator RecoveryAudio(AudioSource audioSource)
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        GameObjectPool.Instance.PushObj(audioSource.gameObject.name, audioSource.gameObject);
    }
}
