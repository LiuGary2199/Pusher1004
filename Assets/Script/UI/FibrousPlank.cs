using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;
using UnityEngine.SceneManagement;

public class FibrousPlank : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    public Image UnsungEgypt;
[UnityEngine.Serialization.FormerlySerializedAs("PassSliderImage")]    public Image JazzLordlyEgypt;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    public Text EmployeePort;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]    public SkeletonGraphic AllowHurl;
    AsyncOperation CouldRace;
[UnityEngine.Serialization.FormerlySerializedAs("gamebg")]

    public Image Result;
[UnityEngine.Serialization.FormerlySerializedAs("passbg")]    public Sprite Squirt;
[UnityEngine.Serialization.FormerlySerializedAs("OldPass")]    public GameObject JoyJazz;
[UnityEngine.Serialization.FormerlySerializedAs("NewPass")]    public GameObject JobJazz;
[UnityEngine.Serialization.FormerlySerializedAs("titleObj")]    public GameObject AllowCop;
[UnityEngine.Serialization.FormerlySerializedAs("EnterBtn")]
    public Button BrawlWeb;
[UnityEngine.Serialization.FormerlySerializedAs("progressObj")]    public GameObject EmployeeCop;



    // Start is called before the first frame update
    void Start()
    {
        EmployeeCop.SetActive(true);
        BrawlWeb.onClick.RemoveAllListeners();
        BrawlWeb.onClick.AddListener(() =>
        {
            if (FalconErie.MyUnder())
            {
                CouldRace.allowSceneActivation = true;
            }
            else {
                Destroy(transform.gameObject);
                CropUncover.Instance.FarePass();
            }
        });
        //if (PlayerPrefs.HasKey(CShield.sys_AppSH))
        //{
        //    gamebg.sprite = passbg;
        //    titleAnim.gameObject.SetActive(true);
        //    titleObj.SetActive(false);
        //    OldPass.gameObject.SetActive(false);
        //    NewPass.gameObject.SetActive(true);
        //}
        //else
        //{
        //    titleAnim.gameObject.SetActive(false);
        //    titleObj.SetActive(true);
        //    OldPass.gameObject.SetActive(true);
        //    NewPass.gameObject.SetActive(false);
        //}
        if (!PlayerPrefs.HasKey(CShield.Bet_Threaten))
        {
            MoreBulkUncover.GunSmooth(CShield.Bet_Threaten, I2.Loc.LocalizationManager.CurrentLanguage);
        }


        JazzLordlyEgypt.fillAmount = 0;
        UnsungEgypt.fillAmount = 0;
        EmployeePort.text = "0%";

        AllowHurl.AnimationState.SetAnimation(0, "chuxian", false);
        AllowHurl.AnimationState.AddAnimation(0, "daiji", true, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (UnsungEgypt.fillAmount <= 0.8f || (SapScanTip.instance.Tread && CashOutManager.GetInstance().Ready))
        {
            JazzLordlyEgypt.fillAmount += Time.deltaTime / 3f;
            UnsungEgypt.fillAmount += Time.deltaTime / 3f;
            EmployeePort.text = (int)(UnsungEgypt.fillAmount * 100) + "%";

            if (SapScanTip.instance.Tread && FalconErie.MyUnder() && CouldRace == null) //审核，模式 
            {
                CouldRace = SceneManager.LoadSceneAsync(1);
                CouldRace.allowSceneActivation = false;
            }
            if (UnsungEgypt.fillAmount >= 1)
            {
                Destroy(transform.gameObject);
                if (FalconErie.MyUnder())
                {
                    CouldRace.allowSceneActivation = true;
                }
                else
                {
                    CropUncover.Instance.FarePass();
                }


                //EmployeeCop.SetActive(false);
                //BrawlWeb.gameObject.SetActive(true);
            }
        }
    }
}
