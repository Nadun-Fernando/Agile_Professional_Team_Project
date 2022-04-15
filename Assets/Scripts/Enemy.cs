using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 20f;

    public GameObject gun;
    
    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("gun");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamage(float damageAmount)
    {
        GunFire gunFire = gun.GetComponent<GunFire>(); //taking the script which is on the gun
        
        health = health - damageAmount;
        if (health <= 0)
        {
            health = 0;
            gunFire.shootingScore(1);
            Destroy(this.gameObject);
        }
    }
}
