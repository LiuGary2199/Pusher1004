using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAdsPanel : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(Hide());
    }

    IEnumerator Hide()
    {
        yield return new WaitForSeconds(1);
        UIParent.Instance.NoAdsPanelActive(false);
    }
}
