using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.InputSystem;

public class UFO : MonoBehaviour
{
    public Camera gameCamera;
    public float t2;
    public float t3;
    public float t4;
    public float t5;
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
        
        transform.position = worldMousePosition;


        if (worldMousePosition.y > 0f)
        {
            if (worldMousePosition.x > -10 && worldMousePosition.x < -6)
            {
                Square.t += Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;



            }
            else if (worldMousePosition.x > -6 && worldMousePosition.x < -2)
            {
                Square.t -= Time.deltaTime / totalAnimationTime;
                t2 += Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;

            }
            else if (worldMousePosition.x > -2 && worldMousePosition.x < 2)
            {
                Square.t -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 += Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;
            }
            else if (worldMousePosition.x > 2 && worldMousePosition.x < 6)
            {
                Square.t -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 += Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;
            }
            else if (worldMousePosition.x > 6 && worldMousePosition.x < 10)
            {
                Square.t -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 += Time.deltaTime / totalAnimationTime;
            }
            else
            {
                Square.t -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;
            }

        }
        else
        {
            Square.t -= Time.deltaTime / totalAnimationTime;
            t2 -= Time.deltaTime / totalAnimationTime;
            t3 -= Time.deltaTime / totalAnimationTime;
            t4 -= Time.deltaTime / totalAnimationTime;
            t5 -= Time.deltaTime / totalAnimationTime;
        }

        if (Square.t < 0)
        {
            Square.t = 0;
        }else if (Square.t > 1)
        {
            Square.t = 1;
        }

        if (t2 < 0)
        {
            t2 = 0;
        }
        else if (t2 > 1)
        {
            t2 = 1;
        }


        if (t3 < 0)
        {
            t3 = 0;
        }
        else if (t3 > 1)
        {
            t3 = 1;
        }


        if (t4 < 0)
        {
            t4 = 0;
        }
        else if (t4 > 1)
        {
            t4 = 1;
        }


        if (t5 < 0)
        {
            t5 = 0;
        }
        else if (t5 > 1)
        {
            t5 = 1;
        }

    }
}
