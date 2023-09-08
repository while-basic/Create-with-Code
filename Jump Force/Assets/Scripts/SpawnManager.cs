using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{    
    public GameObject obstactlePrefab; // reference to obstacle for spawning prefab game objects
    private Vector3 spawnPos = new Vector3(25, 0, 0); // spawn position for obstacles
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate); // constantly call obstacle over time
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // spawn obstacles
    void SpawnObstacle() {

        // creates prefab using instantiate methods (creates copies)
        Instantiate(obstactlePrefab, spawnPos, obstactlePrefab.transform.rotation);
    }
}
