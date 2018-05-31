using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public bool fire;
    public bool water;
    public bool earth;
    public GameObject[] elements;

    public void ChangeToFire()
    {
        fire = true;
        water = false;
        earth = false;
    }

    public void ChangeToWater()
    {
        fire = false;
        water = true;
        earth = false;
    }

    public void ChangeToEarth()
    {
        fire = false;
        water = false;
        earth = true;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
