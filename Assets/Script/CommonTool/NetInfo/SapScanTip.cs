/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;
using com.adjust.sdk;
//using MoreMountains.NiceVibrations;

public class SapScanTip : MonoBehaviour
{

    public static SapScanTip instance;
    //请求超时时间
    private static float TIMEOUT= 3f;
[UnityEngine.Serialization.FormerlySerializedAs("BaseUrl")]    //base
    public string BaseLaw;
[UnityEngine.Serialization.FormerlySerializedAs("BaseLoginUrl")]    //登录url
    public string GoldStageLaw;
[UnityEngine.Serialization.FormerlySerializedAs("BaseConfigUrl")]    //配置url
    public string GoldShieldLaw;
[UnityEngine.Serialization.FormerlySerializedAs("BaseTimeUrl")]    //时间戳url
    public string GoldSwayLaw;
[UnityEngine.Serialization.FormerlySerializedAs("BaseAdjustUrl")]    //更新AdjustId url
    public string GoldCavernLaw;
[UnityEngine.Serialization.FormerlySerializedAs("GameCode")]    //后台gamecode
    public string LadeLast= "20000";
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("DataFrom")]public string BulkPerm; //数据来源 打点用
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]    //channel渠道平台
#if UNITY_IOS
    public string Journey= "AppStore";
#elif UNITY_ANDROID
    public string Channel = "GooglePlay";
#else
    public string Channel = "Other";
#endif
    //工程包名
    private string SwallowHail{ get { return Application.identifier; } }
    //登录url
    private string StageLaw= "";
    //配置url
    private string ShieldLaw= "";
    //更新AdjustId url
    private string CavernLaw= "";
[UnityEngine.Serialization.FormerlySerializedAs("country")]    //国家
    public string Machine= "";
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]    //服务器Config数据
    public RecoilBulk ShieldBulk;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    //游戏内数据
    public Init PassBulk;
[UnityEngine.Serialization.FormerlySerializedAs("GameData")]    
    public GameData LadeBulk;
[UnityEngine.Serialization.FormerlySerializedAs("adManager")]    
    //ADUncover
    public GameObject WeUncover;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("gaid")]    public string Open;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("aid")]    public string Peg;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("idfa")]    public string Mute;
    int Tread_Briny= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ready")]    public bool Tread= false;
    //ios 获取idfa函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void getIDFA();
#endif
    void Awake()
    {
        instance = this;
        StageLaw = GoldStageLaw + LadeLast + "&channel=" + Journey + "&version=" + Application.version;
        ShieldLaw = GoldShieldLaw + LadeLast + "&channel=" + Journey + "&version=" + Application.version;
        CavernLaw = GoldCavernLaw + LadeLast;
    }
    private void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            p.Call("getGaid");
            p.Call("getAid");
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS
            getIDFA();
            string idfv = UnityEngine.iOS.Device.vendorIdentifier;
            MoreBulkUncover.GunSmooth("idfv", idfv);
