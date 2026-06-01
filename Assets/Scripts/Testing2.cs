using UnityEngine;
using UnityEngine.InputSystem;

public class Testing2 : MonoBehaviour
{
    public Camera gameCamera;

    public Vector3 pointA;
    public Vector3 pointB;

    public float triggerDistance = 2f;
    public float moveSpeed = 1f;

    public AnimationCurve moveCurve;

    private float progress = 0f;
    private int moving = 0;
    private int direction = 1;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse screen position using the new input system
        Vector3 mousePosition = Mouse.current.position.ReadValue();

        // Change mouse screen position into world position
        Vector3 worldMousePosition =
            gameCamera.ScreenToWorldPoint(mousePosition);

        // Set z to 0 because this is a 2D scene
        worldMousePosition.z = 0f;

        // Find distance between the mouse and this bird
        float distance =
            Vector3.Distance(worldMousePosition, transform.position);

        // If the mouse is close and the bird is not moving, start moving
        if (distance < triggerDistance && moving == 0)
        {
            moving = 1;
            progress = 0f;
        }

        // Move only when moving is turned on
        if (moving == 1)
        {
            progress += Time.deltaTime * moveSpeed;

            // Use AnimationCurve to control the Lerp value
            float curveValue = moveCurve.Evaluate(progress);

            // Move from A to B
            if (direction == 1)
            {
                transform.position =
                    Vector3.Lerp(pointA, pointB, curveValue);
            }

            // Move from B to A
            if (direction == -1)
            {
                transform.position =
                    Vector3.Lerp(pointB, pointA, curveValue);
            }

            // When it reaches the end, stop and wait for mouse hover again
            if (progress >= 1f)
            {
                moving = 0;
                progress = 0f;
                direction = direction * -1;
            }
        }


    }
}
