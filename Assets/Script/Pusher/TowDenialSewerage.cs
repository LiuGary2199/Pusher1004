using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class TowDenialSewerage : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("fx_Poolgroup")]    public GameObject At_Treatment;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Poolgroup_1")]    public GameObject At_Treatment_1;
[UnityEngine.Serialization.FormerlySerializedAs("text_Poolgroup")]    public GameObject Grid_Treatment;
    private void OnTriggerEnter(Collider other)
    {
        GameObject pusherRewardItem = other.transform.parent.gameObject;
        if (pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce == PusherRewardType.GemBlue || pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce == PusherRewardType.GemDiamond || pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce == PusherRewardType.GemRed || pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce == PusherRewardType.Golden)
        {
            Transform TargetTF = UIManager.GetInstance().CropStripe.transform.Find("Normal/LadePlank/Window/GemsStoreBtn").transform;
            GameObject RawStag= Resources.Load<GameObject>(CShield.Raw_Stag).gameObject;
            GameObject RawAdd= Resources.Load<GameObject>(CShield.Raw_Add).gameObject;
            GameObject RawSurplus= Resources.Load<GameObject>(CShield.Raw_Surplus).gameObject;
            GameObject Prefer= Resources.Load<GameObject>(CShield.Raw_Prefer).gameObject;
            GameObject fx_1 = At_Treatment_1.GetComponent<LuceUncover>().TowWander();
            fx_1.SetActive(true);
            fx_1.transform.position = new Vector3(other.gameObject.transform.position.x, -0.5f, -5.74f);
            switch (pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce) 
            {
                case PusherRewardType.GemBlue:
                    IngenuityInstrument.DiverseSecretDry(TargetTF.transform.position, RawStag, other.gameObject.transform.position, TargetTF,()=> { });
                    break;
                case PusherRewardType.GemDiamond:
                    IngenuityInstrument.DiverseSecretDry(TargetTF.transform.position, RawSurplus, other.gameObject.transform.position, TargetTF, () => { });
                    break;
                case PusherRewardType.GemRed:
                    IngenuityInstrument.DiverseSecretDry(TargetTF.transform.position, RawAdd, other.gameObject.transform.position, TargetTF, () => { });
                    break;
                case PusherRewardType.Golden:
                    IngenuityInstrument.DiverseSecretDry(TargetTF.transform.position, Prefer, other.gameObject.transform.position, TargetTF, () => { });
                    break;

            }
        }
        if (pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce == PusherRewardType.CoinCash || pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce == PusherRewardType.CoinGold)
        {
            GameObject fx = At_Treatment.GetComponent<LuceUncover>().TowWander();
            GameObject Text = Grid_Treatment.GetComponent<LuceUncover>().TowWander();
            Text.SetActive(true);
            fx.SetActive(true);
            float V = (Screen.height * -0.587f) - 260;
            Text.transform.localScale = new Vector3(2f, 2f, 2f);
            Text.transform.localPosition = new Vector3(Text.transform.localPosition.x, Text.transform.localPosition.y - 2, V);
            Text.transform.position = new Vector3(other.gameObject.transform.position.x, -5f, Text.transform.position.z);
            Text.transform.DOMoveY(-4f + Random.Range(0, 1.5f), 0.7f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                Text.SetActive(false);
            });
            fx.transform.position = new Vector3(other.gameObject.transform.position.x, -0.5f, -5.74f);
            if (pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce == PusherRewardType.CoinCash)
            {
                Text.GetComponent<Text>().color = new Color(4 / 255f, 1, 0);
                Text.GetComponent<Text>().text = "+" + System.Math.Round(pusherRewardItem.GetComponent<DenialSecretLess>().SummerGod,2);
            }
            else
            {
                Text.GetComponent<Text>().color = new Color(237 / 255f, 1, 0); 
                Text.GetComponent<Text>().text = "+" + pusherRewardItem.GetComponent<DenialSecretLess>().SummerGod;
            }
            
            
        }

        Transform parent = pusherRewardItem.transform.parent;
        pusherRewardItem.SetActive(false);
        pusherRewardItem.transform.SetParent(DenialUncover.Instance.SummerLessRoost);
        if (parent.childCount == 0)
        {
            Destroy(parent.gameObject);
        }
        DenialUncover.Instance.WhyGoldSecret(pusherRewardItem.GetComponent<DenialSecretLess>().SummerOnce, pusherRewardItem.GetComponent<DenialSecretLess>().SummerGod);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
