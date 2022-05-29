using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject planeRotation;
    public float diff;
    void Start()
    {
        transform.rotation = Quaternion.Euler(40, 90, -90);
    }

    
    void Update()
    {
        diff = Mathf.Abs(transform.eulerAngles.x - planeRotation.transform.eulerAngles.x);
       
        if (diff < 5 || (183 > diff&&177<diff) )
        {
            Debug.Log("oldu");
        }
    }
}
