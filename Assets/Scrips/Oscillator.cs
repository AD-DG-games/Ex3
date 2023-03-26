using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // This variable controls the speed of the oscillation.
    // It can be adjusted in the Unity editor.
    [SerializeField]
    float speed = 1f;

    // This variable keeps track of the speed of the oscillation.
    float x = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the speed of the oscillation for the x and y axes.
        float xSpeed = (float)Math.Cos(x) * Time.deltaTime * speed * 2;
        float ySpeed = (float)Math.Sin(x*2) * Time.deltaTime * speed;

        // Move the game object by adding the calculated x and y speeds to its current position
        transform.position += new Vector3(xSpeed, ySpeed, 0);

        // Increment the x variable by a small value (0.001f) to update its speed for the next frame.
        x += 0.001f;
    }
}
