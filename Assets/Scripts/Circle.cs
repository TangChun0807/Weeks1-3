using UnityEngine;
using UnityEngine.InputSystem;

public class Circle : MonoBehaviour
{
    private Vector3 startPoint = new Vector3(0f, -4.5f, 0f);
    private Vector3 endPoint = new Vector3(0f, -0.5f, 0f);
    private float t;
    public AnimationCurve curve;
    public Camera gameCamera;
    public float totalAnimationTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0f;

        Vector3 temp = Vector3.Lerp(startPoint, endPoint, t);
        temp.x += curve.Evaluate(t);
        transform.position = temp;



        if (worldMousePosition.y > 0f)
        {
            if (worldMousePosition.x > -10 && worldMousePosition.x < -6)
            {
                t -= Time.deltaTime / totalAnimationTime;




            }
            else if (worldMousePosition.x > -6 && worldMousePosition.x < -2)
            {
                t -= Time.deltaTime / totalAnimationTime;

            }
            else if (worldMousePosition.x > -2 && worldMousePosition.x < 2)
            {
                t += Time.deltaTime / totalAnimationTime;

            }
            else if (worldMousePosition.x > 2 && worldMousePosition.x < 6)
            {
                t -= Time.deltaTime / totalAnimationTime;

            }

            else if (worldMousePosition.x > 6 && worldMousePosition.x < 10)
            {
                t -= Time.deltaTime / totalAnimationTime;

            }
            else
            {
                t -= Time.deltaTime / totalAnimationTime;

            }

        }
        else
        {
            t -= Time.deltaTime / totalAnimationTime;

        }

        if (t < 0)
        {
            t = 0;
        }
        else if (t > 1)
        {
            t = 1;
        }
    }
}
