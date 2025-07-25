using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Photo : GoldUIStain
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    public Text PhotoPort;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display()
    {
        base.Display();

        PhotoPort.text = PhotoUncover.GetInstance().Scan;
        StartCoroutine(nameof(LobeFollyPhoto));
    }

    private IEnumerator LobeFollyPhoto()
    {
        yield return new WaitForSeconds(2);
        FollyUIPeak(GetType().Name);
    }

}
