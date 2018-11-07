using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void RestartScene()
    {
        Score.score = 0;
        Difficulty.difficulty = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
