using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject planeRotation;
    private float diff;
    [SerializeField] private int angleTolarence;
   
    public float targetAngleX;
    public float planeAngleX;
    Renderer color;
    Renderer colorChild1;
    Renderer colorChild2;
    bool angleControl=false;
    public static bool task;
    void Start()
    {
        color = this.GetComponent<Renderer>();
        colorChild1 = this.transform.GetChild(0).GetComponent<Renderer>();
        colorChild2 = this.transform.GetChild(1).GetComponent<Renderer>();
    }

    
   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "angle")
        {
            angleControl = true;

        }       
            
        if (other.gameObject.tag == "angle2" &&  angleControl)
        {
            Debug.Log("asd");
            color.material.color = Color.green;
            colorChild1.material.color = Color.green;
            colorChild2.material.color = Color.green;
            task = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "angle" || other.gameObject.tag == "angle2")
        {
            Debug.Log("red");
            color.material.color = Color.red;
            colorChild1.material.color = Color.red;
            colorChild2.material.color = Color.red;
            angleControl = false;
            task = false;
        }
    }
    void Update()
    {

        //AngleState();
        //AngleDiff();
        //AngleCheck(angleTolarence);

    }
    //void AngleState()
    //{
    //    targetAngleX = (UnityEditor.TransformUtils.GetInspectorRotation(transform).x) % 360;
    //    planeAngleX = (UnityEditor.TransformUtils.GetInspectorRotation(planeRotation.transform).x) % 360;

    //}
    //void AngleDiff()
    //{
    //    diff = Mathf.Abs(targetAngleX - planeAngleX);

    //}
    //void AngleCheck(int a)
    //{
    //    if (diff < (180 + a) && diff > (180 - a))
    //        diff = Mathf.Abs(180 - diff);
    //    if (diff < (360 + a) && diff > (360 - a))
    //        diff = Mathf.Abs(360 - diff);
    //    if (diff < a)
    //    {

    //        color.material.color = Color.green;
    //        colorChild1.material.color = Color.green;
    //        colorChild2.material.color = Color.green;


    //    }
    //    else
    //    {

    //        color.material.color = Color.red;
    //        colorChild1.material.color = Color.red;
    //        colorChild2.material.color = Color.red;
    //    }


    //}



}
