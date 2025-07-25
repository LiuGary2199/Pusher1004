/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChinaIonizeBison 
{
    //音乐的管理者
    private GameObject ChinaTip;
    //音乐组件管理队列
    private List<AudioSource> ChinaBotanicalBison;
    //音乐组件默认容器最大值  
    private int YewRigor= 25;
    public ChinaIonizeBison(BrownTip audioMgr)
    {
        ChinaTip = audioMgr.gameObject;
        PassChinaIonizeBison();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void PassChinaIonizeBison()
    {
        ChinaBotanicalBison = new List<AudioSource>();
        for(int i = 0; i < YewRigor; i++)
        {
            SkyChinaIonizeDyeKnapTip();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource SkyChinaIonizeDyeKnapTip()
    {
        AudioSource audio = ChinaTip.AddComponent<AudioSource>();
        ChinaBotanicalBison.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource TowChinaBotanical()
    {
        if (ChinaBotanicalBison.Count > 0)
        {
            AudioSource audio = ChinaBotanicalBison.Find(t => !t.isPlaying);
            if (audio)
            {
                ChinaBotanicalBison.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return SkyChinaIonizeDyeKnapTip();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  SkyChinaIonizeDyeKnapTip();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void UnDueChinaBotanical(AudioSource audio)
    {
        if (ChinaBotanicalBison.Contains(audio)) return;
        if (ChinaBotanicalBison.Count >= YewRigor)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            ChinaBotanicalBison.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
