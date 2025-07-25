using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenialMuchIceSewerage : MonoBehaviour
{
    public static DenialMuchIceSewerage Instance;
[UnityEngine.Serialization.FormerlySerializedAs("slotCount")]
    public int ThenRigor;
[UnityEngine.Serialization.FormerlySerializedAs("isSlotFlag")]    public bool AxMuchWith;

    private void Awake()
    {
        Instance = this;
        ThenRigor = 0;
        AxMuchWith = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_enter_box);
        DenialUncover.Instance.WhyGoldSecret(other.transform.parent.GetComponent<DenialSecretLess>().SummerOnce,
            other.transform.parent.GetComponent<DenialSecretLess>().SummerGod);

        TossAgeMuch();
        other.transform.parent.gameObject.SetActive(false);
    }

    public void TossAgeMuch()
    {
        SkyMuchRigor();
        DoMuch();
    }

    public void SkyMuchRigor()
    {
        ThenRigor++;
        ErodeUncover.Instance.PearMuchGod(true, ThenRigor);
    }


    private void DoMuch()
    {
        if (AxMuchWith) return;
        ErodeUncover.Instance.PearMuchGod(true, ThenRigor);
        AxMuchWith = true;
        ThenRigor--;
        DenialUncover.Instance.TotalMuch();
    }

    public void AtMyMuch()
    {
        if (ThenRigor < 1)
        {
            ErodeUncover.Instance.PearMuchGod(false, ThenRigor);
            return;
        }

        DoMuch();
        // Invoke("DoSlot", 1f);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            TossAgeMuch();
        }
    }
}