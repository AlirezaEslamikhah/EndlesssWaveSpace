using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum speeds_ground { slow = 0, normal = 1, fast = 2, faster = 3, fastests = 4 };

public class move_ground : MonoBehaviour
{
    public float speed = 5f; // Speed at which the ground/roof moves
    public float resetPosition = 20f; // Position where the object resets
    public float startPosition = -20f; // Start position for the object after resetting

    void Update()
    {
        // Move the object to the left
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Check if the object is out of the screen
        if (transform.position.x <= resetPosition)
        {
            // Reset the position to create the endless effect
            transform.position = new Vector2(startPosition, transform.position.y);
        }
    }
}
