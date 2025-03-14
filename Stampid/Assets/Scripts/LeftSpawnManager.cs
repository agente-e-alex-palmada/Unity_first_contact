using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = -30;
    private float spawnPosZ = -17;
    private float startDelay = 1.0F;
    private float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // An infinite loop that spawns animals with a cooldown
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(-spawnPosZ, spawnPosZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
