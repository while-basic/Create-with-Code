using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // player's rigid body, not visibile to outside methods

    // Start is called before the first frame update
    void Start()
    {
        // Make player jump at start
        playerRb = GetComponent<Rigidbody>(); // gets player's rigid body component and takes no parameters
        // playerRb.AddForce(Vector3.up * 1000); // applies force to player's position on z-axis and multiplies by 1,000 when start is pressed
    }

    // Update is called once per frame
    void Update()
    {
        // make player jump only when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse); // applies different types of forces
        }
    }
}
