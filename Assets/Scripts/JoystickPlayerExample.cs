using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{

    public FixedJoystick variableJoystick;
    public Rigidbody rb;
    public float Yaw;
    private float rotateX;
    public float rotateZ;
    public GameObject pedal;
    public float speed;
    public float inspectorX;
    private bool control = false;
    public bool zkontrol = true;
    public float check;


    public void Update()

    {
        if (speed > 25 || control)
        {
            inputJoystick();
            control = true;
        }

        planeMovement();

    }


    void planeMovement()
    {
        speed = pedal.GetComponent<Accerelator>().speed;
        rb.velocity = transform.forward * speed;


    }
    void inputJoystick()
    {
        check = transform.eulerAngles.z;
        if (variableJoystick.Horizontal != 0)
        {
            transform.Rotate(0, 0, -variableJoystick.Horizontal * Time.deltaTime * 30, Space.Self);

        }
        if (variableJoystick.Vertical != 0)
        {
            transform.Rotate(-variableJoystick.Vertical * Time.deltaTime * 30, 0, 0, Space.Self);

        }
        if (variableJoystick.Horizontal == 0)
        {
            transform.rotation =
              Quaternion.Slerp(Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0), 1f * Time.deltaTime);

        }
        if (variableJoystick.Vertical == 0)
        {
            transform.rotation =
               Quaternion.Slerp(Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), 1f * Time.deltaTime);
        }
        if (variableJoystick.Horizontal != 0)
        {
            transform.Rotate(0, variableJoystick.Horizontal * Time.deltaTime * 50, 0, Space.World);
        }

    }    



    //    if (speed > 25 || control)
    //    {
    //        inputJoystick();
    //        control = true;
    //    }       
    //    planeRotate();
    //    planeMovement();

    //    //inspectorX = UnityEditor.TransformUtils.GetInspectorRotation(transform).z;
    //}
    //void inputJoystick()
    //{
    //    Yaw += variableJoystick.Horizontal * 30 * Time.deltaTime + (-rotateZ * Time.deltaTime) / 5;
    //    rotateX = rotateX - (variableJoystick.Vertical * Time.deltaTime * 30);
    //    rotateZ = rotateZ - (variableJoystick.Horizontal * Time.deltaTime * 30);

    //}
    //void planeRotate()
    //{
    //    //transform.rotation = Quaternion.Euler(Vector3.right * rotateX + Vector3.up * Yaw + Vector3.forward * rotateZ * 3);
    //    Quaternion a = Quaternion.AngleAxis(rotateZ * 3, Vector3.forward);
    //    Quaternion b = Quaternion.AngleAxis(rotateX, Vector3.right);
    //    transform.rotation = a * b;
    //    transform.Rotate(0, Yaw, 0, Space.World);        
    //}


} 

