using Lofelt.NiceVibrations;
using UnityEngine;
using UnityEngine.UI;

public class JobSingWhittlePlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("musicBtn")]    public Button AwardWeb;
[UnityEngine.Serialization.FormerlySerializedAs("soundBtn")]    public Button MoistWeb;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationBtn")]    public Button RetentiveWeb;
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]
    public Button VideoWeb;
[UnityEngine.Serialization.FormerlySerializedAs("musicOn")]
    public GameObject AwardOn;
[UnityEngine.Serialization.FormerlySerializedAs("musicOff")]    public GameObject AwardOur;
[UnityEngine.Serialization.FormerlySerializedAs("soundOn")]    public GameObject MoistDy;
[UnityEngine.Serialization.FormerlySerializedAs("soundOff")]    public GameObject MoistOur;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationOn")]    public GameObject RetentiveDy;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationOff")]    public GameObject RetentiveOur;

    private string RetentiveYam;

    protected override void Awake()
    {
        base.Awake();
        RetentiveYam = "sv_vibrationType";
        if (!PlayerPrefs.HasKey(RetentiveYam))
        {
            MoreBulkUncover.GunWok(RetentiveYam, 1);
        }
    }

    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        AwardOn.gameObject.SetActive(BrownTip.GetInstance().MeBrownCoarse);
        AwardOur.gameObject.SetActive(!BrownTip.GetInstance().MeBrownCoarse);

        MoistDy.gameObject.SetActive(BrownTip.GetInstance().ClutchBrownCoarse);
        MoistOur.gameObject.SetActive(!BrownTip.GetInstance().ClutchBrownCoarse);

        RetentiveDy.gameObject.SetActive(MoreBulkUncover.TowWok(RetentiveYam) == 1);
        RetentiveOur.gameObject.SetActive(MoreBulkUncover.TowWok(RetentiveYam) != 1);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }
    // Start is called before the first frame update
    void Start()
    {
        VideoWeb.onClick.AddListener(() =>
        {
            CropUncover.Instance.LadeAmateur();
            if (FalconErie.MyUnder())
            {
                FollyUIPeak(nameof(JobSingWhittlePlank));
            }
            else
            {
                FollyUIPeak(GetType().Name);
            }
        });

        AwardWeb.onClick.AddListener(() =>
        {
            BrownTip.GetInstance().MeBrownCoarse = !BrownTip.GetInstance().MeBrownCoarse;
            AwardOn.gameObject.SetActive(BrownTip.GetInstance().MeBrownCoarse);
            AwardOur.gameObject.SetActive(!BrownTip.GetInstance().MeBrownCoarse);
        });
        MoistWeb.onClick.AddListener(() =>
        {
            BrownTip.GetInstance().ClutchBrownCoarse = !BrownTip.GetInstance().ClutchBrownCoarse;
            MoistDy.gameObject.SetActive(BrownTip.GetInstance().ClutchBrownCoarse);
            MoistOur.gameObject.SetActive(!BrownTip.GetInstance().ClutchBrownCoarse);
        });

        RetentiveWeb.onClick.AddListener(() =>
        {
            int vibrationType = MoreBulkUncover.TowWok(RetentiveYam) * -1;
            RetentiveDy.gameObject.SetActive((vibrationType == 1));
            RetentiveOur.gameObject.SetActive((vibrationType != 1));
            MoreBulkUncover.GunWok(RetentiveYam, vibrationType);
            HapticController.hapticsEnabled = (vibrationType == 1);
        });
    }
}