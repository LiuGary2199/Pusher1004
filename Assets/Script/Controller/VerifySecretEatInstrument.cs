// Project: Plinko
// FileName: VerifySecretEatInstrument.cs
// Author: AX
// CreateDate: 20230522
// CreateTime: 16:53
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class VerifySecretEatInstrument : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]    public GameObject CodeMad;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    public GameObject SinkMad;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    public GameObject UnseenMad;
[UnityEngine.Serialization.FormerlySerializedAs("rollCashImg")]    public GameObject NailDustMad;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]
    public Text SummerGodPort;

    private NormalRewardType SummerOnce;
    private double SummerGod;


    public void PassBulk(NormalRewardType thisType, double num)
    {
        SummerOnce = thisType;
        SummerGod = num;
        FollyMad();
        PearMad();
        SummerGodPort.text = "+ " + SummerGod;
    }


    private void FollyMad()
    {
        CodeMad.gameObject.SetActive(false);
        SinkMad.gameObject.SetActive(false);
        UnseenMad.gameObject.SetActive(false);
        NailDustMad.gameObject.SetActive(false);
    }

    private void PearMad()
    {
        switch (SummerOnce)
        {
            case NormalRewardType.Amazon:
                UnseenMad.gameObject.SetActive(true);
                break;
            case NormalRewardType.Cash:
                SinkMad.gameObject.SetActive(true);
                break;
            case NormalRewardType.RollCash:
                NailDustMad.gameObject.SetActive(true);
                break;
            default:
                CodeMad.gameObject.SetActive(true);
                break;
        }
    }

    public void SenateGodHurl(int multi)
    {
        IngenuityInstrument.SenateSenate(SummerGod, SummerGod * multi, 0, SummerGodPort, "+", () =>
        {
            SummerGod = SummerGod * multi;
            SummerGodPort.text = "+" + SenateErie.MakeupNoShy(SummerGod);
        });
    }


    public void TowVerifyBadSecret()
    {
        switch (SummerOnce)
        {
            case NormalRewardType.Amazon:
                LadePlank.Instance.SkyCoyote(SummerGod, UnseenMad.transform);
                break;
            case NormalRewardType.Cash:
                LadePlank.Instance.SkyDust(SummerGod, SinkMad.transform);
                break;
            case NormalRewardType.RollCash:
                LadePlank.Instance.SkyDust(SummerGod, SinkMad.transform);
                break;
            default:
                LadePlank.Instance.SkyRime(SummerGod, CodeMad.transform);
                break;
        }
    }
}