using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMover : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start ()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        Vector2 vel = new Vector2(1.0f, 0);
        rigidbody.velocity = vel * 10 * speed;
	}
}
