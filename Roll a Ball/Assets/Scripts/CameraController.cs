using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    // Takes current transform position of the camera, subtracting the transform of the player to find the difference
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    
    // Runs every frame like an update, but is guaranteed AFTER all Update() is processed
    // That way, we know FOR SURE that the camera updates only AFTER the user has completed motion
    void LateUpdate()
    {
        // During EVERY frame, set the transformed position of the camera to the player's position PLUS the initially calculated offset
        transform.position = player.transform.position + offset;
    }
}
