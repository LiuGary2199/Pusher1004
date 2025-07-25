using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewerageNoble : MonoBehaviour
{
    System.Action FrontUnload;
    bool AxSense= true;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("��ײ");
        if (AxSense)
        {
            AxSense = false;
            FrontUnload();
            Destroy(this);
        }
    }

    public void LadNobleUnload(System.Action block)
    {
        FrontUnload = block;
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
