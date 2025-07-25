using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Random = UnityEngine.Random;

public class SexGarden : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("boxImg")]    public GameObject ItsMad;
[UnityEngine.Serialization.FormerlySerializedAs("boxBtn")]    public Button ItsWeb;
[UnityEngine.Serialization.FormerlySerializedAs("bubbleGifImage")]    public GameObject CrisisZooEgypt;
    private Sequence _Beg1;
    private Sequence _Beg2;


    void Start()
    {
        SexMustUnload();

        ItsWeb.onClick.AddListener(() =>
        {
            EatUnload();
            SexIceInstrument.Instance.PearFlairPlank();
        });
    }


    public void SexHaste()
    {
        GunWebSubside();
        transform.DOPause();
        _Beg1.Pause();
        _Beg2.Pause();
    }

    public void SexRetool()
    {
        GunWebSewage();
        transform.DOPlay();
        _Beg1.Play();
        _Beg2.Play();
    }

    public void GunWebSewage()
    {
        ItsWeb.enabled = true;
    }

    public void GunWebSubside()
    {
        ItsWeb.enabled = false;
    }

    private void EatUnload()
    {
        ItsMad.SetActive(false);
        ItsWeb.gameObject.SetActive(false);
        CrisisZooEgypt.SetActive(true);
    }


    private void SexMustUnload()
    {
        _Beg1 = DOTween.Sequence();
        _Beg2 = DOTween.Sequence();
        int leftOrRight = Random.Range(0, 2);
        if (leftOrRight == 0)
        {
            transform.localPosition = new Vector3(-450f, 0, 0);
            _Beg1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            _Beg1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            _Beg1.SetLoops(-1);
            _Beg1.Play();

            _Beg2.Append(transform.DOScale(1.4f, 0.5f).SetEase(Ease.Linear));
            _Beg2.Append(transform.DOScale(1.3f, 0.5f).SetEase(Ease.Linear));
            _Beg2.SetLoops(-1);
            _Beg2.Play();
            transform.DOLocalMoveX(450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                _Beg1.Kill();
                _Beg2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
        else
        {
            transform.localPosition = new Vector3(450, 0, 0);
            _Beg1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            _Beg1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            _Beg1.SetLoops(-1);
            _Beg1.Play();

            _Beg2.Append(transform.DOScale(1.4f, 0.5f).SetEase(Ease.Linear));
            _Beg2.Append(transform.DOScale(1.3f, 0.5f).SetEase(Ease.Linear));
            _Beg2.SetLoops(-1);
            _Beg2.Play();
            transform.DOLocalMoveX(-450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                _Beg1.Kill();
                _Beg2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
    }
}