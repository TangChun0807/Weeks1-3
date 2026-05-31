using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bin : MonoBehaviour
{
    public Camera gameCamera;
    public float totalAnimationTime;
    public Vector3 hidePosition;
    public AnimationCurve curve;
    private float progress;
    public Vector3 ogScale;
    public int previousLane;
    public int currentLane;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ogScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;
        worldMousePosition.y -= 1.8f;


        transform.position = worldMousePosition;

        if (worldMousePosition.y > 0f)
        {
            progress += Time.deltaTime;
            Vector3 temp = transform.localScale;
            temp.x = curve.Evaluate(progress / totalAnimationTime) * ogScale.x;
            transform.localScale = temp; 


        }
        else
        {
            transform.position = hidePosition; 
        }

        previousLane = currentLane;


        if (worldMousePosition.y > 0f)
        {
            if (worldMousePosition.x > -10 && worldMousePosition.x < -6)
            {

                currentLane = 1;



            }
            else if (worldMousePosition.x > -6 && worldMousePosition.x < -2)
            {
                currentLane = 2;


            }
            else if (worldMousePosition.x > -2 && worldMousePosition.x < 2)
            {

                currentLane = 3;


            }
            else if (worldMousePosition.x > 2 && worldMousePosition.x < 6)
            {
                currentLane = 4;


            }

            else if (worldMousePosition.x > 6 && worldMousePosition.x < 10)
            {

                currentLane = 5;

            }
            else
            {
                currentLane = 0;


            }

            

        }
        else
        {
            currentLane = 0;
        }

        if (previousLane != currentLane)
        {
            progress = 0;
        }



    }
}
