//using UnityEngine;

//public class camera : MonoBehaviour
//{
//    public float cameraSpeed = 0.1f; // Speed of the camera's horizontal movement
//    public Transform player; // Reference to the player object

//    private Vector3 offset; // Offset between the camera and the player

//    void Start()
//    {
//        // Calculate the initial offset
//        offset = transform.position - player.position;
//    }

//    void Update()
//    {
//        // Move the camera horizontally while keeping the vertical and depth offsets fixed
//        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
//    }
//}
