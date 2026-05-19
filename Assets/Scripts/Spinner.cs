using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float zMax;
    public float zMin;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ////Rotation needs to use eulerAngles;
        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation.z += 30f;
        //transform.eulerAngles = currentRotation;

        //Debug.Log("Hi!!!!");
        //Debug.Log(transform.eulerAngles);

        
    }

    // Update is called once per frame
    void Update()
    {
        ////Rotation needs to use eulerAngles;
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;

        if(currentRotation.z > zMax)
        {
            //Debug.Log("Crossing the upper threshold currentZ[" + currentRotation.z.ToString() + "] zMax[" + zMax.ToString() + "]");
            speed = -speed;

        }

        if(currentRotation.z < zMin)
        {
            //Debug.Log("Passing Min");
            speed = -speed;
        }

    }
}
