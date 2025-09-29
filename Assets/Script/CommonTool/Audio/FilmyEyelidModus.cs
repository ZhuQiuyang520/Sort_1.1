/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FilmyEyelidModus 
{
    //音乐的管理者
    private GameObject FilmyWar;
    //音乐组件管理队列
    private List<AudioSource> FilmyDemocracyModus;
    //音乐组件默认容器最大值  
    private int WitCreep= 25;
    public FilmyEyelidModus(RealmWar audioMgr)
    {
        FilmyWar = audioMgr.gameObject;
        JadeFilmyEyelidModus();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void JadeFilmyEyelidModus()
    {
        FilmyDemocracyModus = new List<AudioSource>();
        for(int i = 0; i < WitCreep; i++)
        {
            KeyFilmyEyelidForBullWar();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource KeyFilmyEyelidForBullWar()
    {
        AudioSource audio = FilmyWar.AddComponent<AudioSource>();
        FilmyDemocracyModus.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource RimFilmyDemocracy()
    {
        if (FilmyDemocracyModus.Count > 0)
        {
            AudioSource audio = FilmyDemocracyModus.Find(t => !t.isPlaying);
            if (audio)
            {
                FilmyDemocracyModus.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return KeyFilmyEyelidForBullWar();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  KeyFilmyEyelidForBullWar();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void ToRimFilmyDemocracy(AudioSource audio)
    {
        if (FilmyDemocracyModus.Contains(audio)) return;
        if (FilmyDemocracyModus.Count >= WitCreep)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            FilmyDemocracyModus.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
