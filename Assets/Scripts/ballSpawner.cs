using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ballSpawner : MonoBehaviour {

    public GameObject[] Balls;
    public Transform BallSpawnPoint;
    public static int ballNum;

     
    public void ballSelectFunction(int selectedNum)
    {
        ballNum = selectedNum;
    }


    // Use this for initialization
    void Start () {

        Instantiate(Balls[ballSelect.ballNum], BallSpawnPoint.position, BallSpawnPoint.rotation).SetActive(true);              

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    

}
