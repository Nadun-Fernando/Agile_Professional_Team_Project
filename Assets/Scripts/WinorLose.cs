using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinorLose : MonoBehaviour
{
    public GameObject lostMessage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Time.timeScale = 0;
            lostMessage.SetActive(true);
            print("You Lost!!!");
        }
    }
}
