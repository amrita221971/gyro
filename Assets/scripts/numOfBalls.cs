using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numOfBalls : MonoBehaviour {
    private float counter;
	// Use this for initialization
	void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "ball")
        {
            counter++;
            Debug.Log(counter);
        }


    }
    private void OnCollisionExit(Collision collider)
    {
        if (collider.gameObject.tag == "ball")
        {
            counter--;
            Debug.Log(counter);
        }


    }
}
