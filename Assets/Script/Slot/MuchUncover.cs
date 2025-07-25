// Project: Plinko
// FileName: MuchUncover.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 11:26
// Description:

using System;
using System.Collections;
using System.IO;
using DG.Tweening;
using DG.Tweening.Plugins.Options;
using Lofelt.NiceVibrations;
using UnityEngine;

public class MuchUncover : MonoBehaviour
{
    public static MuchUncover Instance;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup01")]
    public GameObject ThenRoost01;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup02")]    public GameObject ThenRoost02;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup03")]    public GameObject ThenRoost03;
[UnityEngine.Serialization.FormerlySerializedAs("inLittleGame")]
    public bool OfBackupLade;

    private SlotRewardType ThenCopBulk;

    private bool AwardWith;
    private bool AxJazz;

    private Sequence ThenSad;

    private void Awake()
    {
        Instance = this;
        AwardWith = false;
        AxJazz = false;
    }

    public void PotteryMuchRoost()
    {
        ThenRoost01.transform.localPosition = new Vector3(-0.88f, 0, 0);
        ThenRoost02.transform.localPosition = new Vector3(0, 0, 0);
        ThenRoost03.transform.localPosition = new Vector3(0.88f, 0, 0);

        ThenRoost01.GetComponent<MuchCopRoostInstrument>().PotteryBulk();
        ThenRoost02.GetComponent<MuchCopRoostInstrument>().PotteryBulk();
        ThenRoost03.GetComponent<MuchCopRoostInstrument>().PotteryBulk();
    }

    public void MuchLump()
    {
        AxJazz = true;
        ThenRoost01.transform.DOPause();
        ThenRoost02.transform.DOPause();
        ThenRoost03.transform.DOPause();
    }

    public void MuchAtCabin()
    {
        AxJazz = false;
        ThenRoost01.transform.DOPlay();
        ThenRoost02.transform.DOPlay();
        ThenRoost03.transform.DOPlay();
    }

    public void CabinMuch()
    {
        
        if (ThenCopBulk == SlotRewardType.Null)
        {
            SlotRewardType slotObjData1 = GameUtil.GetSlotObjDataWithOutThanks();
            SlotRewardType slotObjData2 = GameUtil.GetSlotObjDataWithOutThanks();
            SlotRewardType slotObjData3 = GameUtil.GetSlotObjDataWithOutThanks();
            while (slotObjData1 == slotObjData2)
            {
                slotObjData2 = GameUtil.GetSlotObjDataWithOutThanks();
            }

            ThenRoost01.GetComponent<MuchCopRoostInstrument>().ComedySecretCop(slotObjData1);
            ThenRoost02.GetComponent<MuchCopRoostInstrument>().ComedySecretCop(slotObjData2);
            ThenRoost03.GetComponent<MuchCopRoostInstrument>().ComedySecretCop(slotObjData3);
        }
        else
        {
            ThenRoost01.GetComponent<MuchCopRoostInstrument>().ComedySecretCop(ThenCopBulk);
            ThenRoost02.GetComponent<MuchCopRoostInstrument>().ComedySecretCop(ThenCopBulk);
            ThenRoost03.GetComponent<MuchCopRoostInstrument>().ComedySecretCop(ThenCopBulk);
        }
        
    }

    private void MustCup(Action finish)
    {
        AwardWith = true;
        StartCoroutine(nameof(TossMuchBrown));
        ThenRoost01.transform.DOLocalMoveY(-1f * 28,3f).OnComplete(() =>
        {
            //音效
            BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_slotwheel_stop);
        });
        ThenRoost02.transform.DOLocalMoveY(-1f * 28, 3f).SetDelay(0.3f).OnComplete(() =>
        {
            //音效
            BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_slotwheel_stop);
        });
        ThenRoost03.transform.DOLocalMoveY(-1f * 28, 3f).SetDelay(0.6f).OnComplete(() =>
        {
            BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_slotwheel_stop);

            StopCoroutine(nameof(TossMuchBrown));
            ThenRoost03.transform.DOScale(1f, 0f).SetDelay(1f).OnComplete(() =>
            {
                DenialMuchIceSewerage.Instance.AxMuchWith = false;
                //音效
            
                AwardWith = false;

                finish();
                PotteryMuchRoost();
                if (ThenCopBulk == SlotRewardType.Null)
                {
                    Invoke(nameof(PearBreechPlank), 0.5f);
                }
                else
                {
                    CropUncover.Instance.FaunaMuch();
                }
            });
        });
    }


    public void SkyStableGod(SlotRewardType targetType)
    {

        // PlaySlot();
    }


    public void TossMuch(SlotRewardType targetType ,Action finish)
    {
        ThenCopBulk = targetType;
        PlowSenseGarden.GetInstance().CanySense("1003",ThenCopBulk.ToString());
        AwardWith = false;
        CabinMuch();
        MustCup(finish);
    }

    private void PearBreechPlank()
    {
        if (!OfBackupLade)
        {
            VerifyGroupUncover.Instance.PearHangMuchPlank();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            // PlaySlot();
        }
    }


    IEnumerator TossMuchBrown()
    {
        while (AwardWith)
        {
            if (!AxJazz)
            {
                BrownTip.GetInstance().TossClutch(BrownOnce.UIMusic.sound_slotwheel_rotate, 0.1f);
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
    public void Start()
    {
        //根据分辨率不同修改slot位置
        //float x = -0.616f* Screen.height - 159;
        //gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, x);
    }
    public void FollyMuchBG()
    {
     this.gameObject.SetActive(false);
    }
}