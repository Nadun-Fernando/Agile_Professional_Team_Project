using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamage(float damageAmount)
    {
        health = health - damageAmount;
        if (health <= 0)
        {
            health = 0;
            Destroy(this.gameObject);
        }
    }
}
