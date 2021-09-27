using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Creates and moves projectiles from a source object
/// </summary>
public class Shooter : MonoBehaviour
{
    public Transform firePoint;         // Point in space to create the projectile on
    public GameObject bullet;           // Projectile to create

    private void Start()
    {
        // your code here    
    }

    // Shooting Implementation
    public void Shoot(Vector3 direction)
    {
        // Hints:
        // - Direction should indicate which direction the bullet should move in
        // - Use Instantiate(...) to create gameObjects during runtime: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html

        // your code here
    }
}
