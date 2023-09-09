using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim; // player's rigid body, not visibile to outside methods
    public float jumpForce; // players jumping force
    public float gravityModifier; // controlls gravity
    public bool isOnGround = true; // checks player is on ground
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        // Make player jump at start
        playerRb = GetComponent<Rigidbody>(); // gets player's rigid body component and takes no parameters
        // playerRb.AddForce(Vector3.up * 1000); // applies force to player's position on (?)-axis and multiplies by 1,000 when start is pressed

        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier; // pulls gravity from Unity, multiply equals the gravity modifier
    }

    // Update is called once per frame
    void Update()
    {
        // make player jump only when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // applies different types of forces
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig"); // activates jump animation trigger event
        }
    }

    // returns value when player is back on ground
    private void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.CompareTag("Ground")) 
        {
            isOnGround = true;
        } else if(collision.gameObject.CompareTag("Obstacle")) 
        {
            Debug.Log("Game Over");
            gameOver = true;
        }
    }
}
