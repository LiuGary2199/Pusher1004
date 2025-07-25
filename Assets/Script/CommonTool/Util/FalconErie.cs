using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalconErie
{
    [HideInInspector] public static string Cavern_SomedayHail; //归因渠道名称 由SapScanTip的CheckAdjustNetwork方法赋值
    static string More_AP; //ApplePie的本地存档 存储第一次进入状态 未来不再受ApplePie开关影响
    static string VerifyIsleHail= "pie"; //正常模式名称
    static string Wirephoto; //距离黑名单位置的距离 打点用
    static string Absurd; //进审理由 打点用
    [HideInInspector] public static string MostJet= ""; //判断流程 打点用

    public static bool MyUnder()
    {
        //return false;
        //测试
        //return true;
        ///return true;
        if (PlayerPrefs.HasKey("Save_AP"))  //优先使用本地存档
            More_AP = PlayerPrefs.GetString("Save_AP");
        if (string.IsNullOrEmpty(More_AP)) //无本地存档 读取网络数据
            FaunaOregonBulk();

        if (More_AP != "P")
            return true;
        else
            return false;
    }

    public static bool GetSkin()
    {
       // return true;
        bool newskin = false;
        if(SapScanTip.instance.ShieldBulk.game_skin == "a")
        {
            newskin = true;
        }
        else
        {
            newskin = false;
        }
        return newskin;
    }

    static void FaunaOregonBulk() //读取网络数据 判断进入哪种游戏模式
    {
        string OtherChance = "NO"; //进审之后 是否还有可能变正常
        More_AP = "P";
        if (SapScanTip.instance.ShieldBulk.apple_pie != VerifyIsleHail) //审模式 
        {
            OtherChance = "YES";
            More_AP = "A";
            if (string.IsNullOrEmpty(Absurd))
                Absurd = "ApplePie";
        }
        MostJet = "0:" + More_AP;
        //判断地理位置
        if (!string.IsNullOrEmpty(SapScanTip.instance.ShieldBulk.LocationList) && SapScanTip.instance.EverBulk != null)
        {
            //判断运营商信息
            if (SapScanTip.instance.EverBulk.IsHaveApple)
            {
                More_AP = "A";
                if (string.IsNullOrEmpty(Absurd))
                    Absurd = "HaveApple";
            }
            MostJet += "  1:" + More_AP;
            //判断经纬度
            LocationData[] LocationDatas = LitJson.JsonMapper.ToObject<LocationData[]>(SapScanTip.instance.ShieldBulk.LocationList);
            if (LocationDatas != null && LocationDatas.Length > 0 && SapScanTip.instance.EverBulk.lat != 0 && SapScanTip.instance.EverBulk.lon != 0)
            {
                for (int i = 0; i < LocationDatas.Length; i++)
                {
                    float Distance = TowGrandeur((float)LocationDatas[i].X, (float)LocationDatas[i].Y,
                    (float)SapScanTip.instance.EverBulk.lat, (float)SapScanTip.instance.EverBulk.lon);
                    Wirephoto += Distance.ToString() + ",";
                    if (Distance <= LocationDatas[i].Radius)
                    {
                        More_AP = "A";
                        if (string.IsNullOrEmpty(Absurd))
                            Absurd = "Location";
                        break;
                    }
                }
            }
            MostJet += "  2:" + More_AP;
            //判断城市
            string[] HeiCityList = LitJson.JsonMapper.ToObject<string[]>(SapScanTip.instance.ShieldBulk.HeiCity);
            if (!string.IsNullOrEmpty(SapScanTip.instance.EverBulk.regionName) && HeiCityList != null && HeiCityList.Length > 0)
            {
                for (int i = 0; i < HeiCityList.Length; i++)
                {
                    if (HeiCityList[i] == SapScanTip.instance.EverBulk.regionName
                    || HeiCityList[i] == SapScanTip.instance.EverBulk.city)
                    {
                        More_AP = "A";
                        if (string.IsNullOrEmpty(Absurd))
                            Absurd = "City";
                        break;
                    }
                }
            }
            MostJet += "  3:" + More_AP;
            //判断黑名单
            string[] HeiIPs = LitJson.JsonMapper.ToObject<string[]>(SapScanTip.instance.ShieldBulk.HeiNameList);
            if (HeiIPs != null && HeiIPs.Length > 0 && !string.IsNullOrEmpty(SapScanTip.instance.EverBulk.query))
            {
                string[] IpNums = SapScanTip.instance.EverBulk.query.Split('.');
                for (int i = 0; i < HeiIPs.Length; i++)
                {
                    string[] HeiIpNums = HeiIPs[i].Split('.');
                    bool isMatch = true;
                    for (int j = 0; j < HeiIpNums.Length; j++) //黑名单IP格式可能是任意位数 根据位数逐个比对
                    {
                        if (HeiIpNums[j] != IpNums[j])
                            isMatch = false;
                    }
                    if (isMatch)
                    {
                        More_AP = "A";
                        if (string.IsNullOrEmpty(Absurd))
                            Absurd = "IP";
                        break;
                    }
                }
            }
            MostJet += "  4:" + More_AP;
        }
        MostJet += "  5:" + More_AP;
        //判断自然量
        if (!string.IsNullOrEmpty(SapScanTip.instance.ShieldBulk.fall_down))
        {
            if (SapScanTip.instance.ShieldBulk.fall_down == "bottom") //仅判断Organic
            {
                if (Cavern_SomedayHail == "Organic") //打开自然量 且 归因渠道是Organic 审模式
                {
                    More_AP = "A";
                    if (string.IsNullOrEmpty(Absurd))
                        Absurd = "FallDown";
                }
            }
            else if (SapScanTip.instance.ShieldBulk.fall_down == "down") //判断Organic + NoUserConsent
            {
                if (Cavern_SomedayHail == "Organic" || Cavern_SomedayHail == "No User Consent") //打开自然量 且 归因渠道是Organic或NoUserConsent 审模式
                {
                    More_AP = "A";
                    if (string.IsNullOrEmpty(Absurd))
                        Absurd = "FallDown";
                }
            }
        }
        MostJet += "  6:" + More_AP;

        PlayerPrefs.SetString("Save_AP", More_AP);
        PlayerPrefs.SetString("OtherChance", OtherChance);
        //打点
        if (!string.IsNullOrEmpty(MoreBulkUncover.TowSmooth(CShield.Dy_PupilRecoilTo)))
            CanySense();


        //本地log
        Debug.Log("++++++判断流程： " + MostJet);
        if (SapScanTip.instance.EverBulk != null)
        {
            string Scan= "游戏模式：" + (More_AP == "A" ? "审" : "正常")
                       + "\n进审理由：" + Absurd
                       + "\n开关： " + SapScanTip.instance.ShieldBulk.apple_pie
                       + "\n是否包含苹果： " + SapScanTip.instance.EverBulk.IsHaveApple
                       + "\n位置黑名单： " + SapScanTip.instance.ShieldBulk.LocationList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户位置： " + SapScanTip.instance.EverBulk.lat + "," + SapScanTip.instance.EverBulk.lon
                       + "\n黑名单城市： " + SapScanTip.instance.ShieldBulk.HeiCity?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户城市: " + SapScanTip.instance.EverBulk.regionName
                       + "\n与黑名单地点距离： " + Wirephoto
                       + "\nIP黑名单： " + SapScanTip.instance.ShieldBulk.HeiNameList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户IP： " + SapScanTip.instance.EverBulk.query
                       + "\n自然量开关： " + SapScanTip.instance.ShieldBulk.fall_down
                       + "\n归因渠道： " + Cavern_SomedayHail
                       + "\n接口返回信息： " + SapScanTip.instance.EverBulkShy;
            Debug.Log("++++++" + Scan);
        }
    }
    static float TowGrandeur(float lat1, float lon1, float lat2, float lon2)
    {
        const float R = 6371f; // 地球半径，单位：公里
        float latDistance = Mathf.Deg2Rad * (lat2 - lat1);
        float lonDistance = Mathf.Deg2Rad * (lon2 - lon1);
        float a = Mathf.Sin(latDistance / 2) * Mathf.Sin(latDistance / 2)
               + Mathf.Cos(Mathf.Deg2Rad * lat1) * Mathf.Cos(Mathf.Deg2Rad * lat2)
               * Mathf.Sin(lonDistance / 2) * Mathf.Sin(lonDistance / 2);
        float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        return R * c * 1000; // 距离，单位：米
    }

    public static void CanySense()
    {
        //打点
        if (SapScanTip.instance.EverBulk != null)
        {
            string Info1 = "[" + (More_AP == "A" ? "审" : "正常")
                                       + "] [" + Absurd + "]";
            string Info2 = "[" + SapScanTip.instance.EverBulk.lat + "," + SapScanTip.instance.EverBulk.lon
                           + "] [" + SapScanTip.instance.EverBulk.regionName
                           + "] [" + Wirephoto + "]";
            string Info3 = "[" + SapScanTip.instance.EverBulk.query
                           + "] [" + Cavern_SomedayHail + "]";
            PlowSenseGarden.GetInstance().CanySense("3000", Info1, Info2, Info3);
        }
        else
            PlowSenseGarden.GetInstance().CanySense("3000", "No UserData");
        PlowSenseGarden.GetInstance().CanySense("3001", (More_AP == "A" ? "审" : "正常"), MostJet, SapScanTip.instance.BulkPerm);
        PlayerPrefs.SetInt("SendedEvent", 1);
    }

    public static bool MyDomain()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool MyEndanger()
    {
        return Screen.height > Screen.width;
    }


}
