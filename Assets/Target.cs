using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject planeRotation;
    public float diff;
    Renderer color;
    public Material color1;
    public float a;
    public float b;
    void Start()
    {
        transform.rotation = Quaternion.Euler(20, 90, -90);
        color = GetComponent<Renderer>();
    }

    
    void Update()
    {
        if (transform.eulerAngles.x > 180)
            a = transform.eulerAngles.x- 360;
        else
           a = transform.eulerAngles.x;
        if (planeRotation.transform.eulerAngles.x > 180)
            b = planeRotation.transform.eulerAngles.x - 360;
        else
            b = planeRotation.transform.eulerAngles.x;
        diff = Mathf.Abs(a - b);
       
        if (diff < 5 || (183 > diff&&177<diff) )
        {
            color1.color = Color.green;
        }
        else
            color1.color = Color.red;
        Debug.Log(UnityEditor.TransformUtils.GetInspectorRotation(transform).x);
        
        
    }
}
