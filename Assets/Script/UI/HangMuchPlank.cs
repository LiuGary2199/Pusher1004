// Project: Plinko
// FileName: HangMuchPlank.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 9:23
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class HangMuchPlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    public Button VideoWeb;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    public Button WhyWeb;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]

    public GameObject WhyWebPort;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]    public GameObject WeMad;


    private string CreepOnce;

    private void Start()
    {
        VideoWeb.onClick.AddListener(() =>
        {
            CreepOnce = "0";
            ADUncover.Variance.ToBreechSkyRigor();
            CropUncover.Instance.LadeAmateur();
            FollyHallPlank();
        });

        WhyWeb.onClick.AddListener(() =>
        {
            if (MoreBulkUncover.TowSmooth(CShield.Dy_Relax_Then_again) == "new")
            {
                MoreBulkUncover.GunSmooth(CShield.Dy_Relax_Then_again, "done");
                TowSecret();
            }
            else
            {
                ADUncover.Variance.PourSecretSteel((success) => { TowSecret(); }, "1");
            }
        });
    }

    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        if (MoreBulkUncover.TowSmooth(CShield.Dy_Relax_Then_again) == "new")
        {
            WeMad.gameObject.SetActive(false);
            WhyWebPort.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        else
        {
            WhyWebPort.transform.localPosition = new Vector3(37f, 0f, 0f);
            WeMad.gameObject.SetActive(true);
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }

    private void TowSecret()
    {
        CreepOnce = "1";

        DenialMuchIceSewerage.Instance.SkyMuchRigor();
        FollyHallPlank();
    }


    private void FollyHallPlank()
    {
        PlowSenseGarden.GetInstance().CanySense("1004", CreepOnce);
        CropUncover.Instance.LadeAmateur();
        FollyUIPeak(GetType().Name);
    }
}