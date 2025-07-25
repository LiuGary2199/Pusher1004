using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Lofelt.NiceVibrations;

public class EntombViewInvolve : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("index")]    public int Onset;
[UnityEngine.Serialization.FormerlySerializedAs("count")]    public int Briny;
[UnityEngine.Serialization.FormerlySerializedAs("countImage")]    public SpriteRenderer BrinyEgypt;
    int IdeaRigor;
    /// <summary>
    /// ��ײ������Ҳ�ˢ�½�ҿ�����
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            //BrownTip.GetInstance().PlayEffect(BrownOnce.SceneMusic.sound_drop_ball,0.1f);
            collision.gameObject.SetActive(false);
            if (Briny >= 1)
            {
                IdeaHangView(Briny);
                if (!DenialUncover.Instance.AxSourClose)
                {
                    MortiseRigor();
                }
            }
        }
    }

    void MortiseRigor()
    {
        Briny = BulkAfricaUncover.GetInstance().WhyEntombViewRigor(Onset);
        BrinyEgypt.sprite = Resources.Load<Sprite>(CShield.IceRigor + Briny);
    }

    public void IdeaHangView(int c)
    {
        IdeaRigor += c;
        if (IdeaRigor == c)
        {
            StartCoroutine(IdeaHangViewMoatSway());
        }
    }

    /// <summary>
    /// ��ʱ�ͷŶ�����
    /// </summary>
    /// <returns></returns>
    IEnumerator IdeaHangViewMoatSway()
    {
        while(IdeaRigor > 0)
        {
            IdeaRigor--;
            IdeaView();
            yield return new WaitForSeconds(0.1f);
        }
    }
    /// <summary>
    /// ��ʼ�����λ�ò��ͷ�
    /// </summary>
    void IdeaView()
    {
        if (DenialUncover.Instance.AxHaste)
        {
            return;
        }
       
        if (!DenialUncover.Instance.AxSourClose)
        {
            GameObject coin = DenialUncover.Instance.WhySecretLess(PusherRewardType.CoinGold);
            coin.transform.position = transform.position + new Vector3(0, 0, -0.5f);
            coin.transform.eulerAngles = new Vector3(Random.Range(0, 10), WhyVagaryBallad(), Random.Range(0, 10));
            coin.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-30f,30f) * 0.8f, Random.Range(180f,270f) * 0.8f, Random.Range(-50f,-80f) * 0.8f));
            BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_creat_coin, 0.1f);
        }
        else
        {
            GameObject coin = DenialUncover.Instance.WhySecretLess(Random.Range(0,2) == 0 ? PusherRewardType.CoinGold : PusherRewardType.CoinCash);
            coin.transform.position = transform.position + new Vector3(0, 0, -0.5f);
            coin.transform.eulerAngles = new Vector3(WhyVagaryBallad(), WhyVagaryBallad(), WhyVagaryBallad());
            coin.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-10f,10f) * 0.8f, Random.Range(300f,450f) * 0.8f, Random.Range(-30f,-40f) * 0.8f));
            BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_creat_coin_fever, 0.1f);
        }
        LadBottle();
    }
    /// <summary>
    /// �Ƿ������
    /// </summary>
    bool DyeBottle= true;
    /// <summary>
    /// ��ʼ��
    /// </summary>
    void LadBottle()
    {
        if (DyeBottle)
        {
            DyeBottle = false;
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact);
            StartCoroutine(CrunchPicnicMoatSway());
        }
        
    }
    /// <summary>
    /// �𶯽�����ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator CrunchPicnicMoatSway()
    {
        yield return new WaitForSeconds(0.1f);
        DyeBottle = true;
    }
    /// <summary>
    /// ��ȡ����Ƕ�
    /// </summary>
    /// <returns></returns>
    float WhyVagaryBallad()
    {
        return Random.Range(0, 360f);
    }


    /// <summary>
    /// feverģʽ��ˢ�±���
    /// </summary>
    public void ToothCabinPottery(int c)
    {
        Briny = c;
        BrinyEgypt.sprite = Resources.Load<Sprite>(CShield.IceRigor + Briny);
    }
    /// <summary>
    /// fever����ˢ��
    /// </summary>
    /// <param name="count"></param>
    public void ToothIllPottery()
    {
        MortiseRigor();
    }

    // Start is called before the first frame update
    void Start()
    {
        //��ʼ����ҿ�����
        MortiseRigor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
