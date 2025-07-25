// Project: Pusher
// FileName: ErodeUncover.cs
// Author: AX
// CreateDate: 20230823
// CreateTime: 14:33
// Description:

using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ErodeUncover : MonoBehaviour
{
    public static ErodeUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("skillWall")]
    public GameObject PlazaTide;
[UnityEngine.Serialization.FormerlySerializedAs("skillLong")]    public GameObject PlazaObey;
[UnityEngine.Serialization.FormerlySerializedAs("slotObj")]    public GameObject ThenCop;
[UnityEngine.Serialization.FormerlySerializedAs("cashCoinObj")]    public GameObject SinkViewCop;
[UnityEngine.Serialization.FormerlySerializedAs("skillLongText")]
    public Text PlazaObeyPort;
[UnityEngine.Serialization.FormerlySerializedAs("skillWallText")]    public Text PlazaTidePort;
[UnityEngine.Serialization.FormerlySerializedAs("slotNumText")]    public Text ThenGodPort;
[UnityEngine.Serialization.FormerlySerializedAs("cashCoinNumText")]    public Text SinkViewGodPort;


    private int PlazaTideSway;
    private int PlazaObeySway;
    private int SinkViewSway;

    private bool ThenWith;


    private void Awake()
    {
        Instance = this;
        PlazaTideSway = 0;
        PlazaObeySway = 0;
        SinkViewSway = 0;
        ThenWith = false;
    }


    private void PearErodeObeyCup()
    {
        PlazaObey.transform.DOLocalMoveX(-450, 0.5f);
    }

    private void FollyErodeObeyCup()
    {
        PlazaObey.transform.DOLocalMoveX(-725, 0.5f);
        StopCoroutine(nameof(ErodeObeyOxide));
    }

    private void PearErodeTideCup()
    {
        PlazaTide.transform.DOLocalMoveX(450, 0.5f);
    }

    private void FollyErodeTideCup()
    {
        PlazaTide.transform.DOLocalMoveX(725, 0.5f);
        StopCoroutine(nameof(ErodeTideOxide));
    }

    public void CabinErodeObey(bool flag, int time)
    {
        if (flag)
        {
            PearErodeObeyCup();
            PlazaObeySway = 0;
        }

        PlazaObeySway += time;
        StopCoroutine(nameof(ErodeObeyOxide));
        StartCoroutine(nameof(ErodeObeyOxide));
    }

    public void CabinErodeTide(bool flag, int time)
    {
        if (flag)
        {
            PearErodeTideCup();
            PlazaTideSway = 0;
        }

        PlazaTideSway += time;
        StopCoroutine(nameof(ErodeTideOxide));
        StartCoroutine(nameof(ErodeTideOxide));
    }


    public void PearMuchGod(bool flag,int num)
    {
        ThenGodPort.text = num + "";
        if (flag)
        {
            if (ThenWith) return;
            ThenWith = true;
            ThenCop.transform.DOLocalMoveX(-450, 0.5f);
        }
        else
        {
            ThenWith = false;
            ThenGodPort.text = num +"";
            ThenCop.transform.DOLocalMoveX(-725, 0.5f);
        }

    }
    
    

    public void PearDustViewGod(bool flag, int num)
    {
        SinkViewGodPort.text = num + "";
        if (flag)
        {
            SinkViewCop.transform.DOLocalMoveX(450, 0.5f);
        }

        if (num == 1)
        {
            SinkViewGodPort.text = "0";
            SinkViewCop.transform.DOLocalMoveX(725, 0.5f).SetDelay(1f);
        }
        
    }


    IEnumerator ErodeObeyOxide()
    {
        while (PlazaObeySway > 0)
        {
            PlazaObeySway--;
            PlazaObeyPort.text = PlazaObeySway + "";

            if (PlazaObeySway == 0)
            {
                FollyErodeObeyCup();
            }

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator ErodeTideOxide()
    {
        while (PlazaTideSway > 0)
        {
            PlazaTideSway--;
            PlazaTidePort.text = PlazaTideSway + "";
            if (PlazaTideSway == 0)
            {
                FollyErodeTideCup();
            }

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator DustViewOxide()
    {
        while (PlazaTideSway > 0)
        {
            PlazaTideSway--;

            if (PlazaTideSway == 0)
            {
                FollyErodeTideCup();
            }

            yield return new WaitForSeconds(1);
        }
    }
}