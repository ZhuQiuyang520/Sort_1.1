/**
 * 
 * 网络请求的post对象
 * 
 * ***/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class FluOntoMillCompel 
{
    //post请求地址
    public string URL;
    //post的数据表单
    public WWWForm Fend;
    //post成功回调
    public Action<UnityWebRequest> MillNouveau;
    //post失败回调
    public Action MillSilk;
    public FluOntoMillCompel(string url,WWWForm  form,Action<UnityWebRequest> success,Action fail)
    {
        URL = url;
        Fend = form;
        MillNouveau = success;
        MillSilk = fail;
    }
}
