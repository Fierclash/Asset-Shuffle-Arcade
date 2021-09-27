using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Behaviour script for Space Invader shields that determine
/// how collisions affect the shield
/// </summary>
public class ShieldBehaviour : MonoBehaviour
{
    public Rigidbody2D body;
    public Collider2D hitbox;

    public int maxHealth;
    private int health;

    private void Start()
    {
        // your code here
    }

    // Hitbox Behaviour
    public void OnCollisionEnter2D(Collision2D other)
    {
        // Hints:
        // - Whenever a shield takes a hit from a bullet, it should take damage
        // - If a shield loses all its health, it should break
        // - Refer to https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html for more information about OnTriggerEnter2D(...)

        // your code here
    }
}
