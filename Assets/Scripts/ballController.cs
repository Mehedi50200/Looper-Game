using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

    private float ballSpeed;
    Vector3 position;
    private float maxPos= 2.60f;
    Rigidbody2D rb;
    public uiManager ui;
    
   

    // Use this for initialization
    void Start () {

        ballSpeed = 1.5f;
        rb = GetComponent<Rigidbody2D>();
        position = transform.position;
        
		
	}
	
	// Update is called once per frame
	void Update () {
       
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        AccelerometerMove();
        transform.Rotate(0, 0, 4);       
        position = transform.position;
        position.x = Mathf.Clamp(position.x, -2.60f, 2.62f);
        transform.position = position;

    }

   

    public void MoveLeft() {
        rb.velocity = new Vector2(-ballSpeed, 0);

    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(ballSpeed, 0);

    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;

    }

    
    void AccelerometerMove()
    {
        float x = Input.acceleration.x;
        if (x < -0.05f)
        {
            ballSpeed = 2f;
            MoveLeft();
            ballSpeed += 0.25f;
        }
        else if (x > 0.05)
        {
            ballSpeed = 2f;
            MoveRight();
            ballSpeed += 0.25f;
        }
        else
        {
            SetVelocityZero();
        }
    }

       
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hole") {
            Destroy(gameObject);
            ui.gameOverActivation();           
        }
    }
    
    
    
}
