using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float moveSpeed = 600f;
    float movement = 0f;
    public GameObject scoreScene;
    public float longD = 1.5f;
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       movement = Input.GetAxisRaw("Horizontal");
		
	}

    private void FixedUpdate()
    {
        //transform.position()
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);

        if (Input.GetKeyDown("space"))
        {
            transform.position = new Vector3(0, longD, 0);
            
        }
        else if (Input.GetKeyUp("space") )
        {
            transform.position = new Vector3(0, 0.6f, 0);
           
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        scoreScene.SetActive(true);
       
        //This is going to restart script which will be called by the end of the animation.
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
