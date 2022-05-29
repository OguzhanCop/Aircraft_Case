using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject plane;
    public float z;
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 90, -90);
    }

    void Update()
    {
        z = plane.GetComponent<JoystickPlayerExample>().z;
        transform.rotation = Quaternion.Euler(90-z, 90, -90);
        
        
    }
}
