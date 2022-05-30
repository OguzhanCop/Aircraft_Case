using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotationFollow : MonoBehaviour
{
    public GameObject plane;
    public float planeInspectorX;
    public List<GameObject> target=new List<GameObject>();
    private int i;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        planeInspectorX = plane.GetComponent<JoystickPlayerExample>().inspectorX;
        transform.rotation = Quaternion.Euler(90 - planeInspectorX, 90, -90);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "plane")
        {
            i++;
            transform.position = target[i].transform.position;
            
        }
    }
}
