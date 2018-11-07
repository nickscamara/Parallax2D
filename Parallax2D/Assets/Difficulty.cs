using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour {


    public static int difficulty = 0;
	// Update is called once per frame
	void Update () {

        

        if (Score.score > 4)
        {
            difficulty = 1;
            if (Score.score > 8)
            {
                difficulty = 2;
                if (Score.score > 12)
                {
                    difficulty = 3;
                    if (Score.score > 20)
                    {
                        difficulty = 4;
                    }
                }
            }
        }
        
		
	}
}
