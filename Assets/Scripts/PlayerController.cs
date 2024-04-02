using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public GameObject propeller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //This is were we get player input
        
        verticalInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the vehicle
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        propeller.transform.Rotate(Vector3.forward * rotationSpeed * 5 * Time.deltaTime);
    }
}
