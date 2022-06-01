using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    public GameObject plane;
    public GameObject partickleSystem;
      
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire")
        {
            partickleSystem.transform.SetParent(null);
            Destroy(plane);
            partickleSystem.GetComponent<ParticleSystem>().Play();
            
        }
    }
    
}
