using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public Camera fpsCamera;
    public float range = 50f;
    public float damage = 5f;
    public float impactForce = 60f;
    public int score = 0;
    
    public AudioSource gunsound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        /*
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
            gunsound.Play();
        } */
    }
    public void shoot()
    {
        gunsound.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range))
        {
            print("bullet hit :-" + hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.takedamage(damage);
            }
            


            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            

        }
    }

    public void shootingScore(int hit)
    {
        score += hit;
    }
}
