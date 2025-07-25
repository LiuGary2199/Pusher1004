using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFlannel : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("materialId")]    // Scroll main texture based on time
    public int PlateletTo= 0;
[UnityEngine.Serialization.FormerlySerializedAs("scrollSpeedX")]    public float WeightRavenX= 0.5f;
[UnityEngine.Serialization.FormerlySerializedAs("scrollSpeedY")]    public float WeightRavenY= 0f;
    Renderer Bear;

    void Start()
    {
        Bear = GetComponent<Renderer>();
    }

    void Update()
    {
        //GetComponent<LineRenderer>().materials[0].
        

        float offsetX = Time.time/2 * -WeightRavenX;
        float offsetY = Time.time * WeightRavenY;

        Bear.materials[PlateletTo].SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));

        //rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }

}
