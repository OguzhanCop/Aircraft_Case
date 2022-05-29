using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public static JoystickPlayerExample instate;
    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody rb;
    public float Yaw;
    private float pitch;
    private float roll;
    private float horizontalInput;
    private float verticalInput;

    public void FixedUpdate()
    {
        //Vector3 direction = Vector3.forward * variableJoystick.Horizontal + Vector3.right * variableJoystick.Vertical;
        //Vector3 force = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        //rb.AddRelativeForce(force.x * 10, 0,0);
        //rb.AddRelativeForce(0,0,2);
        //gameObject.transform.Rotate(-direction);
    }
    public void Update()
    {
        rb.velocity = transform.forward * 24+transform.right*-roll;
        //transform.position += transform.forward * 50 * Time.deltaTime;
        inputJoystick();
        
        Yaw += horizontalInput * 30 * Time.deltaTime+(-roll/100);
        pitch = pitch - (verticalInput * Time.deltaTime * 30);
        roll = roll - (horizontalInput * Time.deltaTime * 30);
        transform.rotation = Quaternion.Euler(Vector3.right * pitch + Vector3.up * Yaw + Vector3.forward * roll*4 );
        Debug.Log(pitch);
    }
    void inputJoystick()
    {
        horizontalInput = variableJoystick.Horizontal;
        verticalInput = variableJoystick.Vertical;

    }

}