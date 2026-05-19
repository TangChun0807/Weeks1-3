using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver : MonoBehaviour
{
    public Camera gameCamera;
    public bool timeIsRunning;
    public float time;
    public float distance;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = transform.position.z;
        
        
        if(Vector3.Distance(worldMousePosition, transform.position) < distance)
        {

            timeIsRunning = true;
            time += Time.deltaTime;

            Vector3 newPosition = transform.position;
            newPosition.y = curve.Evaluate(time * 5 - Mathf.Floor(time * 5));
            transform.position = newPosition;

            
        }
        else
        {
            timeIsRunning = false;
            time = 0;
        }


    }
}
