using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnRate = 2;

    public GameObject coin;

    public GameObject hex;
    public GameObject hex2;
    public GameObject hex3;
    public GameObject hex4;

    private float nextTimeToSpawn = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(coin, Vector3.one *Time.time, Quaternion.identity);
            nextTimeToSpawn = Time.time + 5f / spawnRate;
            if (Difficulty.difficulty == 0)
            {
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            }

            else if (Difficulty.difficulty == 1)
            {
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            }else if (Difficulty.difficulty == 2)
            {
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            }
            else if (Difficulty.difficulty == 3)
            {
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            }
            else if (Difficulty.difficulty == 4)
            {
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                Instantiate(hex, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + .8f / spawnRate;
            }
        }
		
	}
}
