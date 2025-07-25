using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LullMeUncover : MonoBehaviour
{
    public static LullMeUncover instance;
[UnityEngine.Serialization.FormerlySerializedAs("appid")]
    public string Relic;

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
        var url = string.Format(
            "itms-apps://itunes.apple.com/cn/app/id{0}?mt=8&action=write-review",
            Relic);
        Application.OpenURL(url);
#endif
    }
}
