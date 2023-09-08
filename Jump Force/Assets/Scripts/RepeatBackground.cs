using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos; //position object starts at
    private float repeatwidth; // width actually repeating when resetting position

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatwidth = GetComponent<BoxCollider>().size.x / 2; // divides background size for smooth repeat
    }

    // Update is called once per frame
    void Update()
    {
        // reset to make background go back to start position
        if (transform.position.x < startPos.x - 50) // offsetfor background repeat
        {
            transform.position = startPos;// reset back to position of variable
        }
        
    }
}
