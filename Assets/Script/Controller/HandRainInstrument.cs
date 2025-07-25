// Project: Plinko
// FileName: HandRainInstrument.cs
// Author: AX
// CreateDate: 20230526
// CreateTime: 15:19
// Description:

using System;
using DG.Tweening;
using UnityEngine;

    public class HandRainInstrument : MonoBehaviour
    {
[UnityEngine.Serialization.FormerlySerializedAs("handImg")]        public GameObject HighMad;

        private void Start()
        {
            CabinHurl();
        }

        private void CabinHurl()
        {
           Sequence  handSeq = DOTween.Sequence();
           handSeq.Append(HighMad.transform.DOLocalMoveY(25f, 0.3f)).SetEase(Ease.InSine);;
           handSeq.Append(HighMad.transform.DOLocalMoveY(0f, 0.3f)).SetEase(Ease.InSine);;
           handSeq.SetLoops(-1);
           handSeq.Play();
        }

    }
