/***
 * 
 * 音乐管理器
 * 
 * **/
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownTip : MailPerformer<BrownTip>
{
    //音频组件管理队列的对象
    private ChinaIonizeBison ChinaBison;
    // 用于播放背景音乐的音乐源
    private AudioSource m_ByBrown= null;
    //播放音效的音频组件管理列表
    private List<AudioSource> TossChinaIonizePeal;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float FaunaOrnament= 2f;
    //背景音乐开关
    private bool _MeBrownCoarse;
    //音效开关
    private bool _ClutchBrownCoarse;
    //音乐音量
    private float _MeImpart= 1f;
    //音效音量
    private float _ClutchImpart= 1f;
    string BGM_Hail= "";

    public Dictionary<string, ChinaBring> ChinaWhittleBull;
    public Dictionary<string, AudioClip> ChinaPlanBull;

    public List<string> PraiseHailRoost;
    // 控制背景音乐音量大小
    public float MeImpart    {
        get
        {
            return MeBrownCoarse ? WhyImpart(BGM_Hail) : 0f;
        }
        set
        {
            _MeImpart = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float ClutchSector    {
        get { return _ClutchImpart; }
        set
        {
            _ClutchImpart = value;
            GunEyeClutchImpart();
        }
    }
    //控制背景音乐开关
    public bool MeBrownCoarse    {
        get
        {

            _MeBrownCoarse = MoreBulkUncover.TowWhen("_BgMusicSwitch");
            return _MeBrownCoarse;
        }
        set
        {
            if (m_ByBrown)
            {
                _MeBrownCoarse = value;
                MoreBulkUncover.GunWhen("_BgMusicSwitch", _MeBrownCoarse);
                m_ByBrown.volume = MeImpart;
            }
        }
    }
    public void LadRedFollyAgeSway()
    {
        m_ByBrown.volume = 0;
    }
    public void LadRedDiffuseAgeSway()
    {
        m_ByBrown.volume = MeImpart;
    }
    //控制音效开关
    public bool ClutchBrownCoarse    {
        get
        {
            _ClutchBrownCoarse = MoreBulkUncover.TowWhen("_EffectMusicSwitch");
            return _ClutchBrownCoarse;
        }
        set
        {
            _ClutchBrownCoarse = value;
            MoreBulkUncover.GunWhen("_EffectMusicSwitch", _ClutchBrownCoarse);

        }
    }
    public BrownTip()
    {
        TossChinaIonizePeal = new List<AudioSource>();
    }
    protected override void Awake()
    {
        PraiseHailRoost = new List<string>();
        if (!PlayerPrefs.HasKey("first_music_setBool") || !MoreBulkUncover.TowWhen("first_music_set"))
        {
            MoreBulkUncover.GunWhen("first_music_set", true);
            MoreBulkUncover.GunWhen("_BgMusicSwitch", true);
            MoreBulkUncover.GunWhen("_EffectMusicSwitch", true);
        }
        ChinaBison = new ChinaIonizeBison(this);

        TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
        ChinaWhittleBull = JsonMapper.ToObject<Dictionary<string, ChinaBring>>(json.text);
    }
    private void Start()
    {
        StartCoroutine(nameof(FaunaWeDueChinaBotanical));
    }
    public void PassBrownTip()
    {
        ChinaPlanBull = new Dictionary<string, AudioClip>();
        foreach (string key in ChinaWhittleBull.Keys)
        {
            ChinaPlanBull.Add(key, Resources.Load<AudioClip>(ChinaWhittleBull[key].filePath));
        }

    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator FaunaWeDueChinaBotanical()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(FaunaOrnament);
            for (int i = 0; i < TossChinaIonizePeal.Count; i++)
            {
                //防止数据越界
                if (i < TossChinaIonizePeal.Count)
                {
                    //确保物体存在
                    if (TossChinaIonizePeal[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((TossChinaIonizePeal[i].clip == null || !TossChinaIonizePeal[i].isPlaying))
                        {
                            //返回队列
                            ChinaBison.UnDueChinaBotanical(TossChinaIonizePeal[i]);
                            //从播放列表中删除
                            TossChinaIonizePeal.Remove(TossChinaIonizePeal[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        TossChinaIonizePeal.Remove(TossChinaIonizePeal[i]);
                    }
                }

            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void GunEyeClutchImpart()
    {
        for (int i = 0; i < TossChinaIonizePeal.Count; i++)
        {
            if (TossChinaIonizePeal[i] && TossChinaIonizePeal[i].isPlaying)
            {
                TossChinaIonizePeal[i].volume = _ClutchBrownCoarse ? _ClutchImpart : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void TossMeGold(object bgName, bool restart = false)
    {

        BGM_Hail = bgName.ToString();
        if (m_ByBrown == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_ByBrown = ChinaBison.TowChinaBotanical();
            //开启循环
            m_ByBrown.loop = true;
            //开始播放
            m_ByBrown.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }

        if (!MeBrownCoarse)
        {
            m_ByBrown.volume = 0;
        }

        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_ByBrown.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_ByBrown.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[BGM_Name].filePath);
        AudioClip clip = ChinaPlanBull[BGM_Hail];

        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_ByBrown.clip = clip;
            m_ByBrown.volume = MeImpart;
            m_ByBrown.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_ByBrown.isPlaying)
            {
                m_ByBrown.Stop();
            }
            m_ByBrown.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void TossClutchGold(object effectName, bool defAudio = true, float volume = 1f)
    {
        if (!ClutchBrownCoarse)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = ChinaBison.TowChinaBotanical();
        if (m_effectMusic.isPlaying)
        {
            Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = WhyImpart(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
       // Debug.Log(ChinaWhittleBull[effectName.ToString()].filePath);
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[effectName.ToString()].filePath);
        AudioClip clip = ChinaPlanBull[effectName.ToString()];
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            ChinaBison.UnDueChinaBotanical(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        TossChinaIonizePeal.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
           // Debug.Log("音效播放");
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }
    private void TossClutchGold(object effectName, float start, float end)
    {
        bool defAudio = true;
        float volume = 1f;
        if (!ClutchBrownCoarse)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = ChinaBison.TowChinaBotanical();
        if (m_effectMusic.isPlaying)
        {
            Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = WhyImpart(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[effectName.ToString()].filePath);
        AudioClip clip = ChinaPlanBull[effectName.ToString()];
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            ChinaBison.UnDueChinaBotanical(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        TossChinaIonizePeal.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            Debug.Log("音效播放");
            m_effectMusic.Stop();
            m_effectMusic.SetScheduledStartTime(start);
            m_effectMusic.SetScheduledEndTime(end);
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }
    //播放各种音频剪辑的调用方法，BrownOnce是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void TossMe(BrownOnce.UIMusic bgName, bool restart = false)
    {
        TossMeGold(bgName, restart);
    }

    public void TossMe(BrownOnce.SceneMusic bgName, bool restart = false)
    {
        TossMeGold(bgName, restart);
    }

    public void TossClutch(BrownOnce.UIMusic bgName, float limit, System.Action finish = null)
    {
        TossClutchGold(bgName, limit, finish);
    }

    public void TossClutch(BrownOnce.SceneMusic bgName, float limit, System.Action finish = null)
    {
        TossClutchGold(bgName, limit, finish);
    }


    private void TossClutchGold(object effectName, float limit, System.Action finish = null)
    {
        if (!PraiseHailRoost.Contains(effectName.ToString()))
        {
            if (finish != null)
            {
                finish();
            }
            TossClutchGold(effectName, true, 1);
            PraiseHailRoost.Add(effectName.ToString());
            StartCoroutine(WinnerClutchHail(effectName.ToString(), limit));
        }
    }
    IEnumerator WinnerClutchHail(string name, float limit)
    {
        yield return new WaitForSeconds(limit);
        if (PraiseHailRoost.Contains(name))
        {
            PraiseHailRoost.Remove(name);
        }
    }
    public void TossClutch(BrownOnce.UIMusic effectName, float start, float end)
    {
        TossClutchGold(effectName, start, end);
    }
    //播放各种音频剪辑的调用方法，BrownOnce是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void TossClutch(BrownOnce.UIMusic effectName, bool defAudio = true, float volume = 1f)
    {
        TossClutchGold(effectName, defAudio, volume);
    }

    public void TossClutch(BrownOnce.SceneMusic effectName, bool defAudio = true, float volume = 1f)
    {
        TossClutchGold(effectName, defAudio, volume);
    }
    float WhyImpart(string name)
    {
        if (ChinaWhittleBull == null)
        {
            TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
            ChinaWhittleBull = JsonMapper.ToObject<Dictionary<string, ChinaBring>>(json.text);
        }

        if (ChinaWhittleBull.ContainsKey(name))
        {
            return (float)ChinaWhittleBull[name].volume;

        }
        else
        {
            return 1;
        }
    }

}