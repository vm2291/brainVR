
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateModel : MonoBehaviour
{
    // Define two float variables to handle rotation speed and the amount of rotation.
    float rotationSpeed;
    float rotation;

 
    void Start()
    {
        // Initialize the rotationSpeed to 7f
        rotationSpeed = 7f;

        // Initialize the rotation to 0f
        rotation = 0f;
    }

 
    void Update()
    {
        // Calculating the amount of rotation needed at this frame
        rotation = rotationSpeed * Time.deltaTime;

        // Apply the calculated rotation to the model

        transform.Rotate( 0f, rotation, 0f);
    }
}
