using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float moveSpeed = 600f;
    float movement = 0f;
    public GameObject scoreScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       movement = Input.GetAxisRaw("Horizontal");
		
	}

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        scoreScene.SetActive(true);
       
        //This is going to restart script which will be called by the end of the animation.
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
