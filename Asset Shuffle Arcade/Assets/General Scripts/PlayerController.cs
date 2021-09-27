using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Controller script to allow input from the player to control an object
/// </summary>
public class PlayerController : MonoBehaviour
{
    public Movement movement;   // Implement this first before implementing PlayerController !!!
    //public Shooter shooter;     // Implement this if your object needs to fire projectiles (e.g. Space Invaders)

    private void Start()
    {
        // your code here
    }

    private void Update()
    {
        // Hints:
        // - Every frame, you want to check if there is any input from the player
        // - If there is an input, you want to call Move(...) in movement, passing in the direction of motion as the argument

        // your code here
    }

    // Movement Input
    public Vector3 GetMovementInput()
    {
        // Hints:
        //  - Use Input.GetAxisRaw("Horizontal") and Input.GetAxisRaw("Vertical") to get WASD/Arrow input

        // your code here
        Vector3 input = Vector3.zero;   // Change this for implementation
        return input;
    }

    // Shooter Input
    public bool GetShooterInput()
    {
        // Hints:
        // - You will need to implement this if you are working on the Space Invaders scene
        // - Use Input.GetKeyDown(...) to check if a key has been pressed: https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
        // - Use Input.GetMouseButtonDown(...) to check if a mouse button has been pressed: https://docs.unity3d.com/ScriptReference/Input.GetMouseButton.html
        // - Both functions will only return true for the frame that the key was pressed; Holding down the key will *not* continuously return true

        // your code here
        bool input = false;         // Change this for implementation
        return input;
    }
}
