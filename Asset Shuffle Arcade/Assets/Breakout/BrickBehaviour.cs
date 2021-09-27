using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Behaviour script to determine how the Pong ball moves whenever it is hit
/// </summary>
public class BrickBehaviour : MonoBehaviour
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
        // - Whenever a ball hits a brick, the brick should be removed from the scene
        // - Use Destroy(...) to remove gameObjects from the scene during runtime: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
        // - Refer to https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html for more information on OnCollisionEnter2D(...)

        // your code here
    }
}
