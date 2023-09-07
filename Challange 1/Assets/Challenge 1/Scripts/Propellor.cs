using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propellor : MonoBehaviour
{
    public float rotationSpeed; // Adjust the speed as needed

    // Update is called once per frame
    void Update()
    {
        // Rotate the game object around the Z-axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
