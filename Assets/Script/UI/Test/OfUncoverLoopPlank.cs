using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfUncoverLoopPlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("LastPlayTimeCounterText")]    public Text SpewTossSwayNervousPort;
[UnityEngine.Serialization.FormerlySerializedAs("Counter101Text")]    public Text Nervous101Port;
[UnityEngine.Serialization.FormerlySerializedAs("Counter102Text")]    public Text Nervous102Port;
[UnityEngine.Serialization.FormerlySerializedAs("Counter103Text")]    public Text Nervous103Port;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumText")]    public Text BraveGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("PlayRewardedAdButton")]    public Button TossCheerfulOfBreech;
[UnityEngine.Serialization.FormerlySerializedAs("PlayInterstitialAdButton")]    public Button TossParticipatorOfBreech;
[UnityEngine.Serialization.FormerlySerializedAs("NoThanksButton")]    public Button ToBreechBreech;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumButton")]    public Button BraveGodBreech;
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button FollyButton;
[UnityEngine.Serialization.FormerlySerializedAs("TimeInterstitialText")]    public Text SwayParticipatorPort;
[UnityEngine.Serialization.FormerlySerializedAs("PauseTimeInterstitialButton")]    public Button HasteSwayParticipatorBreech;
[UnityEngine.Serialization.FormerlySerializedAs("ResumeTimeInterstitialButton")]    public Button RetoolSwayParticipatorBreech;

    private void Start()
    {
        InvokeRepeating(nameof(PearNervousPort), 0, 0.5f);

        FollyButton.onClick.AddListener(() => {
            FollyUIPeak(GetType().Name);
        });

        TossCheerfulOfBreech.onClick.AddListener(() => {
            ADUncover.Variance.PourSecretSteel((success) => { }, "10");
        });

        TossParticipatorOfBreech.onClick.AddListener(() => {
            ADUncover.Variance.PourParticipatorOf(1);
        });

        ToBreechBreech.onClick.AddListener(() => {
            ADUncover.Variance.ToBreechSkyRigor();
        });

        BraveGodBreech.onClick.AddListener(() => {
            ADUncover.Variance.TenantBraveGod(MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice) + 1);
            BraveGodPort.text = MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice).ToString();
        });

        HasteSwayParticipatorBreech.onClick.AddListener(() => {
            ADUncover.Variance.HasteSwayParticipator();
            PearHasteSwayParticipator();
        });

        RetoolSwayParticipatorBreech.onClick.AddListener(() => {
            ADUncover.Variance.RetoolSwayParticipator();
            PearHasteSwayParticipator();
        });

    }

    public override void Display()
    {
        base.Display();
        BraveGodPort.text = MoreBulkUncover.TowWok(CShield.Dy_We_Exert_Ice).ToString();
        PearHasteSwayParticipator();
    }

    private void PearNervousPort()
    {
        SpewTossSwayNervousPort.text = ADUncover.Variance.GainTossSwayNervous.ToString();
        Nervous101Port.text = ADUncover.Variance.Moisten101.ToString();
        Nervous102Port.text = ADUncover.Variance.Moisten102.ToString();
        Nervous103Port.text = ADUncover.Variance.Moisten103.ToString();
    }

    private void PearHasteSwayParticipator()
    {
        SwayParticipatorPort.text = ADUncover.Variance.MuralSwayParticipator ? "已暂停" : "未暂停";
    }
}
