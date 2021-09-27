using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Behaviour script for Space Invader enemies that determines how the enemy
/// moves and attacks
/// </summary>
public class EnemyBehaviour : MonoBehaviour
{
    public Rigidbody2D body;
    public Collider hitbox;

    // Depending on how you implement these classes, you may be able to re-use
    // them for enemy behaviour
    // public Movement movement;
    // public Shooter shooter;  

    private void Start()
    {
        // your code here
    }

    private void Update()
    {
        // your code here
    }

    // Movement Behaviour
    public void Move()
    {
        // your code here
    }

    // Shooting Behaviour
    public void Shoot()
    {
        // your code here
    }

    // Hitbox Behaviour
    public void OnCollisionEnter2D(Collision2D other)
    {
        // Hints:
        // - Whenever an enemy is hit with a bullet, it should be removed from the scene
        // - Use Destroy(...) to remove gameObjects from the scene during runtime: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
        // - Refer to https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html for more information on OnCollisionEnter2D(...)

        // your code here
    }
}
