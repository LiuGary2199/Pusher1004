using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuchRoost : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("InitGroup")]    public GameObject PassRoost;

    private GameObject ValidityMessyWander;
    private float PloyQuina= 120f; // 两个item的position.x之差

    // Start is called before the first frame update
    void Start()
    {
        ValidityMessyWander = PassRoost.transform.Find("SlotCard_1").gameObject;
        float x= PloyQuina * 3;
        int multiCount = SapScanTip.instance.PassBulk.RewardMultiList.Count;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < multiCount; j++)
            {
                GameObject fangkuai = Instantiate(ValidityMessyWander, PassRoost.transform);
                fangkuai.transform.localPosition = new Vector3(x + PloyQuina * multiCount * i + PloyQuina * j, ValidityMessyWander.transform.localPosition.y, 0);
                fangkuai.transform.Find("Text").GetComponent<Text>().text = "×" + SapScanTip.instance.PassBulk.RewardMultiList[j].multi;
            }
        }
    }

    public void BookMessy()
    {
        PassRoost.GetComponent<RectTransform>().localPosition = new Vector3(0, -10, 0);
    }

    public void Then(int index, Action<int> finish)
    {
        BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.Sound_OneArmBandit);
        IngenuityInstrument.ImpossibleChoice(PassRoost, -(PloyQuina * 2 + PloyQuina * SapScanTip.instance.PassBulk.RewardMultiList.Count * 3 + PloyQuina * (index + 1)), () =>
        {
            finish?.Invoke(SapScanTip.instance.PassBulk.RewardMultiList[index].multi);
        });
    }
}
