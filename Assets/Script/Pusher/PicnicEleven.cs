﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicnicEleven : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("block")]
    public System.Action Front;
    private void OnTriggerEnter(Collider other)
    {
        Front();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
