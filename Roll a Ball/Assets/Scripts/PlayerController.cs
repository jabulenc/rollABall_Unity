using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerSphere;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerSphere = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called just before any PHYSICS calculations
    private void FixedUpdate()
    {
        float displacementX = Input.GetAxis("Horizontal");
        float displacementY = Input.GetAxis("Vertical");

        playerSphere.AddForce(new Vector3(displacementX, 0f, displacementY) * speed);
    }
}
