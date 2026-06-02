using UnityEngine;
using UnityEngine.InputSystem;

public class Diamond : MonoBehaviour
{
    //Set the starting position of the diamond
    private Vector3 startPoint = new Vector3(4f, -4.5f, 0f);
    //Set the ending position of the traignle
    private Vector3 endPoint = new Vector3(4f, -0.5f, 0f);

    // Set the value used for interpolation (0 = startPoint, 1 = endPoint)
    private float t;

    // Animation curve used to add extra movement
    public AnimationCurve curve;

    // Camera used to convert mouse screen coordinates to world coordinates
    public Camera gameCamera;

    //Total time for move from start to end 
    public float totalAnimationTime;


    
    void Start()
    {
        
    }

 
    void Update()
    {
        // Get current mouse position on the screen
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        // Convert mouse position into world position
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        //Keep the position on 2D
        worldMousePosition.z = 0f;
        // Move between startPoint and endPoint based on t
        Vector3 temp = Vector3.Lerp(startPoint, endPoint, t);

        // Add curve offset to create a curved movement effect
        temp.x += curve.Evaluate(t);


        //Setting square position to temp 
        transform.position = temp;


        // Check the mouse is above the center horizontal line
        if (worldMousePosition.y > 0f)
        {
            // Mouse is in the first column
            if (worldMousePosition.x > -10 && worldMousePosition.x < -6)
            {
                // Move diamond toward startPoint
                t -= Time.deltaTime / totalAnimationTime;




            }
            // Mouse is in the second column
            else if (worldMousePosition.x > -6 && worldMousePosition.x < -2)
            {
                // Move diamond toward startPoint
                t -= Time.deltaTime / totalAnimationTime;

            }
            // Mouse is in the third column
            else if (worldMousePosition.x > -2 && worldMousePosition.x < 2)
            {
                // Move diamond toward startPoint
                t -= Time.deltaTime / totalAnimationTime;

            }
            // Mouse is in the fourth column
            else if (worldMousePosition.x > 2 && worldMousePosition.x < 6)
            {
                // Move diamond toward endPoint
                t += Time.deltaTime / totalAnimationTime;

            }
            // Mouse is in the fifth  column
            else if (worldMousePosition.x > 6 && worldMousePosition.x < 10)
            {
                // Move diamond toward startPoint
                t -= Time.deltaTime / totalAnimationTime;

            }
            // Mouse is not in any column
            else
            {
                // Move diamond toward startPoint
                t -= Time.deltaTime / totalAnimationTime;

            }

        }
        // Mouse is below the horizontal line
        else
        {
            // Move diamond toward startPoint
            t -= Time.deltaTime / totalAnimationTime;

        }

        // Prevent t from going below 0
        if (t < 0)
        {
            t = 0;
        }
        // Prevent t from going above 1
        else if (t > 1)
        {
            t = 1;
        }
    }
}
