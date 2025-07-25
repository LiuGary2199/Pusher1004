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
public class SapKnotPlowWander 
{
    //post请求地址
    public string URL;
    //post的数据表单
    public WWWForm Peak;
    //post成功回调
    public Action<UnityWebRequest> PlowRagtime;
    //post失败回调
    public Action PlowCalm;
    public SapKnotPlowWander(string url,WWWForm  form,Action<UnityWebRequest> success,Action fail)
    {
        URL = url;
        Peak = form;
        PlowRagtime = success;
        PlowCalm = fail;
    }
}
