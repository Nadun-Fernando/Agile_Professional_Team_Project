using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject farmer;
    public GameObject enemy;
    public GameObject gun;
    public GameObject firebutton;
    public GameObject crosshair;
    public GameObject textscore;
    public GameObject message;
    public GameObject restartbutton;
    
    public void onPause()
    {
        Time.timeScale = 0; //time stops.. 'pause'
        farmer.SetActive(false);
        enemy.SetActive(false);
        gun.SetActive(false);
        firebutton.SetActive(false);
        restartbutton.SetActive(false);
        crosshair.SetActive(false);
        textscore.SetActive(false);
        message.SetActive(true);
    }

    public void onResume()
    {
        Time.timeScale = 1; //time resumes.. 'Resume'
        farmer.SetActive(true);
        enemy.SetActive(true);
        gun.SetActive(true);
        firebutton.SetActive(true);
        restartbutton.SetActive(true);
        crosshair.SetActive(true);
        textscore.SetActive(true);
        message.SetActive(false);
    }
}
