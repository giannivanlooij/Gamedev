using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeBetweenPresses = 2.0f;  // interval time

    private float timestamp;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time >= timestamp && (Input.GetKeyDown(KeyCode.Space)) )
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timestamp = Time.time + timeBetweenPresses;
        }
    }
}
