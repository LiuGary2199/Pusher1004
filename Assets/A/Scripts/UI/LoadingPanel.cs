using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Loading页面
/// </summary>
public class LoadingPanel : MonoBehaviour
{
    /// <summary>
    /// 进度条
    /// 用Mask实现
    /// </summary>
    public Image progressMask;

    /// <summary>
    /// 进度条图片
    /// </summary>
    public Image progressBarImage;

    /// <summary>
    /// 进度条长度
    /// </summary>
    private float progressLength;

    /// <summary>
    /// 进度条高度
    /// </summary>
    private float progressHeight;

    /// <summary>
    /// 进度条到头的时间
    /// </summary>
    private float progressTime = 3f;

    /// <summary>
    /// 当前进度条走过的时间
    /// </summary>
    private float currTime = 0;

    /// <summary>
    /// 进度条是否正在增长
    /// </summary>
    private bool isProgressAdding = true;

    void Start()
    {
        // 进度条长度
        progressLength = progressBarImage.rectTransform.rect.width;
        // 进度条高度
        progressHeight = progressBarImage.rectTransform.rect.height;
        //开始进度条动画
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
    /// 进入游戏
    /// </summary>
    void EnterGame()
    {
        gameObject.SetActive(false);
    }
}
