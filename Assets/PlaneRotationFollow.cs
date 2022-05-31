using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaneRotationFollow : MonoBehaviour
{
    public GameObject plane;
    public float planeInspectorX;
    public List<GameObject> target = new List<GameObject>();
    public static int i = 0;
    public TextMeshProUGUI leaderboard;
    private int score=0;

    void Start()
    {

    }
        
    void Update()
    {
        leaderboard.text = "Score:" + score;
        planeInspectorX = plane.GetComponent<JoystickPlayerExample>().rotateZ;
        transform.rotation = Quaternion.Euler(90 - planeInspectorX*3, 90, -90);
    }
    private void OnTriggerEnter(Collider other)
    {


       if (other.gameObject.transform.tag == "plane")
                    
        {
            if (Target.task)
                score += 100;
            else
                score -= 100;
            if (i < target.Count - 1)
            
            
            {

                i++;
                transform.position = target[i].transform.position;
            }
            else
                Debug.Log("end");                
              
      
        }      
       
    }
}

