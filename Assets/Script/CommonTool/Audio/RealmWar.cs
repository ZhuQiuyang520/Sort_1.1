/***
 * 
 * 音乐管理器
 * 
 * **/
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealmWar : DeedSingleton<RealmWar>
{
    //音频组件管理队列的对象
    private FilmyEyelidModus FilmyModus;
    // 用于播放背景音乐的音乐源
    private AudioSource m_DyRealm=null;
    //播放音效的音频组件管理列表
    private List<AudioSource> BodeFilmyEyelidHard;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float CheckEmission= 2f; 
    //背景音乐开关
    private bool _ItRealmEndure;
    //音效开关
    private bool _HandleRealmEndure;
    //音乐音量
    private float _ItAttire=1f;
    //音效音量
    private float _HandleAttire=1f;
    string BGM_Tale= "";

    public Dictionary<string, AudioModel> FilmyHabitatVine;

    // 控制背景音乐音量大小
    public float ItAttire    {
        get { 
            return ItRealmEndure ? WedAttire(BGM_Tale) : 0f; 
        }
        set {
            _ItAttire = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float HandleCavity    {
        get { return _HandleAttire; }
        set { 
            _HandleAttire = value;
            YamLopHandleAttire();
        }
    }
    //控制背景音乐开关
    public bool ItRealmEndure    {
        get {

            _ItRealmEndure = TownVoleBenefit.RimHeed("_BgMusicSwitch");
            return _ItRealmEndure; 
        }
        set {
            if(m_DyRealm)
            {
                _ItRealmEndure = value;
                TownVoleBenefit.YamHeed("_BgMusicSwitch", _ItRealmEndure);
                m_DyRealm.volume = ItAttire; 
            }
        }
    }
    public void IllFewBoardLagShow()
    {
        m_DyRealm.volume = 0;
    }
    public void IllFewExploitLagShow()
    {
        m_DyRealm.volume = ItAttire;
    }
    //控制音效开关
    public bool HandleRealmEndure    {
        get {
            _HandleRealmEndure = TownVoleBenefit.RimHeed("_EffectMusicSwitch");
            return _HandleRealmEndure; 
        }
        set {
            _HandleRealmEndure = value;
            TownVoleBenefit.YamHeed("_EffectMusicSwitch", _HandleRealmEndure);
            
        }
    }
    public RealmWar()
    {
        BodeFilmyEyelidHard = new List<AudioSource>();      
    }
    protected override void Awake()
    {
        if (!PlayerPrefs.HasKey("first_music_setBool") || !TownVoleBenefit.RimHeed("first_music_set"))
        {
            TownVoleBenefit.YamHeed("first_music_set", true);
            TownVoleBenefit.YamHeed("_BgMusicSwitch", true);
            TownVoleBenefit.YamHeed("_EffectMusicSwitch", true);
        }
        FilmyModus = new FilmyEyelidModus(this);

        TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
        FilmyHabitatVine = JsonMapper.ToObject<Dictionary<string, AudioModel>>(json.text);
    }
    private void Start()
    {
        StartCoroutine(nameof(CreepToRimFilmyDemocracy));
    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator CreepToRimFilmyDemocracy()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(CheckEmission);
            for (int i = 0; i < BodeFilmyEyelidHard.Count; i++)
            {
                //防止数据越界
                if (i < BodeFilmyEyelidHard.Count)
                {
                    //确保物体存在
                    if (BodeFilmyEyelidHard[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((BodeFilmyEyelidHard[i].clip == null || !BodeFilmyEyelidHard[i].isPlaying))
                        {
                            //返回队列
                            FilmyModus.ToRimFilmyDemocracy(BodeFilmyEyelidHard[i]);
                            //从播放列表中删除
                            BodeFilmyEyelidHard.Remove(BodeFilmyEyelidHard[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        BodeFilmyEyelidHard.Remove(BodeFilmyEyelidHard[i]);
                    }                 
                }            
               
            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void YamLopHandleAttire()
    {
        for (int i = 0; i < BodeFilmyEyelidHard.Count; i++)
        {
            if (BodeFilmyEyelidHard[i] && BodeFilmyEyelidHard[i].isPlaying)
            {
                BodeFilmyEyelidHard[i].volume = _HandleRealmEndure ? _HandleAttire : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void BodeItRoar(object bgName, bool restart = false)
    {

        BGM_Tale = bgName.ToString();
        if (m_DyRealm == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_DyRealm = FilmyModus.RimFilmyDemocracy();
            //开启循环
            m_DyRealm.loop = true;
            //开始播放
            m_DyRealm.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }

        if (!ItRealmEndure)
        {
            m_DyRealm.volume = 0;
        }

        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_DyRealm.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_DyRealm.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        AudioClip clip = Resources.Load<AudioClip>(FilmyHabitatVine[BGM_Tale].filePath);
        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_DyRealm.clip = clip;
            m_DyRealm.volume = ItAttire;
            m_DyRealm.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_DyRealm.isPlaying)
            {
                m_DyRealm.Stop();
            }
            m_DyRealm.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void BodeHandleRoar(object effectName, bool defAudio = true, float volume = 1f)
    {
        if (!HandleRealmEndure)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = FilmyModus.RimFilmyDemocracy();
        if (m_effectMusic.isPlaying) {
            //Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = WedAttire(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        AudioClip clip = Resources.Load<AudioClip>(FilmyHabitatVine[effectName.ToString()].filePath);
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            //UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            FilmyModus.ToRimFilmyDemocracy(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        BodeFilmyEyelidHard.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void BodeIt(RealmCare.UIMusic bgName, bool restart = false)
    {
        BodeItRoar(bgName, restart);
    }

    public void BodeIt(RealmCare.SceneMusic bgName, bool restart = false)
    {
        BodeItRoar(bgName, restart);
    }

    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void BodeHandle(RealmCare.UIMusic effectName, bool defAudio = true, float volume = 1f)
    {
        BodeHandleRoar(effectName, defAudio, volume);
    }

    public void BodeHandle(RealmCare.SceneMusic effectName, bool defAudio = true, float volume = 1f)
    {
        BodeHandleRoar(effectName, defAudio, volume);
    }
    float WedAttire(string name)
    {
        if (FilmyHabitatVine == null)
        {
            TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
            FilmyHabitatVine = JsonMapper.ToObject<Dictionary<string, AudioModel>>(json.text);
        }

        if (FilmyHabitatVine.ContainsKey(name))
        {
             return (float)FilmyHabitatVine[name].volume;

        }
        else
        {
            return 1;
        }
    }

}