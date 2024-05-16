using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    [SerializeField] private float speed = 20f;
    private const float turnSpeed = 45f;
    private float verticalInput;
    private float horizontalInput;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        //This is were we get player input
        
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
     //   propeller.transform.Rotate(Vector3.forward * rotationSpeed * 5 * Time.deltaTime);
    }
}
