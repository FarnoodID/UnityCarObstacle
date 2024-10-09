using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlTank : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    public Rigidbody vehicleRigidBody;
    private bool hasWon = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("HorizontalP2");
        verticalInput = Input.GetAxis("VerticalP2");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * verticalInput);
        if (transform.position.z>164 && !hasWon)
        {
            vehicleRigidBody.AddForce(Vector3.up * vehicleRigidBody.mass * 1000);
            hasWon = true;
        }
    }
}
