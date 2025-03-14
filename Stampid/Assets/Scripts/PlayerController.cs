using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 20.0f;
    public float xRange = 20;
    public float zRange = 10;
    public GameObject projectilePrefab;

    void Update()
    {
        // Shoot projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        // Keep player in X bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Keep player in Z bounds 
        if (transform.position.z < -zRange + 8)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange + 8);
        }
        if (transform.position.z > zRange + 7)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange + 7);
        }

        // Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move player through Z and X
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
