using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking.Types;

public class LullMeUncover : MonoBehaviour
{
    public static LullMeUncover instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Relic;

    //获取IOS函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void openRateUsUrl(string appId);
#endif

    private void Awake()
    {
        instance = this;
    }

    public void EpicAPRyeChilly()
    {
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=" + Relic);
#endif
#if UNITY_IOS
        openRateUsUrl(Relic);
#endif
    }
}
