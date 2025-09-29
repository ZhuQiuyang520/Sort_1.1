/***
 * 
 * 网络请求的get对象
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class FluOntoRimCompel 
{
    //get的url
    public string Mar;
    //get成功的回调
    public Action<UnityWebRequest> RimNouveau;
    //get失败的回调
    public Action RimSilk;
    public FluOntoRimCompel(string url,Action<UnityWebRequest> success,Action fail)
    {
        Mar = url;
        RimNouveau = success;
        RimSilk = fail;
    }
   
}
