using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShow : MonoBehaviour
{

    public static int scoree = 0;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI cc;
    // Use this for initialization
    void Start()
    {
        txt.text = Score.score.ToString();

        cc.text = PlayerPrefs.GetInt("Highscore").ToString();
    }
}
	
	
