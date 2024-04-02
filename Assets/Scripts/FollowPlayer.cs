using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset the camera behind the player by adding to the player's position
        Vector3 newPosition = plane.transform.position + new Vector3(23, 7, 1);
        transform.position = newPosition;
    }
}
