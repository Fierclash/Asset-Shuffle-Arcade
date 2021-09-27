using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Behaviour script to determine how a bouncy ball moves whenever it is hit
/// (applicable for both Pong and Breakout)
/// </summary>
public class BallBehaviour : MonoBehaviour
{
    public Rigidbody2D body;
    public Collider2D hitbox;

    private void Start()
    {
        // your code here
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        // Hints:
        // - Whenever the ball collides with another object, add motion to the ball using Rigidbody2D (i.e. body.AddForce(...))
        // - There is alternative way to create a bouncy ball:
        //      - Create a new Physics2D Material by right-clicking in the Project tab: Create -> Physics2D Material
        //      - Adjust the friction to 0 and the bounciness to 1
        //      - Drag the Physics2D object to the Rigidbody2D of the ball into the Materials variable
        // - Refer to https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html for more information on OnCollisionEnter2D(...)

        // your code here
    }
}
