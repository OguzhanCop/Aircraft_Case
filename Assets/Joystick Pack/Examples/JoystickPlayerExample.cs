using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
   
    
    
    
    public FixedJoystick variableJoystick;
    public Rigidbody rb;
    public float Yaw;
    private float rotateX;
    private float rotateZ;
    public GameObject de;
    public float speed;
    public float z;
    

    public void Update()
    {
       
        inputJoystick();
        planeRotate();
        planeMovement();
        z = transform.eulerAngles.z;

    }
    void inputJoystick()
    {
        Yaw += variableJoystick.Horizontal * 30 * Time.deltaTime + (-rotateZ * Time.deltaTime) / 5;
        rotateX = rotateX - (variableJoystick.Vertical * Time.deltaTime * 30);
        rotateZ = rotateZ - (variableJoystick.Horizontal * Time.deltaTime * 30);

    }
    void planeRotate()
    {
        //transform.rotation = Quaternion.Euler(Vector3.right * rotateX + Vector3.up * Yaw + Vector3.forward * rotateZ * 3);
        Quaternion a = Quaternion.AngleAxis(rotateZ * 3, Vector3.forward);
        Quaternion b = Quaternion.AngleAxis(rotateX, Vector3.right);
        transform.rotation = a * b;
        transform.Rotate(0, Yaw, 0, Space.World);

    }
    void planeMovement()
    {
        speed = de.GetComponent<Accerelator>().speed;
        rb.velocity = transform.forward * speed;

    }

}