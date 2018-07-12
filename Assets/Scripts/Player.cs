using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
    public float speed, invunerableSpeed;
    public Rigidbody2D rb;
    public bool fire, water, earth;

    private bool invunerable = false;

    private void ChangeToFire()
    {
        fire = true;
        water = false;
        earth = false;
    }

    private void ChangeToWater()
    {
        fire = false;
        water = true;
        earth = false;
    }

    private void ChangeToEarth()
    {
        fire = false;
        water = false;
        earth = true;
    }

    public bool GetFire()
    {
        return fire;
    }

    public bool GetWater()
    {
        return water;
    }

    public bool GetEarth()
    {
        return earth;
    }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(speed * Time.deltaTime, 0, 0);
        Vector2 moveVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * 10 * speed;
        
        Debug.Log(moveVec);
        transform.Translate(moveVec * Time.deltaTime);    }
}
