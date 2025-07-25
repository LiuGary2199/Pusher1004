using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CavernLoopPlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button FollyButton;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustAdidText")]    public Text CavernJoinPort;
[UnityEngine.Serialization.FormerlySerializedAs("ServerIdText")]    public Text RecoilToPort;
[UnityEngine.Serialization.FormerlySerializedAs("ActCounterText")]    public Text CupNervousPort;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustTypeText")]    public Text CavernOncePort;
[UnityEngine.Serialization.FormerlySerializedAs("ResetActCountButton")]    public Button CrestCupRigorBreech;
[UnityEngine.Serialization.FormerlySerializedAs("AddActCountButton")]    public Button SkyCupRigorBreech;

    // Start is called before the first frame update
    void Start()
    {
        FollyButton.onClick.AddListener(() => {
            FollyUIPeak(GetType().Name);
        });

        CrestCupRigorBreech.onClick.AddListener(() => {
            CavernPassUncover.Instance.CrestCupRigor();
        });

        SkyCupRigorBreech.onClick.AddListener(() => {
            CavernPassUncover.Instance.SkyCupRigor("test");
        });
    }

    private void PearNervousPort()
    {
        CavernJoinPort.text = CavernPassUncover.Instance.TowCavernJoin();
        RecoilToPort.text = MoreBulkUncover.TowSmooth(CShield.Dy_PupilRecoilTo);
        CupNervousPort.text = CavernPassUncover.Instance._ThunderRigor.ToString();
        CavernOncePort.text = MoreBulkUncover.TowSmooth("sv_ADJustInitType");
    }

    public override void Display()
    {
        base.Display();
        InvokeRepeating(nameof(PearNervousPort), 0, 0.5f);
    }

    public override void Hidding()
    {
        base.Hidding();
        CancelInvoke(nameof(PearNervousPort));
    }
}
