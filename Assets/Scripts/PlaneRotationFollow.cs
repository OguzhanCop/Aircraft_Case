using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;


public class PlaneRotationFollow : MonoBehaviour
{
   
    public GameObject plane;
    public float planeInspectorX;
    public List<GameObject> target = new List<GameObject>();
    public  int targetpoint = 0;
    public TextMeshProUGUI leaderboard;
    private int score=0;
    public  GameObject camera2;
    public Transform camera2position;
    public GameObject Button;
    float rotationX;

         
    void Update()
    {      
        rotationcheck();
        scoreboard();
    }
    
    private void OnTriggerEnter(Collider other)
    {

       if (other.gameObject.transform.tag == "plane")
                    
        {
            if (Target.task)
                score += 100;
            else
                score -= 100;
            if (targetpoint < target.Count - 1)

            {
                targetpoint++;
                transform.position = target[targetpoint].transform.position;
            }
            else
            {
                plane.GetComponent<Animator>().SetBool("CameraSwitch", true);
                camera2position.gameObject.transform.SetParent(null);
                camera2.GetComponent<CinemachineVirtualCamera>().Follow = camera2position;
                Invoke("restart", 3f);                          

            }      
        }             
    }
    void scoreboard()
    {
        leaderboard.text = "Score:" + score;
    }
    void rotationcheck()
    {
        rotationX = plane.GetComponent<JoystickPlayerExample>().check;
        transform.rotation = Quaternion.Euler(90 - rotationX, 90, -90);

    }
    public void restart()
    {        
        Button.GetComponent<PlayButton>().explosion();
    }         
}

