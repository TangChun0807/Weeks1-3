using UnityEngine;
using UnityEngine.InputSystem;

public class Turret : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Only update to face the targt
        //when the mouse clicker 
       // Keyboard.current.leftArrowKey.isPressed;
       bool leftMouseIsPress =  Mouse.current.leftButton.isPressed;
        bool leftMouseWasPressed = Mouse.current.leftButton.wasPressedThisFrame;
        bool leftMouseWasReleased = Mouse.current.leftButton.wasReleasedThisFrame;

       
        Debug.Log(leftMouseWasPressed);


        if(leftMouseWasPressed )
        {
            // direction to B - A
            //The direction from this object towards the target
            Vector3 directionToTarget = target.position - transform.position;

            transform.up = directionToTarget;

        }
        
       





    }
}
