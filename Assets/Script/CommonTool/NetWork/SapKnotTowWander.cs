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
public class SapKnotTowWander 
{
    //get的url
    public string Law;
    //get成功的回调
    public Action<UnityWebRequest> TowRagtime;
    //get失败的回调
    public Action TowCalm;
    public SapKnotTowWander(string url,Action<UnityWebRequest> success,Action fail)
    {
        Law = url;
        TowRagtime = success;
        TowCalm = fail;
    }
   
}
