using System.Collections;
using System.Collections.Generic;
using com.adjust.sdk;
using UnityEngine;
using UnityEngine.UI;

public class LadePlank : GoldUIStain
{
    public static LadePlank Instance;
[UnityEngine.Serialization.FormerlySerializedAs("goldBtn")]
    public Button CodeWeb;
[UnityEngine.Serialization.FormerlySerializedAs("cashBtn")]    public Button SinkWeb;
[UnityEngine.Serialization.FormerlySerializedAs("amazonBtn")]    public Button UnseenWeb;
[UnityEngine.Serialization.FormerlySerializedAs("coinImg")]
    public Image BondMad;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    public Image SinkMad;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public Image UnseenMad;
[UnityEngine.Serialization.FormerlySerializedAs("ballImg")]    public Image HalfMad;
[UnityEngine.Serialization.FormerlySerializedAs("cashBar")]
    public GameObject SinkRag;
[UnityEngine.Serialization.FormerlySerializedAs("coinBar")]    public GameObject BondRag;
[UnityEngine.Serialization.FormerlySerializedAs("amazonBar")]    public GameObject UnseenRag;
[UnityEngine.Serialization.FormerlySerializedAs("ballBar")]    public GameObject HalfRag;
[UnityEngine.Serialization.FormerlySerializedAs("NormalWindow")]
    public GameObject VerifyRugged;
[UnityEngine.Serialization.FormerlySerializedAs("PassWindow")]    public GameObject JazzRugged;
[UnityEngine.Serialization.FormerlySerializedAs("newgoldBtn")]    public Button BuffaloWeb;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeBar")]    public GameObject ListenerRag;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeNumText")]    public Text ListenerGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("NewSettingBtn")]    public Button JobWhittleWeb;
[UnityEngine.Serialization.FormerlySerializedAs("NewGoldNumText")]    public Text JobRimeGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("goldNumText")]
    public Text CodeGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("cashNumText")]    public Text SinkGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("amazonNumText")]    public Text UnseenGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("ballNumText")]    public Text HalfGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("settingBtn")]
    public Button CompostWeb;
[UnityEngine.Serialization.FormerlySerializedAs("gemsStoreBtn")]    public Button TeemCrowdWeb;
[UnityEngine.Serialization.FormerlySerializedAs("testBtn")]   // public Button sohoShopBtn;

    public Button ThaiWeb;
