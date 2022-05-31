using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject plane;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
       
    }
}
