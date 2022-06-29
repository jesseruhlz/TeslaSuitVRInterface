using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The goal of this object is to move beneath the users feet,
// which will encourage the user to pick up their feet to avoid the laser.
// Laser will move between two points for testing, and will later be implemented to randomly spawn in 
// and move to opposite side.

// First implementation, using simple moveToward()
public class GroundLaser : MonoBehaviour
{
    public Transform startPosition;
    public Transform targetPosition;
    // note: higher speed value translates to slower speed movement and lower speed value translates to faster speed movement
    public float speed;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // use the below to move the laser from just start point to end point once
        /*
         Vector3 a = transform.position;
         Vector3 b = targetPosition.position;
         transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a, b, t), speed);
        */

        // use the below to have the ground laser move between two points continually
        Vector3 start = startPosition.position;
        Vector3 end = targetPosition.position;
        transform.position = Vector3.Lerp(start, end, Mathf.PingPong(Time.time / speed, 1));
        
    }

    // Check to see if ground laser collides with users feet
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Foot"))
        {
            // Do something
            Debug.Log("Foot collided with laser.");
        }
    }
}
