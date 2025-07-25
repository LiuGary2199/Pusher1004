using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntombUncover : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("shootPoint")]    public GameObject AffixTrace;
[UnityEngine.Serialization.FormerlySerializedAs("ballPerfab")]    public GameObject HalfViewer;
[UnityEngine.Serialization.FormerlySerializedAs("ballPanel")]    public GameObject HalfPlank;
[UnityEngine.Serialization.FormerlySerializedAs("plateWidth")]    public float SweetQuina;
[UnityEngine.Serialization.FormerlySerializedAs("allWidth")]    public float allQuina;
[UnityEngine.Serialization.FormerlySerializedAs("allBoxList")]    public List<EntombViewInvolve> CapIcePeal;
[UnityEngine.Serialization.FormerlySerializedAs("ballPool")]    public LuceUncover HalfLuce;
    bool SplitRome;
    static public EntombUncover Instance;
    private void Awake()
    {
        Instance = this;
    }
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="drop_x"></param>
    public void IdeaFast(float drop_x)
    {
        if (DenialUncover.Instance.AxHaste)
        {
            return;
        }
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.MediumImpact);
        float scale = 0.45f;
        GameObject ball = HalfLuce.TowWander();
        ball.transform.position = new Vector3(drop_x, AffixTrace.transform.position.y, AffixTrace.transform.position.z);
        ball.transform.localScale = new Vector3(scale, scale, scale);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20));
    }

    public void GoldView(float drop_x)
    {
        if (DenialUncover.Instance.AxHaste)
        {
            return;
        }
        GameObject coin = DenialUncover.Instance.WhySecretLess(PusherRewardType.CoinGold);
        coin.transform.position = new Vector3(drop_x, 8f, -1f);
        coin.transform.eulerAngles = new Vector3(WhyVagaryBallad(), WhyVagaryBallad(), WhyVagaryBallad());
        coin.GetComponent<Rigidbody>().AddForce(0f, -5f, 0f);
        if (!DenialUncover.Instance.AxSourClose)
        {
            BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_creat_coin, 0.1f);
        }
        else
        {
            BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_creat_coin_fever, 0.1f);
        }
    }
    /// <summary>
    /// ���������
    /// </summary>
    /// <returns></returns>
    IEnumerator SplitPicnicMoatSway()
    {
        yield return new WaitForSeconds(SenateErie.GutSimplyGenre(SapScanTip.instance.LadeBulk.base_config.touch_cd));
        SplitRome = false;
    }

    /// <summary>
    /// ��ͣȫ��С��
    /// </summary>
    public void MuralEyeFast()
    {
        for (int i = 0; i < HalfLuce.King.Count; i++)
        {
            HalfLuce.King[i].GetComponent<SiliceousHaste>().MuralSiliceous();
        }
    }
    /// <summary>
    /// �ָ�ȫ��С��
    /// </summary>
    public void ScantyEyeFast()
    {
        for (int i = 0; i < HalfLuce.King.Count; i++)
        {
            HalfLuce.King[i].GetComponent<SiliceousHaste>().ScantySiliceous();
        }
    }


    /// <summary>
    /// plinko�� ����fever
    /// </summary>
    public void ToothCabinIcePottery(int c)
    {
        foreach (EntombViewInvolve creater in CapIcePeal)
        {
            creater.ToothCabinPottery(c);
        }
    }
    /// <summary>
    /// plinko�� ����fever
    /// </summary>
    public void ToothIllIcePottery()
    {
        foreach (EntombViewInvolve creater in CapIcePeal)
        {
            creater.ToothIllPottery();
        }
    }
    /// <summary>
    /// fever ��ʼ�Զ�����
    /// </summary>
    public void ToothCabinCultGoldFast()
    {
        StartCoroutine(nameof(LobeGoldFastMoatSway));
    }
    /// <summary>
    /// fever �����Զ�����
    /// </summary>
    public void ToothIllCultGoldFast()
    {
        StopCoroutine(nameof(LobeGoldFastMoatSway));
    }
    /// <summary>
    /// fever �Զ������ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator LobeGoldFastMoatSway()
    {
        while (DenialUncover.Instance.AxSourClose)
        {
            if (FalconErie.MyUnder())
            {
                GoldView(Random.Range(-SweetQuina / 2, SweetQuina / 2));
                GoldView(Random.Range(-SweetQuina / 2, SweetQuina / 2));
                GoldView(Random.Range(-SweetQuina / 2, SweetQuina / 2));
            }
            else
            {
                IdeaFast(Random.Range(-SweetQuina / 2, SweetQuina / 2));
            }
            yield return new WaitForSeconds(0.3f);
        }

    }

    /// <summary>
    /// һ��������������
    /// </summary>
    /// <param name="count"></param>
    public void PoundSeekView(int count)
    {
        foreach (EntombViewInvolve creater in CapIcePeal)
        {
            creater.IdeaHangView(count);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        HalfLuce.PassLuceUncover(HalfViewer, HalfLuce.transform, 50, "Ball");
        if (FalconErie.MyUnder())
        {
            HalfPlank.gameObject.SetActive(false);

        }
        else
        {
            HalfPlank.gameObject.SetActive(true);
        }
    }
    float WhyVagaryBallad()
    {
        return Random.Range(0, 360f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (Application.platform == RuntimePlatform.Android ||
                        Application.platform == RuntimePlatform.IPhonePlayer)
            {
                int fingerId = Input.GetTouch(0).fingerId;
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(fingerId))
                {
                    Debug.Log("�����UI");
                    return;
                }
            }
            ////����ƽ̨
            else
            {
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
                {
                    Debug.Log("�����UI");
                    return;
                }
            }
            if (!SplitRome)
            {
                if (FalconErie.MyUnder())
                {
                    if (!VagueFastUncover.Instance.GoldViewForUnder()) return;
                    float coin_x = (Input.mousePosition.x - Screen.width / 2) / (Screen.width / 2) * (SweetQuina / 2);
                    GoldView(coin_x);
                }
                else
                {
                    // �Ƿ���С��
                    if (!VagueFastUncover.Instance.GoldFast()) return;
                    SplitRome = true;
                    StartCoroutine(nameof(SplitPicnicMoatSway));
                    float drop_x = 0;
                    drop_x = (Input.mousePosition.x - Screen.width / 2) / (Screen.width / 2) * (SweetQuina / 2);
                    MoreBulkUncover.GunWok("DropBallCount", MoreBulkUncover.TowWok("DropBallCount") + 1);
                    IdeaFast(drop_x);
                }
            }

        }
    }
}
