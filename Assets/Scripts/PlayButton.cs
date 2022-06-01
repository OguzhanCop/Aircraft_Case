using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject plane;
    public Button play;
    public Button quit;
    public Button restart;
    public Button pause;
   
    void Update()
    {
        if (plane == null)
        {
            Invoke("explosion", 2f);
            
        }
    }
    public void explosion()
    {
        restart.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
        
    }
    public void restartbutton()
    {
        SceneManager.LoadScene(0);
    }
    public void pausebutton()
    {
        play.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void playbutton()
    {
        play.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void quitbutton()
    {
        Application.Quit();
    }
}
