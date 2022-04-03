using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinorLose : MonoBehaviour
{
    private GameObject[] enemiesArray;

    private int enemyCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemiesArray = GameObject.FindGameObjectsWithTag("enemy");
        enemyCount = enemiesArray.Length;

        if (enemyCount == 0)
        {
            print("You Won the Level!!!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            print("You Lost!!!");
        }
    }
}
