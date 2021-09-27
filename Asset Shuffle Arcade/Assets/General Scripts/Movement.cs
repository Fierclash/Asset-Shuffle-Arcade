using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Moves game objects with Rigidbody2D in the scene
/// </summary>
public class Movement : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;

    private void Start()
    {
        // your code here
    }

    public void Move(Vector3 direction)
    {
        // Hints:
        // - Direction should indicate which direction the object should move in
        // - Use with the speed variable to control how fast the object goes
        // - There are several ways to make objects move:
        //      - Changing transform position       (i.e transform.position = ...)
        //      - Setting Rigidbody2D velocity      (i.e body.velocity = ...)
        //      - Using Rigidbody2D AddForce(...)   *HIGHLY RECOMMENDED*
        //      Experiment between each one and see the differences between each method
        // - Refer to https://docs.unity3d.com/ScriptReference/Rigidbody2D.html for more information about Rigidbody2D

        // your code here
    }
}
