using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropUncover : MonoBehaviour
{
    public static CropUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("pushObj")]
    public GameObject WolfCop;
[UnityEngine.Serialization.FormerlySerializedAs("slotObj")]    public GameObject ThenCop;
[UnityEngine.Serialization.FormerlySerializedAs("gameLock")]
    public bool FareRome;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        BrownTip.GetInstance().PassBrownTip();
        FanwiseEnergyHatch.GetInstance()
            .Engineer(CShield.msg_Video_Fluid_Key_Total, (messageData) => { LadeAmateur(); });
    }

    public void FarePass()
    {
        bool isNewPlayer = !PlayerPrefs.HasKey(CShield.Dy_MyJobLonger + "Bool") || MoreBulkUncover.TowWhen(CShield.Dy_MyJobLonger);
        CavernPassUncover.Instance.PassCavernBulk(isNewPlayer);
        if (isNewPlayer)
        {
            // 新用户
            MoreBulkUncover.GunWhen(CShield.Dy_MyJobLonger, false);
        }
        
        PlowSenseGarden.GetInstance().CanySense("1001");
        BrownTip.GetInstance().TossMe(BrownOnce.UIMusic.sound_bgm);
    
        LadeBulkUncover.GetInstance().PassLadeBulk();
        UIManager.GetInstance().PearUIStain(nameof(LadePlank));
        WolfCop.gameObject.SetActive(true);
        ThenCop.gameObject.SetActive(true);
    }

    public void FaunaMuch()
    {
        DenialMuchIceSewerage.Instance.AtMyMuch();
    }

    public void LadeAmateur()
    {
        FareRome = false;
        VerifyGroupUncover.Instance.AxRome = false;
        if (FalconErie.MyUnder())
        { 
            JobCloseSwayUncover.Instance.AtCabinCloseSway();
        }
        else 
        {
            CloseSwayUncover.Instance.AtCabinCloseSway(); 
        }
        SexIceInstrument.Instance.AmateurIce();
        DenialUncover.Instance.ScantyDenial();
        FaunaMuch();
    }

    public void LadeLump()
    {
        FareRome = true;
        if (FalconErie.MyUnder())
        { 
            JobCloseSwayUncover.Instance.LumpClose(); 
        } 
        else 
        {
            CloseSwayUncover.Instance.LumpClose();
        }
        SexIceInstrument.Instance.LumpIce();
        DenialUncover.Instance.MuralDenial();
    }
}