using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwelveLess : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Light")]    public bool Flora;
[UnityEngine.Serialization.FormerlySerializedAs("Lock")]    public bool Rome;
    // Start is called before the first frame update
    void Start()
    {
        Flora = false;
        Rome = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D obj)
    {
        BrownTip.GetInstance().TossClutch(BrownOnce.SceneMusic.sound_column_normal,0.1f);
        if (Flora == false) 
        {
            DenialUncover.Instance.SkyStableGod();
        }
        if (Rome == false) 
        {
            IngenuityInstrument.LordIdle(gameObject);
            StartCoroutine(CloseIngenuity(gameObject.GetComponent<SpriteRenderer>()));
        }
        Flora = true;
    }
    IEnumerator CloseIngenuity(SpriteRenderer Column)
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Selection);
        Rome = true;
        Column.sprite = Resources.Load<Sprite>(CShield.Tex_10);
        yield return new WaitForSeconds(0.2f);
        Column.sprite = Resources.Load<Sprite>(CShield.Law_8);
        Rome = false;
    }
}
