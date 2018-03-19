using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeSpawner : MonoBehaviour {

    public GameObject hole;
    public float maxPos =2.60f;
    public float delayTimer = 1f;
    float timer;



	// Use this for initialization
	void Start () {
        timer = delayTimer;
       

    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <=0)
        {
            Vector3 holePos = new Vector3(Random.Range(-2.60f, 2.60f), transform.position.y, transform.position.z);
            Instantiate(hole, holePos, transform.rotation);
            delayTimer -= 0.0005f;
            timer = delayTimer;

        }

    }
}
