using UnityEngine;
using UnityEngine.InputSystem;

public class Bin : MonoBehaviour
{
    //This is the camera used to convert mouse screen position into world position 
    public Camera gameCamera;

    // The total time for the scale animation to finish
    public float totalAnimationTime;
   
    // The position where the bin will hide when the mouse is not in the top area
    public Vector3 hidePosition;
    
    // Animation curve used to control the scaling animation
    public AnimationCurve curve;

    // This variable tracks the animation progress
    private float progress;
    
    // Stores the original scale of the bin
    public Vector3 ogScale;

    // Stores the mouse lane from the previous frame
    public int previousLane;

    // Stores the mouse lane from the current frame
    public int currentLane;


   
    void Start()
    {
        // Save the original size of the bin when the game starts
        ogScale = transform.localScale;
    }

   
    void Update()
    {    // Get the current mouse position on the screen
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();

        // Convert the mouse position from screen space to world space
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);

        // Keep the bin on  2D
        worldMousePosition.z = 0f;

        // Set the beam lower than the UFO
        worldMousePosition.y -= 1.8f;

        // Make the beamn follow the mouse position
        transform.position = worldMousePosition;

        // Check if the mouse is above the Horizontal line  
        if (worldMousePosition.y > 0f)
        {
            // Increase animation progress over time
            progress += Time.deltaTime;

            // Set current scale into a temporary variable
            Vector3 temp = transform.localScale;
           
            // Change only the x scale using the animation curve
            temp.x = curve.Evaluate(progress / totalAnimationTime) * ogScale.x;
            
            // Set the new scale to the beam
            transform.localScale = temp; 


        }
        else
        {
            // If mouse is below the horizon, move the beam to the hidden position
            transform.position = hidePosition; 
        }

        // Set the current lane  to the previous lane before checking the new lane
        previousLane = currentLane;

       
        // Check the mouse position is above the horizontal line 
        if (worldMousePosition.y > 0f)
        {
            // Mouse is in the first column
            if (worldMousePosition.x > -10 && worldMousePosition.x < -6)
            {
                //set the current lane to 1, remember that you are in lane 1 
                currentLane = 1;



            }
            // Mouse is in the second column
            else if (worldMousePosition.x > -6 && worldMousePosition.x < -2)
            {
                //set the current lane to 2, remember that you are in lane 2
                currentLane = 2;


            }
            // Mouse is in the third column
            else if (worldMousePosition.x > -2 && worldMousePosition.x < 2)
            {
                //set the current lane to 3, remember that you are in lane 3
                currentLane = 3;


            }
            // Mouse is in the fourth column
            else if (worldMousePosition.x > 2 && worldMousePosition.x < 6)
            {
                //set the current lane to 4, remember that you are in lane 4
                currentLane = 4;


            }
            // Mouse is in the fifth column
            else if (worldMousePosition.x > 6 && worldMousePosition.x < 10)
            {
                //set the current lane to 5, remember that you are in lane 5
                currentLane = 5;

            }
            //Mouse is not on any lane 
            else
            {
                //set the current lane to 0, remember that you are not in any lane 
                currentLane = 0;


            }

            

        }
        // mouse below the horizon 
        else
        {   //set the current lane to 0, remember that you are not in any lane 
            currentLane = 0;
        }

        //if the lane has change reset the animation to zero
        if (previousLane != currentLane)
        {
            progress = 0;
        }



    }
}
