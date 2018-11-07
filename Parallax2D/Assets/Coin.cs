using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public Rigidbody2D rb;

    public float shrinkSpeed = 5f;

    // Use this for initialization
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
      

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.one * shrinkSpeed * Time.deltaTime;
        //transform.localScale -= Vector3.one * .5f  * Time.deltaTime;
        if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
           // Score.score += 1;
        }

    }
}
