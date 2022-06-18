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
    public Transform targetPosition;
    public float speed;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = targetPosition.position;
        transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a, b, t), speed);
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
