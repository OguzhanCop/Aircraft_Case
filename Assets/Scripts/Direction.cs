using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{

    public GameObject directionCursor;
    public GameObject target;
     float distance;
    
    void Update()
    {
        directionTarget();
        
    }
    void directionTarget() 
    {
        distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance > 550)
        {
            directionCursor.SetActive(true);
            directionCursor.transform.LookAt(target.transform.position);
        } else
            directionCursor.SetActive(false);
    }
}
