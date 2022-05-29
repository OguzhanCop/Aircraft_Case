using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    JoystickPlayerExample joystick;
    public Transform target;
    public float smoothSpeed = 2f;
    public Vector3 offset;
    private void Start()
    {
       
        offset = transform.position - target.position;
    }
    private void LateUpdate()
    {
        
        Vector3 desiredPosition = target.position + offset;
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = desiredPosition;
        //(transform.LookAt(target);
        transform.rotation = Quaternion.Euler(transform.rotation.x, joystick.Yaw, transform.position.z);
        
    }
}
