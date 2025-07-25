using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordRancher : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public RectTransform Reef;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    public MoatLace Physiology;
    private void Awake()
    {
        Physiology.DyPageSenate = Ecological;
    }

    void Ecological(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Reef.GetComponent<RectTransform>().position = pos;
    }
}
