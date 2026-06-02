
using UnityEngine;
using UnityEngine.InputSystem;

public class UFO : MonoBehaviour
{
    //This is the camera used to convert mouse screen position into world position 
    public Camera gameCamera;
    //This varaible can
    public float totalAnimationTime;

   
    void Start()
    {
        
    }

   
    void Update()
    {
        // Get the current mouse position on the screen
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
       
        // Convert the mouse screen position into Unity world position
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        // Set Z to 0 so the UFO stays on 2D
        worldMousePosition.z = 0f;

        // Move the UFO to the mouse world position
        transform.position = worldMousePosition;
         

       

    }
}
