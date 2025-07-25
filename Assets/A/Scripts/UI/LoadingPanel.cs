using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Loadingҳ��
/// </summary>
public class LoadingPanel : MonoBehaviour
{
    /// <summary>
    /// ������
    /// ��Maskʵ��
    /// </summary>
    public Image progressMask;

    /// <summary>
    /// ������ͼƬ
    /// </summary>
    public Image progressBarImage;

    /// <summary>
    /// ����������
    /// </summary>
    private float progressLength;

    /// <summary>
    /// �������߶�
    /// </summary>
    private float progressHeight;

    /// <summary>
    /// ��������ͷ��ʱ��
    /// </summary>
    private float progressTime = 3f;

    /// <summary>
    /// ��ǰ�������߹���ʱ��
    /// </summary>
    private float currTime = 0;

    /// <summary>
    /// �������Ƿ���������
    /// </summary>
    private bool isProgressAdding = true;

    void Start()
    {
        // ����������
        progressLength = progressBarImage.rectTransform.rect.width;
        // �������߶�
        progressHeight = progressBarImage.rectTransform.rect.height;
        //��ʼ����������
        progressMask.rectTransform.sizeDelta = new Vector2(0, progressLength);
    }

    void Update()
    {
        if (isProgressAdding)
        {
            currTime += Time.deltaTime;
            progressMask.rectTransform.sizeDelta = new Vector2(currTime / progressTime * progressLength, progressHeight);
            if (progressMask.rectTransform.rect.width >= progressLength)
            {
                progressMask.rectTransform.sizeDelta = new Vector2(progressLength, progressHeight);
                isProgressAdding = false;
                Invoke("EnterGame", 0.5f);
            }
        }
    }

    /// <summary>
    /// ������Ϸ
    /// </summary>
    void EnterGame()
    {
        gameObject.SetActive(false);
    }
}