[UnityEngine.Serialization.FormerlySerializedAs("flyBoxController")]
    public SexIceInstrument LotIceInstrument;

    // Start is called before the first frame update
    void Start()
    {
        CompostWeb.onClick.AddListener(() => { VerifyGroupUncover.Instance.PearWhittlePlank(); });
        JobWhittleWeb.onClick.AddListener(() => { VerifyGroupUncover.Instance.PearJobWhittlePlank(); });

        TeemCrowdWeb.onClick.AddListener(() => { VerifyGroupUncover.Instance.PearDisposeCrowdPlank(); });
        //sohoShopBtn.onClick.AddListener(() =>
        //{
        //    JobEverTrulyInstrument.Instance.ShowCashMask();
        //    if (MoreBulkUncover.GetString(CShield.msg_show_rate_us) == "new")
        //    {
        //        PlowSenseGarden.GetInstance().SendEvent("1002");
        //        MoreBulkUncover.SetString(CShield.msg_show_rate_us, "show");
        //    }

        //    CropUncover.Instance.GameStop();
        ////  SOHOShopManager.instance.ShowRedeemPanel();
        //});

        CodeWeb.onClick.AddListener(() =>
        {
            if (FalconErie.MyUnder()) return;
            CropUncover.Instance.LadeLump();
            //SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        });
        SinkWeb.onClick.AddListener(() =>
        {
            CropUncover.Instance.LadeLump();
          //  SOHOShopManager.instance.ShowRedeemPanel();
        });
        UnseenWeb.onClick.AddListener(() =>
        {
            CropUncover.Instance.LadeLump();
       //     SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        });

        ThaiWeb.onClick.AddListener(() =>
        {
            // AddGold(5000, transform);
            // AddCash(5000,transform);
            // AddAmazon(5000,transform);
            // LadeBulkUncover.GetInstance().AddGem(GemsType.Silver);
            // ErodeUncover.Instance.StartSkillLong(true, 5);
            // ErodeUncover.Instance.StartSkillWall(true, 8);
            // ErodeUncover.Instance.ShowSlotNum();
            // ErodeUncover.Instance.ShowCashCoinNum(2);
            VerifyGroupUncover.Instance.PearLullUsPlank();
            // SecretPlankUncover.Instance.ShowCashRollReward();
        });

        FanwiseEnergyHatch.GetInstance().Engineer(CShield.Be_LadeJourney,
            (messageData) =>
            {
                CropUncover.Instance.LadeAmateur();
                PotteryTeacup();
            });

        FanwiseEnergyHatch.GetInstance().Engineer(CShield.Raw_Mine_Solo_Ox,
            (messageData) =>
            {
                //Invoke(nameof(PearLullUsPlank),0.8f);
            });

        FanwiseEnergyHatch.GetInstance().Engineer(CShield.uspanel,
            (messageData) =>
            {
                Invoke(nameof(PearLullUsPlank), 1f);
            });

        LotIceInstrument.CrestAndCabinIce();
        if (FalconErie.MyUnder()) 
        {
            VerifyRugged.SetActive(false);
            JazzRugged.SetActive(true);
        }
        else
        {
            VerifyRugged.SetActive(true);
            JazzRugged.SetActive(false);
        }
}

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    public override void Display()
    {
        base.Display();

        ///sohoShopBtn.gameObject.SetActive(!FalconErie.IsApple());
        //cashBar.gameObject.SetActive(!FalconErie.IsApple());
       // amazonBar.gameObject.SetActive(!FalconErie.IsApple());
        HalfRag.gameObject.SetActive(!FalconErie.MyUnder());
        ListenerRag.gameObject.SetActive(FalconErie.MyUnder());
        // gemsStoreBtn.gameObject.SetActive(!FalconErie.IsApple());
        print("adid: " + Adjust.getAdid());
        PotteryTeacup();
    }

    private void PearLullUsPlank()
    {
        VerifyGroupUncover.Instance.PearLullUsPlank();
    }

    public void PotteryTeacup()
    {
        CodeGodPort.text = LadeBulkUncover.GetInstance().TowRime() + "";
        JobRimeGodPort.text = LadeBulkUncover.GetInstance().TowRime() + "";
        SinkGodPort.text = SenateErie.MakeupNoShy(LadeBulkUncover.GetInstance().TowDust());
        UnseenGodPort.text = LadeBulkUncover.GetInstance().TowCoyote() + "";
        HalfGodPort.text = LadeBulkUncover.GetInstance().TowFast() + "";
        ListenerGodPort.text = LadeBulkUncover.GetInstance().TowFast() + "";
    }

    public void SkyRime(double gold, Transform objTrans = null)
    {
        LadeBulkUncover.GetInstance().SkyRime(gold);
        RimeSkyIngenuity(objTrans, 5);
    }

    public void SkyDust(double cash, Transform objTrans = null)
    {
        LadeBulkUncover.GetInstance().SkyDust(cash);
        DustSkyIngenuity(objTrans, 5);
    }

    public void SkyCoyote(double amazon, Transform objTrans = null)
    {
        LadeBulkUncover.GetInstance().SkyCoyote(amazon);
        CoyoteSkyIngenuity(objTrans, 5);
    }

    private void RimeSkyIngenuity(Transform startTransform, double num)
    {
       
        if (FalconErie.MyUnder()) 
        {
            SkyIngenuity(startTransform, BondMad.transform, BondMad.gameObject, JobRimeGodPort,LadeBulkUncover.GetInstance().TowRime(), num);
        } else
        {
            SkyIngenuity(startTransform, BondMad.transform, BondMad.gameObject, CodeGodPort,LadeBulkUncover.GetInstance().TowRime(), num);
        }

    }

    //  加现金动画
    private void DustSkyIngenuity(Transform startTransform, double num)
    {
        SkyIngenuity(startTransform, SinkMad.transform, SinkMad.gameObject, SinkGodPort,
            LadeBulkUncover.GetInstance().TowDust(), num);
    }

    // 加亚马逊币动画
    private void CoyoteSkyIngenuity(Transform startTransform, double num)
    {
        SkyIngenuity(startTransform, UnseenMad.transform, UnseenMad.gameObject, UnseenGodPort,
            LadeBulkUncover.GetInstance().TowCoyote(), num);
    }

    private void SkyIngenuity(Transform startTransform, Transform endTransform, GameObject icon, Text text,
        double textValue, double num)
    {
        if (startTransform != null)
        {
            IngenuityInstrument.RimeMustAcid(icon, Mathf.Max((int) num, 1), startTransform, endTransform,
                () =>
                {
                    BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_getcoin);
                    IngenuityInstrument.SenateSenate(double.Parse(text.text), textValue, 0.1f, text,
                        () => { text.text = SenateErie.MakeupNoShy(textValue); });
                });
        }
        else
        {
            IngenuityInstrument.SenateSenate(double.Parse(text.text), textValue, 0.1f, text,
                () => { text.text = SenateErie.MakeupNoShy(textValue); });
        }
    }
}