using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreShow : MonoBehaviour
{

    public static int scoree = 0;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI cc;
    public TextMeshProUGUI nameH;
    public GameObject gg;
    public InputField input;

    public Button btn;
    // Use this for initialization
    void Start()
    {
        if (Score.newHigh == true)
         {
            gg.SetActive(true);


           btn.onClick.AddListener(ScoreBoard);

       }

        txt.text = Score.score.ToString();

        cc.text = PlayerPrefs.GetInt("Highscore").ToString();
        nameH.text = PlayerPrefs.GetString("name").ToString() + "'s";
    }

    private void ScoreBoard()
    {

        
        
            string name = input.text;
            PlayerPrefs.SetString("name", name);
             gg.SetActive(false);
            Debug.Log(name);
        
    }
}
	
	
