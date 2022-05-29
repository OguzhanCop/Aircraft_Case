using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accerelator : MonoBehaviour
{
    
    public Slider accerelator;
    public float speed;
    void Start()
    {
       
    }

   
    void Update()
    {
        speed = Mathf.Lerp(speed, accerelator.value * 50, 0.3f * Time.deltaTime);
        
    }
   
}
