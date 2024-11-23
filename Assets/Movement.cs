using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Base speed of the box
    public float rotationAngle = 45f; // Initial movement angle in degrees
    public float maxY = 5f; // Roof position
    public float minY = -5f; // Ground position

    private Vector2 direction; // Current movement direction

    void Start()
    {
        // Set the initial direction based on rotationAngle
        direction = Quaternion.Euler(0, 0, rotationAngle) * Vector2.up;
    }

    void Update()
    {
        HandleInput(); // Change direction based on input
        MoveBox(); // Move the box
    }

    void HandleInput()
    {
        // Rotate the direction when arrow keys are pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rotationAngle += 90f; // Rotate counterclockwise
            direction = Quaternion.Euler(0, 0, 90) * direction;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rotationAngle -= 90f; // Rotate clockwise
            direction = Quaternion.Euler(0, 0, -90) * direction;
        }
    }

    void MoveBox()
    {
        // Move the box in the current direction
        Vector2 newPosition = (Vector2)transform.position + direction * moveSpeed * Time.deltaTime;

        // Check for collision with roof or ground
        if (newPosition.y > maxY)
        {
            newPosition.y = maxY;
            direction.y = -Mathf.Abs(direction.y); // Bounce downward
        }
        else if (newPosition.y < minY)
        {
            newPosition.y = minY;
            direction.y = Mathf.Abs(direction.y); // Bounce upward
        }

        // Apply the new position
        transform.position = newPosition;
    }
}
