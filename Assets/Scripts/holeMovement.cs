using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class holeMovement : MonoBehaviour {

    private float speed=1;
    private float timer=0;
    private float y_speed=2;
    
   


    // Use this for initialization
    void Start () {
               
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(0, -y_speed, 0) * speed * Time.deltaTime);
       
    }
}
