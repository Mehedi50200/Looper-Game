using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour {


    private float speed= 0.1f;
    Vector2 offset;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (speed <= 2)
        {
            offset = new Vector2(0, Time.time * speed);
            speed += 0.00001f;
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
        else{
            speed = 2.0f;
            offset = new Vector2(0, Time.time * speed);
            GetComponent<Renderer>().material.mainTextureOffset = offset;

        }
		
	}
}
