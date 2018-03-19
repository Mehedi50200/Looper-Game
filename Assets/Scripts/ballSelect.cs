using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballSelect : MonoBehaviour {

    public static int ballNum;
    public static int panelNum;
    public GameObject footbalPanel;
    public GameObject basketballPanel;
    public GameObject tennisballPanel;

    public void ballSelectFunction(int selectedNum) {
        ballNum = selectedNum;

        if (selectedNum == 0)
        {
            footbalPanel.gameObject.SetActive(true);
            basketballPanel.gameObject.SetActive(false);
            tennisballPanel.gameObject.SetActive(false);
        }

        if (selectedNum == 1)
        {
            footbalPanel.gameObject.SetActive(false);
            basketballPanel.gameObject.SetActive(true);
            tennisballPanel.gameObject.SetActive(false);
        }

        if (selectedNum == 2)
        {
            footbalPanel.gameObject.SetActive(false);
            basketballPanel.gameObject.SetActive(false);
            tennisballPanel.gameObject.SetActive(true);
        }




    }

    //Application.LoadLevel("Menu");


	


}
