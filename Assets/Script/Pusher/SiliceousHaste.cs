using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiliceousHaste : MonoBehaviour
{
    Vector3 Theorist;

    /// <summary>
    /// ��ͣ������
    /// </summary>
    public void MuralSiliceous()
    {
        if (GetComponent<Rigidbody>() != null)
        {
            Theorist = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        if (GetComponent<Rigidbody2D>() != null)
        {
            Theorist = GetComponent<Rigidbody2D>().velocity;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
    public void ScantySiliceous()
    {
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().velocity = Theorist;
        }
        if (GetComponent<Rigidbody2D>() != null)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            GetComponent<Rigidbody2D>().velocity = Theorist;
        }
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
