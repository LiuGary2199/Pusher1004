using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoUncover : MailPerformer<PhotoUncover>
{
    public string Scan;

    public void PearPhoto(string info)
    {
        Scan = info;
        UIManager.GetInstance().PearUIStain(nameof(Photo));
    }
}
