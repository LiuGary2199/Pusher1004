using System;
using DG.Tweening;
using UnityEngine;

public class ShovelTenthInstrument : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("posY")]    public float VasY;
[UnityEngine.Serialization.FormerlySerializedAs("stoneRadius")]    public float WorthHawaii;
[UnityEngine.Serialization.FormerlySerializedAs("delayTime")]    public float EnjoySway;
[UnityEngine.Serialization.FormerlySerializedAs("moveTime")]    public float NeonSway;
[UnityEngine.Serialization.FormerlySerializedAs("movingFlog")]
    public bool SatireLimy;

    private Sequence SatireSad;

    private void Awake()
    {
        //delayTime = 2f;
    }

    private void Start()
    {
        transform.localPosition = new Vector3(-WorthHawaii, VasY, -1.314f);
        ShovelCup();
    }

    public void LumpShovel()
    {
        SatireLimy = false;
        SatireSad.Pause();
    }

    public void ReCabinShovel()
    {
        SatireLimy = true;
        SatireSad.Play();
    }

    private void ShovelCup()
    {
        SatireSad = DOTween.Sequence();
        SatireSad.Append(transform.DOLocalMoveX(WorthHawaii, NeonSway).SetEase(Ease.InOutCubic));
        SatireSad.AppendInterval(EnjoySway);
        SatireSad.Append(transform.DOLocalMoveX(-WorthHawaii, NeonSway).SetEase(Ease.InOutCubic));
        SatireSad.AppendInterval(EnjoySway);
        SatireSad.SetLoops(-1);
        SatireSad.Play();
    }



}