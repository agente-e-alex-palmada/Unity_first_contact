﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public const float COOLDOWN = 2.0f;
    public float lastTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > lastTime + COOLDOWN)/*If last time was more than 5 seconds ago*/
            {
                lastTime = Time.time;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
