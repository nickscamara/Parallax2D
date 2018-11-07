using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public static int score = 0;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI cc;
    public Camera cam;
    // Use this for initialization
    void Start () {
        txt = GetComponent<TextMeshProUGUI>();
        
        cc.text = "Highscore: "+ PlayerPrefs.GetInt("Highscore").ToString();
        Debug.Log(cc.text);
	}
	
	// Update is called once per frame
	void Update () {
        txt.text = "" + score;

       
      

       


        if (score > 1)
        {
            cam.backgroundColor = Color.green;
            if (score > 3)
            {

                cam.backgroundColor = Color.red;
                if (score > 4)
                {

                    cam.backgroundColor = Color.black;
                    if (score > 5)
                    {

                        cam.backgroundColor = Color.cyan;

                    }

                }

            }
        }
        


        if (score >= PlayerPrefs.GetInt("Highscore"))
        {
            cc.text = "Highscore:" + score;

            PlayerPrefs.SetInt("Highscore", score);
        }
	}
}
