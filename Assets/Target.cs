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
        //if (transform.eulerAngles.x > 180)
        //    a = transform.eulerAngles.x- 360;
        //else
        //   a = transform.eulerAngles.x;
        //if (planeRotation.transform.eulerAngles.x > 180)
        //    b = planeRotation.transform.eulerAngles.x - 360;
        //else
        //    b = planeRotation.transform.eulerAngles.x;
        a = (UnityEditor.TransformUtils.GetInspectorRotation(transform).x)%360;
        b = (UnityEditor.TransformUtils.GetInspectorRotation(planeRotation.transform).x)%360;
        diff = Mathf.Abs( a - b);
        Debug.Log(diff);
        if (diff < 185 && diff > 175)
            diff = Mathf.Abs(180 - diff);
        if (diff<5 )
        {
            color1.color = Color.green;
        }
        else
            color1.color = Color.red;
        
        
        
    }
}
