using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float maxVelocity = 10f;
    public float linearAcceleration = 15f;
    public float angularAcceleration = 5f;
    public float brakeForce = 4f;
    public Rigidbody rb;



    void FixedUpdate()
    {
        //if (IsGrounded) <- to implement
        {
            // TODO: get controls for touchscreen
            // backforth movement
            rb.AddForce(transform.forward * linearAcceleration * Input.GetAxis("Vertical"), ForceMode.Acceleration);

            // rotation
            rb.AddTorque(transform.up * angularAcceleration * Input.GetAxis("Horizontal"), ForceMode.VelocityChange);

            // TODO: rotate front wheel 30* left/right (remember: wheels already rotated 90* on z-axis)

            if (rb.velocity.magnitude > 0f) // braking mechanism
                rb.AddForce(-transform.forward * brakeForce * Input.GetAxis("Space"), ForceMode.Acceleration);

        }


        //TODO: fix braking (rb.velocity.magnitude can never be negative
        //TODO: apply max vilocity
    }

    bool IsGrounded() // car only runs on ground
    {
        //TODO: implement fuction
        //TODO: get all wheelColider refrences variable and check for contionous collision
        throw new System.NotImplementedException();
    }
}