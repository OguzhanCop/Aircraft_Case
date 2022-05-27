using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Horizontal + Vector3.right * variableJoystick.Vertical;
        Vector3 force = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddRelativeForce(force.x * 10, 0,0);
        rb.AddRelativeForce(0,0,2);
        gameObject.transform.Rotate(-direction);
    }
    
}