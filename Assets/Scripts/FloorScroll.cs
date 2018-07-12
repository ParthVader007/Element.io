using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScroll : MonoBehaviour {
    public float backgroudSize;

    private Transform cameraTransform;
    private Transform[] layers;
    private float viewZone = 10;
    private int leftIndex;
    private int rightIndex;

	// Use this for initialization
	void Start () {
        cameraTransform = Camera.main.transform;
        layers = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {

            layers[i] = transform.GetChild(i);
        }

        leftIndex = 0;
        rightIndex = layers.Length - 1;
	}

    private void Update()
    {
        if (cameraTransform.position.x < layers[leftIndex].transform.position.x - viewZone)
        {
            ScrollLeft();
        }
        if (cameraTransform.position.x > layers[rightIndex].transform.position.x + viewZone)
        {
            ScrollRight();
        }
    }

    private void ScrollLeft()
    {
        int lastRight = rightIndex;
        layers[rightIndex].position = new Vector3(layers[leftIndex].transform.position.x - backgroudSize, layers[rightIndex].transform.position.y, 0);
        leftIndex = lastRight;
        rightIndex--;
        if (rightIndex < 0)
        {
            rightIndex = layers.Length - 1;
        }
    }

    /*
     * ScrollRight will check if the player is too far to the right
     * and will scroll the floor to keep the player on it.
     */
	private void ScrollRight()
    {
        int lastLeft = leftIndex;
        layers[leftIndex].position = new Vector3(layers[rightIndex].transform.position.x + backgroudSize, layers[leftIndex].transform.position.y, 0);
        rightIndex = lastLeft;
        leftIndex++;
        if (leftIndex == layers.Length)
        {
            leftIndex = 0;
        }
    }
}
