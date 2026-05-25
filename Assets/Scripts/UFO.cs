using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.InputSystem;

public class UFO : MonoBehaviour
{
    public Camera gameCamera;
    public float t1;
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
                t1 += Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;



            }
            else if (worldMousePosition.x > -6 && worldMousePosition.x < -2)
            {
                t1 -= Time.deltaTime / totalAnimationTime;
                t2 += Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;

            }
            else if (worldMousePosition.x > -2 && worldMousePosition.x < 2)
            {
                t1 -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 += Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;
            }
            else if (worldMousePosition.x > 2 && worldMousePosition.x < 6)
            {
                t1 -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 += Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;
            }
            else if (worldMousePosition.x > 6 && worldMousePosition.x < 10)
            {
                t1 -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 += Time.deltaTime / totalAnimationTime;
            }
            else
            {
                t1 -= Time.deltaTime / totalAnimationTime;
                t2 -= Time.deltaTime / totalAnimationTime;
                t3 -= Time.deltaTime / totalAnimationTime;
                t4 -= Time.deltaTime / totalAnimationTime;
                t5 -= Time.deltaTime / totalAnimationTime;
            }

        }
        else
        {
            t1 -= Time.deltaTime / totalAnimationTime;
            t2 -= Time.deltaTime / totalAnimationTime;
            t3 -= Time.deltaTime / totalAnimationTime;
            t4 -= Time.deltaTime / totalAnimationTime;
            t5 -= Time.deltaTime / totalAnimationTime;
        }



    }
}
