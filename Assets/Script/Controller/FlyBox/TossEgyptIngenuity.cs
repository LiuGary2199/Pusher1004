using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TossEgyptIngenuity : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("imageList")]    public List<Sprite> SullyPeal;
    private Image Sully;
[UnityEngine.Serialization.FormerlySerializedAs("speen")]    public float Bench;
    IEnumerator PourUnload()
    {
        foreach(Sprite sprite in SullyPeal)
        {
            Sully.sprite = sprite;
            yield return new WaitForSeconds(Bench);
        }
    }
    private void OnEnable()
    {
        Sully = GetComponent<Image>();
        StartCoroutine(nameof(PourUnload));
    }
    // private void OnDisable()
    // {
    //     StopCoroutine("playAction");
    // }
}