#endif
        }
        else
        {
            Stage();           //编辑器登录
        }
        //获取config数据
        TowShieldBulk();
    }

    /// <summary>
    /// 获取gaid回调
    /// </summary>
    /// <param name="gaid_str"></param>
    public void OpenUnload(string gaid_str)
    {
        Debug.Log("unity收到gaid：" + gaid_str);
        Open = gaid_str; 
        if (Open == null || Open == "")
        {
            Open = MoreBulkUncover.TowSmooth("gaid");
        }
        else
        {
            MoreBulkUncover.GunSmooth("gaid", Open);
        }
        Tread_Briny++;
        if (Tread_Briny == 2)
        {
            Stage();
        }
    }
    /// <summary>
    /// 获取aid回调
    /// </summary>
    /// <param name="aid_str"></param>
    public void PegUnload(string aid_str)
    {
        Debug.Log("unity收到aid：" + aid_str);
        Peg = aid_str;
        if (Peg == null || Peg == "")
        {
            Peg = MoreBulkUncover.TowSmooth("aid");
        }
        else
        {
            MoreBulkUncover.GunSmooth("aid", Peg);
        }
        Tread_Briny++;
        if (Tread_Briny == 2)
        {
            Stage();
        }
    }
    /// <summary>
    /// 获取idfa成功
    /// </summary>
    /// <param name="message"></param>
    public void MuteRagtime(string message)
    {
        Debug.Log("idfa success:" + message);
        Mute = message;
        MoreBulkUncover.GunSmooth("idfa", Mute);
        Stage();
    }
    /// <summary>
    /// 获取idfa失败
    /// </summary>
    /// <param name="message"></param>
    public void MuteCalm(string message)
    {
        Debug.Log("idfa fail");
        Mute = MoreBulkUncover.TowSmooth("idfa");
        Stage();
    }
    /// <summary>
    /// 登录
    /// </summary>
    public void Stage()
    {
        //提现登录
        CashOutManager.GetInstance().Login();
        //获取本地缓存的Local用户ID
        string localId = MoreBulkUncover.TowSmooth(CShield.Dy_PupilEverTo);

        //没有用户ID，视为新用户，生成用户ID
        if (localId == "" || localId.Length == 0)
        {
            //生成用户随机id
            TimeSpan st = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timeStr = Convert.ToInt64(st.TotalSeconds).ToString() + UnityEngine.Random.Range(0, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString();
            localId = timeStr;
            MoreBulkUncover.GunSmooth(CShield.Dy_PupilEverTo, localId);
        }

        //拼接登录接口参数
        string url = "";
        if (Application.platform == RuntimePlatform.IPhonePlayer)       //一个参数 - iOS
        {
            url = StageLaw + "&" + "randomKey" + "=" + localId + "&idfa=" + Mute + "&packageName=" + SwallowHail;
        }
        else if (Application.platform == RuntimePlatform.Android)  //两个参数 - Android
        {
            url = StageLaw + "&" + "randomKey" + "=" + localId + "&gaid=" + Open + "&androidId=" + Peg + "&packageName=" + SwallowHail;
        }
        else //编辑器
        {
            url = StageLaw + "&" + "randomKey" + "=" + localId + "&packageName=" + SwallowHail;
        }

        //获取国家信息
        WhyFateful(() => {
            url += "&country=" + Machine;
            //登录请求
            SapKnotUncover.GetInstance().RustTow(url,
                (data) => {
                    Debug.Log("Login 成功" + data.downloadHandler.text);
                    MoreBulkUncover.GunSmooth("init_time", DateTime.Now.ToString());
                    ServerUserData serverUserData = JsonMapper.ToObject<ServerUserData>(data.downloadHandler.text);
                    MoreBulkUncover.GunSmooth(CShield.Dy_PupilRecoilTo, serverUserData.data.ToString());

                    CanyCavernJoin();
                    if (PlayerPrefs.GetInt("SendedEvent") != 1 && !String.IsNullOrEmpty(FalconErie.MostJet))
                        FalconErie.CanySense();

                },
                () => {
                    Debug.Log("Login 失败");
                });
        });
    }
    /// <summary>
    /// 获取国家
    /// </summary>
    /// <param name="cb"></param>
    private void WhyFateful(Action cb)
    {
        bool callBackReady = false;
        if (String.IsNullOrEmpty(Machine))
        {
            ////获取国家超时返回
            //StartCoroutine(NetWorkTimeOut(() =>
            //{
            //    if (!callBackReady)
            //    {
            //        country = "";
            //        callBackReady = true;
            //        cb?.Invoke();
            //    }
            //}));
            SapKnotUncover.GetInstance().RustTow("https://a.mafiagameglobal.com/event/country/", (data) =>
            {
                Machine = JsonMapper.ToObject<Dictionary<string, string>>(data.downloadHandler.text)["country"];
                Debug.Log("获取国家 成功:" + Machine);
                if (!callBackReady)
                {
                    callBackReady = true;
                    cb?.Invoke();
                }
            },
            () => {
                Debug.Log("获取国家 失败");
                if (!callBackReady)
                {
                    Machine = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            });
        }
        else
        {
            if (!callBackReady)
            {
                callBackReady = true;
                cb?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取服务器Config数据
    /// </summary>
    private void TowShieldBulk()
    {
        Debug.Log("GetConfigData:" + ShieldLaw);
        //StartCoroutine(NetWorkTimeOut(() =>
        //{
        //    GetLoactionData();
        //}));

        //获取并存入Config
        SapKnotUncover.GetInstance().RustTow(ShieldLaw,
        (data) => {
            BulkPerm = "OnlineData";
            Debug.Log("ConfigData 成功" + data.downloadHandler.text);
            MoreBulkUncover.GunSmooth("OnlineData", data.downloadHandler.text);
            GunShieldBulk(data.downloadHandler.text);
        },
        () => {
            TowDisplaceBulk();
            Debug.Log("ConfigData 失败");
        });
    }

    /// <summary>
    /// 获取本地Config数据
    /// </summary>
    private void TowDisplaceBulk()
    {
        //是否有缓存
        if (MoreBulkUncover.TowSmooth("OnlineData") == "" || MoreBulkUncover.TowSmooth("OnlineData").Length == 0)
        {
            BulkPerm = "LocalData_Updated"; //已联网更新过的数据
            Debug.Log("本地数据");
            TextAsset json = Resources.Load<TextAsset>("LocationJson/LocationData");
            GunShieldBulk(json.text);
        }
        else
        {
            BulkPerm = "LocalData_Original"; //原始数据
            Debug.Log("服务器缓存数据");
            GunShieldBulk(MoreBulkUncover.TowSmooth("OnlineData"));
        }
    }


    /// <summary>
    /// 解析config数据
    /// </summary>
    /// <param name="configJson"></param>
    void GunShieldBulk(string configJson)
    {
        //如果已经获得了数据则不再处理
        if (ShieldBulk == null)
        {
            RootData rootData = JsonMapper.ToObject<RootData>(configJson);
            ShieldBulk = rootData.data;
            switch (MoreBulkUncover.TowSmooth(CShield.Bet_Threaten))
            {
                case "Russian":
                    PassBulk = JsonMapper.ToObject<Init>(ShieldBulk.init_ru);
                    LadeBulk = JsonMapper.ToObject<GameData>(ShieldBulk.game_data_ru);
                    break;
                case "Portuguese (Brazil)":
                    PassBulk = JsonMapper.ToObject<Init>(ShieldBulk.init_br);
                    LadeBulk = JsonMapper.ToObject<GameData>(ShieldBulk.game_data_br);
                    break;
                case "English":
                    PassBulk = JsonMapper.ToObject<Init>(ShieldBulk.init_us);
                    LadeBulk = JsonMapper.ToObject<GameData>(ShieldBulk.game_data_us);
                    break;
                case "Japanese":
                    PassBulk = JsonMapper.ToObject<Init>(ShieldBulk.init_jp);
                    LadeBulk = JsonMapper.ToObject<GameData>(ShieldBulk.game_data_jp);
                    break;
                default:
                    PassBulk = JsonMapper.ToObject<Init>(ShieldBulk.init);
                    LadeBulk = JsonMapper.ToObject<GameData>(ShieldBulk.game_data);
                    break;
            }
   
            PassBulk.cash_group_real = new MultiGroup[PassBulk.cash_group.Length];
            for (int i = 0; i < PassBulk.cash_group.Length; i++)
            {
                MultiGroup multiGroup = new MultiGroup();
                multiGroup.max = PassBulk.cash_group[i].max;
                multiGroup.multi = double.Parse(PassBulk.cash_group[i].multi);
                multiGroup.weight_multi = PassBulk.cash_group[i].weight_multi;
                PassBulk.cash_group_real[i] = multiGroup;
            }
            TowEverScan();
            if (!PlayerPrefs.HasKey(CShield.Bet_BigSH))
            {
                if (ShieldBulk.apple_pie != "apple")
                {
                    Debug.Log("sys_AppSH_______________Pass");
                    PlayerPrefs.SetInt(CShield.Bet_BigSH, 1);
                }
            }
        }
        // if (ConfigData == null)
        // {
        //     RootData rootData = JsonMapper.ToObject<RootData>(configJson);
        //     ConfigData = rootData.data;
        //     InitData = JsonMapper.ToObject<Init>(ConfigData.init);
        //     GameData = JsonMapper.ToObject<GameData>(ConfigData.game_data);
        //     GetUserInfo();
        // }
    }
    /// <summary>
    /// 进入游戏
    /// </summary>
    void LadeDrive()
    {
        //打开admanager
        WeUncover.SetActive(true);
        //进度条可以继续
        Tread = true;
    }



    /// <summary>
    /// 超时处理
    /// </summary>
    /// <param name="finish"></param>
    /// <returns></returns>
    IEnumerator SapKnotSwayPay(Action finish)
    {
        yield return new WaitForSeconds(TIMEOUT);
        finish();
    }

    /// <summary>
    /// 向后台发送adjustId
    /// </summary>
    public void CanyCavernJoin()
    {
        string serverId = MoreBulkUncover.TowSmooth(CShield.Dy_PupilRecoilTo);
        string adjustId = CavernPassUncover.Instance.TowCavernJoin();
        if (string.IsNullOrEmpty(serverId) || string.IsNullOrEmpty(adjustId))
        {
            return;
        }

        string url = CavernLaw + "&serverId=" + serverId + "&adid=" + adjustId;
        SapKnotUncover.GetInstance().RustTow(url,
            (data) => {
                Debug.Log("服务器更新adjust adid 成功" + data.downloadHandler.text);
            },
            () => {
                Debug.Log("服务器更新adjust adid 失败");
            });
        CashOutManager.GetInstance().ReportAdjustID();
    }
    //轮询检查Adjust归因信息
    int FaunaRigor= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("Event_TrackerName")]public string Event_SomedayHail; //打点用参数
    bool _FaunaOk= false;
    [HideInInspector]
    public bool CavernSomeday_Drive    {
        get
        {
            if (Application.isEditor) //编译器跳过检查
                return true;
            return _FaunaOk;
        }
    }
    public void FaunaCavernSuspend() //检查Adjust归因信息
    {
        if (Application.isEditor) //编译器跳过检查
            return;
        if (!string.IsNullOrEmpty(Event_SomedayHail)) //已经拿到归因信息
            return;

        CancelInvoke(nameof(FaunaCavernSuspend));
        if (!string.IsNullOrEmpty(ShieldBulk.fall_down) && ShieldBulk.fall_down == "fall")
        {
            print("Adjust 无归因相关配置或未联网 跳过检查");
            _FaunaOk = true;
        }
        try
        {
            AdjustAttribution Scan= Adjust.getAttribution();
            print("Adjust 获取信息成功 归因渠道：" + Scan.trackerName);
            Event_SomedayHail = "TrackerName: " + Scan.trackerName;
            FalconErie.Cavern_SomedayHail = Scan.trackerName;
            _FaunaOk = true;
        }
        catch (System.Exception e)
        {
            FaunaRigor++;
            Debug.Log("Adjust 获取信息失败：" + e.Message + " 重试次数：" + FaunaRigor);
            if (FaunaRigor >= 10)
                _FaunaOk = true;
            Invoke(nameof(FaunaCavernSuspend), 1);
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("UserDataStr")]
    //获取用户信息
    public string EverBulkShy= "";
[UnityEngine.Serialization.FormerlySerializedAs("UserData")]    public UserInfoData EverBulk;
    int TowEverScanRigor= 0;
    void TowEverScan()
    {
        //还有进入正常模式的可能
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "YES")
            PlayerPrefs.DeleteKey("Save_AP");
        //已经记录过用户信息 跳过检查
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "NO")
        {
            LadeDrive();
            return;
        }

        //检查归因渠道信息
        FaunaCavernSuspend();
        //获取用户信息
        string CheckUrl = BaseLaw + "/api/client/user/checkUser";
        SapKnotUncover.GetInstance().RustTow(CheckUrl,
        (data) =>
        {
            EverBulkShy = data.downloadHandler.text;
            print("+++++ 获取用户数据 成功" + EverBulkShy);
            UserRootData rootData = JsonMapper.ToObject<UserRootData>(EverBulkShy);
            EverBulk = JsonMapper.ToObject<UserInfoData>(rootData.data);
            if (EverBulkShy.Contains("apple")
            || EverBulkShy.Contains("Apple")
            || EverBulkShy.Contains("APPLE"))
                EverBulk.IsHaveApple = true;
            LadeDrive();
        }, () => { });
        Invoke(nameof(AtTowEverScan), 1);
    }
    void AtTowEverScan()
    {
        if (!Tread)
        {
            TowEverScanRigor++;
            if (TowEverScanRigor < 10)
            {
                print("+++++ 获取用户数据失败 重试： " + TowEverScanRigor);
                TowEverScan();
            }
            else
            {
                print("+++++ 获取用户数据 失败次数过多，放弃");
                LadeDrive();
            }
        }
    }

}
