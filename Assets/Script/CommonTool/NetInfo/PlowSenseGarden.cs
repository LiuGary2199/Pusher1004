using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class PlowSenseGarden : MailPerformer<PlowSenseGarden>
{
    public string version = "1.2";
    public string LadeLast= SapScanTip.instance.LadeLast;
    //channel
#if UNITY_IOS
    private string Journey= "AppStore";
#elif UNITY_ANDROID
    private string Channel = "GooglePlay";
#else
    private string Channel = "GooglePlay";
#endif


    private void OnApplicationPause(bool pause)
    {
        PlowSenseGarden.GetInstance().WellLadeProbable();
    }
    
    public Text Grid;

    protected override void Awake()
    {
        base.Awake();
        
        version = Application.version;
        StartCoroutine(nameof(LobeFanwise));
    }
    IEnumerator LobeFanwise()
    {
        while (true)
        {
            yield return new WaitForSeconds(120f);
            PlowSenseGarden.GetInstance().WellLadeProbable();
        }
    }
    private void Start()
    {
        if (MoreBulkUncover.TowWok("event_day") != DateTime.Now.Day && MoreBulkUncover.TowSmooth("user_servers_id").Length != 0)
        {
            MoreBulkUncover.GunWok("event_day", DateTime.Now.Day);
        }
    }
    public void CanyToOvenSense(string event_id)
    {
        CanySense(event_id);
    }
    public void WellLadeProbable(List<string> valueList = null)
    {
        if (MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyRimeView) == 0)
        {
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyRimeView, MoreBulkUncover.TowMakeup(CShield.Dy_RimeView));
        }
        if (MoreBulkUncover.TowMakeup(CShield.Dy_Dust) == 0)
        {
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyDust, MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyDust));
        }
        if (valueList == null)
        {
            valueList = new List<string>() { 
                
                LadeBulkUncover.GetInstance().TowRime().ToString(),
                LadeBulkUncover.GetInstance().TowDust().ToString(),
                LadeBulkUncover.GetInstance().TowRelativelyRimeView().ToString(),
                LadeBulkUncover.GetInstance().TowRelativelyDust().ToString(),
                LadeBulkUncover.GetInstance().TowRelativelyCoyote().ToString(),
                MoreBulkUncover.TowWok("DropBallCount").ToString(),
          
            };
        }
        
        if (MoreBulkUncover.TowSmooth(CShield.Dy_PupilRecoilTo) == null)
        {
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", LadeLast);
        wwwForm.AddField("userId", MoreBulkUncover.TowSmooth(CShield.Dy_PupilRecoilTo));

        wwwForm.AddField("gameVersion", version);

        wwwForm.AddField("channel", Journey);

        for (int i = 0; i < valueList.Count; i++)
        {
            wwwForm.AddField("resource" + (i + 1), valueList[i]);
        }



        StartCoroutine(CanyPlow(SapScanTip.instance.BaseLaw + "/api/client/game_progress", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    public void CanySense(string event_id, string p1 = null, string p2 = null, string p3 = null)
    {
        if (Grid != null)
        {
            if (int.Parse(event_id) < 9100 && int.Parse(event_id) >= 9000)
            {
                if (p1 == null)
                {
                    p1 = "";
                }
                Grid.text += "\n" + DateTime.Now.ToString() + "id:" + event_id + "  p1:" + p1;
            }
        }
        if (MoreBulkUncover.TowSmooth(CShield.Dy_PupilRecoilTo) == null)
        {
            SapScanTip.instance.Stage();
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", LadeLast);
        wwwForm.AddField("userId", MoreBulkUncover.TowSmooth(CShield.Dy_PupilRecoilTo));
        //Debug.Log("userId:" + MoreBulkUncover.GetString(CShield.sv_LocalServerId));
        wwwForm.AddField("version", version);
        //Debug.Log("version:" + version);
        wwwForm.AddField("channel", Journey);
        //Debug.Log("channel:" + channal);
        wwwForm.AddField("operateId", event_id);
        Debug.Log("operateId:" + event_id);


        if (p1 != null)
        {
            wwwForm.AddField("params1", p1);
        }
        if (p2 != null)
        {
            wwwForm.AddField("params2", p2);
        }
        if (p3 != null)
        {
            wwwForm.AddField("params3", p3);
        }
        StartCoroutine(CanyPlow(SapScanTip.instance.BaseLaw + "/api/client/log", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    IEnumerator CanyPlow(string _url, WWWForm wwwForm, Action<string> fail, Action<string> success)
    {
        //Debug.Log(SerializeDictionaryToJsonString(dic));
        using (UnityWebRequest request = UnityWebRequest.Post(_url, wwwForm))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isNetworkError)
            {
                fail(request.error);
                NutHormone();
            }
            else
            {
                success(request.downloadHandler.text);
                NutHormone();
            }
        }
    }
    private void NutHormone()
    {
        StopCoroutine("SendGet");
    }


}