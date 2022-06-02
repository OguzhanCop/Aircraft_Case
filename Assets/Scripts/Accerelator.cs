using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Accerelator : MonoBehaviour
{
    
    public Slider accerelator;
    public float speed;
    public TextMeshProUGUI speedometer;
   
    void Update()
    {
        speedcontrol();
      
    }
    void speedcontrol()
    {
        speed = Mathf.Lerp(speed, accerelator.value * 50, 0.3f * Time.deltaTime);
        speedometer.text = "" + (int)speed * 4;
    }
   
}
