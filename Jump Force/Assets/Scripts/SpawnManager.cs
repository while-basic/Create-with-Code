using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject obstactlePrefab; // reference to obstacle for spawning prefab game objects
    private Vector3 spawnPos = new Vector3(25, 0, 0); // spawn position for obstacles

    // Start is called before the first frame update
    void Start()
    {
        // creates prefab using instantiate methods (creates copies)
        Instantiate(obstactlePrefab, spawnPos, obstactlePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
