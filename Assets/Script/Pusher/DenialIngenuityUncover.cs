using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
public class DenialIngenuityUncover : MonoBehaviour
{
    static public DenialIngenuityUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("push")]    public GameObject Wolf;
[UnityEngine.Serialization.FormerlySerializedAs("slotBox")]    public GameObject ThenIce;
[UnityEngine.Serialization.FormerlySerializedAs("skillWallGroup")]    public GameObject PlazaTideRoost;
[UnityEngine.Serialization.FormerlySerializedAs("ballCreater")]    public FastInvolve HalfInvolve;
    Sequence WolfSad;
    Sequence ThenIceSad;
    float VirtueObey= -2.0f;
    float OatObey= -3f;
    float WolfMustSway= 1.5f;
    float WolfOrnament= 1f;
    float ToothSourMustSway= 0.3f;
    float ToothSourOrnament= 0f;
    float WolfEye= -4.7f;

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        Wolf.transform.position = new Vector3(Wolf.transform.position.x, Wolf.transform.position.y, 0.5f);
        Book_z = Wolf.transform.position.z;
        ThenIce.transform.localPosition = new Vector3(-1, ThenIce.transform.localPosition.y, ThenIce.transform.localPosition.z);
    }

    /// <summary>
    /// �ư��ʼλ��
    /// </summary>
    float Book_z;
    /// <summary>
    /// ��ʼ�Ʊ�
    /// </summary>
    public void WolfCabinMust(bool needRefresh = false)
    {
        WolfSad.Kill();
        
        float moveZ = VirtueObey;
        float time = WolfMustSway;
        float interval = WolfOrnament;
        if (AxInSkyObey)
        {
            moveZ = OatObey;
        }
        bool needBlock = false;
        
        if (DenialUncover.Instance.AxSourClose)
        {
            time = ToothSourMustSway;
            interval = ToothSourOrnament; 
        }
        if (AxSourEye)
        {
            time = WolfMustSway;
            AxSourEye = false;
            moveZ = WolfEye;
            needBlock = true;
        }
        WolfSad = DOTween.Sequence();
        if (needRefresh)
        {
            WolfSad.Append(Wolf.GetComponent<Rigidbody>().DOMoveZ(Book_z + moveZ, time * ((Book_z + moveZ - Wolf.transform.position.z) / moveZ)).SetEase(Ease.Linear));
        }
        else
        {
            WolfSad.AppendInterval(interval);
            WolfSad.Append(Wolf.GetComponent<Rigidbody>().DOMoveZ(Book_z + moveZ, time).SetEase(Ease.Linear));
        }
        WolfSad.AppendInterval(interval);
        WolfSad.Append(Wolf.GetComponent<Rigidbody>().DOMoveZ(Book_z, time).SetEase(Ease.Linear));
        WolfSad.AppendCallback(() =>
        {
            if (needBlock)
            {
                WolfEyePurely();
            }
            WolfCabinMust();
        });
        WolfSad.Play();

    }
    /// <summary>
    /// ��ͣ�Ʊ�
    /// </summary>
    public void WolfHasteMust()
    {
        WolfSad.Pause();
        ThenIceSad.Pause();
    }
    /// <summary>
    /// �ָ��Ʊ�
    /// </summary>
    public void WolfRetoolMust()
    {
        WolfSad.Play();
        ThenIceSad.Play();
    }


    /// <summary>
    /// �Ƿ����ӳ�״̬
    /// </summary>
    bool AxInSkyObey= false;
    /// <summary>
    /// ����ӳ��ĳ���ʱ��
    /// </summary>
    float OatObeySway= 0;
    /// <summary>
    /// �ӳ��ư忪ʼ(��ʼ��������ʱ/ˢ�¶���״̬)
    /// </summary>
    /// <param name="time"></param>
    public void WolfSkyObey(float time)
    {
        OatObeySway += time;
        BulkAfricaUncover.GetInstance().MineErodeObeySway(!AxInSkyObey, (int)time);
        if (!AxInSkyObey)
        {
            AxInSkyObey = true;
            float alreadyPlay = WolfSad.ElapsedPercentage();
            if (alreadyPlay < 0.5f)
            {
                WolfCabinMust(true);
            }
            StartCoroutine(nameof(OatObeyIllMoatSway));
        }
    }
    /// <summary>
    /// ��ʱ�رռӳ�
    /// </summary>
    /// <returns></returns>
    IEnumerator OatObeyIllMoatSway()
    {
        float t = 0;
        while (t < OatObeySway)
        {
            yield return new WaitForSeconds(1);
            t++;
        }
        OatObeySway = 0;
        AxInSkyObey = false;
    }


    /// <summary>
    /// �Ƿ��Ѿ�����ǽ
    /// </summary>
    bool AxAtTideNo= false;
    /// <summary>
    /// ǽ����ʣ��ʱ��
    /// </summary>
    float BengNoSway= 0;
    /// <summary>
    /// ����ǽ����
    /// </summary>
    /// <param name="time"></param>
    public void LadTideNo(float time)
    {
        BengNoSway += time;
        BulkAfricaUncover.GetInstance().MineErodeTideSway(!AxAtTideNo, (int)time);
        if (!AxAtTideNo)
        {
            PlazaTideRoost.transform.DOMoveY(0, 0.3f);
            StartCoroutine(nameof(BengNoIllMoatSway));
        }
    }
    /// <summary>
    /// ����ǽ������ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator BengNoIllMoatSway()
    {
        int t = 0;
        while (t < BengNoSway)
        {
            yield return new WaitForSeconds(1);
            t++;
        }
        BengNoSway = 0;
        AxAtTideNo = false;
        LadTideCode();
    }
    /// <summary>
    /// ����ǽ����
    /// </summary>
    public void LadTideCode()
    {
        PlazaTideRoost.transform.DOMoveY(-0.8f, 0.3f);
    }


    /// <summary>
    /// �Ƿ���Ҫȫ������
    /// </summary>
    bool AxSourEye= false;
    /// <summary>
    /// ȫ�����»ص�
    /// </summary>
    System.Action WolfEyePurely;
    /// <summary>
    /// ȫ������
    /// </summary>
    public void WolfEyeMust(System.Action block)
    {
        WolfEyePurely = block;
        AxSourEye = true;
        float alreadyPlay = WolfSad.ElapsedPercentage();
        if (alreadyPlay < 0.5f)
        {
            WolfCabinMust(true);
        }
    }


    

    /// <summary>
    /// slot�п�ʼ�ƶ�
    /// </summary>
    public void ItsCabinMust()
    {
        float moveX = 2f;
        float x= ThenIce.transform.position.x;
        ThenIceSad = DOTween.Sequence();
        ThenIceSad.Append(ThenIce.GetComponent<Rigidbody>().DOMoveX(x + moveX, 2));
        ThenIceSad.Append(ThenIce.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 90), 0.5f));
        ThenIceSad.Append(ThenIce.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 0), 0.5f));
        ThenIceSad.AppendInterval(0.5f);
        ThenIceSad.Append(ThenIce.GetComponent<Rigidbody>().DOMoveX(x, 2));
        ThenIceSad.Append(ThenIce.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, -90), 0.5f));
        ThenIceSad.Append(ThenIce.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 0), 0.5f));
        ThenIceSad.AppendInterval(0.5f);
        ThenIceSad.SetLoops(-1);
        ThenIceSad.Play();
    }
    /// <summary>
    /// ��ͣslot��
    /// </summary>
    public void ThenIceHasteMust()
    {
        ThenIceSad.Pause();
    }
    /// <summary>
    /// �ָ�slot��
    /// </summary>
    public void ThenIceRetoolMust()
    {
        ThenIceSad.Restart();
    }

    /// <summary>
    /// slot�йر�
    /// </summary>
    public void FollyMuchIce()
    {
        ThenIce.SetActive(false);
    }


    void Start()
    {
        //�趨�ư��ʼλ��
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
