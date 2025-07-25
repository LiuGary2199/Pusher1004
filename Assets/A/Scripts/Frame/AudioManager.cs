using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������Ч������
/// </summary>
public class AudioManager : SingletonMono<AudioManager>
{
    /// <summary>
    /// ��Ч�б�
    /// </summary>
    public AudioClip[] soundClips;

    /// <summary>
    /// �õ���Ч�Ƿ���
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
    /// ������Ч
    /// </summary>
    /// <param name="index">��Ч�±�</param>
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
    /// ������Ч
    /// </summary>
    private IEnumerator RecoveryAudio(AudioSource audioSource)
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        GameObjectPool.Instance.PushObj(audioSource.gameObject.name, audioSource.gameObject);
    }
}
