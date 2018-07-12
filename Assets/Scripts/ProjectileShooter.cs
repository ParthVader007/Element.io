using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ProjectileShooter : MonoBehaviour {
    GameObject fireShot, waterShot, earthShot;

	// Use this for initialization
	void Start () {
        fireShot = Resources.Load("fire shot") as GameObject;
        waterShot = Resources.Load("water shot") as GameObject;
        earthShot = Resources.Load("earth shot") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        bool isShooting = CrossPlatformInputManager.GetButton("Shoot");
        
        if (isShooting)
        {
            GameObject projectile = Instantiate(fireShot) as GameObject;
            projectile.transform.position = transform.position + transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * 40;
        }
        */
    }

    public void Shoot()
    {
        GameObject projectile = Instantiate(fireShot) as GameObject;
        projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * 40;
        } else
        {
            Debug.Log("No rigidbody detected on shot");
        }
        
    }

    private GameObject GetProjectile()
    {
        return fireShot;
    }
}
