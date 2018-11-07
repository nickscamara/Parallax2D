using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public static int score = 0;
    public static int coins = 0;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI cc;
    public Camera cam;
    public TextMeshProUGUI coinss;
    public static bool newHigh = false;
    // Use this for initialization
    void Start () {
        txt = GetComponent<TextMeshProUGUI>();
        
        cc.text = "Highscore: "+ PlayerPrefs.GetInt("Highscore").ToString();
        coinss.text = "Coins: " + PlayerPrefs.GetInt("Coins").ToString();
        Debug.Log(cc.text);
        Debug.Log(coinss.text);
    }
	
	// Update is called once per frame
	void Update () {
        txt.text = "" + score;
        coinss.text = "Coins: " + PlayerPrefs.GetInt("Coins");

        







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

                        if (score > 6)
                        {
                            cam.backgroundColor = Color.magenta;
                        }
                        if (score > 8)
                        {
                            cam.backgroundColor = Color.yellow;
                        }

                    }

                }

            }
        }
        


        if (score >= PlayerPrefs.GetInt("Highscore"))
        {
            cc.text = "Highscore:" + score;
            newHigh = true;



            PlayerPrefs.SetInt("Highscore", score);
        }
	}

    public static void OnSaveCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }
}
