using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    public float FlySpeed = 5;
    private float Yaw;
    private float pitch;
    private float roll;
    public Rigidbody rb;
    
    void LateUpdate()
    {

        //transform.position += transform.forward * FlySpeed * Time.deltaTime;
        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");
        //Yaw += horizontalInput * 50 * Time.deltaTime;
        //float pitch = Mathf.Lerp(0, 20, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);

        //float roll = Mathf.Lerp(0, 30, Mathf.Abs(horizontalInput)) * -Mathf.Sign(horizontalInput);
        //transform.rotation = Quaternion.Euler(Vector3.up * Yaw + Vector3.right * pitch + Vector3.forward * roll);
        //Debug.Log(pitch);

        transform.position += transform.forward * FlySpeed * Time.deltaTime;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Yaw += horizontalInput * 100 * Time.deltaTime;
       
        pitch = pitch - (verticalInput * Time.deltaTime * 100);
        roll = roll - (horizontalInput * Time.deltaTime * 100);
        
        transform.rotation = Quaternion.Euler(Vector3.right * pitch  + Vector3.forward * roll * 2+new Vector3(0,transform.rotation.y,0));
        transform.Rotate(0, Yaw  * Time.deltaTime, 0);

    }
}
