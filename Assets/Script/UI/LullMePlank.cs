using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LullMePlank : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    public Button[] Knife;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    public Sprite Shed1Timely;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    public Sprite Shed2Timely;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button star in Knife)
        {
            star.onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int Onset= indexStr == "" ? 0 : int.Parse(indexStr);
                ReuseCabin(Onset);
            });
        }
        
    }

    public override void Display()
    {
        base.Display();
        ADUncover.Variance.HasteSwayParticipator();
        for (int i = 0; i < 5; i++)
        {
            Knife[i].gameObject.GetComponent<Image>().sprite = Shed2Timely;
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        ADUncover.Variance.RetoolSwayParticipator();
    }


    private void ReuseCabin(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Knife[i].gameObject.GetComponent<Image>().sprite = i <= index ? Shed1Timely : Shed2Timely;
        }
        if (index < 3)
        {
            StartCoroutine(VideoPlank());
        } else
        {
            // 跳转到应用商店
            LullMeUncover.instance.EpicAPRyeChilly();
            StartCoroutine(VideoPlank());
        }
        
        // 打点
        PlowSenseGarden.GetInstance().CanySense("1016", (index + 1).ToString());
    }

    IEnumerator VideoPlank(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
        CropUncover.Instance.LadeAmateur();
        FollyUIPeak(GetType().Name);
    }
}
