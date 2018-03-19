using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    
    public GameObject gameOverPanel;
    public GameObject gamePausePanel;
    public Text scoreText;
    public Text finalScoreText;
    public Button btnRetry;
    int score;
    int finalScore;
    public bool gameOver;

   

   
   
    
     
    public void ChangeMenu(Transform changeMenu) {
        Camera.main.transform.LookAt(changeMenu.position);

    }

   
    // Use this for initialization
    void Start () {       
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 2f);
       
    }       
   
    // Update is called once per frame
    void Update () {
        if (!gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        else if (gameOver) {
                 
            finalScore = score;         
            finalScoreText.text = "" + finalScore;
            gameOverPanel.SetActive(true);

        }
        	
	}


    public void Play()
    {
        Application.LoadLevel("level1");
        Time.timeScale = 1;

    }

    public void Pause()
    {
     
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            gamePausePanel.gameObject.SetActive(true);

        }
        else if (Time.timeScale == 0) {
            Time.timeScale = 1;
            gamePausePanel.gameObject.SetActive(false);
        }
        
    }

    void scoreUpdate() {
        score += 1;
    }

        
    public void ExitToMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void ExitApp() {
        Application.Quit();
    }

    public void gameOverActivation()
    {
        gameOver = true;
        Time.timeScale = 0;

    }

    

}
