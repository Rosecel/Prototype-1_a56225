using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    [SerializeField] float speed;
    [SerializeField] float rpm;
    [SerializeField] private float horsePower = 0;
    [SerializeField] float turnSpeed = 30.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;

    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;



    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //This is were we get player input

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the vehicle forward
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // We turn the vehicle
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f); // For kpn, change 2.237 to 3.6
        speedometerText.SetText("Speed: " + speed + "mph");

        rpm = Mathf.Round((speed % 30) * 40);
        rpmText.SetText("RPM: " + rpm);
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;

        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
